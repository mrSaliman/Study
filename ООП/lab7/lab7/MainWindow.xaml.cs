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
using static System.Net.Mime.MediaTypeNames;

namespace lab7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Automobile> automobiles = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RefreshTextBox()
        {
            StringBuilder text = new();
            foreach (Automobile automobile in automobiles) 
            { 
                text.Append(automobile.ToString() + "\n"); 
            }
            TextBlock.Text = text.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double mileage;
            if (!double.TryParse(Mileage.Text, out mileage) || Model.Text == null || BodyType.Text == null || IsUridic.IsChecked == null)
            {
                MessageBox.Show("Некорректный ввод.");
                return;
            }

            automobiles.Add(new Automobile(
                DateOnly.FromDateTime(ReleaseDate.DisplayDate), 
                mileage, 
                Model.Text, 
                BodyType.Text, 
                IsUridic.IsChecked.Value, 
                DateOnly.FromDateTime(InspectionDate.DisplayDate)));
            RefreshTextBox();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RefreshTextBox();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            StringBuilder urText = new();
            StringBuilder phText = new();
            foreach (Automobile automobile in automobiles)
            {
                if (automobile.NextInspectionDate == DateOnly.FromDateTime(InspectionDateCheck.DisplayDate))
                {
                    if (automobile.IsUridic == true) urText.Append(automobile.ToString() + "\n");
                    else phText.Append(automobile.ToString() + "\n");
                }
            }
            TextBlock.Text = "Юр. лица:\n" + urText.ToString() + "Физ. лица:\n" + phText.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            StringBuilder text = new();
            Dictionary<string, int> bodies = new();

            foreach (Automobile automobile in automobiles)
            {
                if (automobile.IsUridic)
                {
                    if (!bodies.ContainsKey(automobile.BodyType)) bodies.Add(automobile.BodyType, 0);
                    bodies[automobile.BodyType]++;
                }
            }
            foreach (KeyValuePair<string, int> body in bodies)
            {
                text.AppendLine(body.Key + ": " + body.Value);
            }

            TextBlock.Text = text.ToString();
        }
    }
}
