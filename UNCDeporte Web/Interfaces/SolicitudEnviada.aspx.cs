using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

public partial class Web_SolicitudEnviada : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        lblDoc.Text = Session["Documento"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        global.sesion = true;
        Response.Redirect("Estados.aspx");
       
    }
}