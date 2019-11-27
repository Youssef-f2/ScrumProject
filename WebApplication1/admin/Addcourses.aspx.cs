using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace WebApplication1.admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public Outille o = new Outille();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_add_Click(object sender, EventArgs e)
        {

        }

        protected void btn_add_Click1(object sender, EventArgs e)
        {
            o.SeConnecter();
            o.cmd = new SqlCommand("insert into Formation (Title, Short_Description, Description, image, Date_debut, Date_fin) values(@t,@sd,@d,@img,@db,@df)", o.cn);
            o.cmd.Parameters.AddWithValue("@t",titletext.Text);
            o.cmd.Parameters.AddWithValue("@sd",shortdescriptiontext.Text);
            o.cmd.Parameters.AddWithValue("@d",Descriptiontext.Text);
            o.cmd.Parameters.AddWithValue("@img",AddPiece());
            o.cmd.Parameters.AddWithValue("@db",dt_debut.Text.ToString());
            o.cmd.Parameters.AddWithValue("@df", dt_fin.Text.ToString());
            int  y =  o.cmd.ExecuteNonQuery();
            if (y > 0)
            {

            }else
            {

            }
            o.SeDeConnecter();
        }

        public string AddPiece()
        {
            string imgSrc = "";
            //try
            //{

                int stat = -1;

                string folderPath = Server.MapPath("~/upload/courses/");

                //Check whether Directory (Folder) exists.
                if (!Directory.Exists(folderPath))
                {
                    //If Directory (Folder) does not exists Create it.
                    Directory.CreateDirectory(folderPath);
                }
                else
                {
                    if (cr_img.HasFile)
                    {
                        string ext = Path.GetExtension(cr_img.FileName);
                        if (ext == ".jpg" || ext == ".png" || ext == ".pdf")
                        {
                            //Save the File to the Directory (Folder).
                            cr_img.SaveAs(folderPath+ titletext.Text.Replace(" ", "-").Replace("/", "-") + Path.GetFileName(cr_img.FileName));
                            imgSrc ="/upload/courses/"+titletext.Text.Replace(" ","-").Replace("/","-")+cr_img.FileName;
                        //update database 
                    }
                    else
                        {

                        }
                    }
                    else
                    {

                    }

                }
            //}
            //catch (Exception er) { imgSrc = ""; }
            return imgSrc;
        }
    }

   
}