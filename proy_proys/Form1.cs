using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proy_proys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        metodos_BD metodos = new metodos_BD();
        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            //boton cerrar
            Environment.Exit(0);
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            //boton minimizar
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string cadenaEncriptada = Encriptar.GetMD5(txb_pass.Text.Trim());

            MessageBox.Show(metodos.Autentificar(txb_usuario.Text.Trim(), cadenaEncriptada));
                 
            
        }

        private void txb_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txb_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }
    }
}
