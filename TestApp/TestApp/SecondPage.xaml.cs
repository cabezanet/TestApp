using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp
{
    
    public partial class SecondPage : ContentPage
    {
        public List<Jugador> Jugadores =  new List<Jugador>();
        public SecondPage()
        {
            InitializeComponent();

            Jugador jugador = new Jugador()
            {
                Imagen = "https://img.elcomercio.pe/files/article_content_ec_fotos/uploads/2018/12/30/5c2923ba1e201.jpeg",
                Nombre = "Lebron James",
                Equipo = "Los Angeles Lakers"

            };

            this.Jugadores.Add(jugador);

            jugador = new Jugador()
            {
                Imagen = "https://i.cdn.turner.com/nba/nba/celtics/photos/larry-bird-dribble300400.jpg",
                Nombre = "Larry Bird",
                Equipo = "Boston Celtics"

            };

            this.Jugadores.Add(jugador);

            jugador = new Jugador()
            {
                Imagen = "https://www.estadiodeportes.mx/wp-content/uploads/2017/04/michael-jordan-basketball-sport-wallpapers-hd-wallpapers-hd-celebrities-sports-photo-michael-jordan-wallpaper.jpg",
                Nombre = "Michael Jordan",
                Equipo = "Chicago Bulls"
            };

            this.Jugadores.Add(jugador);

            this.jugadores.ItemsSource = this.Jugadores;
        }

        private async void Jugadores_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var myListView = (ListView)sender;
            var myItem = myListView.SelectedItem;

            await Navigation.PushAsync(new DetailPage(myItem));
            /*
            var result = await DisplayAlert("Alert", myItem.ToString(), "Cancelar");
            if(result)
            {
                Console.WriteLine(myItem.ToString());
            }
            */
        }
    }

    public class Jugador
    {
        public String Imagen { get; set; }
        public String Nombre { get; set; }
        public String Equipo { get; set; }
    }
}