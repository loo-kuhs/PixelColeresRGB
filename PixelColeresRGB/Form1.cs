using System;
using IAupt.uptRNA;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelColeresRGB
{
    public partial class Form1 : Form
    {
        List<String> colores = new List<string> { "Fuera de la imagen",
        "Verde", "Azul claro", "Azul fuerte", "Rosa", "Rojo", "Amarillo",
        "Verde/Amarillo", "Verde/Azul claro" };

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap imagen = new Bitmap(pictureBox1.Image);

            txtRojo.Text = imagen.GetPixel(e.X, e.Y).R.ToString();
            txtVerde.Text = imagen.GetPixel(e.X, e.Y).G.ToString();
            txtAzul.Text = imagen.GetPixel(e.X, e.Y).B.ToString();

            PerceptronMultiCapa rna = new PerceptronMultiCapa(@"ejemplo.ppm");

            double[] x = { imagen.GetPixel(e.X, e.Y).R, imagen.GetPixel(e.X, e.Y).G, imagen.GetPixel(e.X, e.Y).B };
            rna.reconocer(x);

            double[,] y = rna.y;

            MessageBox.Show("El color es " + colores[(int)Math.Round(y[0, 0], 0)]);
        }
    }
}
