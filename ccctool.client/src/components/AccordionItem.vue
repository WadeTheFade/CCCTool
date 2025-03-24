<script lang="ts">
import { defineComponent, nextTick } from 'vue';
import WhoComponent from '@/components/WhoComponent.vue';
import ChallengesComponent from '@/components/ChallengesComponent.vue';
import NeedsComponent from '@/components/NeedsComponent.vue';
import SurveyComponent from '@/components/SurveyComponent.vue';
import LocationComponent from '@/components/LocationComponent.vue';
import BranchComponent from "@/components/BranchComponent.vue";
import { Loader } from '@googlemaps/js-api-loader';

const LoadGoogleMaps = async () => {
  // Check if Google Maps has already been loaded
  if (!window?.google?.maps) {
    return await new Loader({
      apiKey: import.meta.env.VITE_GOOGLE_API_KEY,
      version: 'weekly',
      libraries: ['core', 'maps', 'streetView', 'geometry', 'geocoding']
      // Use .importLibrary('core'); in place of .load() to make google.maps available in the global scope.
    }).importLibrary('core');
  }
};

type Sections = {
  title: string,
  content: string,
  icon: string,
  html: string
}[];

interface Data {
  loading: boolean,
  post: null | Sections
}

export default defineComponent({
  components: {
    WhoComponent,
    ChallengesComponent,
    NeedsComponent,
    SurveyComponent,
    LocationComponent,
    BranchComponent
  },
  data(): Data {
    return {
      loading: false,
      post: null
    };
  },
  async created() {
    // fetch the data when the view is created and the data is
    // already being observed
    await this.fetchData();
  },
  watch: {
    // call again the method if the route changes
    '$route': 'fetchData'
  },
  methods: {
    async fetchData() {
      this.post = null;
      this.loading = true;

      let response = await fetch('sections');
      if (response.ok) {
        this.post = await response.json();
        await LoadGoogleMaps();
        this.loading = false;
      }
    }
  }
});

</script>

<template>
  <div id="accordionExample" class="accordion accordion-flush border">
    <div class="accordion-item" v-for="(item, index) in post" :key="index">
      <div class="accordion-header d-flex" :id="'heading' + index">
        <button
          class="accordion-button collapsed"
          type="button"
          data-bs-toggle="collapse"
          :data-bs-target="'#collapse' + index"
          aria-expanded="false"
          :aria-controls="'collapse' + index">
          {{ item.title }}
        </button>
        <div class="d-flex align-items-center gap-3 w-100" v-html="item.html"></div>
        <button
          class="accordion-button collapsed"
          type="button"
          data-bs-toggle="collapse"
          :data-bs-target="'#collapse' + index"
          aria-expanded="false"
          :aria-controls="'collapse' + index">
        </button>
      </div>

      <div
        :id="'collapse' + index"
        class="accordion-collapse collapse"
        :aria-labelledby="'heading' + index">
        <div class="accordion-body">
          <component :is="item.content"></component>
        </div>
      </div>
    </div>
  </div>
</template>

<style scoped>
  .accordion-item {
    position: relative;
  }
  .accordion-button {
    width: 350px !important;
  }

  .accordion-header {
    background-color: var(--bs-accordion-active-bg);
  }
  .accordion-button:focus {
    z-index: 3;
    outline: 0;
    box-shadow: none !important;
  }

  .accordion-button:not(.collapsed) {
     color: var(--bs-accordion-active-color);
     background-color: transparent !important;
     box-shadow: none;
  }

  .accordion-button:is(.collapsed) {
    color: var(--bs-accordion-active-color);
    background-color: transparent !important;
    box-shadow: none;
  }

  .accordion-item:first-of-type > .accordion-header .accordion-button {
    border-top-left-radius: 0 !important;
    border-top-right-radius: 0 !important;
  }

  /*Removes button icon from first button. */
  .accordion-header .accordion-button:first-of-type::after {
   display: none !important;
  }
</style>
