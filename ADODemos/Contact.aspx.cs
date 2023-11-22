using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace ADODemos
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = WebConfigurationManager.ConnectionStrings["adodemoConnectionString"].ConnectionString;

            SqlConnection con  = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("Select * from Products", con);

            con.Open();

            GridView1.DataSource = cmd.ExecuteReader();

            GridView1.DataBind();

        }
    }
}