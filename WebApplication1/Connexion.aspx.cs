using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class Connexion1 : System.Web.UI.Page
    {
        Outille o = new Outille();

        public void middlwareAuth()
        {
            
           
                if (Session["logged"].ToString() != "")
                {
                    Response.Redirect("~/admin/all-courses");
                }
                else
                {
                    Session.Abandon();
                }
            
            

            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                
                middlwareAuth();
                HttpCookie c = Request.Cookies["cok"];
                if (c != null)
                {

                    login.Text = c["Login"];
                    mdpstext.Text = c["Pass"];
                }
            }
        }

        protected void btn_SeConnecter_Click(object sender, EventArgs e)
        {
            o.admin(login.Text);
            HttpCookie c = new HttpCookie("cok");
            if (o.VerifierConnexion(login.Text.ToString(), mdpstext.Text.ToString()) == true)
            {
                o.SeDeConnecter();
                if (accept_arg.Checked == true)
                {
                    c["Login"] = login.Text;
                    c["Pass"] = mdpstext.Text;
                    c.Expires = DateTime.Now.AddMinutes(1);
                    Response.Cookies.Add(c);
                }
                else
                {
                    c.Expires = DateTime.Now.AddMinutes(-1);
                }
                 Session["logged"] = "true";
                Session["fullname"] = login.Text.ToUpper();
                if (o.ds.Tables["admin"].Rows[0][5].ToString() == "1")
                {
                    Session["prev"] = "admin";
                    Response.Redirect(ResolveUrl("~/admin/Addcourses"));
                }else
                {
                    Session["prev"] = "user";
                    Response.Redirect(ResolveUrl("/home.aspx"));
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "randomtext", "pass()", true);
            }


        }
    }
}