using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Logica;
using Entidades;
using System.IO;
using UNCDeporte.Interfaz.Admin;
using System.Text.RegularExpressions;
using UNCDeporte.Torneos;
using UNCDeporte.TorneosYEventos;

//agregar try catch a los null x ej

namespace UNCDeporte.Admin
{
    public partial class RegistrarNuevoTorneo : Form
    {
        string guardado;
        GestorDeporte gde = new GestorDeporte();
        GestorTorneo gt = new GestorTorneo();
        Boolean banderaFechaInicio = false;//para saber si fue seleccionada alguna fecha de inicio
        Boolean banderaCalcular = false; // para saber si calculé la cantidad de participantes en clasificatorio
        int puntajePrimerPuesto=0;
        int puntajeSegundoPuesto=0;

        public static string nombreTorneo;
        public static DateTime fi;//fecha de inicio
        public static DateTime fc;//fecha de cierre


        public RegistrarNuevoTorneo()
        {
            InitializeComponent();
        }

        private void RegistrarNuevoTorneo_Load(object sender, EventArgs e)
        {
            LLenarComboSeleccionTiposDeporte();
            LLenarComboDeportes();
            LLenarComboSeleccionClasificatorio();
            LLenarComboSeleccionPuntajes();
            LlenarComboCantidadParticipantes();
        }

        public void LLenarComboSeleccionTiposDeporte()
        {
            List<string> tiposDeporteSeleccion = new List<string>();
            tiposDeporteSeleccion.Add("- Seleccione un Tipo de Deporte -");
            cmbTiposDeporte.DataSource = tiposDeporteSeleccion;
        }

        public void LLenarComboSeleccionClasificatorio() 
        {
            List<string> clasificatorioSeleccion = new List<string>();
            clasificatorioSeleccion.Add("- Seleccione una Cantidad -");
            cmbCantidadGrupos.DataSource = clasificatorioSeleccion;
            cmbParticipantesPorGrupo.DataSource = clasificatorioSeleccion;
            cmbClasificadosPorGrupo.DataSource = clasificatorioSeleccion;
        }

        public void LLenarComboSeleccionPuntajes()
        {
            List<string> puntajeSeleccion = new List<string>();
            puntajeSeleccion.Add("- Seleccione un Puntaje -");
            cmbPuntajePrimerPuesto.DataSource = puntajeSeleccion;
            cmbPuntajeSegundoPuesto.DataSource = puntajeSeleccion;
        }

        //Eliminatorio y Todos Contra Todos
        public void LlenarComboCantidadParticipantes()
        {
            List<string> seleccionParticipantes = new List<string>();
            seleccionParticipantes.Add("- Seleccione una Cantidad -");
            cmbCantidadParticipantes.DataSource = seleccionParticipantes;
        }

        public void LLenarComboDeportes()
        {
            List<Deporte> deportes = new List<Deporte>();
            Deporte dep = new Deporte();
            dep.Id_deporte = 0;
            dep.Nombre = "- Seleccione un Deporte -";
            dep.Descripcion = "";
            dep.Cod_sanaviron = 0;
            deportes.Add(dep);

            cmbDeportes.DataSource = deportes;
            cmbDeportes.DisplayMember = "Nombre";
            cmbDeportes.ValueMember = "id_deporte";
            cmbDeportes.SelectedIndex = 0;
        }

        private void cmbTiposDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTiposDeporte.SelectedValue == "Recreativo")
            {
                cmbDeportes.DataSource = gde.ConsultarPorTipoRecreativo().Tables[0];
                cmbDeportes.DisplayMember = "Nombre";
                cmbDeportes.ValueMember = "id_deporte";
                cmbDeportes.SelectedIndex = 0;
                LLenarComboSeleccionPuntajes();
                cmbPuntajePrimerPuesto.Enabled = false;
                lblPuntaje1erPuestoO.Visible = false;
                cmbPuntajeSegundoPuesto.Enabled = false;
                lblPuntaje2doPuestoO.Visible = false;
            }

            if (cmbTiposDeporte.SelectedValue == "Federado")
            {
                cmbDeportes.DataSource = gde.ConsultarPorTipoFederado().Tables[0];
                cmbDeportes.DisplayMember = "Nombre";
                cmbDeportes.ValueMember = "id_deporte";
                cmbDeportes.SelectedIndex = 0;
                cmbPuntajePrimerPuesto.Enabled = true;
                lblPuntaje1erPuestoO.Visible = true;
                cmbPuntajeSegundoPuesto.Enabled = true;
                lblPuntaje2doPuestoO.Visible = true;
            }
        }

        private void cmbTiposDeporte_Click(object sender, EventArgs e)
        {
            List<string> tiposDep = new List<string>();
            tiposDep.Add("Recreativo");
            tiposDep.Add("Federado");
            cmbTiposDeporte.DataSource = tiposDep;
            cmbDeportes.Enabled = true;
        }
        
        private void cmbDeportes_Click(object sender, EventArgs e)
        {
            if (cmbTiposDeporte.SelectedValue == "Recreativo")
            {
                cmbDeportes.DataSource = gde.ConsultarPorTipoRecreativo().Tables[0];
                cmbDeportes.DisplayMember = "Nombre";
                cmbDeportes.ValueMember = "id_deporte";
                cmbDeportes.SelectedIndex = 0;            
            }

            if (cmbTiposDeporte.SelectedValue == "Federado")
            {
                cmbDeportes.DataSource = gde.ConsultarPorTipoFederado().Tables[0];
                cmbDeportes.DisplayMember = "Nombre";
                cmbDeportes.ValueMember = "id_deporte";
                cmbDeportes.SelectedIndex = 0;     
            }       
        }

        private void dtFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaHoy = DateTime.Now;
            dtFechaInicio.MinDate = fechaHoy;
            dtFechaCierre.MinDate = fechaHoy;
            dtFechaCierre.Enabled = true;
            banderaFechaInicio = true;
        }

        private void cbEliminatoria_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEliminatoria.Checked == true)
            {
                cbTCTUnaVuelta.Checked = false;
                cbTCTDobleVuelta.Checked = false;
                cbClasificatorio.Checked = false;
                cmbCantidadParticipantes.Enabled = true;

                LLenarComboSeleccionClasificatorio();
                desactivarCamposTipoTorneoClasificatorio();
            }
        }

        private void cbTCTUnaVuelta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTCTUnaVuelta.Checked == true)
            {
                cbEliminatoria.Checked = false;
                cbTCTDobleVuelta.Checked = false;
                cbClasificatorio.Checked = false;
                cmbCantidadParticipantes.Enabled = true;

                LLenarComboSeleccionClasificatorio();
                desactivarCamposTipoTorneoClasificatorio();
            }
        }

        private void cbTCTDobleVuelta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTCTDobleVuelta.Checked == true)
            {
                cbEliminatoria.Checked = false;
                cbTCTUnaVuelta.Checked = false;
                cbClasificatorio.Checked = false;
                cmbCantidadParticipantes.Enabled = true;

                LLenarComboSeleccionClasificatorio();
                desactivarCamposTipoTorneoClasificatorio();
            }
        }

        private void cbClasificatorio_CheckedChanged(object sender, EventArgs e)
        {
            if (cbClasificatorio.Checked == true)
            {
                cbEliminatoria.Checked = false;
                cbTCTUnaVuelta.Checked = false;
                cbTCTDobleVuelta.Checked = false;
                activarCamposTipoTorneoClasificatorio();
            }

            else
                desactivarCamposTipoTorneoClasificatorio();
        }

        private void cmbCantidadGrupos_Click(object sender, EventArgs e)
        {
            List<string> cant = new List<string>();
            cant.Add("1"); cant.Add("2");
            cant.Add("3"); cant.Add("4");
            cant.Add("5"); cant.Add("6");
            cant.Add("7"); cant.Add("8");
            cant.Add("9"); cant.Add("10");
            cmbCantidadGrupos.DataSource = cant;
            
            if (txtCantParticipantes.Text != "" && txtCantParticipantes.Visible == true && cbClasificatorio.Checked == true)
            {
                btnCalcularCantParticipantes.Visible = true;
                txtCantParticipantes.Visible = false;
                txtCantParticipantes.Text = ""; //revisar, no hace falta capaz
            }
            banderaCalcular = false;
        }

        private void cmbParticipantesPorGrupo_Click(object sender, EventArgs e)
        {
            List<string> cant = new List<string>();
            cant.Add("2");
            cant.Add("3"); cant.Add("4");
            cant.Add("5"); cant.Add("6");
            cant.Add("7"); cant.Add("8");
            cant.Add("9"); cant.Add("10");
            cmbParticipantesPorGrupo.DataSource = cant;
            if (txtCantParticipantes.Text != "" && txtCantParticipantes.Visible == true && cbClasificatorio.Checked == true)
            {
                btnCalcularCantParticipantes.Visible = true;
                txtCantParticipantes.Visible = false;
                txtCantParticipantes.Text = ""; //revisar, no hace falta capaz
            }
            banderaCalcular = false;
        }

        private void cmbClasificadosPorGrupo_Click(object sender, EventArgs e)
        {
            List<string> cant = new List<string>();
            cant.Add("1"); cant.Add("2");
            cant.Add("3"); cant.Add("4");
            cant.Add("5");
            cmbClasificadosPorGrupo.DataSource = cant;
        }

        public void desactivarCamposTipoTorneoClasificatorio()
        {
            cmbCantidadGrupos.Enabled = false;
            cmbParticipantesPorGrupo.Enabled = false;
            cmbClasificadosPorGrupo.Enabled = false;

            btnCalcularCantParticipantes.Visible = false;
            lblCantidadParticipantesPorClasificatorioO.Visible = false;
            cmbCantidadParticipantes.Visible = true;
            lblCantidadParticipantesO.Visible = true;
            txtCantParticipantes.Visible = false;


            lblParticipantesPorGrupoO.Visible = false;
            lblCantidadGruposO.Visible = false;
            lblClasificadosPorGrupoO.Visible = false;
        }

        public void activarCamposTipoTorneoClasificatorio()
        {
            cmbCantidadGrupos.Enabled = true;
            cmbParticipantesPorGrupo.Enabled = true;
            cmbClasificadosPorGrupo.Enabled = true;

            btnCalcularCantParticipantes.Visible = true;
            lblCantidadParticipantesPorClasificatorioO.Visible = true;
            cmbCantidadParticipantes.Visible = false;
            lblCantidadParticipantesO.Visible = false;
            txtCantParticipantes.Visible = false;

            lblParticipantesPorGrupoO.Visible = true;
            lblCantidadGruposO.Visible = true;
            lblClasificadosPorGrupoO.Visible = true;
        }

        private void cmbPuntajePrimerPuesto_Click(object sender, EventArgs e)
        {
            List<string> puntajes = new List<string>();
            puntajes.Add("2");
            puntajes.Add("3"); puntajes.Add("4");
            puntajes.Add("5"); puntajes.Add("6");
            puntajes.Add("7"); puntajes.Add("8");
            puntajes.Add("9"); puntajes.Add("10");
            cmbPuntajePrimerPuesto.DataSource = puntajes;
        }

        private void cmbPuntajeSegundoPuesto_Click(object sender, EventArgs e)
        {
            List<string> puntajes = new List<string>();
            puntajes.Add("1"); puntajes.Add("2");
            puntajes.Add("3"); puntajes.Add("4");
            puntajes.Add("5"); puntajes.Add("6");
            puntajes.Add("7"); puntajes.Add("8");
            puntajes.Add("9");
            cmbPuntajeSegundoPuesto.DataSource = puntajes;
        }

        //Eliminatorio y Todos Contra Todos
        private void cmbCantidadParticipantes_Click(object sender, EventArgs e)
        {
            List<string> cp = new List<string>();
            cp.Add("4");
            cp.Add("8");
            cp.Add("16");
            cp.Add("32");
            cp.Add("64");
            cmbCantidadParticipantes.DataSource = cp;
        }


        private void btnCalcularCantParticipantes_Click(object sender, EventArgs e)
        {
            banderaCalcular = true;
            if (cmbCantidadGrupos.SelectedValue != "- Seleccione una Cantidad -" && cmbParticipantesPorGrupo.SelectedValue != "- Seleccione una Cantidad -")
            {
                string cg = cmbCantidadGrupos.SelectedValue.ToString();
                int cantGrupos = int.Parse(cg);

                string pxg = cmbParticipantesPorGrupo.SelectedValue.ToString();
                int participantesXGrupo = int.Parse(pxg);

                btnCalcularCantParticipantes.Visible = false;
                txtCantParticipantes.Visible = true;

                int totalParticipantes = cantGrupos * participantesXGrupo;
                txtCantParticipantes.Text = totalParticipantes.ToString();
            }
            else 
            {
                MessageBox.Show("Ingrese Cantidad de Grupos y Cantidad de Participantes por Grupo para realizar el cálculo.", "Registro de Torneo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //public void hayFaseAnterior()
        //{
        //    DialogResult res;
        //    res = MessageBox.Show("¿El torneo tiene una fase anterior?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (res == DialogResult.Yes)
        //    {
        //        try
        //        {
        //            //abre una ventana para seleccionar una fase anterior 
        //            TieneFaseAnterior form = new TieneFaseAnterior();
        //            form.Show();
        //            //guardar id de torneo nada mas, haria un update en el torneo elegido. 
        //            //form.ShowDialog();//para que bloquee la pantalla nueva y no se pueda modificar la de atras.
        //            // Que pasa si no selecciona nada en la pantallaTieneFaseAnterior?
        //        }
        //        catch (Exception ex) { }
        //    }
        //}

        // al guardar aparece la pregunta si tiene fase anterior. Si pongo que si me abre otra pantalla donde consulta todos los torneos del mismo deporte y mismo y tipo para relacionarlo con la fk idTorneoProxFase. Ahi me permite seleccionar.
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre para el Torneo.", "Registro de Torneo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
                return;
            }

            if (cmbTiposDeporte.SelectedValue == "- Seleccione un Tipo de Deporte -")
            {
                MessageBox.Show("Seleccione un Tipo de Deporte.", "Registro de Torneo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbTiposDeporte.Focus();
                return;
            }
            
            if (cmbDeportes.SelectedValue == "- Seleccione un Deporte -")
            {
                MessageBox.Show("Seleccione un Deporte.", "Registro de Torneo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbDeportes.Focus();
                return;
            }

            if (banderaFechaInicio == false)
            {
                MessageBox.Show("Seleccione una Fecha de Inicio.", "Registro de Torneo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtFechaInicio.Focus();
                return;
            }

            if (banderaFechaInicio == true && (DateTime.Compare(dtFechaInicio.Value,dtFechaCierre.Value)>0))
            {
                MessageBox.Show("La Fecha de Cierre debe ser posterior a la Fecha de Inicio.", "Registro de Torneo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtFechaInicio.Focus();
                return;
            }

            TipoTorneo tt = new TipoTorneo();
             
            if (cbEliminatoria.Checked == false && cbTCTUnaVuelta.Checked == false && cbTCTDobleVuelta.Checked == false && cbClasificatorio.Checked == false)
            {
                MessageBox.Show("Seleccione un Tipo de Torneo.", "Registro de Torneo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbEliminatoria.Focus();
                return;
            }

            else //MEJORAR CODIGO 
            {
                // tt.Id_tipoTorneo = Convert.ToInt32(cmbTiposTorneo.SelectedValue);

                if (cbEliminatoria.Checked == true)
                {
                    tt.Id_tipoTorneo = 1;
                }
                if(cbTCTUnaVuelta.Checked == true)
                {
                    tt.Id_tipoTorneo = 2;
                }
                if(cbTCTDobleVuelta.Checked == true)
                {
                    tt.Id_tipoTorneo = 3;
                }
                if(cbClasificatorio.Checked == true)
                {
                    tt.Id_tipoTorneo = 4;
                }
            }
            
            if (cbClasificatorio.Checked == true)
            {
                if (cmbCantidadGrupos.SelectedValue == "- Seleccione una Cantidad -")
                {
                    MessageBox.Show("Seleccione una Cantidad de Grupos.", "Registro de Torneo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbCantidadGrupos.Focus();
                    return;
                }

                if (cmbParticipantesPorGrupo.SelectedValue == "- Seleccione una Cantidad -")
                {
                    MessageBox.Show("Seleccione una Cantidad de Participantes por Grupo.", "Registro de Torneo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbParticipantesPorGrupo.Focus();
                    return;
                }

                if (cmbClasificadosPorGrupo.SelectedValue == "- Seleccione una Cantidad -")
                {
                    MessageBox.Show("Seleccione una Cantidad de Clasificados por Grupo.", "Registro de Torneo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbClasificadosPorGrupo.Focus();
                    return;
                }
            }

            if (cmbPuntajePrimerPuesto.SelectedValue == "- Seleccione un Puntaje -" && cmbTiposDeporte.SelectedValue == "Federado")
            {
                MessageBox.Show("Seleccione un Puntaje para el Primer Puesto del Torneo.", "Registro de Torneo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbPuntajePrimerPuesto.Focus();
                return;
            }

            if (cmbPuntajeSegundoPuesto.SelectedValue == "- Seleccione un Puntaje -" && cmbTiposDeporte.SelectedValue == "Federado")
            {
                MessageBox.Show("Seleccione un Puntaje para el Segundo Puesto del Torneo.", "Registro de Torneo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbPuntajeSegundoPuesto.Focus();
                return;
            }

            if (cbClasificatorio.Checked == true && cmbClasificadosPorGrupo.SelectedValue != "- Seleccione una Cantidad -" && cmbParticipantesPorGrupo.SelectedValue != "- Seleccione una Cantidad -")
            {
                string clasi = cmbClasificadosPorGrupo.SelectedValue.ToString();
                int clasificados = int.Parse(clasi);
                string part= cmbParticipantesPorGrupo.SelectedValue.ToString();
                int participantes = int.Parse(part);
                
                if (participantes <= clasificados)
                {
                    MessageBox.Show("La Cantidad de Clasificados por Grupo debe ser menor que la Cantidad de Participantes por Grupo.", "Registro de Torneo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbParticipantesPorGrupo.Focus();
                    return;
                }
            }

            //Eliminatorio y Todos Contra Todos
            if (cmbCantidadParticipantes.SelectedValue == "- Seleccione una Cantidad -" && (cbEliminatoria.Checked == true || cbTCTUnaVuelta.Checked == true || cbTCTDobleVuelta.Checked == true))
            {
                MessageBox.Show("Seleccione una Cantidad de Participantes.", "Registro de Torneo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbCantidadParticipantes.Focus();
                return;
            }

            if (banderaCalcular == false && cbClasificatorio.Checked == true)
            {
                MessageBox.Show("Presione el botón Calcular del campo Cantidad de Participantes.", "Registro de Torneo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbCantidadParticipantes.Focus();
                return;
            }

            Deporte de = new Deporte();
            Estado est = new Estado();
            DateTime inicio = dtFechaInicio.Value;
            DateTime cierre = dtFechaCierre.Value;

            //********************************** seria mejor hacerlo todo por bd con una tabla TiposDeporte
            if (cmbTiposDeporte.SelectedValue == "Recreativo")
            {
                de.Id_tipo = 1;
                de.Tipo = "Recreativo";
            }

            if (cmbTiposDeporte.SelectedValue == "Federado")
            {
                de.Id_tipo = 2;
                de.Tipo = "Federado";
            } 
            
            //de.Id_tipo = Convert.ToInt32(cmbDeportes.SelectedValue);
            //de.Tipo = cmbDeportes.SelectedValue.ToString();
            //**********************************

            de.Id_deporte = Convert.ToInt32(cmbDeportes.SelectedValue);
            
            int cantidadParticipantes;
            
            // para eliminatoria, todos contra todos
            if (cmbCantidadParticipantes.Visible == true)
            {
                cantidadParticipantes = Convert.ToInt32(cmbCantidadParticipantes.SelectedValue);
            }

            //para clasificatorio
            else
            {
                string cp = txtCantParticipantes.Text;
                cantidadParticipantes = int.Parse(cp);
            }
            
            est.Id_estado = 12;//setea el estado del torneo a "Creado" 

            if (cbEliminatoria.Checked == true || cbTCTUnaVuelta.Checked == true || cbTCTDobleVuelta.Checked == true)
            {
                    if (cmbTiposDeporte.SelectedValue == "Recreativo")
                    {
                        puntajePrimerPuesto = 0;
                        puntajeSegundoPuesto = 0;
                    }

                    if (cmbTiposDeporte.SelectedValue == "Federado")
                    {
                        puntajePrimerPuesto = Convert.ToInt32(cmbPuntajePrimerPuesto.SelectedValue);
                        puntajeSegundoPuesto = Convert.ToInt32(cmbPuntajeSegundoPuesto.SelectedValue);

                        if (puntajePrimerPuesto <= puntajeSegundoPuesto)
                        {
                            MessageBox.Show("El puntaje del Primer Puesto debe ser mayor al puntaje del Segundo Puesto.", "Registro de Torneo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmbPuntajePrimerPuesto.Focus();
                            return;
                        }
                    } 
                guardado = gt.Registrar(txtNombre.Text, rtbDescripcion.Text, de, inicio, cierre, tt, cantidadParticipantes, est, puntajePrimerPuesto, puntajeSegundoPuesto,de);
            }

            if (cbClasificatorio.Checked == true)
            {
                if (cmbTiposDeporte.SelectedValue == "Recreativo")
                {
                    puntajePrimerPuesto = 0;
                    puntajeSegundoPuesto = 0;
                }

                if (cmbTiposDeporte.SelectedValue == "Federado")
                {
                    puntajePrimerPuesto = Convert.ToInt32(cmbPuntajePrimerPuesto.SelectedValue);
                    puntajeSegundoPuesto = Convert.ToInt32(cmbPuntajeSegundoPuesto.SelectedValue);

                    if (puntajePrimerPuesto <= puntajeSegundoPuesto)
                    {
                        MessageBox.Show("El puntaje del Primer Puesto debe ser mayor al puntaje del Segundo Puesto.", "Registro de Torneo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbPuntajePrimerPuesto.Focus();
                        return;
                    }
                }
    
                string cg = cmbCantidadGrupos.SelectedValue.ToString();
                int cantGrupos = int.Parse(cg);

                string pxg = cmbParticipantesPorGrupo.SelectedValue.ToString();
                int participantesXGrupo = int.Parse(pxg);

                string cxg = cmbClasificadosPorGrupo.SelectedValue.ToString();
                int clasificadosXGrupo = int.Parse(cxg);

                string total = txtCantParticipantes.Text;
                int totalParticipantes = int.Parse(total);

                guardado = gt.RegistrarClasificatorio(txtNombre.Text, rtbDescripcion.Text, de, inicio, cierre, tt, totalParticipantes, est, cantGrupos, participantesXGrupo, clasificadosXGrupo, puntajePrimerPuesto, puntajeSegundoPuesto,de);
            }
   
            if (guardado == "Existe")
            {
                lblGuardado.Visible = false;
                lblGuardado.Text = "No Guardado, ya existe: " + txtNombre.Text;
                txtNombre.Text = "";
                MessageBox.Show("Ya existe un Torneo con ese nombre.", "Registro de Torneo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (guardado == "Guardado")
            {
                lblGuardado.Visible = false;
                lblGuardado.Text = "Guardado Correctamente: " + txtNombre.Text;
                txtNombre.Text = "";
                rtbDescripcion.Text = "";
                LLenarComboSeleccionTiposDeporte();
                LLenarComboDeportes();
                cmbDeportes.Enabled = false;
                banderaFechaInicio = false;

                try
                {
                    DateTime fechaHoy = DateTime.Now;
                    dtFechaInicio.Value = fechaHoy;
                    dtFechaCierre.Value = fechaHoy;
                }
                catch (ArgumentOutOfRangeException ex) { }

                dtFechaCierre.Enabled = false;
                LLenarComboSeleccionClasificatorio();
                LLenarComboSeleccionPuntajes();
                if (cbClasificatorio.Checked == true)
                {
                    cbClasificatorio.Checked = false;
                    txtCantParticipantes.Text = "";
                    txtCantParticipantes.Visible = false;
                    cmbCantidadParticipantes.Visible = true;
                }
                if (cbEliminatoria.Checked == true) { cbEliminatoria.Checked = false; }
                if (cbTCTUnaVuelta.Checked == true) { cbTCTUnaVuelta.Checked = false; }
                if (cbTCTDobleVuelta.Checked == true) { cbTCTDobleVuelta.Checked = false;}

                LlenarComboCantidadParticipantes();
                
                MessageBox.Show("Se registró correctamente el Torneo.", "Registro de Torneo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hayReserva();
                return;
            }
            
            if (guardado == "Error al Guardar")
            {
                lblGuardado.Visible = false;
                lblGuardado.Text = "No Guardado, error de escritura";
                MessageBox.Show("No se pudo guardar el Torneo. Error al Guardar.", "Registro de Torneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Al reservar las canchas de torneo al inicio de año pisaria todo, tienen prioridad

            /*res = MessageBox.Show("“Desea registrar reserva de canchas para torneo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                RegistrarReserva form = new RegistrarReserva();
                form.Show();
            }*/
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void gbTorneos_Enter(object sender, EventArgs e)
        {

        }

        public void hayReserva()
        {
            DialogResult res;
            res = MessageBox.Show("¿Desea reservar sectores para el torneo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    RegistrarNuevoTorneo.nombreTorneo = txtNombre.Text;
                    RegistrarNuevoTorneo.fi = dtFechaInicio.Value;
                    RegistrarNuevoTorneo.fc = dtFechaCierre.Value;

                    ReservaTorneo form = new ReservaTorneo(3);
                    form.Show();
                }
                catch (Exception ex) { }
            }

        }
   }
}
