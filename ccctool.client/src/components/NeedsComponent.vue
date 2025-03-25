<script setup lang="ts">

</script>

<template>
  <div class="row">
    <p>Check any product mentioned during call.</p>
  </div>
  <div class="row">
    <div class="col-8">
      <label class="form-label">Needs:</label>
      <div class="form-check">
        <input class="form-check-input" type="checkbox" id="self" value="Self">
        <label class="form-check-label" for="self">Ramp</label>
      </div>
      <div class="form-check">
        <input class="form-check-input" type="checkbox" id="parent" value="Parent">
        <label class="form-check-label" for="parent">Transfer Aid</label>
      </div>
      <div class="form-check">
        <input class="form-check-input" type="checkbox" id="friend" value="Friend">
        <label class="form-check-label" for="friend">Temporary Ramp</label>
      </div>
      <div class="form-check">
        <input class="form-check-input" type="checkbox" id="sibling" value="Sibling">
        <label class="form-check-label" for="sibling">Stair Lift</label>
      </div>
      <div class="form-check">
        <input class="form-check-input" type="checkbox" id="homeOwner" value="Home Owner">
        <label class="form-check-label" for="homeOwner">Elevator</label>
      </div>
    </div>
    <div class="col-4">
      <label for="additionalNotes" class="form-label">Additional Notes</label>
      <textarea class="form-control" id="additionalNotes" rows="3"></textarea>
      <label for="ballpark" class="form-label">Ballpark Costs Given</label>
      <input type="text" class="form-control" id="ballpark" />
    </div>
  </div>
</template>

<style scoped>

</style>
