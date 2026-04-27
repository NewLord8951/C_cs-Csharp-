using System.Collections;

namespace MyWinFormsApp;

public partial class Form1 : Form
{
    public double a = 0;
    public double b = 0;
    public char c = '-';
    public Label label;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button button0;

    public Button delite;

    public Button ymnog;

    public Button minus;
    public Button plus;

    public Button del;
    public Button ravno;

    public Button zap;

    public Form1()
    {
        InitializeComponent();

        Panel myPanel = new Panel();
        myPanel.Location = new Point(10, 75);          
        myPanel.Size = new Size(310, 2);            
        myPanel.BackColor = Color.White;           
        myPanel.BorderStyle = BorderStyle.FixedSingle;
        this.Controls.Add(myPanel);

        Panel myPanel2 = new Panel();
        myPanel2.Location = new Point(10, 20);          
        myPanel2.Size = new Size(310, 2);            
        myPanel2.BackColor = Color.White;           
        myPanel2.BorderStyle = BorderStyle.FixedSingle;
        this.Controls.Add(myPanel2);

        Panel myPanel3 = new Panel();
        myPanel3.Location = new Point(10, 20);          
        myPanel3.Size = new Size(2, 55);            
        myPanel3.BackColor = Color.White;           
        myPanel3.BorderStyle = BorderStyle.FixedSingle;
        this.Controls.Add(myPanel3);

        Panel myPanel4 = new Panel();
        myPanel4.Location = new Point(320, 20);          
        myPanel4.Size = new Size(2, 57);            
        myPanel4.BackColor = Color.White;           
        myPanel4.BorderStyle = BorderStyle.FixedSingle;
        this.Controls.Add(myPanel4);
        this.BackColor = Color.Black;

        label = new Label();
        label.Text = a.ToString();
        label.Location = new Point(10, 20);
        label.Size = new Size { Width = 310, Height = 50 };
        label.ForeColor = Color.White;
        label.Font = new Font("Arial Black", 30);

        button1 = new Button();
        button1.Text = "1";
        button1.Location = new Point(10, 100);
        button1.Size = new Size { Width = 70, Height = 80 };
        button1.ForeColor = Color.White;
        button1.Font = new Font("Arial Black", 20);
        button1.BackColor = Color.DarkSlateGray;
        button1.Click += num1;

        button2 = new Button();
        button2.Text = "2";
        button2.Location = new Point(90, 100);
        button2.Size = new Size { Width = 70, Height = 80 };
        button2.ForeColor = Color.White;
        button2.Font = new Font("Arial Black", 20);
        button2.BackColor = Color.DarkSlateGray;
        button2.Click += num2;

        button3 = new Button();
        button3.Text = "3";
        button3.Location = new Point(170, 100);
        button3.Size = new Size { Width = 70, Height = 80 };
        button3.ForeColor = Color.White;
        button3.Font = new Font("Arial Black", 20);
        button3.BackColor = Color.DarkSlateGray;
        button3.Click += num3;

        button4 = new Button();
        button4.Text = "4";
        button4.Location = new Point(10, 190);
        button4.Size = new Size { Width = 70, Height = 80 };
        button4.ForeColor = Color.White;
        button4.Font = new Font("Arial Black", 20);
        button4.BackColor = Color.DarkSlateGray;
        button4.Click += num4;

        button5 = new Button();
        button5.Text = "5";
        button5.Location = new Point(90, 190);
        button5.Size = new Size { Width = 70, Height = 80 };
        button5.ForeColor = Color.White;
        button5.Font = new Font("Arial Black", 20);
        button5.BackColor = Color.DarkSlateGray;
        button5.Click += num5;

        button6 = new Button();
        button6.Text = "6";
        button6.Location = new Point(170, 190);
        button6.Size = new Size { Width = 70, Height = 80 };
        button6.ForeColor = Color.White;
        button6.Font = new Font("Arial Black", 20);
        button6.BackColor = Color.DarkSlateGray;
        button6.Click += num6;

        button7 = new Button();
        button7.Text = "7";
        button7.Location = new Point(10, 280);
        button7.Size = new Size { Width = 70, Height = 80 };
        button7.ForeColor = Color.White;
        button7.Font = new Font("Arial Black", 20);
        button7.BackColor = Color.DarkSlateGray;
        button7.Click += num7;

        button8 = new Button();
        button8.Text = "8";
        button8.Location = new Point(90, 280);
        button8.Size = new Size { Width = 70, Height = 80 };
        button8.ForeColor = Color.White;
        button8.Font = new Font("Arial Black", 20);
        button8.BackColor = Color.DarkSlateGray;
        button8.Click += num8;

        button9 = new Button();
        button9.Text = "9";
        button9.Location = new Point(170, 280);
        button9.Size = new Size { Width = 70, Height = 80 };
        button9.ForeColor = Color.White;
        button9.Font = new Font("Arial Black", 20);
        button9.BackColor = Color.DarkSlateGray;
        button9.Click += num9;

        button0 = new Button();
        button0.Text = "0";
        button0.Location = new Point(90, 370);
        button0.Size = new Size { Width = 70, Height = 80 };
        button0.ForeColor = Color.White;
        button0.Font = new Font("Arial Black", 20);
        button0.BackColor = Color.DarkSlateGray;
        button0.Click += num0;

        del = new Button();
        del.Text = "AC";
        del.Location = new Point(10, 370);
        del.Size = new Size { Width = 70, Height = 80 };
        del.ForeColor = Color.White;
        del.Font = new Font("Arial Black", 20);
        del.BackColor = Color.Red;
        del.Click += del_;

        zap = new Button();
        zap.Text = ",";
        zap.Location = new Point(170, 370);
        zap.Size = new Size { Width = 70, Height = 80 };
        zap.ForeColor = Color.White;
        zap.Font = new Font("Arial Black", 20);
        zap.BackColor = Color.DarkSlateGray;
        zap.Click += zap_;

        delite = new Button();
        delite.Text = "/";
        delite.Location = new Point(250, 100);
        delite.Size = new Size { Width = 70, Height = 80 };
        delite.ForeColor = Color.White;
        delite.Font = new Font("Arial Black", 20);
        delite.BackColor = Color.Orange;
        delite.Click += delite_;

        ymnog = new Button();
        ymnog.Text = "*";
        ymnog.Location = new Point(250, 190);
        ymnog.Size = new Size { Width = 70, Height = 80 };
        ymnog.ForeColor = Color.White;
        ymnog.Font = new Font("Arial Black", 20);
        ymnog.BackColor = Color.Orange;
        ymnog.Click += ymnog_;

        minus = new Button();
        minus.Text = "-";
        minus.Location = new Point(250, 370);
        minus.Size = new Size { Width = 70, Height = 80 };
        minus.ForeColor = Color.White;
        minus.Font = new Font("Arial Black", 20);
        minus.BackColor = Color.Orange;
        minus.Click += minus_;

        plus = new Button();
        plus.Text = "+";
        plus.Location = new Point(250, 280);
        plus.Size = new Size { Width = 70, Height = 80 };
        plus.ForeColor = Color.White;
        plus.Font = new Font("Arial Black", 20);
        plus.BackColor = Color.Orange;
        plus.Click += plus_;

        ravno = new Button();
        ravno.Text = "=";
        ravno.Location = new Point(10, 460);
        ravno.Size = new Size { Width = 310, Height = 80 };
        ravno.ForeColor = Color.White;
        ravno.Font = new Font("Arial Black", 20);
        ravno.BackColor = Color.Orange;
        ravno.Click += ravno_;

        this.Controls.Add(label);
        this.Controls.Add(button1);
        this.Controls.Add(button2);
        this.Controls.Add(button3);
        this.Controls.Add(button4);
        this.Controls.Add(button5);
        this.Controls.Add(button6);
        this.Controls.Add(button7);
        this.Controls.Add(button8);
        this.Controls.Add(button9);
        this.Controls.Add(button0);
        this.Controls.Add(ravno);
        this.Controls.Add(plus);
        this.Controls.Add(minus);
        this.Controls.Add(ymnog);
        this.Controls.Add(delite);
        this.Controls.Add(del);
        this.Controls.Add(zap);
    }

    private bool test(){
        string text_ = label.Text;
        if (text_.Length < 10){
            return true;
        }
        else{
            return false;
        }
    }

    private void zap_(object sender, EventArgs e){
        label.Text = "Kirill gay";
    }

    private void ravno_(object sender, EventArgs e){
        if (c == '-'){
            double ans = b - a;
            label.Text = ans.ToString();
            a = ans;
            b = 0;
        }
        else if (c == '+'){
            double ans = b + a;
            label.Text = ans.ToString();
            a = ans;
            b = 0;
        }
        else if (c == '/'){
            double ans = b / a;
            label.Text = ans.ToString();
            a = ans;
            b = 0;
        }
        else if (c == '*'){
            double ans = b * a;
            label.Text = ans.ToString();
            a = ans;
            b = 0;
        }
    }

    private void minus_(object sender, EventArgs e){
        b = a;
        a = 0;
        c = '-';
        label.Text = "0";
    }

    private void plus_(object sender, EventArgs e){
        b = a;
        a = 0;
        c = '+';
        label.Text = "0";
    }

    private void delite_(object sender, EventArgs e){
        b = a;
        a = 0;
        c = '/';
        label.Text = "0";
    }

    private void ymnog_(object sender, EventArgs e){
        b = a;
        a = 0;
        c = '*';
        label.Text = "0";
    }

    private void del_ (object sender, EventArgs e){
        label.Text = "0";
        if (b != 0){
            b = 0;
        }
        else{
            a = 0;
        }
    }

    private void num1 (object sender, EventArgs e){
        bool test_ = test();
        if (test_){
           string num = a.ToString();
            if (label.Text == "0"){
                label.Text = "1";
                a = double.Parse(label.Text);
            }
            else{
                label.Text += "1";
                a = double.Parse(label.Text);
            }
        }
    }

    private void num2 (object sender, EventArgs e){
        bool test_ = test();
        if (test_){
           string num = a.ToString();
            if (label.Text == "0"){
                label.Text = "2";
                a = double.Parse(label.Text);
            }
            else{
                label.Text += "2";
                a = double.Parse(label.Text);
            }
        }
    }

    private void num3 (object sender, EventArgs e){
        bool test_ = test();
        if (test_){
           string num = a.ToString();
            if (label.Text == "0"){
                label.Text = "3";
                a = double.Parse(label.Text);
            }
            else{
                label.Text += "3";
                a = double.Parse(label.Text);
            }
        }
    }
    private void num4 (object sender, EventArgs e){
        bool test_ = test();
        if (test_){
           string num = a.ToString();
            if (label.Text == "0"){
                label.Text = "4";
                a = double.Parse(label.Text);
            }
            else{
                label.Text += "4";
                a = double.Parse(label.Text);
            }
        }
    }

    private void num5 (object sender, EventArgs e){
        bool test_ = test();
        if (test_){
           string num = a.ToString();
            if (label.Text == "0"){
                label.Text = "5";
                a = double.Parse(label.Text);
            }
            else{
                label.Text += "5";
                a = double.Parse(label.Text);
            }
        }
    }

    private void num6 (object sender, EventArgs e){
        bool test_ = test();
        if (test_){
           string num = a.ToString();
            if (label.Text == "0"){
                label.Text = "6";
                a = double.Parse(label.Text);
            }
            else{
                label.Text += "6";
                a = double.Parse(label.Text);
            }
        }
    }

    private void num7 (object sender, EventArgs e){
        bool test_ = test();
        if (test_){
           string num = a.ToString();
            if (label.Text == "0"){
                label.Text = "7";
                a = double.Parse(label.Text);
            }
            else{
                label.Text += "7";
                a = double.Parse(label.Text);
            }
        }
    }

    private void num8 (object sender, EventArgs e){
        bool test_ = test();
        if (test_){
           string num = a.ToString();
            if (label.Text == "0"){
                label.Text = "8";
                a = double.Parse(label.Text);
            }
            else{
                label.Text += "8";
                a = double.Parse(label.Text);
            }
        }
    }

    private void num9 (object sender, EventArgs e){
        bool test_ = test();
        if (test_){
           string num = a.ToString();
            if (label.Text == "0"){
                label.Text = "9";
                a = double.Parse(label.Text);
            }
            else{
                label.Text += "9";
                a = double.Parse(label.Text);
            }
        }
    }

    private void num0 (object sender, EventArgs e){
        bool test_ = test();
        if (test_){
           string num = a.ToString();
            if (label.Text == "0"){
                label.Text = "0";
                a = double.Parse(label.Text);
            }
            else{
                label.Text += "0";
                a = double.Parse(label.Text);
            }
        }
    }
}