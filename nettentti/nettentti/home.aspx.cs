using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nettentti
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DataSet ds = new DataSet())
            {
                ds.ReadXml(Server.MapPath("~/kirjanpito.xml"));
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }

        }
    }
}