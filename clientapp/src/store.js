import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
    state: {
        teams: []
    },
    getters: {
        getTeams: (state) => (state.teams)
    },
    mutations: {
        setTeams: (state, teams) => (state.teams = teams),
        filterTeams: (state, params) => (state.teams = state.teams.filter(team => team[params.filter].toUpperCase().indexOf(params.value.toUpperCase()) >= 0)),
        sortTeams: (state, prop) => (state.teams.sort((a, b) => ((a[prop] < b[prop] ? -1:1) || (a.winslosses < b.winslosses ? -1:1))))
    },
    actions: {}
})
