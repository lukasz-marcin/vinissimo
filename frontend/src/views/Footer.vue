<template>
  <footer class="bg-bg border-t border-black/5 pt-10 pb-6 px-4 font-sans">
    
    <div class="flex flex-col space-y-8 max-w-6xl mx-auto">
      
      <div class="flex flex-col justify-between space-y-8 md:flex-row md:space-x-12 md:space-y-0">

        <div class="bg-wineRedDark rounded-xl p-8 text-center shadow-lg flex flex-col items-center justify-start md:w-1/3">
          <h3 class="text-2xl font-bold text-textLight mb-4 font-serif">Sekcja Prawna</h3>
          <ul class="space-y-2 text-white/90 text-sm md:text-base">
            <li><a href="https://pijodpowiedzialnie.pl/" target="_blank" class="hover:underline">Pij odpowiedzialnie</a></li>
            <li><a href="/terms" class="hover:underline">Regulamin</a></li>
            <li><a href="/privacy" class="hover:underline">Polityka prywatności</a></li>
            <li><a href="/cookies" class="hover:underline">Polityka cookies</a></li>
          </ul>
        </div>

        <div class="bg-wineWhite rounded-xl p-8 text-center shadow-lg flex flex-col items-center justify-start md:w-1/3">
          <h3 class="text-2xl font-bold text-textDark mb-4 font-serif">Społeczność</h3>
          <ul class="space-y-2 text-textDark/90 text-sm md:text-base font-medium">
            <li><a href="#" class="hover:text-white transition">Facebook</a></li>
            <li><a href="#" class="hover:text-white transition">Instagram</a></li>
            <li><a href="/newsletter" class="hover:text-white transition">Newsletter</a></li>
          </ul>
        </div>

        <div class="bg-wineRose rounded-xl p-8 text-center shadow-lg flex flex-col items-center justify-start md:w-1/3">
          <h3 class="text-2xl font-bold text-textDark mb-4 font-serif">Statystyki</h3>
          <div class="space-y-2 text-textDark/90 text-sm md:text-base font-medium">
            <p>Ilość degustacji: <span class="font-bold">5000</span></p>
            <p>Ilość użytkowników: <span class="font-bold">2000</span></p>
          </div>
        </div>

      </div>

      <div class="bg-textDark rounded-lg py-4 text-center shadow-md">
        <p class="text-textLight text-sm md:text-base italic font-serif opacity-90">
          Created by WhaleCode - 2025
        </p>
      </div>
    </div>

  </footer>
</template>

<script setup></script>

<style scoped></style>