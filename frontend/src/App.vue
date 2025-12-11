<script setup>
  import { RouterView } from 'vue-router'
  import AppFooter from './views/Footer/AppFooter.vue';
</script>

<template>
<div class="min-h-screen flex flex-col">
    
    <main class="flex-grow">
      <RouterView />
    </main>

    <AppFooter />
    
  </div>
</template>

<style scoped></style>
