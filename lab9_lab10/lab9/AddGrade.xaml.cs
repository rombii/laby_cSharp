using System.Windows;

namespace lab9;

public partial class AddGrade : Window
{
    private Student student;
    public AddGrade()
    {
        InitializeComponent();
    }

    public AddGrade(Student student)
    {
        InitializeComponent();
        this.student = student;
    }

    private void okButton(object sender, RoutedEventArgs e)
    {
        student.listaOcen.Add(new Ocena(przedmiot.Text, int.Parse(ocena.Text)));
        this.DialogResult = true;

    }
}