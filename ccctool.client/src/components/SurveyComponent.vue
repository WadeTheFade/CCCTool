<script setup lang="ts">

</script>

<template>
  <div class="row">
    <p>Recommend a new referral source:</p>
  </div>
  <div class="row">
    <div class="col-8">
      <label for="organizationName" class="form-label">Organization Name</label>
      <input type="text" id="organizationName" class="form-control" />
      <label for="individual" class="form-label">Individual</label>
      <input type="text" id="individual" class="form-control" />
      <label for="cityState" class="form-label">City/State</label>
      <input type="text" id="cityState" class="form-control" />
    </div>
    <div class="col-4">
      <label for="survey_AdditionalNotes" class="form-label">Additional Notes</label>
      <textarea class="form-control" id="survey_AdditionalNotes" rows="3"></textarea>
    </div>
  </div>
</template>

<style scoped>

</style>
