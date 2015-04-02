using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Logica;

public partial class Web_Canchas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    
      txtDocumento.Text = Session["Documento"].ToString();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
     
        GestorDeportista gd = new GestorDeportista();
        int documento = int.Parse(txtDocumento.Text);
        try{
            txtEstudios.Text = gd.Consultar(documento).Tables[0].Rows[0][0].ToString();

            if (txtEstudios.Text == "inscripto federado" || txtEstudios.Text == "inscripto recreativas")
            { txtEstudios.Text = "Inscripto"; }


            if (txtEstudios.Text == "creada")
            {
                txtEstudios.Text = "Por asignar";
                lblaviso.Text = "Acercarse a la direccion de deportes para su asignacion";
            }
            else { lblaviso.Text = ""; }
            //lblExiste.Text = "";
            int id_estado = int.Parse(gd.Consultar(documento).Tables[0].Rows[0][1].ToString());
            if (id_estado == 8 || id_estado == 9)
                txtUsuario.Text = txtDocumento.Text;
            else
                txtUsuario.Text = "";
        }
       
            //    txtEstudios.Text = "";
            //    txtUsuario.Text = "";
            //}

            //if (gd.Consultar(documento).Tables[0].Rows[0][17].ToString() == "4")
            //{
            //    txtLaboratorio.Text = "Asignado";
            //    txtUsuario.Text = documento + "";
            //}
            //else
            //{
            //    txtLaboratorio.Text = "Sin Asignar";
            //    txtUsuario.Text = "";

            //}
            //lblExiste.Text = "";

        //}

        catch (Exception ex) 
        { 
        //lblExiste.Text = "No Existe";
        txtEstudios.Text = "";
        txtUsuario.Text = "";
        lblaviso.Text = "";
        }
      
    }
}