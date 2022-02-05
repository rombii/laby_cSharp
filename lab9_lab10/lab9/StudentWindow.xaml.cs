using System.Text.RegularExpressions;
using System.Windows;

namespace lab9;

public partial class StudentWindow : Window
{
    public Student student;
    public StudentWindow(Student student = null)
    {
        InitializeComponent();
        if (student != null)
        {
            imie.Text = student.imie;
            nazwisko.Text = student.nazwisko;
            nr.Text = student.nr.ToString();
            wydzial.Text = student.wydzial;
        }

        this.student = student ?? new Student();
    }

    public StudentWindow()
    {
        InitializeComponent();
    }

    private void okButton(object sender, RoutedEventArgs e)
    {
        if (!Regex.IsMatch(imie.Text, @"\w+") || !Regex.IsMatch(nazwisko.Text, @"\w+") || !Regex.IsMatch(nr.Text, @"\d+") || !Regex.IsMatch(wydzial.Text, @"\w+"))
        {
            MessageBox.Show("zle dane");
            return;
        }

        student.imie = imie.Text;
        student.nazwisko = nazwisko.Text;
        student.nr = int.Parse(nr.Text);
        student.wydzial = wydzial.Text;
        this.DialogResult = true;
    }
}