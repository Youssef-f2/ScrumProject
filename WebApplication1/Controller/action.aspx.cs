using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Controller
{
    public partial class action : System.Web.UI.Page
    {
        public Outille t = new Outille();
        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Request.QueryString["do"];
            string id = Request.QueryString["id"];
           

            switch (action)
            {
                case "delete":
                    if (t.delete(int.Parse(id)))
                    {
                        Response.Redirect("~/admin/all-courses.aspx");
                        // popup deleted success
                    }
                    else
                    {
                        // popup deleted failed
                    }
                    break;
                case "disconnect":
                    Session.Abandon();
                    Response.Redirect("~/Connexion");
                    break;
                default:
                    Response.Redirect("~/admin/all-courses.aspx");
                    break;

            }
        }
    }
}