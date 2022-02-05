using System.Windows;

namespace lab9;

public partial class Grades : Window
{
    public Grades()
    {
        InitializeComponent();
    }
    public Grades(Student student)
    {
        InitializeComponent();
        grades.ItemsSource = student.listaOcen;
    }
}