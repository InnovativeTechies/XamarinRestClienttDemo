using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RestClientDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        protected static RestClient _restClient = new RestClient();
        public MainPage()
        {
            InitializeComponent();
        }

        private async void CallRestApi(object sender,EventArgs e)
        {
            var response = await _restClient.GetAsync<PostObject>("https://jsonplaceholder.typicode.com/posts/1");

            await DisplayAlert("Vales from Api", response.body, "OK", "Cancel");
        }
    }

    public class PostObject
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
