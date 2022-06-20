using PM2P1_T4.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM2P1_T4.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocalPage : ContentPage
    {
        public LocalPage()
        {
            InitializeComponent();
        }

        protected  override void OnAppearing()
        {
            base.OnAppearing();

            string folderPath = "/storage/emulated/0/Android/data/com.companyname.pm2p1_t4/files/Pictures/MisFotos/";


            try
            {
                string[] files = Directory.GetFiles(folderPath, "*.jpg");

                List<Imagen> imagenes = new List<Imagen>();

                Imagen temp = null;
                foreach (var item in files)
                {
                    temp = new Imagen();

                    temp.nombre = item.Remove(0, 82);
                    temp.descripcion = item;

                    imagenes.Add(temp);
                }

                listaImagen.ItemsSource = imagenes;
            }
            catch (Exception)
            {
               
            }
        }
    }
}