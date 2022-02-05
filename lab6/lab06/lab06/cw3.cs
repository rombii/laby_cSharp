using System.Windows.Forms;

namespace lab06;

public partial class cw3 : Form
{
    private Label label = new Label();
    private Button button = new Button();
    private TextBox textboxX = new TextBox();
    private TextBox textboxEquals = new TextBox();
    public cw3()
    {
        label.Text = "Liczba x";
        label.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
        Controls.Add(label);

        textboxX.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
        Controls.Add(textboxX);
        
        button.Text = "Oblicz";
        button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
        Controls.Add(button);
        
        textboxEquals.ReadOnly = true;
        textboxEquals.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
        Controls.Add(textboxEquals);

        button.Click += calculateX; 
        InitializeComponent();
    }

    private void calculateX(object sender, EventArgs e)
    {
        int number = 0;
        number = int.Parse(textboxX.Text);
        number *= number;
        textboxEquals.Text = number.ToString();
    }
}