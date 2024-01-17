using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kifestooo
{
    public partial class Form1 : Form
    {
        int R;
        int G;
        int B;
        Color fekete = Color.FromArgb(0, 0, 0);
        Color ujSzin;
        Bitmap eredeti;
        Point akt = new Point();
        // FIFO ( sor )
        // FILO ( stack )
        Queue<Point> fest = new Queue<Point>();



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string utvonal = openFileDialog1.FileName;
                eredeti = (Bitmap)Image.FromFile(utvonal);
                pictureBox1.Image = eredeti;
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int seged = (int)e.NewValue;
            textBox1.Text = seged.ToString();
            R = seged;
            label1.BackColor = Color.FromArgb(R, G, B);
        }
        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            int seged = (int)e.NewValue;
            textBox2.Text = seged.ToString();
            G = seged;
            label1.BackColor = Color.FromArgb(R, G, B);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            int seged = (int)e.NewValue;
            textBox3.Text = seged.ToString();
            B = seged;
            label1.BackColor = Color.FromArgb(R, G, B);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void festes(Queue<Point> fest)
        {
            Point seged = new Point();
            Point be = new Point();
            //While
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Color minta = eredeti.GetPixel(e.X, e.Y);
            if (minta != fekete)
            {
                akt.X = e.X; akt.Y = e.Y;
                fest.Enqueue(akt);
                festes(fest);
            }
        }
    }
}
