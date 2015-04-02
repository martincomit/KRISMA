using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


public partial class mp : System.Web.UI.MasterPage
{            
    protected void Page_Load(object sender, EventArgs e)
    {
                
        if (!Page.IsPostBack)
        {
            btnIniciarSesion.Attributes.Add("class", "s1");
            lblSesion.Attributes.Add("class","s2");
            btnCerrarSesion.Attributes.Add("class", "s3");
            btnCerrarSesion.Visible = false;
            btnPrincipal.Attributes.Add("class", "m");
        }
        
    }
    protected void btnIniciarSesion_Click(object sender, EventArgs e)
    {
       
        Logica.global.master = 1;
        Response.Redirect("~/Interfaces/Login.aspx");
    }

    protected void btnCerrarSesion_Click(object sender, EventArgs e)
    {
        // Cerrar la sesion
    }

    protected void btnPrincipal_Click(object sender, EventArgs e)
    {
        try
        {

            string usuario = Session["usuario"].ToString();
            Response.Redirect("~/Interfaces/AutoGestion.aspx");      

        }
        catch (Exception ex)
        {
            Logica.global.master = 1;
            Response.Redirect("~/Interfaces/Login.aspx");


        }
          
    }

    protected void btnEventos_Click(object sender, EventArgs e)
    {
        
        


        try
        {

            string usuario = Session["usuario"].ToString();
            Response.Redirect("~/Interfaces/InscripcionATorneosCET.aspx");

        }
        catch (Exception ex)
        {
            Logica.global.master = 3;//selecciono eventos
            Response.Redirect("~/Interfaces/Login.aspx");


        }


    }

    protected void btnTorneos_Click(object sender, EventArgs e)
    {




        try
        {

            string usuario = Session["usuario"].ToString();
            Response.Redirect("~/Interfaces/InscripcionATorneosCET.aspx");

        }
        catch (Exception ex)
        {
            Logica.global.master = 4;//
            Response.Redirect("~/Interfaces/Login.aspx");


        }


    }


    protected void btnCet_Click(object sender, EventArgs e)
    {




        try
        {

            string usuario = Session["usuario"].ToString();
            Response.Redirect("~/Interfaces/InscripcionATorneosCET.aspx");

        }
        catch (Exception ex)
        {
            Logica.global.master = 5;//
            Response.Redirect("~/Interfaces/Login.aspx");


        }


    }

    protected void btnCanchas_Click(object sender, EventArgs e)
    {
        try
        {
            
            string usuario = Session["usuario"].ToString();
            Response.Redirect("~/Interfaces/Estados.aspx");
            
        }
        catch (Exception ex) {
            Logica.global.master = 2; //selecciono estado.
            Response.Redirect("~/Interfaces/Login.aspx");
            
        
        }


     
    }

    protected void btnCarnet_Click1(object sender, EventArgs e)
    {
        Response.Redirect("~/Interfaces/SolicitarPreinscripcion.aspx");
    }
}
