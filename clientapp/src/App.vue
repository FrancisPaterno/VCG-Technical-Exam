<template>
  <v-app id="inspire">
    <v-app-bar app clipped-left>
    <v-icon text large class="mx-2">mdi-home-circle</v-icon>
      <v-toolbar-title>Technical Examination</v-toolbar-title>
    </v-app-bar>

    <v-content>
      <v-container class="fill-height" fluid>
        <v-row align="center" justify="center">
          <v-col class="fill-height">
            <router-view></router-view>
          </v-col>
        </v-row>
      </v-container>
    </v-content>

    <v-footer app>
      <span>&copy; {{new Date().getYear()+1900}}</span>
    </v-footer>
  </v-app>
</template>

<script>
export default {
  data: () => ({
    drawer: null
  }),

  created() {
    this.$vuetify.theme.dark = true;
  },
  props: {}
};
</script>