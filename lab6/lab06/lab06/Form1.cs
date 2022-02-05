namespace lab06;

public partial class Form1 : Form
{
    private Label labelX = new Label();
    private Label labelY = new Label();
    private Label labelZ = new Label();
    private Label labelWynik = new Label();

    private TextBox textboxX = new TextBox();
    private TextBox textboxY = new TextBox();
    private TextBox textboxZ = new TextBox();
    private TextBox textboxWynik = new TextBox();

    private Button buttonSum = new Button();
    private Button buttonIlo = new Button();
    private Button buttonExit = new Button();
    
    public Form1()
    {
        
        labelX.Text = "x";
        labelX.Location = new Point(10, 10);
        Controls.Add(labelX);
        
        labelY.Text = "y";
        labelY.Location = new Point(10, 30);
        Controls.Add(labelY);
        
        labelZ.Text = "z";
        labelZ.Location = new Point(10, 50);
        Controls.Add(labelZ);
        
        labelWynik.Text = "wynik";
        labelWynik.Location = new Point(10, 70);
        Controls.Add(labelWynik);

        textboxX.Location = new Point(120, 10);
        Controls.Add(textboxX);
        
        textboxY.Location = new Point(120, 30);
        Controls.Add(textboxY);
        
        textboxZ.Location = new Point(120, 50);
        Controls.Add(textboxZ);
        
        textboxWynik.Location = new Point(120, 70);
        Controls.Add(textboxWynik);

        buttonSum.Text = "Suma";
        buttonSum.Location = new Point(240, 20);
        Controls.Add(buttonSum);
        
        buttonIlo.Text = "Iloczyn";
        buttonIlo.Location = new Point(240, 40);
        Controls.Add(buttonIlo);
        
        buttonExit.Text = "Wyjscie";
        buttonExit.Location = new Point(240, 60);
        Controls.Add(buttonExit);
        
        InitializeComponent();
        
    }
}