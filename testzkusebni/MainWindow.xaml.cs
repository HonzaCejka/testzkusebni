using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace testzkusebni
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person;
        public MainWindow()
        {
            InitializeComponent();
            person = new Person("Pepa");
        }
        //objem/obsah
        public double count(bool obsah,double r)
        {
            double vysledek;
            if (obsah == true)
            {
                vysledek = Math.PI * Math.Pow(r,2);
                type.Text = "obsah";
            }
            else
            {
                vysledek = (4.0/3.0)*Math.PI*Math.Pow(r,3);
                type.Text = "objem";
            }
            return Math.Round(vysledek,2);
        }

        private void VS_Click(object sender, RoutedEventArgs e)
        {
            if (polomer.Text == "")
            {
                type.Text = "nebyla zadána hodnota";
            }
            else
            {
                if (cb.SelectedIndex==1)
                {
                    vypocet.Text = count(true,double.Parse(polomer.Text)).ToString();
                }
                else
                {
                    vypocet.Text = count(false, double.Parse(polomer.Text)).ToString();
                }
                
            }
        }
        //barvy
        private void generuj(int pocet, string color1,string color2)
        {            
            for (int i = 0; i < pocet; i++)
            {
                vystup.RowDefinitions.Add(new RowDefinition());
                for (int j = 0; j < pocet; j++)
                {
                    vystup.ColumnDefinitions.Add(new ColumnDefinition());
                    Rectangle rect = new Rectangle();                       
                    if (j%2 == 0)
                    {
                        if (i%2==0)
                        {
                            Color color = (Color)ColorConverter.ConvertFromString(color1);
                            rect.Fill = new SolidColorBrush(color);
                            Grid.SetColumn(rect, j);
                            Grid.SetRow(rect, i);
                            vystup.Children.Add(rect);
                        }
                        else
                        {
                            Color color = (Color)ColorConverter.ConvertFromString(color2);
                            rect.Fill = new SolidColorBrush(color);
                            Grid.SetColumn(rect, j);
                            Grid.SetRow(rect, i);
                            vystup.Children.Add(rect);
                        }
                    }
                    else
                    {
                        if (i%2==0)
                        {
                            Color color = (Color)ColorConverter.ConvertFromString(color2);
                            rect.Fill = new SolidColorBrush(color);
                            Grid.SetColumn(rect, j);
                            Grid.SetRow(rect, i);
                            vystup.Children.Add(rect);
                        }
                        else
                        {
                            Color color = (Color)ColorConverter.ConvertFromString(color1);
                            rect.Fill = new SolidColorBrush(color);
                            Grid.SetColumn(rect, j);
                            Grid.SetRow(rect, i);
                            vystup.Children.Add(rect);
                        }
                    }
                }
            }            
        }
//Pepa
        private void generate_Click(object sender, RoutedEventArgs e)
        {
            vystup.RowDefinitions.Clear();
            vystup.ColumnDefinitions.Clear();
            int pocet = 0;
            if (Pocet.Text!="")
            {
                 pocet = int.Parse(Pocet.Text);
            }
            else
            {                
                MessageBox.Show("zadej pocet");
            }
            string color1 = "#" + Color1.Text;
            string color2 = "#" + Color2.Text;
            generuj(pocet, color1, color2);
        }

        private void Starnout_Click(object sender, RoutedEventArgs e)
        {
            person.starnout();            
            load();
        }
        public void load()
        {
            Jmeno.Text = "";
            Vek.Text = "";
            Jmeno.Text = person.Name;
            if (person.Vek==0)
            {
                Vek.Text = person.Name + " má " + person.Vek + " let";
            }
            else if (person.Vek>=99)
            {
                Vek.Text = person.Name + " umřel :(";
            }
            else
            {
                Vek.Text = person.Name + " má " + person.Vek + person.YearDef;
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            load();
        }
    }
}
