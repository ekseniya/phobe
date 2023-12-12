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
    public partial class Page1 : ContentPage
    {
        public Label rez;
        public Entry k1, k2;
        public Page1()
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
                Text = "Задания 2",
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Center
            };
            Label mim = new Label()
            {
                Text = "Введите число 1",
                FontSize = 14,
                VerticalTextAlignment = TextAlignment.Center

            };
            Label mim1 = new Label()
            {
                Text = "Введите число 2",
                FontSize = 14,
                VerticalTextAlignment = TextAlignment.Center

            };
            k1 = new Entry()
            {
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 16,
                VerticalOptions = LayoutOptions.End,


            };
            k2= new Entry()
            {
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 16,
                VerticalOptions = LayoutOptions.End,


            };
            Button naiti = new Button()
            {
                Text = "Найти",
                FontSize = 14,

            };
            Button pagenex = new Button()
            {
                Text = "Следующее",
                FontSize = 14

            };
            rez = new Label()
            {
                Text = "Ответ:",
                FontSize = 16
            };
            grid.Children.Add(rez, 0, 3);
            Grid.SetColumnSpan(rez, 2);
            grid.Children.Add(title, 0, 0);
            Grid.SetColumnSpan(title, 2);
            grid.Children.Add(mim, 0, 1);
            grid.Children.Add(mim1, 0, 2);
            grid.Children.Add(k1, 1, 1);
            grid.Children.Add(k2, 1, 2);
            StackLayout stackLayout = new StackLayout();
            stackLayout.Orientation = StackOrientation.Horizontal;
            stackLayout.HorizontalOptions = LayoutOptions.Center;
            naiti.Clicked += Naiti_Clicked;
            pagenex.Clicked += Pagenex_Clicked;
            stackLayout.Children.Add(naiti);
            stackLayout.Children.Add(pagenex);
            grid.Children.Add(stackLayout, 0, 4);
            Grid.SetColumnSpan(stackLayout, 2);
            Content = grid;
        }

        private async void Pagenex_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        private void Naiti_Clicked(object sender, EventArgs e)
        {
            int A = int.Parse(k1.Text);
            int B = int.Parse(k2.Text);
            if (A > B)
            {
                rez.Text = $"Ответ: {A} {B}";
            }
            else
            {
                rez.Text = $"Ответ: {B} {A}";
            }
        }
    }
}