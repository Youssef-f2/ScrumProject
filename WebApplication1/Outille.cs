using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public class Outille
    {
        public SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-O003TP9N\SQLEXPRESS;initial Catalog=Base;integrated Security=true");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        SqlDataAdapter adapter;
        public DataSet ds = new DataSet();
        public DataTable dt = new DataTable();

        public void SeConnecter()
        {
            if (cn.State != ConnectionState.Open || cn.State == ConnectionState.Broken)
            {
                cn.Open();
            }
        }

        public void SeDeConnecter()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }
        public bool VerifierConnexion(string log ,string mdp)
        {
            SeConnecter();
            cmd = new SqlCommand("Select * from Authentification where Log_in='" + log + "' and mdp ='"+mdp+"'", cn);
            dr=cmd.ExecuteReader();
            dt.Load(dr);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void getALlCourse()
        {
            SeConnecter();
            if (ds.Tables["allcourses"] != null)
            {
                ds.Tables["allcourses"].Clear();
            }

            adapter = new SqlDataAdapter("select * from Formation",cn);
            adapter.Fill(ds,"allcourses");
            
        }
        public bool VerifierInscription(string log)
        {
            SeConnecter();
            cmd = new SqlCommand("Select * from Authentification where Log_in='" + log + "'", cn);
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool delete(int id)
        {
            bool doi = false;
            SeConnecter();
            cmd.Parameters.Clear();
            cmd.Connection = cn;
            cmd.CommandText = "delete from Formation where id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            int y = cmd.ExecuteNonQuery();
            SeDeConnecter();
            if (y > 0)
                doi = true;
            else
                doi = false;
            return doi;
        }

        public void edit(int id)
        {
            SeConnecter();
            if (ds.Tables["edit"] != null)
            {
                ds.Tables["edit"].Clear();
            }
            adapter = new SqlDataAdapter("select * from Formation where id = " + id, cn);
            adapter.Fill(ds, "edit");
            SeDeConnecter();
        }
        public void admin(string login)
        {
            SeConnecter();
            if (ds.Tables["admin"] != null)
            {
                ds.Tables["admin"].Clear();
            }
            adapter = new SqlDataAdapter("select * from Authentification where Log_in ='"+login+"'", cn);
            adapter.Fill(ds,"admin");
            SeDeConnecter();
        }
    }
}
