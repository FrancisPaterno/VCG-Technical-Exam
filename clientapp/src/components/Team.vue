<template>
    <v-container>
        <v-data-table :loading="loading" :items="getTeams" :headers="headers" :expanded.sync="expanded" show-expand>
            <template v-slot:top>
                <v-card flat>
                    <v-container>
                        <v-row>
                            <v-col>
                                <v-card-title>Teams</v-card-title>
                            </v-col>
                        </v-row>
                        <v-row>
                            <v-col></v-col>
                            <v-col>
                                <v-row>
                                    <v-select label="Filter by" :items="filter" v-model="filterModel" class="mr-2" style="max-width:200px" item-text="text" item-value="value"></v-select>
                                    <v-text-field append-icon="mdi-magnify" class="mx-2" v-model="search" @keyup.enter="filterTeamLists"></v-text-field>
                                </v-row>
                            </v-col>
                        </v-row>
                        <v-row>
                            <v-col>
                                <v-tooltip top>
                                    <template v-slot:activator="{ on, attrs }">
                                        <v-btn small
                                               text
                                               color="white"
                                               @click="sortBy('conference')"
                                               v-bind="attrs"
                                               v-on="on">
                                            <v-icon left small>mdi-basketball-hoop</v-icon>
                                            <span class="caption text-lowercase">By conference</span>
                                        </v-btn>
                                    </template>
                                    <span>Organize teams by conference</span>
                                </v-tooltip>
                                <v-tooltip top>
                                    <template v-slot:activator="{ on, attrs }">
                                        <v-btn small
                                               text
                                               color="white"
                                               @click="sortBy('division')"
                                               v-bind="attrs"
                                               v-on="on">
                                            <v-icon left small>mdi-basketball</v-icon>
                                            <span class="caption text-lowercase">By division</span>
                                        </v-btn>
                                    </template>
                                    <span>Organize teams by division</span>
                                </v-tooltip>
                            </v-col>
                        </v-row>
                    </v-container>
                </v-card>
            </template>
            <template #item.conference="{ item }">
                {{ item.conference }} : {{ item.division }}
            </template>
            <template v-slot:expanded-item="{headers, item}">
                <td :colspan="headers.length">
                    <v-container v-if="item.fivestartplayers">
                        <v-card max-width="500" class="mx-auto" flat>
                            <v-card-title>5 Starting Players:</v-card-title>
                            <v-card-text>
                                <v-row v-for="(player, index) in item.fivestartplayers" :key="index" class="mx-auto">
                                    {{player}}
                                </v-row>
                            </v-card-text>
                        </v-card>
                    </v-container>
                </td>
            </template>
        </v-data-table>
    </v-container>
</template>
<script>
    import axios from 'axios';
    import { mapGetters } from 'vuex';

    export default {
        data() {
            return {
                filter: [{ text: 'Conference', value: 'conference' }, { text:'Division', value:'division'}],
                filterModel: 'conference',
                search:'',
                loading: false,
                errors: [],
                headers: [
                    { text: 'ID', align: 'start', value: 'id', sortable:false },
                    { text: 'Team Name', value: 'team', sortable: false},
                    { text: 'City', value: 'city', sortable: false },
                    { text: 'Coach', value: 'coach', sortable: false },
                    { text: 'Wins-Losses', value: 'winslosses', sortable: false },
                    { text: 'Conference:Division', value: 'conference', sortable: false},
                    { text: '', value: 'data-table-expand' },
                ],
                expanded: []
            }
        },
        computed: {
            ...mapGetters(['getTeams'])
        },
        methods: {
            fetchTeams() {
                this.loading = true;
                axios.get("/api/Team/teamPlayers")
                    .then(response => {
                        this.$store.commit('setTeams', response.data)
                    })
                    .catch((error) => {
                        if (error.response.status === 422) {
                            this.errors.error.response.data.errors;
                        }

                        if (error.response.status === 500) {
                            this.errors = error.response.data;
                        }
                        this.loading = false;
                    })
                    .finally(() => {
                        this.loading = false;
                    })
            },
            filterTeamLists() {
                if (this.search) {
                    this.loading = true;
                    this.$store.commit('filterTeams', { filter: this.filterModel, value: this.search });
                    this.loading = false;
                }
                else this.fetchTeams();
            },
            sortBy(prop) {
                this.$store.commit('sortTeams', prop);
            }
        },
        created() {
            this.fetchTeams();
        }
    }
</script>
<style>

</style>