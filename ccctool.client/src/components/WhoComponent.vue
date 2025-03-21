<script setup lang="ts">

</script>

<template>
  <div class="row">
    <p>Possible match with on <a href="">OP01232242</a></p>
  </div>
  <div class="row">
    <div class="col-8">
      <div>
        <label for="whoName" class="form-label">Person of interest?</label>
        <input type="text" class="form-control" id="whoName">
      </div>
      <label class="form-label">Person of interest is:</label>
      <div class="form-check">
        <input class="form-check-input" type="checkbox" id="self" value="Self">
        <label class="form-check-label" for="self">Self</label>
      </div>
      <div class="form-check">
        <input class="form-check-input" type="checkbox" id="parent" value="Parent">
        <label class="form-check-label" for="parent">Parent</label>
      </div>
      <div class="form-check">
        <input class="form-check-input" type="checkbox" id="friend" value="Friend">
        <label class="form-check-label" for="friend">Friend</label>
      </div>
      <div class="form-check">
        <input class="form-check-input" type="checkbox" id="sibling" value="Sibling">
        <label class="form-check-label" for="sibling">Sibling</label>
      </div>
      <div class="form-check">
        <input class="form-check-input" type="checkbox" id="homeOwner" value="Home Owner">
        <label class="form-check-label" for="homeOwner">Home Owner</label>
      </div>
      <div class="form-check">
        <input class="form-check-input" type="checkbox" id="other" value="Other">
        <label class="form-check-label" for="other">Other</label>
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
