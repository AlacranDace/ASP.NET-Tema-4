using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tema4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            anchor1.HRef = "tarea1.aspx";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Botón apretado";
        }

       
    }
}