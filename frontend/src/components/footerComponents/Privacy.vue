<template>
  <section class="min-h-screen bg-bg px-5 py-10 font-sans text-textDark">
    <div class="max-w-4xl mx-auto bg-white p-8 md:p-12 rounded-xl shadow-xl">
      
      <h1 class="text-3xl md:text-4xl font-extrabold mb-8 text-center text-wineRedDark border-b pb-4 border-wineRedDark/20">
        Polityka Prywatności
      </h1>

      <div class="space-y-6 text-justify leading-relaxed text-textDark/90">
        
        <p class="font-medium italic text-center text-wineRed mb-6">
          Szanujemy Twoją prywatność. Poniżej wyjaśniamy, w jaki sposób dbamy o Twoje dane w aplikacji "MLWine".
        </p>

        <div>
          <h2 class="text-xl font-bold mb-2 text-wineRed">§ 1. Administrator Danych</h2>
          <p>
            1. Administratorem Twoich danych osobowych jest Operator aplikacji "MLWine" (dalej: "Administrator").<br>
            2. Kontakt z Administratorem możliwy jest drogą elektroniczną pod adresem e-mail: <strong>[Twój Email Kontaktowy]</strong>.
          </p>
        </div>

        <div>
          <h2 class="text-xl font-bold mb-2 text-wineRed">§ 2. Jakie dane zbieramy?</h2>
          <p>
            W celu świadczenia usługi zbieramy tylko niezbędne minimum danych:
          </p>
          <ul class="list-disc pl-5 mt-2 space-y-1">
            <li><strong>Adres e-mail:</strong> Niezbędny do założenia konta, logowania i odzyskiwania hasła.</li>
            <li><strong>Dane o winach:</strong> Wszystkie informacje, które wprowadzasz do dziennika (nazwy win, roczniki, Twoje oceny i notatki).</li>
            <li><strong>Zdjęcia:</strong> Jeśli zdecydujesz się wgrać zdjęcia etykiet, są one przechowywane na naszych serwerach przypisane do Twojego konta.</li>
          </ul>
        </div>

        <div>
          <h2 class="text-xl font-bold mb-2 text-wineRed">§ 3. Cel przetwarzania</h2>
          <p>
            Twoje dane przetwarzamy wyłącznie w celu:
          </p>
          <ul class="list-disc pl-5 mt-2 space-y-1">
            <li>Świadczenia usługi (umożliwienia Ci dostępu do Twojej listy win),</li>
            <li>Zapewnienia bezpieczeństwa i stabilności działania serwisu.</li>
          </ul>
          <p class="mt-2">
            <strong>Nie sprzedajemy</strong> Twoich danych podmiotom trzecim ani nie wykorzystujemy ich do celów marketingowych bez Twojej wyraźnej zgody.
          </p>
        </div>

        <div>
          <h2 class="text-xl font-bold mb-2 text-wineRed">§ 4. Odbiorcy danych</h2>
          <p>
            Twoje dane mogą być przekazywane jedynie zaufanym podmiotom, które zapewniają infrastrukturę techniczną aplikacji (dostawca hostingu, dostawca bazy danych). Podmioty te przetwarzają dane wyłącznie na nasze polecenie i gwarantują ich bezpieczeństwo.
          </p>
        </div>

        <div>
          <h2 class="text-xl font-bold mb-2 text-wineRed">§ 5. Twoje Prawa</h2>
          <p>
            Zgodnie z RODO przysługuje Ci prawo do:
          </p>
          <ul class="list-disc pl-5 mt-2 space-y-1">
            <li>Dostępu do swoich danych,</li>
            <li>Sprostowania (poprawiania) danych,</li>
            <li>Usunięcia danych ("prawo do bycia zapomnianym") – w tym celu skontaktuj się z nami mailowo,</li>
            <li>Ograniczenia przetwarzania.</li>
          </ul>
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