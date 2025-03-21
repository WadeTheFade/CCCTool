<script setup lang="ts">
import { ref } from 'vue';

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

/*declare const google: any;

const streetAddress = ref('');
const city = ref('');
const selectedState = ref('');
const zipCode = ref('');
function initMap() {
  const address = `${streetAddress.value}, ${city.value}, ${selectedState.value} ${zipCode.value}`;
  const geocoder = new google.maps.Geocoder();
  geocoder.geocode({ address: address }, (results: google.maps.GeocoderResult[], status: google.maps.GeocoderStatus) => {
    const location = results[0].geometry.location;
    const panorama = new google.maps.StreetViewPanorama(
      document.getElementById("street-view") as HTMLElement,
      {
        position: location,
        pov: {
          heading: 34,
          pitch: 10,
        },
        zoom:1
      }
    );
    panorama.setStreetView(panorama);
  });

}*/

declare global {
  interface Window {
    initialize: () => void;
  }
}
//window.initialize = initMap;
</script>

<template>
  <div class="row">
    <div class="col-auto">
      <div class="row">
        <div class="form-outline mb-4">
          <label for="StreetAddress" class="form-label">Street Address</label>
          <input type="text" id="StreetAddress" class="form-control" />
        </div>
      </div>
      <div class="row">
        <div class="col-md-4 mb-4">
          <label class="form-label" for="City">City</label>
          <input type="text" id="City" class="form-control" />
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
            <input type="text" id="ZipCode" class="form-control" />
          </div>
        </div>
      </div>

    </div>
    <div class="col-auto">
      <div id="street-view"></div>
    </div>
  </div>

</template>

<style scoped>
#street-view {
  width: 600px;
  height: 400px;
}
</style>
