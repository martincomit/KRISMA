using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Logica;

public partial class Web_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {        
             
    }
    protected void btnIniciar_Click(object sender, EventArgs e)
    {
        Master.FindControl("btnIniciarSesion").Visible = false;
        Master.FindControl("btnCerrarSesion").Visible = true;
        
        
    }
    protected void LoginButton_Click(object sender, EventArgs e)
    {

        if (global.master == 1)
        {
            DataSet ds = new DataSet();
            String sql = "";
            sql = "select * from UsuariosXPerfiles where documento='" + txtUsuario.Text + "' and pass='" + txtPass.Text + "' and id_perfil =5";
            String con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection cx = new SqlConnection(con);
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "UsuariosXPerfiles");
            try
            {
                string test = ds.Tables[0].Rows[0][0].ToString();
                Session["documento"] = ds.Tables[0].Rows[0][0].ToString(); ;

                Response.Redirect("~/Interfaces/AutoGestion.aspx");

            }


            catch (Exception ex)
            {
                txtUsuario.Text = "";
                txtPass.Text = "";
                lblIncorrecto.Visible = true;
            }

        }


        if (global.master == 2)
        {
            DataSet ds = new DataSet();
            String sql = "";
            sql = "select * from UsuariosXPerfiles where documento='" + txtUsuario.Text + "' and pass='" + txtPass.Text + "' and id_perfil =5";
            String con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection cx = new SqlConnection(con);
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "UsuariosXPerfiles");
            try
            {
                string test = ds.Tables[0].Rows[0][0].ToString();
                Session["documento"] = ds.Tables[0].Rows[0][0].ToString(); ;

                Response.Redirect("~/Interfaces/Estados.aspx");

            }


            catch (Exception ex)
            {
                txtUsuario.Text = "";
                txtPass.Text = "";
                lblIncorrecto.Visible = true;
            }

        }

        if (global.master == 3)
        {
            DataSet ds = new DataSet();
            String sql = "";
            sql = "select * from UsuariosXPerfiles where documento='" + txtUsuario.Text + "' and pass='" + txtPass.Text + "' and id_perfil =5";
            String con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection cx = new SqlConnection(con);
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "UsuariosXPerfiles");
            try
            {
                string test = ds.Tables[0].Rows[0][0].ToString();
                Session["documento"] = ds.Tables[0].Rows[0][0].ToString(); ;

                Response.Redirect("~/Interfaces/Eventos.aspx");

            }


            catch (Exception ex)
            {
                txtUsuario.Text = "";
                txtPass.Text = "";
                lblIncorrecto.Visible = true;
            }

        }


        if (global.master == 4)
        {
            DataSet ds = new DataSet();
            String sql = "";
            sql = "select * from UsuariosXPerfiles where documento='" + txtUsuario.Text + "' and pass='" + txtPass.Text + "' and id_perfil =5";
            String con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection cx = new SqlConnection(con);
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "UsuariosXPerfiles");
            try
            {
                string test = ds.Tables[0].Rows[0][0].ToString();
                Session["documento"] = ds.Tables[0].Rows[0][0].ToString(); ;

                Response.Redirect("~/Interfaces/InscripcionATorneosCET.aspx");

            }


            catch (Exception ex)
            {
                txtUsuario.Text = "";
                txtPass.Text = "";
                lblIncorrecto.Visible = true;
            }

        }

        if (global.master == 5)
        {
            DataSet ds = new DataSet();
            String sql = "";
            sql = "select * from UsuariosXPerfiles where documento='" + txtUsuario.Text + "' and pass='" + txtPass.Text + "' and id_perfil =5";
            String con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection cx = new SqlConnection(con);
            SqlDataAdapter da = new SqlDataAdapter(sql, cx);
            da.Fill(ds, "UsuariosXPerfiles");
            try
            {
                string test = ds.Tables[0].Rows[0][0].ToString();
                Session["documento"] = ds.Tables[0].Rows[0][0].ToString(); ;

                Response.Redirect("~/Interfaces/InscripcionATorneosCET.aspx");

            }


            catch (Exception ex)
            {
                txtUsuario.Text = "";
                txtPass.Text = "";
                lblIncorrecto.Visible = true;
            }

        }

            //DataSet ds2 = new DataSet();
            //string sql2 = "";
            //sql2 = "select * from UsuariosXPerfiles where documento='" + txtUsuario.Text + "' and pass='" + txtPass.Text + "' and id_perfil =6"; //para profes
            //SqlDataAdapter da2 = new SqlDataAdapter(sql2, cx);
            //da2.Fill(ds2, "UsuariosXPerfiles");
            //try
            //{
            //    string test = ds2.Tables[0].Rows[0][0].ToString();
            //    Session["usuario"] = test;
            //    Response.Redirect(Request.ApplicationPath + "/Interfaces/AutoGestionProfe.aspx");
            //}
            //catch (Exception exs)
            //{


            //    DataSet ds3 = new DataSet();
            //    string sql3 = "";
            //    sql3 = "select * from UsuariosXPerfiles where documento='" + txtUsuario.Text + "' and pass='" + txtPass.Text + "' and id_perfil =9"; //para profes
            //    SqlDataAdapter da3 = new SqlDataAdapter(sql3, cx);
            //    da3.Fill(ds3, "UsuariosXPerfiles");
            //    try
            //    {
            //        string test = ds3.Tables[0].Rows[0][0].ToString();
            //        Session["usuario"] = test;

            //        Response.Redirect(Request.ApplicationPath + "/Interfaces/InscripcionATorneosCET.aspx");
            //    }



            //    catch (Exception ex3)
            //    {


            //        lblIncorrecto.Visible = true;
            //        lblIncorrecto.Text = "Usuario o Pass Incorrecto";
            //        txtUsuario.Text = "";
            //        txtPass.Text = "";
            //    }
            //}
    





           
        
           
    }
}