using System.Collections.Generic;
using System.ComponentModel;

class Superheroe : INotifyPropertyChanged
    {
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public bool Vengador { get; set; }
        public bool Xmen { get; set; }
        public bool Heroe { get; set; }

        public Superheroe()
        {
        }

        public Superheroe(string nombre, string imagen, bool vengador, bool xmen, bool heroe)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
        }

    public event PropertyChangedEventHandler PropertyChanged;

    public static List<Superheroe> GetSamples()
        {
            List<Superheroe> ejemplos = new List<Superheroe>();

            Superheroe ironman = new Superheroe("Ironman", @"https://dossierinteractivo.com/wp-content/uploads/2021/01/Iron-Man.png",true, false,true);
            Superheroe kingpin = new Superheroe("Kingpin", @"https://www.comicbasics.com/wp-content/uploads/2017/09/Kingpin.jpg", false, false,false);
            Superheroe spiderman = new Superheroe("Spiderman", @"https://wipy.tv/wp-content/uploads/2019/08/destino-de-%E2%80%98Spider-Man%E2%80%99-en-los-Comics.jpg", true, true,true);

            ejemplos.Add(ironman);
            ejemplos.Add(kingpin);
            ejemplos.Add(spiderman);

            return ejemplos;
        }
      }