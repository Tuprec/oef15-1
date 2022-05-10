using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oef15_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                Response.Write("Je hebt reeds op VERSTUUR geklikt!");
            else
                Response.Write("Klik op VERSTUUR om te versturen!");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}