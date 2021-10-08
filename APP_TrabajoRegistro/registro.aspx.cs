using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APP_TrabajoRegistro
{
    public partial class registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void fnt_registro(String i, String n, String c, String ema)
        {
            ClsControlador objRegistro = new ClsControlador(i, n, c, ema);
            lblMensaje.Text = objRegistro.getMensaje();
        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            fnt_registro(txtId.Text, txtNombre.Text, txtContacto.Text, txtCorreo.Text);
        }
    }
}