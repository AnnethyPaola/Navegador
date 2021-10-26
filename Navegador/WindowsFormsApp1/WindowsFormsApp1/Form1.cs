using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> favoritos = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.do");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.do");
            txtdireccion.Text = "";
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtdireccion.Text);
        }

        private void atras_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void cargar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void delante_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            favoritos.Add(webBrowser1.Url.ToString());
            Actualizar();
        }
        private void Actualizar()
        {
            cmdfav.Items.Clear();
            foreach(string direccion in favoritos)
            {
                cmdfav.Items.Add(direccion);
            }
        }
       
        private void cmdfav_SelectedIndexChanged(object sender, EventArgs e)
        {

            webBrowser1.Navigate(cmdfav.SelectedItem.ToString());
            Actualizar();
        }
       
    }
}
