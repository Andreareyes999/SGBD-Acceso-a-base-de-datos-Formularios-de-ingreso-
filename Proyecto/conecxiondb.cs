using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto
{
    class conecxiondb
    {
        string cadena = "Data Source=DESKTOP-N9UIGE6\\SQLEXPRESS; Initial Catalog=formulario_ingreso; integrate Security=True";
        public SqlConnection conectardb = new SqlConnection();

        public conecxiondb()
        {
            conectardb.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectardb.Open();

            }
            catch (global::System.Exception)
            {

                throw;
            }
        }
            
    }
}
