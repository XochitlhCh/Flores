using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Ribbon;

namespace Flores.Models
{
    public class FloresContext
    {
        //cadena de conexion, abrir y cerrar se pone aqui 
        public MySqlConnection Connection { get; set; } = new MySqlConnection("user=root; password=root;database=flores; server=localhost");
        
        public void Conectar()
        {
            if (Connection.State != ConnectionState.Open)
            {
                Connection.Open();
            }
        }

        public void Desconectar() 
        {
            if (Connection.State !=ConnectionState.Closed)
            {
                Connection.Close();
            }
        }
    }
}
