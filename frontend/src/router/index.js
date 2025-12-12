import { createRouter, createWebHistory } from 'vue-router'
import LoginPage from '@/views/LoginPage.vue'
import RegisterPage from '@/views/RegisterPage.vue'
import Form from '@/views/Form.vue'
import FormBasic from '../components/formComponents/BasicInfoComponent.vue'
import VisualComponent from '../components/formComponents/VisualComponent.vue'
import Footer from '@/views/Footer.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/login',
      name: 'login',
      component: LoginPage,
    },
    {
      path: '/register',
      name: 'register',
      component: RegisterPage,
    },
    {
      path: '/form',
      name: 'form',
      component: Form
    },

    // TEST ONLY!
    {
      path: '/formBasic',
      name: 'formBasic',
      component: FormBasic
    },
    {
      path: '/visualComponent',
      name: 'visualComponent',
      component: VisualComponent
    },
    {
      path: '/footer',
      name: 'footer',
      component: Footer
    }
  ],
})

export default router
