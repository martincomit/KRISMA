using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;
using Entidades;

public partial class Interfaces_InscripcionATorneosCET : System.Web.UI.Page
{
    static int id_torneo;


    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
           

            if (!Page.IsPostBack)
            {
                lblUsuario.Text = Session["usuario"].ToString();
                cmbTipoDeporte.Items.Add("Federado");
                cmbTipoDeporte.Items.Add("Recreativo");
                cmbTipoDeporte.SelectedIndex = 0;

                if (cmbTipoDeporte.Text == "Federado")
                {
                    cargarDeportesTorneo("Federado");
                }
                else
                {
                    cargarDeportesTorneo("Recreativo");
                }

             


            }





        }
        catch (Exception ex) { }


      
    }
    public void cargarDeportesTorneo(string tipo)
    {
        GestorDeporte gp = new GestorDeporte();
        cmbDeportes.DataSource = gp.Consultar(true, tipo).Tables[0];
        cmbDeportes.DataTextField = "Nombre";
        cmbDeportes.DataValueField = "id_deporte";
        cmbDeportes.DataBind();
        cmbDeportes.SelectedIndex = 0;
        try
        {
            int id_deporte = int.Parse(cmbDeportes.SelectedValue.ToString());
            cargarTorneos(id_deporte);
        }
        catch (Exception ex) { }
    }


    public void cargarTorneos(int id_deporte)
    {
   
        GestorTorneo gt = new GestorTorneo();
        cmbTorneos.DataSource = gt.Consultar(id_deporte).Tables[0];
        cmbTorneos.DataTextField = "Nombre";
        cmbTorneos.DataValueField = "id_torneo";
        cmbTorneos.DataBind();
       
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        GestorTorneo gt = new GestorTorneo();
        try
        {
            int id_deporte = int.Parse(cmbDeportes.SelectedValue.ToString());
            lblCaract.Text = gt.Consultar(id_deporte).Tables[0].Rows[0][2].ToString();
            btnBuscar.Enabled = true;
            txtDocumento.Enabled = true;
        }
        catch (Exception ex) { }
        
        try
        {
            int id_deporte = int.Parse(cmbDeportes.SelectedValue.ToString()); 
            id_torneo = int.Parse(cmbTorneos.SelectedValue.ToString());
            int cantidad_inscriptos = int.Parse(gt.ConsultarInscriptos(id_torneo).Tables[0].Rows[0][0].ToString());
            int cupo = int.Parse(gt.ConsultarCupo(id_torneo).Tables[0].Rows[0][0].ToString());
            lblEstado.Text = gt.ConsultarCupo(id_torneo).Tables[0].Rows[0][1].ToString();

            if (cantidad_inscriptos == cupo && lblEstado.Text =="finalizado")
            {
                lblnocupo.Text = "";
                txtDocumento.Enabled = false;
                btnBuscar.Enabled = false;
                btnInscribir.Enabled = false;
                btnAvisar.Visible = false;
                txtMensaje.Visible = false;
            }



            else if (cantidad_inscriptos == cupo)
            {
                lblnocupo.Text = "No hay cupo";
                txtDocumento.Enabled = false;
                btnBuscar.Enabled = false;
                btnInscribir.Enabled = false;
                btnAvisar.Visible = true;
                txtMensaje.Visible = true;
            }
            else
            {
                

                lblnocupo.Text = "";
                txtDocumento.Enabled = true;
                btnBuscar.Enabled = true;
                btnAvisar.Visible = false;
                txtMensaje.Visible = false;

            }

            lblInscriptos.Text = cantidad_inscriptos+ " de " + cupo;

        }
        catch (Exception ex) { }
    }
    protected void btnBuscar_Click(object sender, EventArgs e)
    {
       
            if (txtDocumento.Text != "")
            {
                int documento = int.Parse(txtDocumento.Text);
                int id_deporte = int.Parse(cmbDeportes.SelectedValue.ToString());

                GestorDeportista gde = new GestorDeportista();
                try
                {
                    lblDatosDeportista.Text = "";
                    lblDatosDeportista.Text = gde.ConsultarDeportista(documento, id_deporte).Tables[0].Rows[0][3].ToString() + "," + gde.ConsultarDeportista(documento, id_deporte).Tables[0].Rows[0][4].ToString();
                    btnInscribir.Enabled = true;
                }
                catch (Exception ex) 
                { 
                    lblDatosDeportista.Text = " No esta inscripto al deporte";
                    btnInscribir.Enabled = false;
                }
               
               
              
            }
        
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        GestorTorneo gt = new GestorTorneo();
        try
        {
            int docu = int.Parse(txtDocumento.Text);
            lblGuardado.Text= gt.registrarParticipante(docu, id_torneo);
            
        }
        catch (Exception ex) { lblGuardado.Text = "Error al guardar"; }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
    protected void cmbTipoDeporte_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cmbTipoDeporte.Text == "Federado")
        {
            cargarDeportesTorneo("Federado");
        }
        else
        {
            cargarDeportesTorneo("Recreativo");
        }
    }
    protected void cmbDeportes_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            int id_deporte = int.Parse(cmbDeportes.SelectedValue.ToString());
            cargarTorneos(id_deporte);
        }
        catch (Exception ex) { }
    }
    protected void cmbDeportes_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void btnAvisar_Click(object sender, EventArgs e)
    {
        if (txtMensaje.Text == "")
            lblMensaje.Text = "Ingrese mensaje no nulo";
        else
        {
            try
            {
                string mensaje = txtMensaje.Text;
                GestorMensaje gm = new GestorMensaje();
                gm.EnviarMensajeTorneo(id_torneo, mensaje);
                lblMensaje.Text = "Mensaje Enviado";
                btnAvisar.Enabled = false;
            }
            catch (Exception ex) { lblMensaje.Text = "Error al enviar"; }
        }
    }
}