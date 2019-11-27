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
    public partial class WebForm4 : System.Web.UI.Page
    {
        public Outille o = new Outille();
        string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["id"];
            if (!Page.IsPostBack)
            {
               
                o.edit(int.Parse(id));



                DateTime datedebut = (DateTime)o.ds.Tables["edit"].Rows[0][5];
                DateTime datefin = (DateTime)o.ds.Tables["edit"].Rows[0][6];






                titletext.Text = o.ds.Tables["edit"].Rows[0][1].ToString();
                shortdescriptiontext.Text = o.ds.Tables["edit"].Rows[0][2].ToString();
                Descriptiontext.Text = o.ds.Tables["edit"].Rows[0][3].ToString();
                dt_debut.Text = datedebut.ToString("yyyy-MM-dd");
                dt_fin.Text = datefin.ToString("yyyy-MM-dd");
            }

        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            o.SeConnecter();
           
            
            if (cr_img.HasFile)
            {
                o.cmd = new SqlCommand("Update Formation set [Title]=@t, [Short_Description]=@sd, [Description]=@d, [image]=@img, [Date_debut]=@db, [Date_fin]=@df where [Id]=" + id, o.cn);
                o.cmd.Parameters.AddWithValue("@img", AddPiece());
            }else
            {
                //Response.Write("<script>alert('hello world')</script>");
                o.cmd = new SqlCommand("Update Formation set [Title]=@t, [Short_Description]=@sd, [Description]=@d, [Date_debut]=@db, [Date_fin]=@df where [Id]=@id", o.cn);

            }
            o.cmd.Parameters.AddWithValue("@t", titletext.Text);
            o.cmd.Parameters.AddWithValue("@id", id);
            o.cmd.Parameters.AddWithValue("@sd", shortdescriptiontext.Text);
            o.cmd.Parameters.AddWithValue("@d", Descriptiontext.Text);
            o.cmd.Parameters.AddWithValue("@db", dt_debut.Text.ToString());
            o.cmd.Parameters.AddWithValue("@df", dt_fin.Text.ToString());
            int y = o.cmd.ExecuteNonQuery();
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
                        cr_img.SaveAs(folderPath + titletext.Text.Replace(" ", "-").Replace("/", "-").Replace("+","-") + Path.GetFileName(cr_img.FileName));
                        imgSrc = "/upload/courses/" + titletext.Text.Replace(" ", "-").Replace("/", "-").Replace("+", "-") + cr_img.FileName;
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