using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1._1._26._03
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Port;
        bool IsClosed = false;

        public Form1()
        {
            InitializeComponent();

            Port = new System.IO.Ports.SerialPort();
            Port.PortName = "COM5";
            Port.BaudRate = 9600;
            Port.ReadTimeout = 500;

            try
            {
                Port.Open();
            }
            catch
            {
               
            }

            //como leo el arduino 

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EscucharSerial()
        {
            while(!IsClosed)
                try
                {
                    string cadena = Port.ReadLine();
                }
                catch
                { }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
