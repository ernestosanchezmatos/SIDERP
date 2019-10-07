<template >
<v-app>
 <v-layout align-right >
    <v-flex>
      <v-toolbar flat color="white">      
        <v-divider class="mx-2" inset vertical></v-divider>
        <v-spacer></v-spacer>
        <v-text-field
          class="text-xs-center"
          v-model="search"
          append-icon="search"
          label="Búsqueda"
          single-line
          hide-details
        ></v-text-field>
        <v-spacer></v-spacer>       
      </v-toolbar>


   
<!--
     <v-data-table :headers="sa" :items="lstaProyectos" :search="search" class="elevation-1"  >
         <template slot="items" slot-scope="props">
              <td class="justify-center layout px-0">
            <v-icon small class="mr-2">edit</v-icon>
          
          </td>   
          <td>{{ props.item.nProyecto }}</td>
          <td>{{ props.item.tDireccion }}</td>
          <td>{{ props.item.nVendedor }}</td>
          <td>{{ props.item.nDistribuidor }}</td>     
          <td>{{ props.item.tEstatusProyecto }}</td>
          <td>{{ props.item.nConstructora }}</td >
           <v-icon
        small
        class="mr-2"
        @click="editItem(item)"
      >
        edit
      </v-icon>
                  
        </template>     
                   
      </v-data-table>     -->
<!--------------------------------------------------------------------------------------------------------------------------->
<v-data-table
    :headers="headers"
    :items="lstaProyectos"  
    :search="search"
    style="width:155%"
    sort-by="nProyecto"
    class="elevation-1"  
    
  >   
                   
    <template v-slot:top >
      <v-toolbar flat color="white">
        <v-toolbar-title>Proyectos</v-toolbar-title>
        <v-divider
          class="mx-4"
          inset
          vertical
        ></v-divider>
        <div class="flex-grow-1"></div>

       <v-dialog v-model="dialog" max-width="500px">
          <template v-slot:activator="{ on }">
            <v-btn color="second" dark class="mb-2" v-on="on">Nuevo</v-btn>
          </template>
         <v-card>
            <v-card-title>
              <span class="headline">{{ formTitle }}</span>
            </v-card-title>

            <v-card-text>   
              <v-container grid-list-md>                  
                  <v-flex>
                    <v-text-field v-model="nProyecto" label="Nombre de Proyecto"></v-text-field>
                  </v-flex>
                   <v-flex  xs12 sm12 md12>
                    <v-combobox
                      v-model="nDistrito"
                      :items="lstaDistritos"
                      label="Distritos"
                    ></v-combobox>
                  </v-flex>     
                  <v-flex xs12 sm12 md12>
                    <v-text-field v-model="numArea" label="Area de la obra en m2"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm12 md12>
                    <v-text-field v-model="tTipoInversion" label="Tipo de inversion"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm12 md12>
                    <v-text-field v-model="tEstatusProyecto" label="Estatus del proyecto"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm12 md12>
                    <v-text-field v-model="tDireccion" label="Direccion"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm12 md12>
                    <v-text-field v-model="numLicencia" label="Numero de licencia"></v-text-field>
                  </v-flex>
                    <v-flex xs12 sm12 md12 >
                  <v-text-field type="date" v-model="dInicioSuministro" label="Fecha de Registro de inicio de suministro"></v-text-field>
                  </v-flex>
                    <v-flex xs12 sm12 md12>
                    <v-text-field v-model="numTiempoSuministro" label="Duracion del periodo de suministro"></v-text-field>
                  </v-flex>
                    <v-flex xs12 sm12 md12>
                    <v-text-field type="date" v-model="dFechaFinalObra" label="Fecha final de la obra"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm12 md12>
                    <v-text-field v-model="tMarcaProveedorActual" label="Proveedor Actual"></v-text-field>
                  </v-flex>    
                        <v-flex xs12 sm12 md12>
                    <v-text-field v-model="mPrecioSolicitado" label="Precio Solicitado"></v-text-field>
                  </v-flex>
                       <v-flex xs12 sm12 md12>
                    <v-text-field v-model="nConstructora" label="Nombre de la constructora"></v-text-field>
                  </v-flex> 
                      
                    <v-flex xs12 sm12 md12>
                    <v-text-field v-model="tRucConstructora" label="RUC de la constructora"></v-text-field>
                  </v-flex>                  
                    <v-flex xs12 sm12 md12>
                    <v-text-field v-model="tActividadEconomicaEmpresa" label="Actividad económica"></v-text-field>
                  </v-flex>    
             

              </v-container>
            </v-card-text>

            <v-card-actions>
              <div class="flex-grow-1"></div>
              <v-btn color="blue darken-1" text @click="close">Cancel</v-btn>
              <v-btn color="blue darken-1" text @click="save">Save</v-btn>
            </v-card-actions>
          </v-card>
        
        </v-dialog>  

 <!-- DETALLESSS ------------------------------------------------------------------------------------->

      </v-toolbar>
    </template>
    <template v-slot:item.action="{ item }">
      <v-dialog v-model="dialog_2" max-width="500px">
          <template v-slot:activator="{ on }">
            <v-btn color="second" dark  v-on="on">Detalles</v-btn>
          </template>    
                <v-card>
            <v-card-title>
              <span class="headline">Detalle de Proyecto</span>
            </v-card-title>

            <v-card-text>
          <v-simple-table dense>
    <template v-slot:default>
      <thead>
        <tr>
          <th class="text-left">Atributo</th>
          <th class="text-left">Valor</th>
        </tr>
      </thead>
      <tbody>
        <!--<tr v-for="item in lstaProyectos" :key="item.name">
          <td>{{item.nProyecto}}</td>
          <td>.......</td> -->
    <tr :item=lstaProyectos>
          <td>Codigo del Proyecto</td>
          <td>{{item.proyectoId}}</td>         
      </tr>

       <tr :item=lstaProyectos>
          <td>Nombre del Proyecto</td>
          <td>{{item.nProyecto}}</td>         
      </tr>
      <tr :item=lstaProyectos>
          <td>Distrito</td>
          <td>{{item.nDistrito}}</td>         
      </tr>

       <tr :item=lstaProyectos>
          <td>Area en m2</td>
          <td>{{item.numArea}}</td>         
      </tr>

      
       <tr :item=lstaProyectos >
          <td>Tipo de inversion</td>
          <td>{{item.tTipoInversion}}</td>         
      </tr>

       <tr :item=lstaProyectos >
          <td>Estatus del proyecto</td>
          <td>{{item.tEstatusProyecto}}</td>         
      </tr>
       <tr :item=lstaProyectos >
          <td>Direccion</td>
          <td>{{item.tDireccion}}</td>         
      </tr>
       <tr :item=lstaProyectos >
          <td>Numero de licencia</td>
          <td>{{item.numLicencia}}</td>         
      </tr>
       <tr :item=lstaProyectos >
          <td>Area en m2</td>
          <td>{{item.dInicioSuministro}}</td>         
      </tr>
 
   <tr :item=lstaProyectos >
          <td>Fecha de inicio de suministro</td>
          <td>{{item.numTiempoSuministro}}</td>         
      </tr>
        <tr :item=lstaProyectos >
          <td>Fecha final de la obra</td>
          <td>{{item.dFechaFinalObra}}</td>         
      </tr>
    <tr :item=lstaProyectos >
          <td>Marca de proveedor actual</td>
          <td>{{item.tMarcaProveedorActual}}</td>         
      </tr>      
         <tr :item=lstaProyectos >
          <td>Tipo de solicitud</td>
          <td>{{item.tTipoSolicitud}}</td>         
      </tr>      
       
         <tr :item=lstaProyectos >
          <td>Precio solicitado</td>
          <td>{{item.mPrecioSolicitado}}</td>         
      </tr>   
        <tr :item=lstaProyectos >
          <td>Constructora</td>
          <td>{{item.nConstructora}}</td>         
      </tr>   
        <tr :item=lstaProyectos >
          <td>RUC de la constructora</td>
          <td>{{item.tRucConstructora}}</td>         
      </tr>     
          <tr :item=lstaProyectos >
          <td>Actividad economica de la empresa</td>
          <td>{{item.tActividadEconomicaEmpresa}}</td>         
      </tr>            
      
      </tbody>
    </template>
  </v-simple-table>
            </v-card-text>
                </v-card>
        
        </v-dialog>        
    </template>  
  </v-data-table>     

    </v-flex>
 </v-layout>

</v-app>
</template>

<script>
import axios from "axios";
import router from "vue-router"
export default {
  data() {
    return {           
         dialog: false,
         dialog_2: false,
      headers: [
        {
          text: 'Proyecto',
          align: 'center',
          sortable: false,
          value: 'nProyecto',
        },
        { text: 'Direccion', value: 'tDireccion' },
        { text: 'Vendedor ', value: 'nVendedor' },
        { text: 'Distribuidor ', value: 'nDistribuidor' },
        { text: 'Estado ', value: 'tEstatusProyecto' },
         { text: 'Constructora ', value: 'nConstructora' },
        { text: 'Actions', value: 'action', sortable: false },
      ],     
      editedIndex: -1,      
    idProyecto:0,
      search: "", 
            //TODO:Model
      lstaProyectos:[],
      lstaDistritos:[],
      DetalleProyecto:[],
/*--------------------ATRIBUTOS DE PROYECTO------------------------------*/
    proyectoId:'',
      nProyecto:'',
     distribuidorId :'',
    nDistribuidor:'', 
      distritoId :'',
nDistrito:'',
 vendedorId:'',
  nVendedor:'',
   numArea:'',
    tTipoInversion:'',
     tEstatusProyecto:'',
      tDireccion:'',
       numLicencia:'',
        dInicioSuministro:'',
        numTiempoSuministro:'',
          dFechaFinalObra:'',
           tMarcaProveedorActual:'',
            tTipoSolicitud:'',
             mPrecioSolicitado:'',
              nConstructora:'',
               tRucConstructora:'',
                tActividadEconomicaEmpresa:'',
      //para la vista detalleEquipo



    };
  }, 

  computed: {
      formTitle () {
        return this.editedIndex === -1 ? 'Nuevo Proyecto' : 'Edit Item'
      },
    },

    watch: {
      dialog (val) {
        val || this.close()
      },
    },

    created () {
      this.listar(),
      this.listarDistritos()  
    },
  methods: { 
    DetalleProyecto(id) {
      let me = this;    
      axios
        .get("api/proyecto/"+id)
        .then(function(response) {
          console.log(response);
          me.DetalleProyecto = response.data;
        })
        .catch(function(error) {
          console.log(error);
        });
    },
       editItem (item) {
        this.editedIndex = this.lstaProyectos.indexOf(item)
        this.editedItem = Object.assign({}, item)
        this.dialog = true
      },

      deleteItem (item) {
        const index = this.desserts.indexOf(item)
        confirm('Are you sure you want to delete this item?') && this.desserts.splice(index, 1)
      },



      close () {
        this.dialog = false
        setTimeout(() => {
          this.editedItem = Object.assign({}, this.defaultItem)
          this.editedIndex = -1
        }, 300)
      },

      save () {
        if (this.editedIndex > -1) {
          Object.assign(this.desserts[this.editedIndex], this.editedItem)
        } else {
          this.desserts.push(this.editedItem)
        }
        this.close()
      },
    listar() {
      let me = this;
      axios
        .get("api/proyecto")
        .then(function(response) {
          console.log(response);
          me.lstaProyectos = response.data;
        })
        .catch(function(error) {
          console.log(error);
        });
    }   ,
      listarDistritos() {
      let me = this;
      axios
        .get("api/distrito/names")
        .then(function(response) {
          console.log(response);
          me.lstaDistritos = response.data;
        })
        .catch(function(error) {
          console.log(error);
        });
    }   ,
  },
  }  
</script>


   /*guardar() {
      if (this.editedIndex > -1) {
        //Código para editar

        let me = this;

        axios 
          .put("api/equipo", {
            cequipo: me.cequipo,
            tdescripcion: me.tdescripcion,
            ndistrito: me.ndistrito,
            nequipo: me.nequipo,
            numParticipantes: me.numParticipantes,
            dfechaJuego: me.dfechaJuego
          })
          .then(function(response) {
            me.close();
            me.setListaEquiposRecomendados();
            me.limpiar();
          })
          .catch(function(error) {
            console.log(error);
          });
      } else {

        //Código para guardar
        let me = this;

        var dFechaRegistro = new Date();
        var dia = dFechaRegistro.getDate();
        var mes = dFechaRegistro.getMonth();
        var anio = dFechaRegistro.getFullYear();
        var hora = dFechaRegistro.getHours();
        var minutos = dFechaRegistro.getMinutes();
        var segundos = dFechaRegistro.getSeconds();

        var f = dia+'-'+mes+'-'+anio+' '+hora+':'+minutos+':'+segundos;

        axios
          .post("api/equipo", {
            Tdescripcion: me.tdescripcion,
            Nequipo: me.nequipo,
            ndistrito: me.ndistrito,
            numParticipantes: me.numParticipantes,
            DfechaJuego: me.dfechaJuego,
            DfechaRegistro: f,
            idJugador: Number(localStorage.getItem('usuario')),
          })
          .then(function(response) {
            me.close();
            me.setListaEquiposRecomendados();
            me.limpiar();
            me.$router.push('/equipo/misequipos');
          })
          .catch(function(error) {
            console.log(error);
          });
      }
    },
    setearParticipantes(){
         let me = this;
      axios
      
        .get("/api/equipo/equipodetalle/"+me.idEquipo)
        .then(function(response) {
          console.log(response);
          me.lstaParticipantes = response.data;
        })
        .catch(function(error) {
          console.log(error);
        });
    },
     setearLstaAlquileresDelEquipo(){
         let me = this;
      axios
      
        .get("/api/alquiler/alquilerdetalle/"+me.idEquipo)
        .then(function(response) {
          console.log(response);
          me.lstaAlquilerDelEquipo = response.data;
        })
        .catch(function(error) {
          console.log(error);
        });
    },
    mostrarDetallesEquipo(data =[]){
     this.verDetalleEquipo=1;
     this.idEquipo=data["cequipo"];
     localStorage.setItem("equipo", this.idEquipo);
     this.setearParticipantes();
     this.setearLstaAlquileresDelEquipo();
    },
    ocultarDetallesEquipo(){
      this.verDetalleEquipo=0;
      localStorage.removeItem("equipo");
    },
    unirJugador(){
      let me = this;

      var dFechaRegistro = new Date();
      var dia = dFechaRegistro.getDate();
      var mes = dFechaRegistro.getMonth();
      var anio = dFechaRegistro.getFullYear();
      var hora = dFechaRegistro.getHours();
      var minutos = dFechaRegistro.getMinutes();
      var segundos = dFechaRegistro.getSeconds();

      var f = dia+'-'+mes+'-'+anio+' '+hora+':'+minutos+':'+segundos;

      axios
        .post("api/participante", {
          cjugador: Number(localStorage.getItem('usuario')),
          cequipo: Number(localStorage.getItem("equipo")),
          fesadministrador: false,
          dfechaunion: f,
        })
        .then(function(response) {
          me.close();
          me.setListaEquiposRecomendados();
          me.limpiar();
          localStorage.removeItem("equipo"),
          me.$router.push('/equipo/misequipos');
          alert("Usted se unió exitosamente al grupo :)");
        })
        .catch(function(error) {
            console.log(error);
        });
    }
  }
};*/
