<script setup lang="ts">
import Accordion from './components/AccordionItem.vue';
</script>

<template>
  <header>
    <img alt="Vue logo" class="logo" src="./assets/logo.svg" width="75" height="75" />
  </header>

  <main>
    <div class="container-fluid">
      <div class="row">
        <div class="col-12">
          <div class="d-flex justify-content-between">
            <div class=""><input type="text" class="form-control form-control-sm" placeholder="Load Opportunity Id.." /></div>
            <div class="d-grid gap-2 d-md-flex justify-content-md-end mb-4">
              <button class="btn btn-secondary" type="button">Cancel</button>
              <button class="btn btn-secondary" type="button">New</button>
              <button class="btn btn-primary" type="button">Save</button>
            </div>
          </div>
          <Suspense>
            <Accordion/>
          </Suspense>
          <div class="d-grid gap-2 d-md-flex justify-content-md-end mt-4">
            <button class="btn btn-secondary" type="button">Cancel</button>
            <button class="btn btn-secondary" type="button">New</button>
            <button class="btn btn-primary" type="button">Save</button>
          </div>
        </div>
      </div>
    </div>

  </main>
</template>

<style scoped>


.logo {
  margin-right: 1rem; /* Adjust margin as needed */
}

main {
  margin-top: 125px; /* Adjust this value to prevent content from being hidden behind the fixed header */
}

</style>
