<template>
    <section id="login" class="bg-bg flex items-center justify-center min-h-screen px-5 py-10 md:px-0">
        <div
            class="container flex flex-col items-center space-y-10 py-14 px-5 md:px-10 bg-textLight shadow-xl max-w-xl rounded-lg">
            <p class="text-textDark text-4xl font-extrabold md:text-5xl">Rejestracja</p>

            <form class="space-y-4 w-full" @submit.prevent="handleRegister" novalidate>
                <div class="flex flex-col space-y-1">
                    <label for="email" class="uppercase text-textDark text-xl md:text-2xl font-bold">Email</label>
                    <input id="email"
                        class="bg-textLight border-2 rounded-lg py-2 px-2 focus:outline-none duration-150"
                        :class="errors.email ? 'border-red-500 focus:border-red-500' : 'border-textGray/90 focus:border-textDark'"
                        type="text" placeholder="Wprowadź email" v-model="registerData.email"
                        @input="errors.email = ''">
                    <div class="h-5 flex items-center">
                        <span v-if="errors.email" class="text-red-500 text-sm font-medium">{{ errors.email }}</span>
                    </div>
                </div>

                <div class="flex flex-col space-y-1">
                    <label for="name" class="uppercase text-textDark text-xl md:text-2xl font-bold">Imię</label>
                    <input id="name"
                        class="bg-textLight border-2 rounded-lg py-2 px-2 focus:outline-none duration-150"
                        :class="errors.name ? 'border-red-500 focus:border-red-500' : 'border-textGray/90 focus:border-textDark'"
                        type="text" placeholder="Wprowadź imię" v-model="registerData.name"
                        @input="errors.name = ''">
                    <div class="h-5 flex items-center">
                        <span v-if="errors.name" class="text-red-500 text-sm font-medium">{{ errors.name }}</span>
                    </div>
                </div>

                <div class="flex flex-col space-y-1">
                    <label for="surname" class="uppercase text-textDark text-xl md:text-2xl font-bold">Nazwisko</label>
                    <input id="surname"
                        class="bg-textLight border-2 rounded-lg py-2 px-2 focus:outline-none duration-150"
                        :class="errors.surname ? 'border-red-500 focus:border-red-500' : 'border-textGray/90 focus:border-textDark'"
                        type="text" placeholder="Wprowadź nazwisko" v-model="registerData.surname"
                        @input="errors.surname = ''">
                    <div class="h-5 flex items-center">
                        <span v-if="errors.surname" class="text-red-500 text-sm font-medium">{{ errors.surname }}</span>
                    </div>
                </div>

                <div class="flex flex-col space-y-1">
                    <label for="login" class="uppercase text-textDark text-xl md:text-2xl font-bold">Login</label>
                    <input id="login"
                        class="bg-textLight border-2 rounded-lg py-2 px-2 focus:outline-none duration-150"
                        :class="errors.login ? 'border-red-500 focus:border-red-500' : 'border-textGray/90 focus:border-textDark'"
                        type="text" placeholder="Wprowadź nazwę użytkownika" v-model="registerData.login"
                        @input="errors.login = ''">
                    <div class="h-5 flex items-center">
                        <span v-if="errors.login" class="text-red-500 text-sm font-medium">{{ errors.login }}</span>
                    </div>
                </div>

                <div class="flex flex-col space-y-1">
                    <label for="date" class="uppercase text-textDark text-xl md:text-2xl font-bold">Data
                        urodzenia</label>
                    <input id="date"
                        class="bg-textLight border-2 rounded-lg py-2 px-2 focus:outline-none duration-150"
                        :class="errors.date ? 'border-red-500 focus:border-red-500' : 'border-textGray/90 focus:border-textDark'"
                        type="date" v-model="registerData.date" @input="errors.date = ''">
                    <div class="min-h-5 flex items-center">
                        <span v-if="errors.date" class="text-red-500 text-sm font-medium leading-tight">{{ errors.date }}</span>
                    </div>
                </div>

                <div class="flex flex-col space-y-1">
                    <label for="password" class="uppercase text-textDark text-xl md:text-2xl font-bold">Hasło</label>
                    <div class="relative">
                        <input id="password"
                            class="bg-textLight border-2 rounded-lg py-2 px-2 focus:outline-none duration-150 w-full"
                            :class="errors.password ? 'border-red-500 focus:border-red-500' : 'border-textGray/90 focus:border-textDark'"
                            :type="showPassword ? 'text' : 'password'" placeholder="Wprowadź hasło"
                            v-model="registerData.password" @input="errors.password = ''">
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
                    <div class="min-h-5 flex items-center">
                         <span v-if="errors.password" class="text-red-500 text-sm font-medium leading-tight">{{ errors.password }}</span>
                    </div>
                </div>

                <div class="flex flex-col space-y-1">
                    <label for="passwordConfirmation"
                        class="uppercase text-textDark text-xl md:text-2xl font-bold">Powtórz hasło</label>
                    <div class="relative">
                        <input id="passwordConfirmation"
                            class="bg-textLight border-2 rounded-lg py-2 px-2 focus:outline-none duration-150 w-full"
                            :class="errors.passwordConfirmation ? 'border-red-500 focus:border-red-500' : 'border-textGray/90 focus:border-textDark'"
                            :type="showPasswordConfirmation ? 'text' : 'password'" placeholder="Powtórz hasło"
                            v-model="passwordConfirmation" @input="errors.passwordConfirmation = ''">
                        <button type="button" @click="showPasswordConfirmation = !showPasswordConfirmation"
                            class="absolute inset-y-0 right-0 flex items-center pr-4 text-formPlaceholder hover:text-gray-700">
                             <svg v-if="!showPasswordConfirmation" xmlns="http://www.w3.org/2000/svg" fill="none"
                                viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" class="w-5 h-5">
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
                    <div class="h-5 flex items-center">
                         <span v-if="errors.passwordConfirmation" class="text-red-500 text-sm font-medium">{{ errors.passwordConfirmation }}</span>
                    </div>
                </div>

                <div class="border text-center py-3 rounded relative transition-all duration-200 min-h-5 flex items-center justify-center"
                    :class="generalError ? 'bg-red-100 border-red-400 text-red-700' : 'border-transparent'">
                    <span>{{ generalError || '' }}</span>
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
                            <span v-if="isLoading">Rejestracja...</span>
                            <span v-else>Zarejestruj się</span>
                        </span>
                    </button>

                </div>

            </form>
            <div class="flex flex-col space-y-2 items-center justify-center w-full pt-8">
                <p class="text-3xl md:text-4xl text-textDark font-bold">Masz już konto?</p>
                <a href="/login" class="group w-full">
                    <div class="bg-wineRose py-3 w-full rounded-lg group-hover:bg-wineRoseLight duration-200">
                        <p class="font-bold text-xl text-center text-textLight group-hover:text-textDark duration-200">
                            Zaloguj się</p>
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

const registerData = reactive({
    email: '',
    name: '',
    surname: '',
    login: '',
    password: '',
    date: ''
});

const errors = reactive({
    email: '',
    name: '',
    surname: '',
    login: '',
    password: '',
    passwordConfirmation: '',
    date: ''
});

const generalError = ref('');

const isLoading = ref(false);
const showPassword = ref(false);
const showPasswordConfirmation = ref(false);
const passwordConfirmation = ref('');

const API_URL = 'https://localhost:7028/api/Auth/register';

const validateForm = () => {
    Object.keys(errors).forEach(key => errors[key] = '');
    generalError.value = '';

    let isValid = true;

    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    const nameSurnameRegex = /^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]+$/;
    const passwordRegex = /^(?=.*\d)(?=.*[\W_]).{8,}$/;

    if (!registerData.email) {
        errors.email = 'Podaj adres email.';
        isValid = false;
    } else if (!emailRegex.test(registerData.email)) {
        errors.email = 'Nieprawidłowy format adresu email.';
        isValid = false;
    }

    if (!registerData.name) {
        errors.name = 'Podaj imię.';
        isValid = false;
    } else if (!nameSurnameRegex.test(registerData.name)) {
        errors.name = 'Imię nie może zawierać cyfr ani znaków specjalnych.';
        isValid = false;
    }

    if (!registerData.surname) {
        errors.surname = 'Podaj nazwisko.';
        isValid = false;
    } else if (!nameSurnameRegex.test(registerData.surname)) {
        errors.surname = 'Nazwisko nie może zawierać cyfr ani znaków specjalnych.';
        isValid = false;
    }

    if (!registerData.login) {
        errors.login = 'Podaj login.';
        isValid = false;
    }

    if (!registerData.password) {
        errors.password = 'Podaj hasło.';
        isValid = false;
    } else if (!passwordRegex.test(registerData.password)) {
        errors.password = 'Min. 8 znaków, jedna cyfra i jeden znak specjalny.';
        isValid = false;
    }

    if (passwordConfirmation.value !== registerData.password) {
        errors.passwordConfirmation = 'Podane hasła muszą być takie same.';
        isValid = false;
    }

    if (!registerData.date) {
        errors.date = 'Podaj datę urodzenia.';
        isValid = false;
    } else {
        const today = new Date();
        const birthDate = new Date(registerData.date);
        let age = today.getFullYear() - birthDate.getFullYear();
        const monthDiff = today.getMonth() - birthDate.getMonth();
        if (monthDiff < 0 || (monthDiff === 0 && today.getDate() < birthDate.getDate())) {
            age--;
        }
        if (age < 18) {
            errors.date = 'Rejestracja jest dostępna tylko dla osób pełnoletnich (18+).';
            isValid = false;
        }
    }

    return isValid;
};

const handleRegister = async () => {
    if (!validateForm()) {
        return;
    }

    isLoading.value = true;
    generalError.value = '';

    try {
        const response = await fetch(API_URL, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                email: registerData.email,
                name: registerData.name,
                surname: registerData.surname,
                password: registerData.password,
                birthDate: registerData.date,
                login: registerData.login,
            })
        });

        const data = await response.json();

        if (!response.ok) {
            throw new Error(data.message);
        }

        const { token, ...userProfile } = data;
        localStorage.setItem('userToken', token);
        localStorage.setItem('userData', JSON.stringify(userProfile));
        router.push('/login');

    } catch (error) {
        console.error(error);
        generalError.value = typeof error.message === 'string'
            ? error.message
            : 'Wystąpił problem z połączeniem z serwerem.';
    } finally {
        isLoading.value = false;
    }
};
</script>

<style scoped></style>