using Flores.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flores.Repositories
{
    public class DatosFloresRepository
    {
        FloresContext context = new FloresContext();
        public List<DatosFlores> GetAll()
        {
            //consulta a la base de datos
            context.Conectar();
            MySqlCommand cmd = new MySqlCommand("select * from datosflores", context.Connection);//consulta
            MySqlDataReader lector = cmd.ExecuteReader();//ejecutar lectura
            List<DatosFlores> listaDatosFlores = new List<DatosFlores>();//iniciarlizar la lista e instanciarla para verla en una lista desde c#
            //el read es como el foreach, mientra haya datos avanza
            while (lector.Read())//leer
            {
                DatosFlores df = new DatosFlores
                {
                    IdFlor = lector.GetInt32("idflor"),//obtener los datos con el nombre que tiene la columna en la base de datos
                    Nombre = lector.GetString("nombre"),
                    Descripcion = lector.GetString("descripcion"),
                    NombreCientifico = lector.GetString("nombrecientifico"),
                    NombreComun = lector.GetString("nombrecomun"),
                    Origen = lector.GetString("origen"),
                    URL = lector.GetString("urlImagen")

                };
                listaDatosFlores.Add(df);
            }
            lector.Close();//cerrar lector
            context.Desconectar(); 
            return listaDatosFlores;
        }
    }
}
