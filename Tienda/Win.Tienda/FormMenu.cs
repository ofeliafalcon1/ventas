using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win.Rentas;

namespace Win.Tienda
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();

            if (Program.UsuarioLogueado != null)
            {
                toolStripStatusLabel1.Text = "Usuario: "
                    + Program.UsuarioLogueado.Nombre;

                if (Program.UsuarioLogueado.TipoUsuario == "Usuarios caja")
                {
                    articulosToolStripMenuItem.Visible = false;
                    clientesToolStripMenuItem.Visible = false;
                    tiendaToolStripMenuItem.Visible = true;
                    facturaToolStripMenuItem.Visible = true;
                    administraciónDeUsuariosToolStripMenuItem.Visible = false;
                    reporteDeProductosToolStripMenuItem.Visible = false;
                    reportesDeClientesToolStripMenuItem.Visible = false;
                    reportesDeVentasToolStripMenuItem.Visible = true;
                    reporteDeFacturasToolStripMenuItem.Visible = true;
                }

                if (Program.UsuarioLogueado.TipoUsuario == "Usuarios Ventas")
                {
                    articulosToolStripMenuItem.Visible = false;
                    clientesToolStripMenuItem.Visible = true;
                    tiendaToolStripMenuItem.Visible = false;
                    facturaToolStripMenuItem.Visible = false;
                    administraciónDeUsuariosToolStripMenuItem.Visible = false;
                    reporteDeProductosToolStripMenuItem.Visible = false;
                    reportesDeClientesToolStripMenuItem.Visible = true;
                    reportesDeVentasToolStripMenuItem.Visible = false;
                    reporteDeFacturasToolStripMenuItem.Visible = false;
                }

                if (Program.UsuarioLogueado.TipoUsuario == "Administradores")
                {
                    articulosToolStripMenuItem.Visible = true;
                    clientesToolStripMenuItem.Visible = true;
                    tiendaToolStripMenuItem.Visible = true;
                    facturaToolStripMenuItem.Visible = true;
                    administraciónDeUsuariosToolStripMenuItem.Visible = true;
                    reporteDeProductosToolStripMenuItem.Visible = true;
                    reportesDeClientesToolStripMenuItem.Visible = true;
                    reportesDeVentasToolStripMenuItem.Visible = true;
                    reporteDeFacturasToolStripMenuItem.Visible = true;
                }

            }
            else
            {
                Application.Exit();
            }
        }

       
        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formArticulos = new FormProductos();
            formArticulos.MdiParent = this;
            formArticulos.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes();
            formClientes.MdiParent = this;
            formClientes.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormFactura();
            formFactura.MdiParent = this;
            formFactura.Show();
        }

        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteProductos = new FormReporteProductos();
            formReporteProductos.MdiParent = this;
            formReporteProductos.Show();
        }

        private void reporteDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteFacturas = new formReporteFacturas();
            formReporteFacturas.MdiParent = this;
            formReporteFacturas.Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administraciónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormUsuarios();
            form.MdiParent = this;
            form.Show();
        }
    }
}
