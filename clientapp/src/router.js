import Vue from 'vue'
import Router from 'vue-router'
import Team from './components/Team.vue'
Vue.use(Router)

export default new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
      path: '/',
          name: 'team',
          component: Team
    }
  ]
})
