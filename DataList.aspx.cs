using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tema4
{
    public partial class DataList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("id");
            table.Columns.Add("Nombre");
            table.Columns.Add("Correo");
            table.Rows.Add("1", "Paco Gomez", "gomez@example.com");
            table.Rows.Add("2", "Juanmi Arbeola", "arbeola@example.com");
            table.Rows.Add("3", "Esther Buendia", "buendia@example.com");
            table.Rows.Add("4", "Lucía Arnal", "arnal@example.com");
            DataList1.DataSource = table;
            DataList1.DataBind();
        }
    }
}