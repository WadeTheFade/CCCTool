<script setup lang="ts">

</script>

<template>
<div class="row">
  <div class="col-2">
    <div class="input-group mb-3">
      <input type="text" class="form-control" id="branch_zipCode" placeholder="Search Zip..." >
      <button class="btn btn-outline-secondary" type="button" id="branch_zipCodeSearch">Search</button>
    </div>
    <span class="badge bg-primary">Send Out of Area</span>
    <span class="badge bg-primary">Out of Service Opportunity</span>
  </div>
  <div class="col-10">
    <div class="row">
      <div class="col-auto">
      <!-- foreach branch -->
      <div class="card">
        <div class="card-header d-flex justify-content-between">
          <h4 class="card-title">Chicago (10 miles)</h4>
          <button class="btn btn-sm btn-primary">Assign</button>
        </div>
        <div class="card-body">
          <div class="d-grid gap-2 d-md-block mb-3">
            <!-- foreach service -->

              <button type="button" class="btn btn-sm btn-primary">Stair Lifts</button>
              <button type="button" class="btn btn-sm btn-primary">Ramps</button>
              <button type="button" class="btn btn-sm btn-secondary">Transfer Aids</button>

              <button type="button" class="btn btn-sm btn-primary">Elevators</button>
              <button type="button" class="btn btn-sm btn-secondary">Wheelchair Lifts</button>
              <button type="button" class="btn btn-sm btn-secondary">Shower Bath</button>
          </div>
          <div class="card">
            <div class="card-body">
              <h5 class="card-title">Primary Contact</h5>
              <h6 class="card-subtitle mb-2 text-body-secondary">Jimmy Carr</h6>
              <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
              <a href="#" class="card-link">Call 444-555-5555</a>
              <a href="#" class="card-link">Call 111-111-2222</a>
            </div>
          </div>

        </div>
      </div>

    </div>
      <div class="col-auto">
        <!-- foreach branch -->
        <div class="card">
          <div class="card-header d-flex justify-content-between">
            <h4 class="card-title">Boonies (50 miles)</h4>
            <button class="btn btn-sm btn-primary">Assign</button>
          </div>
          <div class="card-body">
            <div class="d-grid gap-2 d-md-block mb-3">
              <!-- foreach service -->

              <button type="button" class="btn btn-sm btn-primary">Stair Lifts</button>
              <button type="button" class="btn btn-sm btn-secondary">Ramps</button>
              <button type="button" class="btn btn-sm btn-primary">Transfer Aids</button>

              <button type="button" class="btn btn-sm btn-primary">Elevators</button>
              <button type="button" class="btn btn-sm btn-primary">Wheelchair Lifts</button>
              <button type="button" class="btn btn-sm btn-primary">Shower Bath</button>
            </div>
            <div class="card">
              <div class="card-body">
                <h5 class="card-title">Primary Contact</h5>
                <h6 class="card-subtitle mb-2 text-body-secondary">Bob Hope</h6>
                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <a href="#" class="card-link">Call 333-222-1111</a>
                <a href="#" class="card-link">Call 555-111-8888</a>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</div>
</template>

<style scoped>

</style>
