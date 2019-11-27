using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.admin
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public void middlwareAuth()
        {
            if (Session["logged"].ToString()=="")
            {
                Response.Redirect("~/Connexion");
            }else
            {
                if (Session["prev"].ToString() == "admin")
                {
                    
                }
                else if(Session["prev"].ToString() == "user")
                {
                    Response.Redirect("~/home");
                }
                else
                {
                    Response.Redirect("~/Connexion");
                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            middlwareAuth();
        }
    }
}