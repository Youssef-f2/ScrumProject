using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Home : System.Web.UI.Page
    {
      public  Outille ou = new Outille();

        public void middlwareAuth()
        {
            if (Session["logged"].ToString().Equals(""))
            {
                Response.Redirect("~/Connexion");
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            middlwareAuth();
            ou.getALlCourse();
        }
    }
}