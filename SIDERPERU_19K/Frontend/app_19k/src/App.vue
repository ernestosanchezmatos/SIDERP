<template>
  <v-app id="app">      
     
    <v-toolbar
      color="dark"
      dark    
      fixed 
    ><v-app-bar-nav-icon @click.stop="drawer = !drawer"></v-app-bar-nav-icon>
     <v-toolbar-title style="width: 200px" class="ml-0 pl-3">
        <span class="hidden-sm-and-down">SIDERPERU</span>
      </v-toolbar-title>
      <v-spacer></v-spacer>             
    </v-toolbar>
    <v-content>
      <v-container fluid fill-height>
        <v-slide-y-transition mode="out-in">
          <router-view/>
        </v-slide-y-transition>
      </v-container>
    </v-content>


      <v-navigation-drawer
        v-model="drawer"
        absolute
        bottom
        temporary
      >
        <v-list>
          <v-list-item @click="irAProyectos()">
            
              <v-list-item-icon>
                <v-icon>folder_open</v-icon>
              </v-list-item-icon>
              <v-list-item-title>Proyectos</v-list-item-title>
          </v-list-item>
          
          <v-list-item @click="logOut()">
            
              <v-list-item-icon>
                <v-icon>exit_to_app</v-icon>
              </v-list-item-icon>
              <v-list-item-title>Log Out</v-list-item-title>
          </v-list-item>
        </v-list>
      </v-navigation-drawer>


      <v-layout justify-center>
        <v-flex text-xs-center>
          <v-card flat tile color="primary" class="white--text" height="50px" width="100%">
            <v-card-text class="white--text pt-0">
             SIDERPERU &copy;2019
            </v-card-text>
          </v-card>
        </v-flex>
      </v-layout>

  </v-app>
  
</template>


<script>
export default {
  name: 'App',
  data () {
    return {
      drawer: false,
     }
  },
  methods: {
    irAProyectos(){
      this.$router.push('/proyectos');
    },
    logOut(){
      localStorage.removeItem("usuario");
      this.$router.push('/');
    }
  }
}
</script>