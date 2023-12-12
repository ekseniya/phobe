using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace phobe
{
    public partial class MainPage : ContentPage
    {
        public Label otv;
        public Entry ks;

        public MainPage()
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
                    new ColumnDefinition { Width = 130 },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };
            Label title = new Label()
            {
                Text = "Задания 1",
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Center
            };
            Label ksa = new Label()
            {
                Text = "Введите двухзначное число",
                FontSize = 14,
                VerticalTextAlignment = TextAlignment.Center

            };
            ks = new Entry()
            {
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 16,
                VerticalOptions = LayoutOptions.End,


            };
            Button nashel = new Button()
            {
                Text = "Найти",
                FontSize = 14,

            };
            Button pagenext = new Button()
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
            grid.Children.Add(ksa,0, 1);
            grid.Children.Add(ks, 1, 1);
            StackLayout stackLayout = new StackLayout();
            stackLayout.Orientation = StackOrientation.Horizontal;
            stackLayout.HorizontalOptions = LayoutOptions.Center;
            nashel.Clicked += Nashel_Clicked;
            pagenext.Clicked += Pagenext_Clicked;
            stackLayout.Children.Add(nashel);
            stackLayout.Children.Add(pagenext);
            grid.Children.Add(stackLayout, 0, 3);
            Grid.SetColumnSpan(stackLayout, 2);
            Content = grid;
        }

        private async void Pagenext_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        private void Nashel_Clicked(object sender, EventArgs e)
        {
            int A = int.Parse(ks.Text);
            int A1 = A / 10;
            int A2 = A % 10;
            if ((A1 + A2) % 3 == 0)
            {
                otv.Text = $"Кратно";
            }
            else
            {
                otv.Text = "Не кратно";
            }
        }
    }
}
