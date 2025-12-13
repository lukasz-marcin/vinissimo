<template>
  <section class="min-h-screen bg-bg px-5 py-10 font-sans text-textDark">
    <div class="max-w-4xl mx-auto bg-white p-8 md:p-12 rounded-xl shadow-xl">
      
      <h1 class="text-3xl md:text-4xl font-extrabold mb-8 text-center text-wineRedDark border-b pb-4 border-wineRedDark/20">
        Regulamin Serwisu "Vinissimo"
      </h1>

      <div class="space-y-6 text-justify leading-relaxed text-textDark/90">
        
        <div>
          <h2 class="text-xl font-bold mb-2 text-wineRed">§ 1. Postanowienia ogólne</h2>
          <p>
            1. Niniejszy Regulamin określa zasady korzystania z aplikacji internetowej "Twoja Piwniczka".<br>
            2. Właścicielem serwisu jest Operator (dalej: "Usługodawcą").<br>
            3. Serwis przeznaczony jest wyłącznie dla osób pełnoletnich. Korzystając z serwisu, Użytkownik oświadcza, że ukończył 18 lat.
          </p>
        </div>

        <div>
          <h2 class="text-xl font-bold mb-2 text-wineRed">§ 2. Zakres Usług</h2>
          <p>
            1. Serwis umożliwia prowadzenie cyfrowego dziennika degustacji win.<br>
            2. Usługa ma charakter wyłącznie informacyjny i hobbystyczny. Serwis <strong>nie prowadzi sprzedaży alkoholu</strong> ani nie pośredniczy w jego obrocie.<br>
            3. Korzystanie z podstawowej wersji serwisu jest bezpłatne.
          </p>
        </div>

        <div>
          <h2 class="text-xl font-bold mb-2 text-wineRed">§ 3. Odpowiedzialność</h2>
          <p>
            1. Użytkownik ponosi pełną odpowiedzialność za treści i zdjęcia umieszczane w serwisie.<br>
            2. Usługodawca promuje model odpowiedzialnego spożywania alkoholu. Treści w serwisie nie są kierowane do osób niepełnoletnich.<br>
            3. Usługodawca dokłada wszelkich starań, aby serwis działał nieprzerwanie, jednak zastrzega sobie prawo do przerw technicznych.
          </p>
        </div>

        <div>
          <h2 class="text-xl font-bold mb-2 text-wineRed">§ 4. Prywatność i Prawa Autorskie</h2>
          <p>
            1. Administratorem danych osobowych jest Usługodawca. Dane (adres e-mail) przetwarzane są wyłącznie w celu obsługi konta Użytkownika.<br>
            2. Autorskie prawa majątkowe do kodu i projektu graficznego serwisu należą do Usługodawcy. Użytkownik zachowuje prawa do swoich opisów degustacyjnych.
          </p>
        </div>

        <div>
          <h2 class="text-xl font-bold mb-2 text-wineRed">§ 5. Postanowienia końcowe</h2>
          <p>
            1. W sprawach nieuregulowanych niniejszym Regulaminem zastosowanie mają przepisy prawa polskiego.<br>
            2. Usługodawca zastrzega sobie prawo do zmiany Regulaminu.
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