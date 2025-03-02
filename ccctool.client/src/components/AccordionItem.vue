<script setup lang="ts">

</script>

<template>
  <div id="accordionExample" class="accordion">
    <div class="accordion-item" v-for="(item, index) in items" :key="index">
      <h2 class="accordion-header" :id="'heading' + index">
        <button
          class="accordion-button"
          type="button"
          data-bs-toggle="collapse"
          :data-bs-target="'#collapse' + index"
          aria-expanded="true"
          :aria-controls="'collapse' + index"
        >
          {{ item.title }}
        </button>
      </h2>
      <div
        :id="'collapse' + index"
        class="accordion-collapse collapse"
        :class="{ show: index === 0 }"
        :aria-labelledby="'heading' + index"
        data-bs-parent="#accordionExample"
      >
        <div class="accordion-body">
          {{ item.content }}
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: 'Accordion',
  data() {
    return {
      items: [
        { title: 'Accordion Item #1', content: 'Content for item #1' },
        { title: 'Accordion Item #2', content: 'Content for item #2' },
        { title: 'Accordion Item #3', content: 'Content for item #3' },
      ],
    };
  },
};
</script>

<style scoped>

</style>
