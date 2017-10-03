using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }
        private void Guardar_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("hola", nombre1.Text + "" + apellido2.Text + "" + direccion3.Text + "" + telefono4.Text + "" + carrera5.Text + "" + semestre6.Text + "" + matricula7.Text + "" + correo8.Text + "" + github9.Text, "Good");
        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }
        private void Button_Clicked2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

    }
}
   