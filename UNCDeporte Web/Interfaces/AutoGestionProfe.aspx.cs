using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

public partial class Interfaces_AutoGestionProfe : System.Web.UI.Page
{
    static int id_deporte;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            lblUsuario.Text = Session["usuario"].ToString();
            if (!Page.IsPostBack)
                cargarComboDeportes();


        }
        catch (Exception ex) { }

        Calendar1.SelectedDate = DateTime.Today.Date.Date;
    }

    public void cargarComboDeportes()
    {
        string documento_profesor = lblUsuario.Text;
        GestorDeportista gd = new GestorDeportista();
        ddlDeportes.DataSource = gd.ConsultarDeportesProfe(documento_profesor).Tables[0];
        ddlDeportes.DataValueField = "id_deporte";
        ddlDeportes.DataTextField = "nombre";
        ddlDeportes.DataBind();
    }




    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtMensaje.Text == "")
            lblMensaje.Text = "Ingrese mensaje no nulo";
        else
        {
            try
            {
                string mensaje = txtMensaje.Text;
                GestorMensaje gm = new GestorMensaje();
                gm.EnviarMensaje(id_deporte, mensaje);
                lblMensaje.Text = "Mensaje Enviado";
                btnMensaje.Enabled = false;
            }
            catch (Exception ex) { lblMensaje.Text = "Error al enviar"; }
        }
    }
    protected void ddlDeportes_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnSeleccionar_Click(object sender, EventArgs e)
    {
        btnMensaje.Enabled = true;
        txtMensaje.Text = "";
        try
        {
            id_deporte = int.Parse(ddlDeportes.SelectedValue.ToString());
            GestorDeportista gd = new GestorDeportista();
            gvDeportistas.DataSource = gd.ConsultarDeportistasPorDeporte(id_deporte);
            gvDeportistas.DataBind();
            lblObs.Visible = true;
            btnEnviarObs.Visible = true;
            txtObservacion.Visible = true;
        }
        catch (Exception ex) { }

        lblHorario.Text = "";
        lblHorarios.Visible = true;
        lblHorario.Visible = true;

        GestorPrograma gp = new GestorPrograma();
        try
        {
            int id_deporte = int.Parse(ddlDeportes.SelectedValue.ToString());

            int cantidad_filas = gp.ConsultarHorariosPrograma(id_deporte).Tables[0].Rows.Count;

            for (int i = 0; i < cantidad_filas; i++)
            {
                lblHorario.Text = lblHorario.Text + " " + gp.ConsultarHorariosPrograma(id_deporte).Tables[0].Rows[i][0].ToString() + " " + gp.ConsultarHorariosPrograma(id_deporte).Tables[0].Rows[i][1].ToString() + " " + gp.ConsultarHorariosPrograma(id_deporte).Tables[0].Rows[i][2].ToString() + "\t";
                lblSectores.Visible = true;
                lblSectores.Text = gp.ConsultarHorariosPrograma(id_deporte).Tables[0].Rows[i][3].ToString() + " " + gp.ConsultarHorariosPrograma(id_deporte).Tables[0].Rows[i][4].ToString() + " " + gp.ConsultarHorariosPrograma(id_deporte).Tables[0].Rows[i][5].ToString();
            }
        }
        catch (Exception ex) { }
    }
    protected void Logout_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Interfaces/Login.aspx");    
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        GestorMensaje gm = new GestorMensaje();
    

            gvMensajes.DataSource = gm.ConsultarMensajes(id_deporte);
            gvMensajes.DataBind();
 

    }
    protected void gvMensajes_SelectedIndexChanged(object sender, EventArgs e)
    {


    }
    protected void gvMensajes_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

       
    }
    protected void gvMensajes_RowDeleting1(object sender, GridViewDeleteEventArgs e)
    {
      
    }
    protected void gvMensajes_SelectedIndexChanged1(object sender, EventArgs e)
    {
   
    }
    protected void gvMensajes_SelectedIndexChanged2(object sender, EventArgs e)
    {
        try
        {
            GridViewRow fila = gvMensajes.SelectedRow;
            int id_mensaje = int.Parse(fila.Cells[1].Text);

            GestorMensaje gm = new GestorMensaje();
            gm.EliminarMensaje(id_mensaje);

            //consulto luego de eliminar para refrescar la grilla
           
            gvMensajes.DataSource = gm.ConsultarMensajes(id_deporte);
            gvMensajes.DataBind();


        }
        catch (Exception ex) { }
    }
    protected void gvDeportistas_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}