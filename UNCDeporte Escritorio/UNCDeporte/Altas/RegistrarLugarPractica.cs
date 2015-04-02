using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;
using Entidades;
using UNCDeporte.Admin;

namespace UNCDeporte.Interfaz.Admin
{
    public partial class RegistrarLugarPractica : Form
    {
        string guardado;
        private int a;//atributo que me sirve para controlar los combos localidad y barrio
        public int index; //es el índice de localidad que le voy a pasar a la pantalla registrar barrio cuando la llame.

        GestorLugarPractica glp = new GestorLugarPractica(); 
        GestorLocalidad gl = new GestorLocalidad();
        GestorBarrio gb = new GestorBarrio();
          
        public RegistrarLugarPractica()
        {
            InitializeComponent();
            a = 0;//inicialización.
        }

        private void RegistrarLugarPractica_Load(object sender, EventArgs e)
        {
            LLenarComboLocalidad();
        }

        public void LLenarComboLocalidad()
        {
            cmbLocalidades.DataSource = gl.Consultar().Tables[0];
            cmbLocalidades.DisplayMember = "Nombre";
            cmbLocalidades.ValueMember = "id_localidad";
            cmbLocalidades.SelectedIndex = 0;
            //ojo cuando no tiene nada
            global.id_localidad = int.Parse(cmbLocalidades.SelectedValue.ToString());
            LLenarComboBarrioDeLocalidad();
        }

        public void LLenarComboBarrioDeLocalidad()
        {
            cmbBarrios.DataSource = gb.Consultar(global.id_localidad).Tables[0]; //.tables[0] pq sino no trae el nombre
            cmbBarrios.DisplayMember = "Nombre";
            cmbBarrios.ValueMember = "id_barrio";

            if (cmbBarrios.Items.Count > 0)
                cmbBarrios.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" && txtDireccion.Text == "")
            {
                MessageBox.Show("Completar los campos obligatorios para el Lugar de Práctica.", "Registro de Lugar de Práctica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
                return;
            } 
            
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre para el Lugar de Práctica.", "Registro de Lugar de Práctica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
                return;
            }

            if (txtDireccion.Text == "")
            {
                MessageBox.Show("Ingrese una dirección para el Lugar de Práctica.", "Registro de Lugar de Práctica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDireccion.Focus();
                return;
            }

            Localidad l = new Localidad();
            Barrio b = new Barrio();

            l.Id_localidad = Convert.ToInt32(cmbLocalidades.SelectedValue);
            l.nombre = cmbLocalidades.Text;

            b.Id_barrio = Convert.ToInt32(cmbBarrios.SelectedValue);

            guardado = glp.Registrar(txtNombre.Text, txtDescripcion.Text, txtDireccion.Text, l, b);

            if (guardado == "Existe")
            {
                lblGuardado.Visible = false;
                lblGuardado.Text = "No Guardado, ya existe: " + txtNombre.Text;
                txtNombre.Text = "";
                MessageBox.Show("Ya existe un Lugar de Práctica con ese nombre.", "Registro de Lugar de Práctica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (guardado == "Guardado")
            {
                lblGuardado.Visible = false;
                lblGuardado.Text = "Guardado Correctamente: " + txtNombre.Text;
                txtNombre.Text = "";
                txtDescripcion.Text = "";
                txtDireccion.Text = " ";
                //para volver el comboLocalidades a la primera posición
                cmbLocalidades.SelectedIndex = 0;
                MessageBox.Show("Se registró correctamente el Lugar de Práctica.", "Registro de Lugar de Práctica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (guardado == "Error al Guardar")
            {
                lblGuardado.Visible = false;
                lblGuardado.Text = "No Guardado, error de escritura";
                txtNombre.Text = "";
                MessageBox.Show("No se pudo guardar el Lugar de Práctica. Error al Guardar.", "Registro de Lugar de Práctica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_NuevaLocalidad(object sender, EventArgs e)
        {
            NuevaLocalidad form = new NuevaLocalidad();
            form.Owner = this;
            form.Show();
            
            a = 1;
            //cuando vuelve a la pantalla de reglugarpractica tiene q actualizarlo
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
        }

        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            LLenarComboLocalidad();
        }

        private void btn_NuevoBarrio(object sender, EventArgs e)
        {
            index = cmbLocalidades.SelectedIndex; 
            RegistrarBarrio form = new RegistrarBarrio();
            form.index = index;
            form.Owner = this;
            form.Show();
            a = 0;
            //cuando vuelve a la pantalla de reglugarpractica tiene q actualizar
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
        }

        void form_FormClosed2(object sender, FormClosedEventArgs e)
        {
            LLenarComboBarrioDeLocalidad();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cmbLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLocalidades.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                global.id_localidad = int.Parse(cmbLocalidades.SelectedValue.ToString());
                LLenarComboBarrioDeLocalidad();
            }
        }
    }
}

