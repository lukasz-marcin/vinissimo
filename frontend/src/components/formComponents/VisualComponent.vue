<template>
    <div class="container max-w-6xl mx-auto">
    <div class="w-full bg-wineRedDark flex flex-col text-textLight space-y-8 px-4 py-6 rounded-lg shadow-lg">
        <h3 class="text-2xl font-bold text-center">Wzrok</h3>

        <!-- form container -->
        <div class="flex flex-col space-y-8">

            <!-- intensity -->
            <div class="flex space-x-5 items-center">
                <label for="intensity" class="text-textLight text-lg md:text-xl">Intensywność</label>

                <div class="w-full flex items-center space-x-4">
                    <input id="intensity" type="range" min="0" max="100" v-model="wineData.intensity"
                        :style="sliderStyle" class="w-full h-2 rounded-lg appearance-none cursor-pointer accent-white">
                    <span class="text-textLight font-bold w-12 text-right">{{ wineData.intensity
                    }}%</span>
                </div>
            </div>

            <!-- color -->
            <div class="flex space-x-5 items-center">
                <label for="color" class="text-textLight text-lg md:text-xl">Barwa</label>

                <div class="relative w-full">
                    <div @click="isColorOpen = !isColorOpen"
                        class="flex justify-between items-center bg-wineRedLight text-textDark rounded-lg py-2 px-2 w-full duration-150"
                        :class="{ 'ring ring-white': isColorOpen }">
                        <span v-if="wineData.color">{{ wineData.color }}</span>
                        <span v-else class="text-textDark/70">Wybierz</span>

                        <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5"
                            stroke="currentColor" class="w-5 h-5 transition-transform duration-200"
                            :class="{ 'rotate-180': isColorOpen }">
                            <path stroke-linecap="round" stroke-linejoin="round" d="M19.5 8.25l-7.5 7.5-7.5-7.5" />
                        </svg>
                    </div>

                    <div v-if="isColorOpen" @click="isColorOpen = false" class="fixed inset-0 z-10 cursor-default">
                    </div>

                    <ul v-if="isColorOpen"
                        class="absolute top-full left-0 w-full mt-2 bg-bg text-textDark rounded-lg shadow-xl z-20 overflow-hidden border border-white">

                        <li v-for="(option, index) in colorOptions" :key="index" @click="selectColor(option)"
                            class="px-4 py-2 hover:bg-wineRedDark hover:text-white cursor-pointer transition-colors border-b border-gray-100 last:border-0">
                            {{ option }}
                        </li>
                    </ul>
                </div>
            </div>

            <!-- other -->
            <div class="flex space-x-5 items-center">
                <label for="other" class="text-textLight text-lg md:text-xl">Inne</label>

                <div class="relative w-full">
                    <div @click="isOtherOpen = !isOtherOpen"
                        class="flex justify-between items-center bg-wineRedLight text-textDark rounded-lg py-2 px-2 w-full duration-150"
                        :class="{ 'ring ring-white': isOtherOpen }">
                        <span v-if="selectedOtherLabel">{{ selectedOtherLabel }}</span>
                        <span v-else class="text-textDark/70">Wybierz cechy</span>
                        <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5"
                            stroke="currentColor" class="w-5 h-5 transition-transform duration-200"
                            :class="{ 'rotate-180': isOtherOpen }">
                            <path stroke-linecap="round" stroke-linejoin="round" d="M19.5 8.25l-7.5 7.5-7.5-7.5" />
                        </svg>
                    </div>

                    <div v-if="isOtherOpen" @click="isOtherOpen = false" class="fixed inset-0 z-10 cursor-default">
                    </div>

                    <ul v-if="isOtherOpen"
                        class="absolute top-full left-0 w-full mt-2 bg-bg text-textDark rounded-lg shadow-xl z-20 overflow-hidden border border-white">

                        <li v-for="(option, index) in otherOptions" :key="index"
                            class="border-b border-gray-100 last:border-0 hover:bg-wineRedDark hover:text-white transition-colors">

                            <label class="flex items-center px-4 py-3 cursor-pointer w-full space-x-3">

                                <div class="relative flex items-center">
                                    <input type="checkbox" :value="option" v-model="wineData.other"
                                        class="peer appearance-none w-5 h-5 border-2 border-wineRedLight rounded checked:bg-wineRed checked:border-textGray transition-colors cursor-pointer">
                                    <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" fill="currentColor"
                                        class="w-3.5 h-3.5 text-textLight absolute left-1/2 top-1/2 -translate-x-1/2 -translate-y-1/2 opacity-0 peer-checked:opacity-100 pointer-events-none transition-opacity">
                                        <path fill-rule="evenodd"
                                            d="M19.916 4.626a.75.75 0 01.208 1.04l-9 13.5a.75.75 0 01-1.154.114l-6-6a.75.75 0 011.06-1.06l5.353 5.353 8.493-12.739a.75.75 0 011.04-.208z"
                                            clip-rule="evenodd" />
                                    </svg>
                                </div>

                                <span class="select-none">{{ option }}</span>
                            </label>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    </div>
</template>

<script setup>
import { ref, reactive, computed } from 'vue';

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

const isColorOpen = ref(false)
const isOtherOpen = ref(false)

const colorOptions = [
    'fioletowe',
    'rubinowe',
    'brązowe'
]

const otherOptions = [
    'musowanie',
    'osad',
    'mętność',
];

const selectColor = (option) => {
    wineData.color = option;
    isColorOpen.value = false;
};

const selectedOtherLabel = computed(() => {
    return wineData.other.join(', ');
});

const sliderStyle = computed(() => {
    const val = wineData.intensity;
    return {
        background: `linear-gradient(to right, white 0%, white ${val}%, rgba(255, 255, 255, 0.2) ${val}%, rgba(255, 255, 255, 0.2) 100%)`
    };
});
</script>