<template>
  <section class="min-h-screen bg-bg px-5 py-10 font-sans text-textDark">
    <div class="max-w-4xl mx-auto bg-white p-8 md:p-12 rounded-xl shadow-xl">
      
      <h1 class="text-3xl md:text-4xl font-extrabold mb-8 text-center text-wineRedDark border-b pb-4 border-wineRedDark/20">
        Polityka Plików Cookies
      </h1>

      <div class="space-y-6 text-justify leading-relaxed text-textDark/90">
        
        <p class="font-medium italic text-center text-wineRed mb-6">
          Korzystając z serwisu "Vinissimo", wyrażasz zgodę na używanie plików Cookies zgodnie z tą Polityką.
        </p>

        <div>
          <h2 class="text-xl font-bold mb-2 text-wineRed">§ 1. Czym są pliki Cookies?</h2>
          <p>
            Pliki Cookies (tzw. "ciasteczka") to małe pliki tekstowe wysyłane przez serwis internetowy i zapisywane na urządzeniu końcowym Użytkownika (komputerze, smartfonie). Służą one do zapamiętywania preferencji oraz utrzymywania sesji użytkownika.
          </p>
        </div>

        <div>
          <h2 class="text-xl font-bold mb-2 text-wineRed">§ 2. Jakich Cookies używamy?</h2>
          <p>
            W ramach serwisu stosujemy dwa zasadnicze rodzaje plików (oraz technologii zbliżonych, takich jak <em>Local Storage</em>):
          </p>
          <ul class="list-disc pl-5 mt-2 space-y-2">
            <li>
              <strong>Niezbędne (Techniczne):</strong> Są kluczowe dla prawidłowego działania strony. Umożliwiają m.in. <strong>logowanie do konta</strong> i bezpieczne poruszanie się po serwisie. Bez nich Twoja "Piwniczka" nie mogłaby działać.
            </li>
            <li>
              <strong>Analityczne (Opcjonalne):</strong> Pozwalają nam zrozumieć, w jaki sposób użytkownicy korzystają z serwisu (np. które wina są dodawane najczęściej), co pomaga nam ulepszać aplikację.
            </li>
          </ul>
        </div>

        <div>
          <h2 class="text-xl font-bold mb-2 text-wineRed">§ 3. Bezpieczeństwo</h2>
          <p>
            Pliki Cookies używane przez naszą aplikację są bezpieczne dla Twojego urządzenia. Nie zawierają wirusów ani złośliwego oprogramowania. Nie służą też do identyfikacji tożsamości użytkownika w sposób inny niż na potrzeby logowania.
          </p>
        </div>

        <div>
          <h2 class="text-xl font-bold mb-2 text-wineRed">§ 4. Zarządzanie Cookies</h2>
          <p>
            Użytkownik może w każdej chwili zmienić ustawienia dotyczące plików Cookies w swojej przeglądarce internetowej (zablokować je lub usunąć). Należy jednak pamiętać, że <strong>wyłączenie obsługi Cookies może uniemożliwić zalogowanie się</strong> do aplikacji "Twoja Piwniczka".
          </p>
        </div>

      </div>

      <div class="mt-10 text-center">
        <router-link 
          to="/dashboard" 
          class="inline-block bg-wineRedDark text-textLight px-8 py-3 rounded-lg font-bold hover:bg-wineRed transition duration-200"
        >
          Wróć do listy win
        </router-link>
      </div>

    </div>
  </section>
</template>

<script setup>
</script>