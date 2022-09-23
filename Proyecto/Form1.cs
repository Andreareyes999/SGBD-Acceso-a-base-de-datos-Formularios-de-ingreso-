using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace Proyecto
{
       
    public partial class Form1 : Form

    {

        //public string conec = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\formulario_de_ingreso.accdb";
        //OleDbConnection cn = new OleDbConnection();

        SqlConnection conexionsqlserver = new SqlConnection("Data Source=LAPTOP-C6KTNLFR\\joser; Initial Catalog=formulario_ingreso; integrated Security=True");
        OleDbConnection conexionacceses = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\formulario_de_ingreso.accdb");



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                conexionacceses.Open();
               
            }
            catch (Exception a)
            {

                MessageBox.Show("Error" + a.ToString());
            }


        }

        private void Txtsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txtaccess_Click(object sender, EventArgs e)
        {

            string usuario = txtusuario.Text;
            string pass = txtpass.Text;

            if (usuario == "" || pass == "")
            {
                MessageBox.Show("Debe de completar los campos para poder continuar");
            }
            else
            {
                string consulta_access = "select * from Users where user = '" + usuario + "' and password = '" + pass + "'";
                OleDbCommand comando = new OleDbCommand(consulta_access, conexionacceses);
                OleDbDataReader leeraccess;
                leeraccess = comando.ExecuteReader();
                Boolean siexiste = leeraccess.HasRows;
                if (siexiste)
                {
                    MessageBox.Show("bienvendo al Sistema " + usuario);
                    sistema abrirnuevo = new sistema();
                    abrirnuevo.recuperarValores("Se a iniciado seccion desde Access");
                    abrirnuevo.Show();
                    
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error Datos Incorectos");
                    //conexionacceses.Close();
                }
            }

            

        }

        private void Txtsqlserver_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string pass = txtpass.Text;

            if (usuario == "" || pass == "")
            {
                MessageBox.Show("Debe de completar los campos para poder continuar");
            }
            else
            {
                conexionsqlserver.Open();
                String consulta_sql = "select * from usuario where usuario = '" + usuario + "' and password = '" + pass + "'";
                SqlCommand comando = new SqlCommand(consulta_sql, conexionsqlserver);
                SqlDataReader leersql;
                leersql = comando.ExecuteReader();

                if (leersql.HasRows == true)
                {
                    MessageBox.Show("bienvendo al Sistema " + usuario);
                    sistema abrirnuevo = new sistema();
                    abrirnuevo.recuperarValores("Se a iniciado seccion desde SQL Server");
                    abrirnuevo.Show();

                    this.Hide();
                   
                }
                else
                {
                    MessageBox.Show("no");

                }
            }


            
        }
    }
}
