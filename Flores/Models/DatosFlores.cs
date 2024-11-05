using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flores.Models
{
    public class DatosFlores
    {
        public int IdFlor { get; set; }
        public string? NombreCientifico { get; set; }
        public string? NombreComun { get; set; }
        public string? Origen { get; set; }
        public string? Descripcion { get; set; }
        public string? Nombre { get; set; }
        public string? URL { get; set; }
    }
}
