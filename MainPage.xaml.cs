using MauiAppDemo.Models;
using Newtonsoft;
using Newtonsoft.Json;

namespace MauiAppDemo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new DemoPage());
            //count++;

            //if (count == 1)
            //CounterBtn.Text = $"Clicked {count} time";
            //else
            //CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);

            HttpClient client = new HttpClient();
            string json = client.GetStringAsync("https://dummy.restapiexample.com/api/v1/employees").Result;
            EmployeeDetailsVM employeeDetails = JsonConvert.DeserializeObject<EmployeeDetailsVM>(json);

        }
    }

}
