using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Math;

namespace phobe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Label otv;
        public Entry num1;
        public Page3()
        {
            InitializeComponent();
            Grid grid = new Grid
            {
                RowSpacing = 5,
                RowDefinitions =
                {
                    new RowDefinition { Height = 50 },
                    new RowDefinition { Height = 50 },
                    new RowDefinition { Height = 50 },
                    new RowDefinition { Height = 50 },
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = 120 },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };
            Label title = new Label()
            {
                Text = "Задания 4",
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Center
            };
            Label numa1 = new Label()
            {
                Text = "Введите X",
                FontSize = 16,
                VerticalTextAlignment = TextAlignment.Center

            };
            num1 = new Entry()
            {
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 16,
                VerticalOptions = LayoutOptions.End,


            };
            Button vipol = new Button()
            {
                Text = "Найти",
                FontSize = 14,

            };
            Button nextp = new Button()
            {
                Text = "Следующее",
                FontSize = 14

            };
            otv = new Label()
            {
                Text = "Ответ:",
                FontSize = 16
            };
            grid.Children.Add(otv, 0, 2);
            Grid.SetColumnSpan(otv, 2);
            grid.Children.Add(title, 0, 0);
            Grid.SetColumnSpan(title, 2);
            grid.Children.Add(numa1, 0, 1);
            grid.Children.Add(num1, 1, 1);
            StackLayout stackLayout = new StackLayout();
            stackLayout.Orientation = StackOrientation.Horizontal;
            stackLayout.HorizontalOptions = LayoutOptions.Center;
            vipol.Clicked += Vipol_Clicked;
            nextp.Clicked += Nextp_Clicked;
            stackLayout.Children.Add(vipol);
            stackLayout.Children.Add(nextp);
            grid.Children.Add(stackLayout, 0, 3);
            Grid.SetColumnSpan(stackLayout, 2);
            Content = grid;
        }

        private async void Nextp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }

        private void Vipol_Clicked(object sender, EventArgs e)
        {
            double x = double.Parse(num1.Text);
            double y = 0;
            if (-PI / 2 < x && x < PI / 2)
            {
                y = Sqrt(Abs((Sin(x) + Pow(Tan(x), 2)) / (3.5 * Cos(x))));
            }
            else if (PI / 2 < x && x < PI)
            {
                y = Cos(x / 3) / (Sin(x) + Pow(Tan(x), 2));
            }
            otv.Text = $"Отвтет: Y = {y}";
        }
    }
}