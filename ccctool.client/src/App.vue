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
          <Suspense>
            <Accordion/>
          </Suspense>
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
