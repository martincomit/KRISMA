using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using UNCDeporte.Interfaz.Admin;
using UNCDeporte.Admin;
using Entidades;
using MapeoDeDatos;
using UNCDeporte.TorneosYEventos;
using UNCDeporte.Torneos;
using UNCDeporte.ConsultarEliminar;
using UNCDeporte.Informes;
using UNCDeporte.Altas;

namespace UNCDeporte
{
    public partial class MenuAdmin : Form
    {
        String sql = "";
        String sql2 = "";
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void logutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void verPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sql = " SELECT Usuarios.id_usuario, Usuarios.usuario, Usuarios.pass, Roles.rol FROM Roles INNER JOIN Usuarios ON Roles.id_rol= Usuarios.id_rol";                
            //DataSet ds = new DataSet();
            //SqlConnection cx = new SqlConnection();
            //cx.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bd_proyecto;Data Source=AMSAVS\\SQLEXPRESS";
            //SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            //da.Fill(ds, "usuarios");
            //gv2.DataSource = ds;
            //gv2.DataMember = "usuarios";
        }

        private void nuevaPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltadeUsuarios f3 = new AltadeUsuarios();
            f3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            //string sql = "";
            //sql = " SELECT  Permisos.id_permiso, Permisos.nombre, Permisos.descripcion FROM         PerfilesXUsuario INNER JOIN      Usuarios ON PerfilesXUsuario.id_usuario = Usuarios.id_usuario INNER JOIN      Perfiles ON PerfilesXUsuario.id_perfil = Perfiles.id_perfil INNER JOIN  Permisos INNER JOIN   PermisosXPerfil ON Permisos.id_permiso = PermisosXPerfil.id_permiso ON Perfiles.id_perfil = PermisosXPerfil.id_perfil where Usuarios.id_usuario=" + global.id_usuario;

            //SqlConnection cx = new SqlConnection();


            //DataSet ds = new DataSet();



            //StringConexion c = new StringConexion();

            //cx.ConnectionString = c.getCadena();

            //SqlDataAdapter da = new SqlDataAdapter(sql, cx);

            //da.Fill(ds, "usuarios");

            //int cantidad_filas = ds.Tables[0].Rows.Count;
            //int id_permiso;
            //for (int i = 0; i < cantidad_filas; i++)
            //{
            //    id_permiso = int.Parse(ds.Tables[0].Rows[i][0].ToString());
            //    switch (id_permiso)
            //    {
            //        case 1:
            //            registrarProfesorToolStripMenuItem1.Visible = true;
            //            break;
            //        case 2:
            //            consultarProfesorToolStripMenuItem.Visible = true;
            //            break;
            //        case 3:
            //            registrarUsuariosToolStripMenuItem.Visible = true;
            //            break;
            //        case 4:
            //            consultarUsuariosToolStripMenuItem.Visible = true;
            //            break;
            //        case 5:
            //            nuevoPerfilToolStripMenuItem.Visible = true;
            //            break;
            //        case 6:
            //            modificarPerfilToolStripMenuItem.Visible = true;
            //            break;
            //        case 7:
            //            eliminarPerfilToolStripMenuItem.Visible = true;
            //            break;
            //        case 8:
            //            consultarPerfilesToolStripMenuItem.Visible = true;
            //            break;
            //    }

            //}

            //sacar si se usa el login
            // menu administracion general
            registrarProfesorToolStripMenuItem1.Visible = true;
            consultarProfesorToolStripMenuItem.Visible = true;
            registrarUsuariosToolStripMenuItem.Visible = true;
            consultarUsuariosToolStripMenuItem.Visible = true;
            nuevoPerfilToolStripMenuItem.Visible = true;
            modificarPerfilToolStripMenuItem.Visible = true;
            eliminarPerfilToolStripMenuItem.Visible = true;
            consultarPerfilesToolStripMenuItem.Visible = true;
            //menu admin espacios
            registrarLugarDePracticaToolStripMenuItem.Visible = true;
            modificarLugarDePracticaToolStripMenuItem.Visible = true;
            eliminarLugarDePracticaToolStripMenuItem.Visible = true;
            consultarLugaresDePracticaToolStripMenuItem.Visible = true;
            registrarCanchasToolStripMenuItem.Visible = true;
            eliminarCanchasToolStripMenuItem.Visible = true;
            consultarCanchasToolStripMenuItem.Visible = true;
            registrarTipoSectorToolStripMenuItem.Visible = true;
            eliminarTipoSectorToolStripMenuItem.Visible = true;
            consultarTipoSectoresToolStripMenuItem.Visible = true;
            nuevaLocalidadToolStripMenuItem1.Visible = true;
            eliminarLocalidadToolStripMenuItem1.Visible = true;
            consultarLocalidadToolStripMenuItem1.Visible = true;
            nuevoBarrioToolStripMenuItem1.Visible = true;
            eliminarBarrioToolStripMenuItem1.Visible = true;
            consultarBarriosToolStripMenuItem1.Visible = true;

            //admin deportistas

            nuevoDeportistaToolStripMenuItem2.Visible = true;
            //eliminarDeportistaToolStripMenuItem1.Visible = true;
            consultarDeportistasToolStripMenuItem2.Visible = true;
            registrarHistorialMedicoToolStripMenuItem1.Visible = true;
            modificiarHistorialMedicoToolStripMenuItem.Visible = true;
            eliminarHistorialMedicoToolStripMenuItem1.Visible = true;
            consultarHistorialMedicoToolStripMenuItem1.Visible = true;

            //menu inscripciones
        
            consultarInscripcionesToolStripMenuItem.Visible = true;

            //menu deportes 
            nuevoDeporteToolStripMenuItem.Visible = true;
         
            consultarDeportesToolStripMenuItem1.Visible = true;
            registrarPlanificacionDeActividadesToolStripMenuItem.Visible = true;
          
            eliminarPlanificacionDeActividadesToolStripMenuItem.Visible = true;
           

            //menu reservas

            nuevaReservaToolStripMenuItem.Visible = true;
         
            confirmarReservaToolStripMenuItem.Visible = true;
            cancelarReservaToolStripMenuItem.Visible = true;
            consultarReservaToolStripMenuItem.Visible = true;

        }



        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            //if(cmbFiltro.Text=="Deportistas")
            //{
            //    sql = " SELECT Usuarios.id_usuario, Usuarios.usuario, Usuarios.pass, Roles.rol FROM Roles INNER JOIN Usuarios ON Roles.id_rol= Usuarios.id_rol where Usuarios.id_rol = 2";
            //    conexion c = new conexion();
            //    DataSet ds = new DataSet();
            //    SqlConnection cx = new SqlConnection();
            //    cx.ConnectionString = c.getCadena();
            //    SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            //    da.Fill(ds, "Usuarios");
            //    gv2.DataSource = ds;
            //    gv2.DataMember = "Usuarios";
            //}
            //if (cmbFiltro.Text == "Profesores")
            //{
            //    sql = " SELECT Usuarios.id_usuario, Usuarios.usuario, Usuarios.pass, Roles.rol FROM Roles INNER JOIN Usuarios ON Roles.id_rol= Usuarios.id_rol where Usuarios.id_rol = 3";
            //    conexion c = new conexion();
            //    DataSet ds = new DataSet();
            //    SqlConnection cx = new SqlConnection();
            //    cx.ConnectionString = c.getCadena();
            //    SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            //    da.Fill(ds, "Usuarios");
            //    gv2.DataSource = ds;
            //    gv2.DataMember = "Usuarios";
            //}
            //if (cmbFiltro.Text == "Admin")
            //{
            //    sql = " SELECT Usuarios.id_usuario, Usuarios.usuario, Usuarios.pass, Roles.rol FROM Roles INNER JOIN Usuarios ON Roles.id_rol= Usuarios.id_rol where Usuarios.id_rol = 1";
            //    conexion c = new conexion();
            //    DataSet ds = new DataSet();
            //    SqlConnection cx = new SqlConnection();
            //    cx.ConnectionString = c.getCadena();
            //    SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            //    da.Fill(ds, "Usuarios");
            //    gv2.DataSource = ds;
            //    gv2.DataMember = "Usuarios";
            //}
            //if (cmbFiltro.Text == "Todos")
            //{
            //    sql = " SELECT Usuarios.id_usuario, Usuarios.usuario, Usuarios.pass, Roles.rol FROM Roles INNER JOIN Usuarios ON Roles.id_rol= Usuarios.id_rol";
            //    conexion c = new conexion();
            //    DataSet ds = new DataSet();
            //    SqlConnection cx = new SqlConnection();
            //    cx.ConnectionString = c.getCadena();
            //    SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            //    da.Fill(ds, "Usuarios");
            //    gv2.DataSource = ds;
            //    gv2.DataMember = "Usuarios";
            //}
            //if (cmbFiltro.Text == "Ninguno")
            //{
            //    sql = " SELECT Usuarios.id_usuario, Usuarios.usuario, Usuarios.pass, Roles.rol FROM Roles INNER JOIN Usuarios ON Roles.id_rol= Usuarios.id_rol where Usuarios.id_rol = 0";
            //    conexion c = new conexion();
            //    DataSet ds = new DataSet();
            //    SqlConnection cx = new SqlConnection();
            //    cx.ConnectionString = c.getCadena();
            //    SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            //    da.Fill(ds, "Usuarios");
            //    gv2.DataSource = ds;
            //    gv2.DataMember = "Usuarios";
            //}

        }

        private void registrarRelacionDePersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panelConsulta.Visible = true;
        }

        private void altaDeportistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaDeportista f3 = new AltaDeportista();
            f3.Show();
        }

        private void consultarDeportistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panelConsulta.Visible = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnFiltrarDeportista_Click(object sender, EventArgs e)
        {
            //if (cmbFiltro.Text == "Todos")
            //{
            //    sql = " SELECT Profesores.nombre, Profesores.nombre2, Profesores.apellido, Profesores.fec_nac, Profesores.email, Deportes.nombre AS NombreDeporte,Localidades.nombre AS NombreLocalidad FROM Deportes INNER JOIN Profesores ON Deportes.id_deporte = Profesores.id_deporte INNER JOIN Localidades ON Profesores.id_localidad = Localidades.id_localidad";
            //    conexion c = new conexion();
            //    DataSet ds = new DataSet();
            //    SqlConnection cx = new SqlConnection();
            //    cx.ConnectionString = c.getCadena();
            //    SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            //    da.Fill(ds, "deportistas");
            //    gv2.DataSource = ds;
            //    gv2.DataMember = "deportistas";
            //}





        }

        private void panelConsulta_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registrarProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPersonal f3 = new ConsultarPersonal();
            f3.Show();
        }

        private void panelConsulta2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registrarNuevoDeporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarDeportes f3 = new RegistrarDeportes();
            f3.Show();
        }

        private void consultarDeportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ConsultaDeportes f3 = new ConsultaDeportes();
            //f3.Show();
        }

        private void registrarProfesorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AltaPersonal f3 = new AltaPersonal();
            f3.Show();

        }

        private void consultarProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPersonal f3 = new ConsultarPersonal();
            f3.Show();
        }

        private void registrarDeportistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaDeportista f3 = new AltaDeportista();
            f3.Show();
        }

        private void registrarNuevoDeporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void registrarLocalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //RegistrarLocalidad f3 = new RegistrarLocalidad();
            //f3.Show();
        }

        private void consultarDeportistasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarPersonal f3 = new ConsultarPersonal();
            f3.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoDeporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarDeportes f3 = new RegistrarDeportes();
            f3.Show();
        }

        private void nuevaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //RegistrarCategoria f3 = new RegistrarCategoria();
            //f3.Show();
        }

        private void consultarDeportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarDeportes f3 = new ConsultarDeportes();
            f3.Show();
        }

        private void registrarDeportistaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void consultarDeportistasToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            //SeleccionarDeportistas form = new SeleccionarDeportistas();
            //form.Show();
        }

        private void nuevoDeportistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaDeportista f3 = new AltaDeportista();
            f3.Show();
        }

        private void nuevaLocalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaLocalidad f3 = new NuevaLocalidad();
            f3.Show();
        }

        private void registrarUsuarioTESTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarUsuariosTESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarUsuarios f3 = new ConsultarUsuarios();
            f3.Show();
        }

        private void consultarLocalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarLocalidades form = new ConsultarLocalidades();
            form.Show();
        }

        private void registrarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevaReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //RegistrarReserva form = new RegistrarReserva();
            //form.Show();
        }

        private void consultarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarReservas form = new ConsultarReservas();
            form.Show();
        }

        private void registrarPlanificacionDeActividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramaActividades form = new ProgramaActividades();
            form.Show();
        }

        private void nuevoDeportistaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RealizarInscripcion form = new RealizarInscripcion();
            form.Show();
        }

        private void registrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltadeUsuarios form = new AltadeUsuarios();
            form.Show();
        }

        private void consultarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarUsuarios form = new ConsultarUsuarios();
            form.Show();
        }

        private void modificarInscripcionDeDeportistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarInscripcion form = new ModificarInscripcion();
            form.Show();
        }

        private void eliminarUnaInscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarInscripcion form = new EliminarInscripcion();
            form.Show();
        }

        private void consultarInscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarSolicitudes form = new ConsultarSolicitudes();
            form.Show();
        }

        private void eliminarLocalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarLocalidades form = new EliminarLocalidades();
            form.Show();
        }

        private void nuevoBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarBarrio form = new RegistrarBarrio();
            form.Show();
        }

        private void consultarBarriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarBarrio form = new ConsultarBarrio();
            form.Show();
        }

        private void eliminarBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarBarrio form = new EliminarBarrio();
            form.Show();
        }

        private void eliminarDeportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarDeporte form = new EliminarDeporte();
            form.Show();
        }

        private void nuevaLocalidadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NuevaLocalidad form = new NuevaLocalidad();
            form.Show();
        }

        private void eliminarLocalidadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EliminarLocalidades form = new EliminarLocalidades();
            form.Show();
        }

        private void consultarLocalidadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarLocalidades form = new ConsultarLocalidades();
            form.Show();
        }

        private void nuevoBarrioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistrarBarrio form = new RegistrarBarrio();
            form.Show();
        }

        private void eliminarBarrioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EliminarBarrio form = new EliminarBarrio();
            form.Show();
        }

        private void consultarBarriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarBarrio form = new ConsultarBarrio();
            form.Show();
        }

        private void nuevoPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoPerfil form = new NuevoPerfil();
            form.Show();
        }

        private void consultarPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPerfiles form = new ConsultarPerfiles();
            form.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca_de.getInstancia().Show(); //acceder a mostrar el form a travez de getinstancia, ya que nose puede crear normalmente porque es privado
            Acerca_de.getInstancia().BringToFront(); // traer al frente esta instancia unica creada, en caso de hacer otro click en acercade solo traera al frente esta y no creara otra instancia de form.
        }

        private void modificarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarPerfil form = new ModificarPerfil();
            form.Show();
        }

        private void eliminarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarPerfiles form = new EliminarPerfiles();
            form.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "";
            sql = " SELECT  Permisos.id_permiso, Permisos.nombre, Permisos.descripcion FROM         PerfilesXUsuario INNER JOIN      Usuarios ON PerfilesXUsuario.id_usuario = Usuarios.id_usuario INNER JOIN      Perfiles ON PerfilesXUsuario.id_perfil = Perfiles.id_perfil INNER JOIN  Permisos INNER JOIN   PermisosXPerfil ON Permisos.id_permiso = PermisosXPerfil.id_permiso ON Perfiles.id_perfil = PermisosXPerfil.id_perfil where Usuarios.id_usuario=" + global.id_usuario;
            // sql = "select * from Usuarios";
            SqlConnection cx = new SqlConnection();


            DataSet ds = new DataSet();



            StringConexion c = new StringConexion();

            cx.ConnectionString = c.getCadena();

            SqlDataAdapter da = new SqlDataAdapter(sql, cx);

            da.Fill(ds, "usuarios");

            int cantidad_filas = ds.Tables[0].Rows.Count;
            int id_permiso;
            for (int i = 0; i < cantidad_filas; i++)
            {
                id_permiso = int.Parse(ds.Tables[0].Rows[i][0].ToString());
                switch (id_permiso)
                {
                    case 1:
                        registrarProfesorToolStripMenuItem1.Visible = true;
                        break;
                }

            }

            //MessageBox.Show(registrarProfesorToolStripMenuItem1.ToString());
            //1 registrar profesor(personal)
            //2 consultar profesor(personal)
            //ToolStripMenuItem[] menu = new ToolStripMenuItem[50];
            //menu[1] = registrarProfesorToolStripMenuItem1;
            //menu[2] = consultarProfesorToolStripMenuItem;




        }

        private void nuevoDeportistaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AltaDeportista form = new AltaDeportista();
            form.Show();
        }

        private void registrarLugarDePracticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarLugarPractica form = new RegistrarLugarPractica();
            form.Show();
        }


        private void modificarLugarDePracticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarLugarDePractica form = new ModificarLugarDePractica();
            form.Show();
        }


        private void consultarLugaresDePracticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarLugarPractica form = new ConsultarLugarPractica();
            form.Show();
        }

        private void eliminarLugarDePracticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarLugarDePractica form = new EliminarLugarDePractica();
            form.Show();
        }

        private void consultarSolicitudesDeLaWebToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarSolicitudesWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarSolicitudes form = new ConsultarSolicitudes();
            form.Show();
        }

        private void consultarSolicitudesWebToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarSolicitudes form = new ConsultarSolicitudes();
            form.Show();
        }

        private void modificarPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarPersonal form = new ModificarPersonal();
            form.Show();
        }

        private void eliminarPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarPersonal form = new EliminarPersonal();
            form.Show();
        }

        private void webToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarSolicitudes form = new ConsultarSolicitudes();
            form.Show();
        }

        private void webToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConfirmarEstudios form = new ConfirmarEstudios();
            form.Show();
        }

        private void consultarDeportistasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultarEliminarDeportistas form = new ConsultarEliminarDeportistas();
            form.Show();
        }

        private void confirmarInscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmarEstudios form = new ConfirmarEstudios();
            form.Show();
        }

        private void consultarAprobadosDesaprobadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InscribirDeportistaConEstudiosAprobados form = new InscribirDeportistaConEstudiosAprobados();
            form.Show();
        }

        private void deportesMasSolicitadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformeDeportesMasSolicitados form = new InformeDeportesMasSolicitados();
            form.Show();
        }

        private void inscribirAMasDeportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void consultarInscripcionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarInscripciones form = new ConsultarInscripciones();
            form.Show();
        }

        private void registrarNuevoTorneoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarNuevoTorneo form = new RegistrarNuevoTorneo();
            form.Show();
        }

        private void registrarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarEvento form = new RegistrarEvento();
            form.Show();
        }

        private void modificarTorneoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarTorneo form = new ModificarTorneo();
            form.Show();
        }

        private void consultarEliminarTonreoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaryEliminarTorneos form = new ConsultaryEliminarTorneos();
            form.Show();
        }

        private void generarFixtureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarFixture form = new GenerarFixture();
            form.Show();

        }

        private void modificarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarEvento form = new ModificarEvento();
            form.Show();
        }

        private void consultarEliminarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarEliminarEvento form = new ConsultarEliminarEvento();
            form.Show();
        }

        private void reservaDeCanchasParaTorneoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservaTorneo form = new ReservaTorneo(1);
            form.Show();
        }

        private void registrarPersonalToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Registrar_Usuario form = new Registrar_Usuario();
            form.Show();
        }

        private void generarRankingDeDeportistasFederadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarRanking form = new ConsultarRanking();
            form.Show();
        }

        private void asignarDeportesAProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarDeportesAProfesor form = new AsignarDeportesAProfesor();
            form.Show();
        }

        private void verMensajesDelCETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MensajesTorneo form = new MensajesTorneo();
            form.Show();
        }

        private void consultarEliminarProfesorPorDeporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarProfesoresPorDeportes form = new ConsultarProfesoresPorDeportes();
            form.Show();
        }

        private void preinscripcionesResueltasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformePreeinscripcionesResueltas form = new InformePreeinscripcionesResueltas();
            form.Show();
        }

        private void registrarCanchasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarSector form = new RegistrarSector();
            form.Show();
        }

        private void agregarDeporteADeportistaInscriptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarDeporteADeportistaInscripto form = new AgregarDeporteADeportistaInscripto();
            form.Show();
        }

        private void registrarTipoSectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarTipoSector form = new RegistrarTipoSector();
            form.Show();
        }

        private void eliminarTipoSectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarTipoSector form = new EliminarTipoSector();
            form.Show();
        }

        private void consultarTipoSectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarTipoSector form = new ConsultarTipoSector();
            form.Show();
        }



        //private void btnFiltrar_Click(object sender, EventArgs e)
        //{
        //    if(cmbSexo.Text=="Todos")
        //    {
        //    sql = "SELECT p.*, f.link_face, f.url_perfil, DATEDIFF(yy, GETDATE(), fec_nac) * - 1 AS edad FROM Personas p, Facebooks f where p.id_face = f.id_face";

        //    DataSet ds = new DataSet();
        //    SqlConnection cx = new SqlConnection();
        //    cx.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=vadb;Data Source=MARTIN-PC\\SQLEXPRESS";
        //    SqlDataAdapter da = new SqlDataAdapter(sql, cx);
        //    da.Fill(ds, "personas");
        //    gv1.DataSource = ds;
        //    gv1.DataMember = "personas";
        //    }
        //    if (cmbSexo.Text == "Mujeres")
        //    {
        //        sql = "SELECT p.*, f.link_face, f.url_perfil, DATEDIFF(yy, GETDATE(), fec_nac) * - 1 AS edad FROM Personas p, Facebooks f where p.id_face = f.id_face and p.sexo='f'";

        //        DataSet ds = new DataSet();
        //        SqlConnection cx = new SqlConnection();
        //        cx.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=vadb;Data Source=MARTIN-PC\\SQLEXPRESS";
        //        SqlDataAdapter da = new SqlDataAdapter(sql, cx);
        //        da.Fill(ds, "personas");
        //        gv1.DataSource = ds;
        //        gv1.DataMember = "personas";
        //    }
        //    if (cmbSexo.Text == "Hombres")
        //    {
        //        sql = "SELECT p.*, f.link_face, f.url_perfil, DATEDIFF(yy, GETDATE(), fec_nac) * - 1 AS edad FROM Personas p, Facebooks f where p.id_face = f.id_face and p.sexo='m'";

        //        DataSet ds = new DataSet();
        //        SqlConnection cx = new SqlConnection();
        //        cx.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=vadb;Data Source=MARTIN-PC\\SQLEXPRESS";
        //        SqlDataAdapter da = new SqlDataAdapter(sql, cx);
        //        da.Fill(ds, "personas");
        //        gv1.DataSource = ds;
        //        gv1.DataMember = "personas";
        //    }
        //    if (cmbSexo.Text == "Señoras")
        //    {
        //        sql = "SELECT p.*, f.link_face, f.url_perfil, DATEDIFF(yy, GETDATE(), fec_nac) * - 1 AS edad FROM Personas p, Facebooks f where p.id_face = f.id_face and p.sexo='f' and fec_nac < '01-01-1985'";

        //        DataSet ds = new DataSet();
        //        SqlConnection cx = new SqlConnection();
        //        cx.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=vadb;Data Source=MARTIN-PC\\SQLEXPRESS";
        //        SqlDataAdapter da = new SqlDataAdapter(sql, cx);
        //        da.Fill(ds, "personas");
        //        gv1.DataSource = ds;
        //        gv1.DataMember = "personas";
        //    }  
        //}
    }
}
