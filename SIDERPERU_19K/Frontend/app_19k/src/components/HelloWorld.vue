<template>   
   <v-container style="height:700px">

    <v-layout justify-center
      text-xs-center
      wrap
      >
      <v-flex xs7  >

     <v-layout>
        <v-toolbar flat color="white">    
          <h1>¡Bienvenido a SIDERPERU!</h1>    
        </v-toolbar>
     </v-layout>
     
        <v-text-field v-model="loginUsuario" label="Usuario"></v-text-field>

          <v-text-field v-model="contraseña"
            :append-icon="show2 ? 'visibility' : 'visibility_off'"
            :type="show2 ? 'text' : 'password'"
            name="input-10-2"
            label="Contraseña"
            value="wqfasds"
            class="input-group--focused"
            @click:append="show2 = !show2"
          ></v-text-field>
      
          <v-btn  @click="Loggin()" slot="activator" color="red" dark class="mb-2" >Login</v-btn>    
          <p></p>
          <v-btn   @click="Register()" slot="activator" color="blue" dark class="mb-2">Register</v-btn>
      </v-flex>

    </v-layout>
   </v-container>
 
     
</template>


<script>

import axios from "axios";
import router from "vue-router"
export default {
  name: 'App',
  data () {
    return {
        show2: false,
        password: 'Password',
        lstaUsuarios:[],
        loginUsuario:'',
        contraseña:'',
        idUsuario:'',
        ruta:'',
        drawer: true,
     }
  },
  
  created(){
   localStorage.removeItem("usuario");
   this.setLstaUsuarios();
  },
  methods: {
  setLstaUsuarios(){
       let me = this; 

      axios.get("api/usuario")
       .then(function(response) {
         me.lstaUsuarios = response.data;
       })
       .catch(function(error) {
         console.log(error);
       });
  },
  LoginCorrecto(){      
            var correcto = 0;
            for (var i = 0; i < this.lstaUsuarios.length; i++) {
               if (this.lstaUsuarios[i].tUserName == this.loginUsuario && this.lstaUsuarios[i].tPassword == this.contraseña) { 
                    correcto = 1;
                    this.idUsuario=this.lstaUsuarios[i].usuarioId;
               }
            }
            return correcto;       
  },
  Register(){
    this.$router.push('/register');
  },
  Loggin(){ 

      if (this.LoginCorrecto()==1){
        localStorage.setItem("usuario",this.idUsuario);        
        this.$router.push('/proyectos');
      }
      else{ 
             
        alert("Usuario o Contraseña incorrecta");
       this.loginUsuario='';
        this.contraseña='';
      }   
  }
  },
  

}
</script>

