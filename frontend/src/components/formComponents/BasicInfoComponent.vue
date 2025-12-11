<template>
    <div class="container max-w-6xl mx-auto">
    <div
        class="flex flex-col items-center space-y-8 md:space-y-0 md:flex-row md:space-x-10 px-5 py-8 rounded-md bg-wineRedDark shadow-xl">

        <!-- left section -->
        <div class="flex flex-col w-full md:w-1/2 space-y-8">

            <!-- name -->
            <div class="flex space-x-5 items-center">
                <label for="name" class="text-textLight text-lg md:text-xl">Nazwa</label>
                <input id="name"
                    class="bg-wineRedLight rounded-lg py-2 px-2 focus:outline-none focus:ring-white focus:bg-wineRed focus:text-textLight focus:ring duration-150 w-full"
                    type="text" placeholder="Wprowadź nazwę wina" required v-model="wineData.name"></input>
            </div>

            <!-- region -->
            <div class="flex space-x-5 items-center">
                <label for="region" class="text-textLight text-lg md:text-xl whitespace-nowrap">Kraj /
                    Region</label>
                <input id="region"
                    class="bg-wineRedLight rounded-lg py-2 px-2 focus:outline-none focus:ring-white focus:bg-wineRed focus:text-textLight focus:ring duration-150 w-full"
                    type="text" placeholder="Wprowadź kraj / region pochodzenia" required
                    v-model="wineData.region"></input>
            </div>

            <!-- variety -->
            <div class="flex space-x-5 items-center">
                <label for="variety" class="text-textLight text-lg md:text-xl">Szczep(y)</label>
                <input id="variety"
                    class="bg-wineRedLight rounded-lg py-2 px-2 focus:outline-none focus:ring-white focus:bg-wineRed focus:text-textLight focus:ring duration-150 w-full"
                    type="text" placeholder="Wprowadź szczep(y)" required v-model="wineData.variety"></input>
            </div>
        </div>

        <!-- right section -->
        <div class="flex flex-col w-full md:w-1/2 space-y-8">
            <!-- year -->
            <div class="flex space-x-5 items-center">
                <label for="year" class="text-textLight text-lg md:text-xl">Rocznik</label>
                <input id="year"
                    class="bg-wineRedLight rounded-lg py-2 px-2 focus:outline-none focus:ring-white focus:bg-wineRed focus:text-textLight focus:ring duration-150 w-full"
                    type="text" placeholder="Wprowadź rocznik wina" required v-model="wineData.year"></input>
            </div>

            <!-- place -->
            <div class="flex space-x-5 items-center">
                <label for="place" class="text-textLight text-lg md:text-xl whitespace-nowrap">Miejsce
                    zakupu</label>
                <input id="place"
                    class="bg-wineRedLight rounded-lg py-2 px-2 focus:outline-none focus:ring-white focus:bg-wineRed focus:text-textLight focus:ring duration-150 w-full"
                    type="text" placeholder="Wprowadź miejsce zakupu" required v-model="wineData.place"></input>
            </div>

            <!-- price -->
            <div class="flex space-x-5 items-center">
                <label for="price" class="text-textLight text-lg md:text-xl">Cena</label>
                <input id="price"
                    class="bg-wineRedLight rounded-lg py-2 px-2 focus:outline-none focus:ring-white focus:bg-wineRed focus:text-textLight focus:ring duration-150 w-full"
                    type="text" placeholder="Wprowadź cenę" required v-model="wineData.price"></input>
            </div>
        </div>
    </div>
    </div>
</template>

<script setup>
import { ref, reactive } from 'vue'

const wineData = reactive({
    name: '',
    region: '',
    variety: '',
    year: '',
    place: '',
    price: '',
    intensity: '50',
    color: '',
    other: [],
})

</script>