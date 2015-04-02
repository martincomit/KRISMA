using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace UNCDeporte.Interfaz.Admin
{
    public partial class ProgramaActividades : Form
    {        
        //Datos de la Pantalla        
        public enum Opcion{REGISTRAR, MODIFICAR, ELIMINAR,CONSULTAR};//Despues se puede meter en una Clase glogal GestorPantallas para el menu Admin
        public Opcion opcion; //Se asigna el valor al crear el Form y antes del Show

        public GestorPrograma gp;
        //----------------------------------------------------------------------------------
               

        //Constructor
        public ProgramaActividades()
        {
            InitializeComponent();

            gp = new GestorPrograma();

            gp.Cargar_Lista_Programas();
            gp.Cargar_Lista_Deportes();
            //gp.Cargar_Lista_Lugares();
            gp.Cargar_Lista_Profesores();


            cbDeporte.DisplayMember = "Nombre";
            cbDeporte.ValueMember = "Id_deporte";
            cbDeporte.DataSource = gp.Obtener_Lista_Deportes();

            cbLugar.DisplayMember = "Nombre";
            cbLugar.ValueMember = "Id_lugar";
            cbLugar.DataSource = gp.Obtener_Lista_Lugares();

            
            //cbTipoSector.DisplayMember = "Nombre";
            //cbTipoSector.ValueMember = "Id_tipo_sector";
            //cbTipoSector.DataSource = gp.Obtener_Lista_Tipos_Sectores(gp.lista_lugares.First());

            //cbSector.DisplayMember = "Nombre";
            //cbSector.ValueMember = "Id_sector";
            //cbSector.DataSource = gp.Obtener_Lista_Sectores(gp.lista_lugares.First(), gp.lista_tipo_sectores.First());

            
            cbProfesor.DisplayMember = "Apellido";
            cbProfesor.ValueMember = "Documento";
            cbProfesor.DataSource = gp.Obtener_Lista_Profesores();
            
        }

        private void RegistrarProgramaActividades_Load(object sender, EventArgs e)
        {            
                       
            switch (opcion)
            {
                case Opcion.REGISTRAR:
                    gp.Nuevo_Programa();
                    txtAnioLectivo.Enabled = true;
                    txtFechaAlta.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    txtAnioLectivo.Text = DateTime.Now.Year.ToString();
                    dtpInicio.Enabled = true;                    
                    dtpInicio.Value = new DateTime(Convert.ToInt32(txtAnioLectivo.Text),1,1);
                    dtpCierre.Enabled = true;
                    dtpCierre.Value = new DateTime(Convert.ToInt32(txtAnioLectivo.Text), 12, 31);
                    txtDescripcion.Enabled = true;

                    if (gp.Hay_Programas())
                    {
                        btnObtenerProgramas.Enabled = true;
                    }
                    else
                    {
                        btnObtenerProgramas.Enabled = false;
                    }
                    gbDetalle.Enabled = true;

                    btnDiagramarDeporte.Enabled = true;
                    btnQuitarDelPrograma.Enabled = false;
                    btnVerDiagramacion.Enabled = false;
                    
                    gbDiagramacion.Enabled = false;

                    chkDuracion.Checked = false;
                    cbDuracion.Enabled = false;
     
                    btnGuardarPrograma.Enabled = false;
                    btnCancelarPrograma.Enabled = false;
                    btnReservar.Enabled = false;                                        
                    break;


                case Opcion.MODIFICAR:

                    break;

                case Opcion.ELIMINAR:

                    break;

                case Opcion.CONSULTAR:

                    break;
            }
            Setear_Pantalla();
        }

        public void Setear_Pantalla()
        {                        
            txtDescripcion.Text = "";
           
            cbDeporte.SelectedIndex = 0;
            cbLugar.SelectedIndex = 0;
            cbTipoSector.SelectedIndex = 0;
            cbSector.SelectedIndex = 0;
            cbDuracion.SelectedIndex = 0;
            cbDia.SelectedIndex = 0;
            dudHoraDesde.SelectedIndex = 0;
            dudMinutoDesde.SelectedIndex = 0;
            dudHoraHasta.SelectedIndex = 0;
            dudMinutoHasta.SelectedIndex = 0;
            txtCupo.Text = "";                        
        }

        private void cbLugar_SelectedIndexChanged(object sender, EventArgs e)
        {            
            cbTipoSector.DataSource = gp.Obtener_Lista_Tipos_Sectores(gp.lista_lugares[Convert.ToInt32(cbLugar.SelectedIndex)]);
            cbSector.DataSource = gp.Obtener_Lista_Sectores(gp.lista_lugares[Convert.ToInt32(cbLugar.SelectedIndex)], gp.lista_tipo_sectores[Convert.ToInt32(cbTipoSector.SelectedIndex)]);            
        }

        private void cbTipoSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSector.DataSource = gp.Obtener_Lista_Sectores(gp.lista_lugares[Convert.ToInt32(cbLugar.SelectedIndex)], gp.lista_tipo_sectores[Convert.ToInt32(cbTipoSector.SelectedIndex)]);
        }

        private void btnDiagramarDeporte_Click(object sender, EventArgs e)
        {
            if (txtCupo.Text != "")
            {
                gbDiagramacion.Enabled = true;
                cbDeporte.Enabled = false;
                txtCupo.Enabled = false;
            }
            else
            {
                MessageBox.Show("Ingrese else CUPO");
            }
        }        

        private void chkConfirmarEspacio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConfirmarEspacio.Checked)
            {
                cbLugar.Enabled = false;
                cbTipoSector.Enabled = false;
                cbSector.Enabled = false;
            }
            else
            {
                cbLugar.Enabled = true;
                cbTipoSector.Enabled = true;
                cbSector.Enabled = true;
            }
        }

        private void chkConfirmarHorario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConfirmarHorario.Checked)
            {
                dudHoraDesde.Enabled = false;
                dudMinutoDesde.Enabled = false;
                dudHoraHasta.Enabled = false;
                dudMinutoHasta.Enabled = false;
                chkDuracion.Enabled = false;
                cbDuracion.Enabled = false;
            }
            else
            {
                dudHoraDesde.Enabled = true;
                dudMinutoDesde.Enabled = true;
                dudHoraHasta.Enabled = true;
                dudMinutoHasta.Enabled = true;
                chkDuracion.Enabled = true;
                if (chkDuracion.Checked)
                    cbDuracion.Enabled = true;
                else
                    cbDuracion.Enabled = false;                
            }
        }

        private void chkDuracion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDuracion.Checked)
            {
                cbDuracion.Enabled = true;
                dudHoraHasta.Enabled = false;
                dudMinutoHasta.Enabled = false;
            }
            else
            {
                cbDuracion.Enabled = false;
                dudHoraHasta.Enabled = true;
                dudMinutoHasta.Enabled = true;
            }
        }

        private void btnAgregarDiagramacion_Click(object sender, EventArgs e)
        {
            if (dgvDiagramacion.Rows.Count >= 3)
                dgvDiagramacion.Columns[0].Width = 220;
            dgvDiagramacion.Rows.Add(cbLugar.Text,cbTipoSector.Text, cbSector.Text, cbDia.Text, dudHoraDesde.Text+":"+dudMinutoDesde.Text, dudHoraHasta.Text+":"+dudMinutoHasta.Text);
        }

        private void btnGuardarPrograma_Click(object sender, EventArgs e)
        {

        }
        
        

    }
}
