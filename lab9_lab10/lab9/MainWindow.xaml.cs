using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;
using Microsoft.Win32;

namespace lab9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> list { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            list = new List<Student>()
            {
                new Student("Andrzej", "Pandrzej", 123768, "GX"),
                new Student("Jan", "Dzban", 123769, "FF"),
                new Student("Agata", "Zfiata", 123761, "IE")
            };
            content.Columns.Add(new DataGridTextColumn(){Header = "Imie", Binding = new Binding("imie")});
            content.Columns.Add(new DataGridTextColumn(){Header = "Nazwisko", Binding = new Binding("nazwisko")});
            content.Columns.Add(new DataGridTextColumn(){Header = "Nr_indeksu", Binding = new Binding("nr")});
            content.Columns.Add(new DataGridTextColumn(){Header = "Wydzial", Binding = new Binding("wydzial")});
            content.AutoGenerateColumns = false;
            content.ItemsSource = list;
        }

        private void openAddStudent(object sender, RoutedEventArgs e)
        {
            var dialog = new StudentWindow(new Student());
            if (dialog.ShowDialog() == true)
            {
                list.Add(dialog.student);
                content.Items.Refresh();
            }
        }

        private void removeStudent(object sender, RoutedEventArgs e)
        {
            if (content.SelectedItem is Student)
            {
                list.Remove((Student) content.SelectedItem);
            }
            content.Items.Refresh();
        }

        private void addGrade(object sender, RoutedEventArgs e)
        {
            var dialog = new AddGrade((Student) content.SelectedItem);
            if (dialog.ShowDialog() == true) {}
        }

        private void showGrades(object sender, RoutedEventArgs e)
        {
            var dialog = new Grades((Student) content.SelectedItem);
            if (dialog.ShowDialog() == true) {}
        }

        private void saveToFile(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "TXT Files (*.txt)|*.txt";
            if(save.ShowDialog() == true)
            {
                FileStream fs = new FileStream("data.txt", FileMode.Create);
                StreamWriter file = new StreamWriter(fs);
                foreach (var student in list)
                {
                    Type t = student.GetType();
                    file.WriteLine($"[[{t.FullName}]]");
                    foreach (var p in t.GetProperties())
                    {
                        file.WriteLine($"{p.Name}");
                        file.WriteLine(p.GetValue(student));
                    }

                    file.WriteLine($"[[]]");
                }

                file.Close();
                fs.Close();
                MessageBox.Show("zapisano");
            }
        }

        private void loadFromFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "TXT Files (*.txt)|*.txt";
            if (open.ShowDialog() == true)
            {
                FileStream fs = new FileStream(open.FileName, FileMode.Open);
                StreamReader file = new StreamReader(fs);
                list.Clear();

                while (!file.EndOfStream)
                {
                    file.ReadLine();
                    file.ReadLine();
                    string newName = file.ReadLine();
                    file.ReadLine();
                    string newSurame = file.ReadLine();
                    file.ReadLine();
                    int newNumber = int.Parse(file.ReadLine());
                    file.ReadLine();
                    string newFaculty = file.ReadLine();
                    file.ReadLine();
                    list.Add(new Student(newName, newSurame, newNumber, newFaculty));
                }

                file.Close();
                fs.Close();
                MessageBox.Show("odczytano");
                content.Items.Refresh();
            }
        }

        private void saveToFileXML(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "XML Files (*.xml)|*.xml";
            if(save.ShowDialog() == true)
            {
                FileStream fs = new FileStream(save.FileName, FileMode.Create);
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                    serializer.Serialize(fs, list);
                    MessageBox.Show("odczytano");
                }
                catch
                {
                    MessageBox.Show("Blad");
                }

                fs.Close();
            }

        }

        private void loadFromFileXML(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "XML Files (*.xml)|*.xml";
            List<Student> listI = new List<Student>();
            list.Clear();
            if (open.ShowDialog() == true)
            {
                FileStream fs = new FileStream(open.FileName, FileMode.Open);
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                    listI = (List<Student>) serializer.Deserialize(fs);
                    foreach (var student1 in listI) list.Add(student1);
                    content.Items.Refresh();
                    MessageBox.Show("odczytano");
                }
                catch
                {
                    MessageBox.Show("Blad");
                }
                fs.Close();
            }
        }
    }
}