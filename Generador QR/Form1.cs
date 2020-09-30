using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador_QR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                QRCodeEncoder QREncoder = new QRCodeEncoder();
                pictureBox1.Image = QREncoder.Encode(link.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error generando codigo QR");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "Imagen png|*.png",
                    InitialDirectory = @"C:\Users\Jose A Garcia Osorio\Downloads"
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(sfd.FileName);
                }
            }
            else
            {
                MessageBox.Show("No entrado ningun enlace");
            }
        }

    }
}
