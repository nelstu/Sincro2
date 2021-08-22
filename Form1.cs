using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sincro2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Adios");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Test t = new Test();
            t.eje();
        
        }

        private void sincronizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

           


            timer1.Stop(); // detener mientras se hace la consulta

            Test t = new Test();
            t.eje();

            timer1.Start();  // iniciar nuevamente el timer.


            //Console.log("El gato tiene hambre!");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop(); // detener mientras se hace la consulta

            Test t = new Test();
            t.eje();

            timer1.Start();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion frm = new Configuracion();
            frm.Show();
        }
    }
}
