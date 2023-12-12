using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace phobe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : ContentPage
    {
        public Label otv;
        public Entry num1, num2;
        public Page4()
        {
            InitializeComponent();
            Grid grid = new Grid
            {
                RowSpacing = 5,
                RowDefinitions =
                {
                    new RowDefinition { Height = 50 },
                    new RowDefinition { Height = 120 },
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
                Text = "Задания 5",
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Center
            };
            Label numa1 = new Label()
            {
                Text = "Введите X",
                FontSize = 16,
                VerticalTextAlignment = TextAlignment.Center

            };
            Label numa2 = new Label()
            {
                Text = "Введите Y",
                FontSize = 16,
                VerticalTextAlignment = TextAlignment.Center

            };
            num1 = new Entry()
            {
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 16,
                VerticalOptions = LayoutOptions.End,


            };
            num2 = new Entry()
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
                Text = "На главную",
                FontSize = 14

            };
            otv = new Label()
            {
                Text = "Ответ:",
                FontSize = 16
            };
            Image img = new Image();
            img.Source = ImageSource.FromFile("kr.png");
            grid.Children.Add(otv, 0, 4);
            grid.Children.Add(img, 0, 1);
            Grid.SetColumnSpan(img, 2);
            Grid.SetColumnSpan(otv, 2);
            grid.Children.Add(title, 0, 0);
            Grid.SetColumnSpan(title, 2);
            grid.Children.Add(numa1, 0, 2);
            grid.Children.Add(numa2, 0, 3);
            grid.Children.Add(num1, 1, 2);
            grid.Children.Add(num2, 1, 3);
            StackLayout stackLayout = new StackLayout();
            stackLayout.Orientation = StackOrientation.Horizontal;
            stackLayout.HorizontalOptions = LayoutOptions.Center;
            vipol.Clicked += Vipol_Clicked;
            nextp.Clicked += Nextp_Clicked;
            stackLayout.Children.Add(vipol);
            stackLayout.Children.Add(nextp);
            grid.Children.Add(stackLayout, 0, 5);
            Grid.SetColumnSpan(stackLayout, 2);
            Content = grid;
        }

        private async void Nextp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private void Vipol_Clicked(object sender, EventArgs e)
        {
            int X = int.Parse(num1.Text);
            int Y = int.Parse(num2.Text);
            string R = "";
            if (X == 70 && Y >= 0 && Y <= X || Y == 0 && X >= 0 && X <= 70 || Y == X && X >= 0 && X <= 70)
            {
                R = "На границе";
            }
            else if (X <= 70 && X >= 0 && Y >= 0 && Y <= X) R = "Да";
            else
            {
                R = "Нет";
            }
            otv.Text = $"Ответ: {R}";
        }
    }
}