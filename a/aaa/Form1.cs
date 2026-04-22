namespace aaa;

public partial class Form1 : Form {
    public double q = 0;
    private void click0(object sender, EventArgs e) {
        string f = q.ToString() + "0"; 
        label.Text = f;
    }
    private void click1(object sender, EventArgs e) {
        string f = q.ToString() + "1"; 
        label.Text = f;
    }
    public Label label;
    public Button button0;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button button_plus;
    public Button button_minus;
    public Button button_umn;
    public Button button_del;

    public Form1() {
        InitializeComponent();

        label = new Label();
        label.Text = q.ToString();
        label.Location = new Point(10, 50);
        this.Controls.Add(label);

        button0 = new Button();
        button0.Text = "0";
        button0.Location = new Point(10, 100);
        button0.Size = new Size { Width = 70, Height = 80 };
        button0.Click += click0;
        this.Controls.Add(button0);

        button1 = new Button();
        button1.Text = "1";
        button1.Location = new Point(75, 100);
        button1.Size = new Size { Width = 70, Height = 80 };
        button1.Click += click1;
        this.Controls.Add(button1);

    }
}
