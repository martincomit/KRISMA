using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Logica;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            lblUsuario.Text = Session["documento"].ToString();
            if (!Page.IsPostBack)
                cargarComboDeportes();
            
            
        }
        catch (Exception ex) { Response.Redirect("~/Interfaces/Login.aspx"); }

        Calendar1.SelectedDate = DateTime.Today.Date.Date;
    }
    protected void ddlDeportes_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    public void cargarComboDeportes()
    {
        string documento_deportista = lblUsuario.Text;
        GestorDeportista gd = new GestorDeportista();
        ddlDeportes.DataSource = gd.ConsultarDeportes(documento_deportista).Tables[0];
        ddlDeportes.DataValueField = "id_deporte";
        ddlDeportes.DataTextField = "nombre";
        ddlDeportes.DataBind();
    }


    protected void btnSeleccionar_Click(object sender, EventArgs e)
    {
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


            lstMensajes.Items.Clear();

            GestorMensaje gm = new GestorMensaje();
          
            int cant_filas_mensajes = gm.ConsultarMensajes(id_deporte).Tables[0].Rows.Count;


            for (int i = 0; i < cant_filas_mensajes; i++)
            {

                lstMensajes.Items.Add(gm.ConsultarMensajes(id_deporte).Tables[0].Rows[i][1].ToString() + "," + gm.ConsultarMensajes(id_deporte).Tables[0].Rows[i][2].ToString());
            }

            GestorTorneo gt = new GestorTorneo();
            gvTorneos.DataSource = gt.Consultar(id_deporte);
            gvTorneos.DataBind();

        }
        catch (Exception ex) { }



    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Interfaces/Login.aspx");    
    }
}
