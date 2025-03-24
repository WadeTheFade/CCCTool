<script setup lang="ts">
import { ref, watch } from 'vue';

const states = [
  { name: 'Alabama', abbreviation: 'AL' },
  { name: 'Alaska', abbreviation: 'AK' },
  { name: 'Arizona', abbreviation: 'AZ' },
  { name: 'Arkansas', abbreviation: 'AR' },
  { name: 'California', abbreviation: 'CA' },
  { name: 'Colorado', abbreviation: 'CO' },
  { name: 'Connecticut', abbreviation: 'CT' },
  { name: 'Delaware', abbreviation: 'DE' },
  { name: 'Florida', abbreviation: 'FL' },
  { name: 'Georgia', abbreviation: 'GA' },
  { name: 'Hawaii', abbreviation: 'HI' },
  { name: 'Idaho', abbreviation: 'ID' },
  { name: 'Illinois', abbreviation: 'IL' },
  { name: 'Indiana', abbreviation: 'IN' },
  { name: 'Iowa', abbreviation: 'IA' },
  { name: 'Kansas', abbreviation: 'KS' },
  { name: 'Kentucky', abbreviation: 'KY' },
  { name: 'Louisiana', abbreviation: 'LA' },
  { name: 'Maine', abbreviation: 'ME' },
  { name: 'Maryland', abbreviation: 'MD' },
  { name: 'Massachusetts', abbreviation: 'MA' },
  { name: 'Michigan', abbreviation: 'MI' },
  { name: 'Minnesota', abbreviation: 'MN' },
  { name: 'Mississippi', abbreviation: 'MS' },
  { name: 'Missouri', abbreviation: 'MO' },
  { name: 'Montana', abbreviation: 'MT' },
  { name: 'Nebraska', abbreviation: 'NE' },
  { name: 'Nevada', abbreviation: 'NV' },
  { name: 'New Hampshire', abbreviation: 'NH' },
  { name: 'New Jersey', abbreviation: 'NJ' },
  { name: 'New Mexico', abbreviation: 'NM' },
  { name: 'New York', abbreviation: 'NY' },
  { name: 'North Carolina', abbreviation: 'NC' },
  { name: 'North Dakota', abbreviation: 'ND' },
  { name: 'Ohio', abbreviation: 'OH' },
  { name: 'Oklahoma', abbreviation: 'OK' },
  { name: 'Oregon', abbreviation: 'OR' },
  { name: 'Pennsylvania', abbreviation: 'PA' },
  { name: 'Rhode Island', abbreviation: 'RI' },
  { name: 'South Carolina', abbreviation: 'SC' },
  { name: 'South Dakota', abbreviation: 'SD' },
  { name: 'Tennessee', abbreviation: 'TN' },
  { name: 'Texas', abbreviation: 'TX' },
  { name: 'Utah', abbreviation: 'UT' },
  { name: 'Vermont', abbreviation: 'VT' },
  { name: 'Virginia', abbreviation: 'VA' },
  { name: 'Washington', abbreviation: 'WA' },
  { name: 'West Virginia', abbreviation: 'WV' },
  { name: 'Wisconsin', abbreviation: 'WI' },
  { name: 'Wyoming', abbreviation: 'WY' }
];

let selectedState = ref('');
let streetAddress = ref('');
let city = ref('');
let zipCode = ref('');

// Instantiate Geocoding Service
const { Geocoder } = await google.maps.importLibrary('geocoding');
const geocoder = new Geocoder();

// Instantiate Geocoding Service
const { StreetViewService } = await google.maps.importLibrary('streetView');
const streetViewService = new StreetViewService();

const updateStreetView = () => {
  const address = `${streetAddress.value}, ${city.value}, ${selectedState.value} ${zipCode.value}`;
  let streetViewDiv = document.getElementById("street-view") as HTMLElement;
   geocoder.geocode({address}, (results, status) => {
    if (status === 'OK' && results[0]) {
      const location = results[0].geometry.location;
      let panoRequest = {
        location: location,
        radius: 50
      } as google.maps.StreetViewLocationRequest;

      streetViewService.getPanorama(panoRequest, function (streetViewPanoramaData, status) {

        if(status ===google.maps.StreetViewStatus.OK){

          var panoLocation = streetViewPanoramaData.location.latLng;

          var heading = google.maps.geometry.spherical.computeHeading(panoLocation,location);

          const panorama = new google.maps.StreetViewPanorama(
            streetViewDiv,
            {
              position: location,
              pov: {
                heading: heading,
                pitch: 0
              },
              zoom: 1
            }
          );
          panorama.setVisible(true);
          streetViewDiv.hidden = false;
        }else{
          streetViewDiv.hidden = true;
        }
      });
    }
  });
};

const debounce = (func, delay) => {
  let timeout;
  return (...args) => {
    clearTimeout(timeout);
    timeout = setTimeout(() => func.apply(this, args), delay);
  };
};

const debouncedUpdateStreetView = debounce(updateStreetView, 1000);

watch([streetAddress, city, selectedState, zipCode], () => {
  if (streetAddress.value && city.value && selectedState.value && zipCode.value) {
    debouncedUpdateStreetView();
  }
});

</script>

<template>
  <div class="row">
    <div class="col-6">
      <div class="row">
        <div class="form-outline mb-4">
          <label for="StreetAddress" class="form-label">Street Address</label>
          <input type="text" id="StreetAddress" v-model="streetAddress" class="form-control" />
        </div>
      </div>
      <div class="row">
        <div class="col-md-4 mb-4">
          <label class="form-label" for="City">City</label>
          <input type="text" id="City" v-model="city" class="form-control" />
        </div>
        <div class="col-md-4 mb-4">
          <label class="form-label" for="State">State</label>
          <select class="form-control" id="State" v-model="selectedState">
            <option v-for="state in states" :key="state.abbreviation" :value="state.abbreviation">
              {{ state.name }}
            </option>
          </select>
        </div>

        <div class="col-md-4 mb-4">
          <div class="form-outline mb-4">
            <label class="form-label" for="ZipCode">Zip</label>
            <input type="text" id="ZipCode" v-model="zipCode" class="form-control" />
          </div>
        </div>
      </div>

    </div>
    <div class="col-6">
      <div class="bg-body-secondary" style="height: 400px;">
        <div id="street-view" style="width: 100%;"></div>
      </div>
    </div>
  </div>

</template>

<style scoped>
#street-view {
  width: 600px;
  height: 400px;
}
</style>
