<script setup lang="ts">

</script>

<template>
  <div class="row">
    <p>Check any challenges mentioned during call.</p>
  </div>
  <div class="row">
    <div class="col-8">
      <label class="form-label">Challenges:</label>
      <div class="form-check">
        <input class="form-check-input" type="checkbox" id="self" value="Self">
        <label class="form-check-label" for="self">Arthritis</label>
      </div>
      <div class="form-check">
        <input class="form-check-input" type="checkbox" id="parent" value="Parent">
        <label class="form-check-label" for="parent">Stroke Recovery</label>
      </div>
      <div class="form-check">
        <input class="form-check-input" type="checkbox" id="friend" value="Friend">
        <label class="form-check-label" for="friend">Parkinson's</label>
      </div>
      <div class="form-check">
        <input class="form-check-input" type="checkbox" id="sibling" value="Sibling">
        <label class="form-check-label" for="sibling">Post Surgery</label>
      </div>
      <div class="form-check">
        <input class="form-check-input" type="checkbox" id="homeOwner" value="Home Owner">
        <label class="form-check-label" for="homeOwner">COPD</label>
      </div>
      <div class="form-check">
        <input class="form-check-input" type="checkbox" id="other" value="Other">
        <label class="form-check-label" for="other">CHF</label>
      </div>
    </div>
    <div class="col-4">
      <label for="additionalNotes" class="form-label">Additional Notes</label>
      <textarea class="form-control" id="additionalNotes" rows="3"></textarea>
    </div>
  </div>
</template>

<style scoped>

</style>
