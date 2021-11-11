using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private Superheroe superheroeActual;

        public Superheroe SuperheroeActual
        {
            get { return superheroeActual; }
            set { 
                superheroeActual = value;
                NotifyPropertyChanged("SuperheroeActual");            
            }
        }
        private int contadorActual;

        public int ContadorActual
        {
            get { return contadorActual; }
            set { 
                contadorActual = value;
                NotifyPropertyChanged("ContadorActual");
            }
        }
        private int totalHeroes;

        public int TotalHeroes
        {
            get { return totalHeroes; }
            set { 
                totalHeroes = value;
                NotifyPropertyChanged("TotalHeroes");
            }
        }
   
        private List<Superheroe> listaSuperheroes = Superheroe.GetSamples();

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindowVM()
        {
            SuperheroeActual = listaSuperheroes.FirstOrDefault();
            ContadorActual = 1;
            TotalHeroes = listaSuperheroes.Count;
        }

        public void Avanzar()
        {
            if (ContadorActual < TotalHeroes)
            {
                ContadorActual++;
                SuperheroeActual = listaSuperheroes[ContadorActual - 1];
            }
            
        }
        public void Retroceder()
        {
            if (ContadorActual > 1)
            {
                ContadorActual--;
                SuperheroeActual = listaSuperheroes[ContadorActual - 1];
            }
        }
    }
}
