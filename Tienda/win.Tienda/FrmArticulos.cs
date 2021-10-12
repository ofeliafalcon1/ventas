using BLTienda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win.Tienda
{
    public partial class FrmArticulos : Form
    {
        /*Agregamos la variable de productos*/
        ProductosBL _productos;

        public FrmArticulos()
        {
            InitializeComponent();

            /*Inicializamos la variable de productos en nuestro constructor*/
            _productos = new ProductosBL();
            listaProductosBindingSource.DataSource = _productos.ObtenerProductos();//Enlaza y retorna a ProductosBL
        }
    }
}
