namespace HelloWorldWinForms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        // 以下为添加代码
        this.Text = "Hello World Application";
        this.ClientSize = new Size(300, 200);

        Button helloButton = new Button();
        helloButton.Text = "Click Me!";
        helloButton.Click += (sender, e) => MessageBox.Show("Hello, World!");
        helloButton.Location = new Point(100, 80);
        this.Controls.Add(helloButton);
    }
}
