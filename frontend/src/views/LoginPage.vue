<template>
    <section id="login" class="bg-bg flex items-center justify-center min-h-screen px-5 py-10 md:px-0">
        <div
            class="container flex flex-col items-center space-y-10 py-14 px-5 md:px-10 bg-textLight shadow-xl max-w-xl rounded-lg">
            <p class="text-textDark text-4xl font-extrabold md:text-5xl">Logowanie</p>

            <form class="space-y-8 w-full" @submit.prevent="handleLogin" novalidate>

                <div class="flex flex-col space-y-1">
                    <label for="name" class="uppercase text-textDark text-xl md:text-2xl font-bold">Email</label>
                    <input id="name"
                        class="bg-textLight border-2 border-textGray/90 rounded-lg py-2 px-2 focus:outline-none focus:border-textDark duration-150"
                        type="text" placeholder="Wprowadź email" required v-model="loginData.email"></input>
                </div>
                <div class="flex flex-col space-y-1">
                    <label for="password" class="uppercase text-textDark text-xl md:text-2xl font-bold">Hasło</label>
                    <div class="relative">
                        <input id="password"
                            class="bg-textLight border-2 border-textGray/90 rounded-lg py-2 px-2 focus:outline-none focus:border-textDark duration-150 w-full"
                            :type="showPassword ? 'text' : 'password'" placeholder="Wprowadź hasło" required
                            v-model="loginData.password"></input>
                        <button type="button" @click="showPassword = !showPassword"
                            class="absolute inset-y-0 right-0 flex items-center pr-4 text-formPlaceholder hover:text-gray-700">
                            <svg v-if="!showPassword" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24"
                                stroke-width="1.5" stroke="currentColor" class="w-5 h-5">
                                <path stroke-linecap="round" stroke-linejoin="round"
                                    d="M2.036 12.322a1.012 1.012 0 010-.639C3.423 10.224 7.66 6.5 12 6.5s8.577 3.724 9.964 5.183c.375.375.375.983 0 1.358C20.577 14.776 16.34 18.5 12 18.5s-8.577-3.724-9.964-5.183a1.012 1.012 0 010-.639z" />
                                <path stroke-linecap="round" stroke-linejoin="round"
                                    d="M15 12a3 3 0 11-6 0 3 3 0 016 0z" />
                            </svg>
                            <svg v-else xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24"
                                stroke-width="1.5" stroke="currentColor" class="w-5 h-5">
                                <path stroke-linecap="round" stroke-linejoin="round"
                                    d="M3.98 8.223A10.477 10.477 0 001.934 12C3.226 16.338 7.244 19.5 12 19.5c.993 0 1.953-.138 2.863-.395M6.228 6.228A10.45 10.45 0 0112 4.5c4.756 0 8.773 3.162 10.065 7.498a10.522 10.522 0 01-4.293 5.774M6.228 6.228L3 3m3.228 3.228l3.65 3.65m7.894 7.894L21 21m-3.228-3.228l-3.65-3.65m0 0a3 3 0 10-4.243-4.243m4.243 4.243l-4.243-4.243" />
                            </svg>
                        </button>
                    </div>
                </div>

                <div class="border text-center py-3 rounded relative transition-colors duration-200"
                    :class="errorMessage ? 'bg-red-100 border-red-400 text-red-700' : 'invisible border-transparent'">
                    <span v-if="errorMessage">{{ errorMessage }}</span>
                    <span v-else>&nbsp;</span>
                </div>

                <div class="flex flex-col space-y-3 pt-5 md:flex-row md:space-y-0 md:space-x-6">

                    <a class="md:w-1/2 group" href="#">
                        <div
                            class="bg-wineWhiteDark py-3 rounded-lg group-hover:bg-wineWhite group-hover:text-textLight duration-200">
                            <p class="text-xl text-center font-bold">Zapomniałeś hasła?</p>
                        </div>
                    </a>

                    <button type="submit"
                        class="group md:w-1/2 bg-wineRedDark py-3 rounded-lg hover:bg-wineRed duration-200 cursor-pointer">
                        <span class="text-xl font-bold text-textLight group-hover:text-textDark duration-200">
                            <span v-if="isLoading">Logowanie...</span>
                            <span v-else>Zaloguj się</span>
                        </span>
                    </button>

                </div>

            </form>

            <div class="flex flex-col space-y-2 items-center justify-center w-full pt-8">
                <p class="text-3xl md:text-4xl text-textDark font-bold">Nie masz konta?</p>

                <a href="/register" class="group w-full">
                    <div class="bg-wineRose py-3 w-full rounded-lg group-hover:bg-wineRoseLight duration-200">
                        <p class="font-bold text-xl text-center text-textLight group-hover:text-textDark duration-200">
                            Zarejestruj się</p>
                    </div>
                </a>
            </div>
        </div>
    </section>
</template>

<script setup>
import { ref, reactive } from 'vue';
import { useRouter } from 'vue-router';

const router = useRouter();

const loginData = reactive({
    email: '',
    password: ''
});

const errorMessage = ref('');
const isLoading = ref(false);
const showPassword = ref(false);

const API_URL = 'https://localhost:7028/api/Auth/login';

const validateForm = () => {
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

    if (!loginData.email) {
        errorMessage.value = 'Podaj adres email.';
        return false;
    }
    
    if (!loginData.password) {
        errorMessage.value = 'Podaj hasło.';
        return false;
    }

    if (!emailRegex.test(loginData.email)) {
        errorMessage.value = 'Nieprawidłowy format adresu email.';
        return false;
    }

    return true;
};

const handleLogin = async () => {
    errorMessage.value = '';

    if (!validateForm()) {
        return;
    }

    isLoading.value = true;

    try {
        const response = await fetch(API_URL, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                email: loginData.email,
                password: loginData.password
            })
        });

        const data = await response.json();

        if (!response.ok) {
            throw new Error(data);
        }

        const { token, ...userProfile } = data;

        localStorage.setItem('userToken', token);
        localStorage.setItem('userData', JSON.stringify(userProfile));

        router.push('/dashboard');

    } catch (error) {
        console.error(error);
        errorMessage.value = typeof error.message === 'string'
            ? error.message
            : 'Wystąpił problem z połączeniem z serwerem.';
    } finally {
        isLoading.value = false;
    }
};
</script>

<style scoped></style>