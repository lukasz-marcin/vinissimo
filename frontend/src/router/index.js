import { createRouter, createWebHistory } from 'vue-router'
import LoginPage from '@/views/LoginPage.vue'
import RegisterPage from '@/views/RegisterPage.vue'
import TastingList from '@/views/TastingList.vue'
import Terms from '@/views/Footer/Terms.vue'
import CookiesTerms from '@/views/Footer/CookiesTerms.vue'
import Privacy from '@/views/Footer/Privacy.vue'
import Newsletter from '@/views/Footer/Newsletter.vue'
import Form from '@/views/Form.vue'
import FormBasic from '../components/formComponents/BasicInfoComponent.vue'
import VisualComponent from '../components/formComponents/VisualComponent.vue'

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
      path: '/dashboard',
      name: 'lista degustacji',
      component: TastingList,
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
      path: '/terms',
      name: 'terms',
      component: Terms
    },
    {
      path: '/cookies',
      name: 'cookies',
      component: CookiesTerms
    },
    {
      path: '/privacy',
      name: 'privacy',
      component: Privacy
    },
    {
      path: '/newsletter',
      name: 'newsletter',
      component: Newsletter
    }
  ],
})

export default router
