import Vue from 'vue'
import Router from 'vue-router'
import Home from './views/Home.vue'
import Proyecto from './components/Proyecto.vue'
import Registrar from './components/Registrar.vue'

Vue.use(Router)

export default new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
      path: '/',
      name: 'home',
      component: Home
    },
    {
      path: '/proyectos',
      name: 'proyectos',
      component: Proyecto
    },
    {
      path: '/register',
      name: 'register',
      component: Registrar
    },

  ]
})
