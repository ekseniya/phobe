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
    public partial class Page2 : ContentPage
    {
        public Label otv;
        public Entry num1, num2, num3, num4;
        public Page2()
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
                Text = "Задания 3",
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Center
            };
            Label numa1 = new Label()
            {
                Text = "Введите число 1",
                FontSize = 16,
                VerticalTextAlignment = TextAlignment.Center

            };
            Label numa2 = new Label()
            {
                Text = "Введите число 2",
                FontSize = 16,
                VerticalTextAlignment = TextAlignment.Center

            };
            Label numa3 = new Label()
            {
                Text = "Введите число 3",
                FontSize = 16,
                VerticalTextAlignment = TextAlignment.Center

            }; Label numa4 = new Label()
            {
                Text = "Введите число 4",
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
            num3 = new Entry()
            {
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 16,
                VerticalOptions = LayoutOptions.End,


            };
            num4 = new Entry()
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
            grid.Children.Add(numa2, 0, 2);
            grid.Children.Add(num2, 1, 2);
            grid.Children.Add(numa3, 0, 3);
            grid.Children.Add(num3, 1, 3);
            grid.Children.Add(numa4, 0, 4);
            grid.Children.Add(num4, 1, 4);
            grid.Children.Add(otv, 0, 5);
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
            grid.Children.Add(stackLayout, 0, 6);
            Grid.SetColumnSpan(stackLayout, 2);
            Content = grid;
        }

        private async void Nextp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }

        private void Vipol_Clicked(object sender, EventArgs e)
        {
            int a = int.Parse(num1.Text);
            int b = int.Parse(num2.Text);
            int c = int.Parse(num3.Text);
            int z = int.Parse(num4.Text);
            if (a != b && a != c && a != z)
            {
                otv.Text = $"Ответ: порядковый номре отличающегося числа 1";
            }
            else if (b != a && b != c && b != z)
            {
                otv.Text = $"Ответ: порядковый номре отличающегося числа 2";
            }
            else if (c != a && c != b && c != z)
            {
                otv.Text = $"Ответ: порядковый номре отличающегося числа 3";
            }
            else if (z != a && z != b && z != c)
            {
                otv.Text = $"Ответ: порядковый номре отличающегося числа 4";
            }
            else
            {
                otv.Text = $"Ответ: ошибка";
            }
        }
    }
}