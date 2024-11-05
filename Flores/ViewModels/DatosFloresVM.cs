using CommunityToolkit.Mvvm.Input;
using Flores.Models;
using Flores.Repositories;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Flores.ViewModels
{
    public enum Vistas
    {
        DatosFlores, Flor
    }
    public class DatosFloresVM:INotifyPropertyChanged
    {
        public List<DatosFlores> ListaFlores{ get; set; }
        public Vistas Vista { get; set; }  = Vistas.DatosFlores;
        public DatosFlores Flor { get; set; }
        DatosFloresRepository FloresRepository { get; set; } = new DatosFloresRepository();

        public void CambiarVista(Vistas v)//vista con la q va trabajar
        {
            Vista = v;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }


        public ICommand CambiarVistaCommand{ get; set; }


        public DatosFloresVM()
        {
           ListaFlores = FloresRepository.GetAll();

            CambiarVistaCommand = new RelayCommand<Vistas>(CambiarVista);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
