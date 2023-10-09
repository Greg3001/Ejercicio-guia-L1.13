using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Cliente2
{
    public partial class Form2 : Form
    {
        int nForm;
        Socket server;
        public Form2(int nForm, Socket server)
        {
            InitializeComponent();
            this.nForm = nForm;
            this.server = server;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numForm.Text = nForm.ToString();
        }

        public void TomaRespuesta1(string mensaje)
        {
            MessageBox.Show("Temperatura: " + mensaje + "ºF");
        }
        public void TomaRespuesta2(string mensaje)
        {
            MessageBox.Show("Temepratura: " + mensaje + "ºC");
        }

        private void enviar1_Click(object sender, EventArgs e)
        {
            string mensaje = "1/" + nForm + "/" + temp1.Text;
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void enviar2_Click(object sender, EventArgs e)
        {
            string mensaje = "2/" + nForm + "/" + temp2.Text;
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }
    }
}
