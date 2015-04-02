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
using System.Threading;
using System.Globalization;
using UNCDeporte.TorneosYEventos;

namespace UNCDeporte.Admin
{
    public partial class ReservaTorneo : Form
    {

        public GestorReserva gr;
        public List<Deporte> lauxdep;
        public int tipo;

        private GestorTorneo gt;
        private GestorDeporte gde;
        private GestorLugarPractica gl;
        private GestorTipoSector gts;


        public ReservaTorneo(int tipo)
        {
            InitializeComponent();

            try
            {

                gt = new GestorTorneo();
                gde = new GestorDeporte();
                gl = new GestorLugarPractica();
                gts = new GestorTipoSector();

                txtNombre.Text = RegistrarNuevoTorneo.nombreTorneo;
                txtIDDeporte.Text = gt.ConsultarPorFiltro(txtNombre.Text).Tables[0].Rows[0][3].ToString();
                txtDeporte.Text = gde.Consultar(int.Parse(txtIDDeporte.Text)).Tables[0].Rows[0][1].ToString();



            }
            catch (Exception ex) { }

            try
            {
                dtpFecInicio.Value = RegistrarNuevoTorneo.fi;
                dtpFecFin.Value = RegistrarNuevoTorneo.fc;
                txtLugar.Text = gl.Consultar2(int.Parse(txtIDDeporte.Text)).Tables[0].Rows[0][0].ToString();
                txtTipoSector.Text = gts.ConsultarPorNombre(txtDeporte.Text).Tables[0].Rows[0][1].ToString();
            }
            catch (Exception ex) { }

            try
            {
                dtpFecha.MinDate = dtpFecInicio.Value;
                dtpFecha.MaxDate = dtpFecFin.Value;
                txtNombre.Enabled = false;
                dtpFecFin.Enabled = false;
                dtpFecInicio.Enabled = false;
                txtDeporte.Enabled = false;
                txtLugar.Enabled = false;
                txtTipoSector.Enabled = false;

            }
            catch (Exception ex) { }




            gr = new GestorReserva();            
            gr.Cargar_Lista_Lugares();
            gr.Cargar_Lista_Horarios();
            gr.Cargar_Lista_Deportes();

            gr.Cargar_Lista_Tipos_Reserva();
            gr.Cargar_Lista_Estados_Detalle_Reserva();
            
            //cbLugar.DisplayMember = "Nombre";
            //cbLugar.ValueMember = "Id_lugar";
            //cbLugar.DataSource = gr.Obtener_Lista_Lugares();


            //cbTipoSector.DisplayMember = "Nombre";
            //cbTipoSector.ValueMember = "Id_tipo_sector";
            //cbTipoSector.DataSource = gr.Obtener_Tipo_Sectores(gr.lista_lugares.First());

            cbSector.DisplayMember = "NombreCompleto";
            cbSector.ValueMember = "Id_sector";
            cbSector.DataSource = gr.Obtener_Sectores(gr.lista_lugares.First(), gr.lista_tipo_sectores.First());

            lauxdep = new List<Deporte>();
            Deporte d = new Deporte(0, "Sin Deporte", "", 0);
            lauxdep.Add(d);
            for (int i = 0; i < gr.lista_deportes.Count; i++)
                lauxdep.Add(gr.lista_deportes[i]);

            //cbDeporte.DisplayMember = "Nombre";
            //cbDeporte.ValueMember = "Id_deporte";
            //cbDeporte.DataSource = lauxdep;//gr.Obtener_Lista_Deportes();

            Seteo_Reserva();
            //Consulta de Reservas
            gr.Nueva_Lista_Reserva();
            gr.Cargar_Lista_Reservas((Sector)cbSector.Items[0]);//.SelectedItem); 
            this.tipo = tipo;
        }

        public void Seteo_Reserva()
        {
            gr.Nueva_Reserva();
            dgvHorario.ClearSelection();
            dgvDetalleReserva.Rows.Clear();
            //txtApellido.Text = "";            
            txtDesde.Text = "";
            //txtDocumento.Text = "";
            //txtEmail.Text = "";
            txtHasta.Text = "";
            //txtNombre.Text = "";
            //txtTelCelular.Text = "";
            //txtTelFijo.Text = "";            

        }

        public void Limpiar_Grilla()
        {
            for (int i = 0; i < dgvHorario.Rows.Count; i++)
            {
                dgvHorario.Rows[i].Cells[1].Value = "";
                dgvHorario.Rows[i].Cells[1].Style.BackColor = Color.White;                
            }
            dgvHorario.ClearSelection();
        }

        public void Mostrar_Reserva()
        {
            dgvHorario.ClearSelection();
            if (gr.lista_reserva != null)
            {
                //Limpiar_Grilla();
                for (int i = 0; i < gr.lista_reserva.Count; i++)
                {
                    if (gr.lista_reserva[i].Detalle[0].Fecha_reserva.ToString("dd/MM/yyyy") == dtpFecha.Value.ToString("dd/MM/yyyy"))
                    {
                        for (int j = gr.lista_reserva[i].Detalle[0].Hora_desde.Id_horario - 1; j < gr.lista_reserva[i].Detalle[0].Hora_hasta.Id_horario - 1; j++)
                        {
                            switch (gr.lista_reserva[i].Tipo_reserva.Id_tipo_reserva)
                            {
                                case 1:
                                    dgvHorario.Rows[j].Cells[1].Style.BackColor = Color.Green;
                                    break;
                                case 2:
                                    dgvHorario.Rows[j].Cells[1].Style.BackColor = Color.Red;
                                    break;
                                case 3:
                                    dgvHorario.Rows[j].Cells[1].Style.BackColor = Color.Blue;
                                    break;
                                case 4:
                                    dgvHorario.Rows[j].Cells[1].Style.BackColor = Color.Gray;
                                    break;
                                case 5:
                                    dgvHorario.Rows[j].Cells[1].Style.BackColor = Color.FromArgb(255, 192, 192, 0);
                                    break;
                            }
                        }

                        dgvHorario.Rows[gr.lista_reserva[i].Detalle[0].Hora_desde.Id_horario - 1].Cells[1].Value = gr.lista_reserva[i].Descripcion;
                        if (gr.lista_reserva[i].Detalle[0].Deporte != null)
                            dgvHorario.Rows[gr.lista_reserva[i].Detalle[0].Hora_desde.Id_horario].Cells[1].Value = gr.lista_reserva[i].Detalle[0].Deporte.Nombre;
                        dgvHorario.Rows[gr.lista_reserva[i].Detalle[0].Hora_desde.Id_horario + 1].Cells[1].Value = gr.lista_reserva[i].Detalle[0].Hora_desde.Hora + ":" + gr.lista_reserva[i].Detalle[0].Hora_desde.Minuto;
                        dgvHorario.Rows[gr.lista_reserva[i].Detalle[0].Hora_desde.Id_horario + 2].Cells[1].Value = gr.lista_reserva[i].Detalle[0].Hora_hasta.Hora + ":" + gr.lista_reserva[i].Detalle[0].Hora_hasta.Minuto;
                        dgvHorario.Rows[gr.lista_reserva[i].Detalle[0].Hora_desde.Id_horario + 3].Cells[1].Value = gr.lista_reserva[i].Detalle[0].Persona.Nombres;
                        dgvHorario.Rows[gr.lista_reserva[i].Detalle[0].Hora_desde.Id_horario + 4].Cells[1].Value = gr.lista_reserva[i].Detalle[0].Persona.Apellido;                        

                    }                  
                }                
            }
        
         
        }

     
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDesde.Text == "" && txtHasta.Text == "")
            {

                MessageBox.Show("Seleccione horario");
                return;
            }
            else
            {
                //tomar lugar.
                dgvDetalleReserva.Rows.Add("lugar1", "sector1", cbSector.Text, dtpFecha.Value.ToString("dd/MM/yyyy"), txtDesde.Text, txtHasta.Text);
                dgvDetalleReserva.ClearSelection();
                dgvHorario.ClearSelection();
                DetalleReserva dr = new DetalleReserva();
                Deporte d = new Deporte();
                d.Nombre = "Tenis federado"; //cambiar
                dr.Deporte = d;
                Estado est = new Estado();
                est.Nombre = "libre";
                dr.Estado = est; //cambiar
                dr.Sector = (Sector)cbSector.SelectedItem;
                dr.Fecha_reserva = dtpFecha.Value;
                dr.Hora_desde = gr.Obtener_Horario(txtDesde.Text);
                dr.Hora_hasta = gr.Obtener_Horario(txtHasta.Text);

                gr.reserva.Detalle.Add(dr);
              
            }

        }

        private void dgvHorario_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }



       

        private void ReservaTorneo_Load(object sender, EventArgs e)
        {
            //if (txtDeporte.Text == "Tenis Federado")
            //    txtTipoSector.Text = "Cancha de Tenis";


            for (int i = 1; i < gr.lista_horarios.Count; i++)
            {
                dgvHorario.Rows.Add(gr.lista_horarios[i - 1].Hora + ":" + gr.lista_horarios[i - 1].Minuto + " - " + gr.lista_horarios[i].Hora + ":" + gr.lista_horarios[i].Minuto);
                dgvHorario.Rows[i - 1].Height = 14;
            }
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
            dgvHorario.Columns[1].HeaderText = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedDayName(dtpFecha.Value.DayOfWeek).ToString() + " " + dtpFecha.Value.Date.ToString("dd/MM/yyyy");
            dgvHorario.Columns[0].DefaultCellStyle.BackColor = Color.FromArgb(255, 4, 110, 140);
            dgvHorario.Columns[0].DefaultCellStyle.ForeColor = Color.White;
            dgvHorario.Columns[1].DefaultCellStyle.ForeColor = Color.White;
            dgvHorario.Columns[0].DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 4, 110, 140);

            switch (tipo)
            {
                case 1:
                    dgvHorario.Columns[1].DefaultCellStyle.SelectionBackColor = Color.Green;
                    break;
                case 3:
                    dgvHorario.Columns[1].DefaultCellStyle.SelectionBackColor = Color.Blue;
                    break;
            }
            dgvHorario.ClearSelection();

            //cbLugar.SelectedIndexChanged += new EventHandler(cbLugar_SelectedIndexChanged);
            //cbTipoSector.SelectedIndexChanged += new EventHandler(cbTipoSector_SelectedIndexChanged);
            //cbSector.SelectedIndexChanged += new EventHandler(cbSector_SelectedIndexChanged);
            Mostrar_Reserva();
        }

        private void dgvHorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHorario_MouseUp(object sender, MouseEventArgs e)
        {
            int p = dgvHorario.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int u = dgvHorario.Rows.GetLastRow(DataGridViewElementStates.Selected);
            int uaux = u;
            if ((u + 1) % 12 == 0)
                uaux = u + 1;

            txtDesde.Text = gr.lista_horarios[p].Hora + ":" + gr.lista_horarios[p].Minuto;
            txtHasta.Text = gr.lista_horarios[uaux].Hora + ":" + gr.lista_horarios[u + 1].Minuto;
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
           
            gr.reserva.Descripcion = "Torneo";
    

            gr.reserva.Fecha_realizacion = DateTime.Now;
            gr.reserva.Tipo_reserva = gr.lista_tipos_reserva[tipo - 1];

        

            for (int i = 0; i < gr.reserva.Detalle.Count; i++)
            {
                gr.reserva.Detalle[i].Item = i + 1;
                gr.reserva.Detalle[i].Reserva = gr.reserva;
            }

            if (gr.Registrar_Reserva(gr.reserva))
            {
                MessageBox.Show("Se Registró correctamente la Reserva");
                Seteo_Reserva();
            }
            else
            {
                MessageBox.Show("No se pudo Registrar la Reserva");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            hayFaseAnterior();
        }

        public void hayFaseAnterior()
        {
            DialogResult res;
            res = MessageBox.Show("¿El torneo tiene una fase anterior?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    //abre una ventana para seleccionar una fase anterior 
                    TieneFaseAnterior form = new TieneFaseAnterior();
                    form.Show();
                    //guardar id de torneo nada mas, haria un update en el torneo elegido. 
                    //form.ShowDialog();//para que bloquee la pantalla nueva y no se pueda modificar la de atras.
                    // Que pasa si no selecciona nada en la pantallaTieneFaseAnterior?
                }
                catch (Exception ex) { }
            }
        }

        

    }
}