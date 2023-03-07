using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageExamen : ContentPage
    {
        public PageExamen()
        {
            InitializeComponent();
        }

        private async void btnguardar_Clicked(object sender, EventArgs e)
        {
            var examen1 = new Models.Examen1
            {
                nombres = txtnombre.Text,
                apellidos = txtapellidos.Text,
                edad = txtedad.Text,
                pais = txtpais.Text,
                nota = txtnota.Text,
                latitud = txtlatitud.Text,
                longitud = txtlongitud.Text,
               
                
            };
            
            }
    }
}