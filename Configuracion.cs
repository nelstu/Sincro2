using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sincro2
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }
        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=c:\\xml\\base.db3; Version = 3; New = True; Compress = True; ");
         // Open the connection:
         try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return sqlite_conn;
        }

        static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT dxml,dsal,ip,user,pa,base FROM config WHERE id=1";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            Configuracion conf = new Configuracion();
            while (sqlite_datareader.Read())
            {
                string dxml = sqlite_datareader.GetString(0);
                string dsal = sqlite_datareader.GetString(1);
                string ip   = sqlite_datareader.GetString(2);
                string user = sqlite_datareader.GetString(3);
                string pa   = sqlite_datareader.GetString(4);
                string database = sqlite_datareader.GetString(5);
                conf.textBox1.Text = dxml;
                conf.textBox2.Text = dsal;
                conf.textBox3.Text = ip;
                conf.textBox4.Text = user;
                conf.textBox5.Text = pa;
                conf.textBox6.Text = database;





               // MessageBox.Show(dxml);
            }
            conn.Close();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            //  ReadData(sqlite_conn);
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT dxml,dsal,ip,user,pa,base FROM config WHERE id=1";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            Configuracion conf = new Configuracion();
            while (sqlite_datareader.Read())
            {
                string dxml = sqlite_datareader.GetString(0);
                string dsal = sqlite_datareader.GetString(1);
                string ip   = sqlite_datareader.GetString(2);
                string user = sqlite_datareader.GetString(3);
                string pa   = sqlite_datareader.GetString(4);
                string database = sqlite_datareader.GetString(5);
                this.textBox1.Text = dxml;
                this.textBox2.Text = dsal;
                this.textBox3.Text = ip;
                this.textBox4.Text = user;
                this.textBox5.Text = pa;
                this.textBox6.Text = database;





                //MessageBox.Show(dxml);
            }
            sqlite_conn.Close();

            string path = Directory.GetCurrentDirectory();

           // MessageBox.Show(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
         


            sqlite_cmd.CommandText = "UPDATE config SET dxml='" + this.textBox1.Text + "',dsal='" + this.textBox2.Text + "',ip='" + this.textBox3.Text+ "',user='" + this.textBox4.Text + "',pa='" + this.textBox5.Text + "',base='" + this.textBox6.Text + "' WHERE id=1; ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
            MessageBox.Show("Configuracion Actualizada");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Database files (*.mdb, *.accdb)|*.mdb;*.accdb";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                //...
            }
        }
    }
}
