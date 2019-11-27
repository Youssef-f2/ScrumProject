using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.admin
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        public  Outille ou = new Outille();
        protected void Page_Load(object sender, EventArgs e)
        {
            ou.getALlCourse();
        }

        protected void btn_modifier_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("Modifycourses.aspx");

        }
    }
}