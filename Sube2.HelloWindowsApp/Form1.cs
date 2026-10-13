namespace Sube2.HelloWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var btn = new Button();
            btn.Text = "My Button!";
            btn.Location = new Point(100, 50);
            btn.Size = new Size(100, 100);
            btn.Click += MyButtonClick;
            this.Controls.Add(btn);
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("My Button Clicked!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gazi Üniversitesi");
        }

        private void button1_Move(object sender, EventArgs e)
        {

        }

        private void MyButtonClick(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            MessageBox.Show(buton.Text);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            btnHello.Location = new Point(btnHello.Location.X + 1, btnHello.Location.Y + 1);
        }
    }
}

//Bir event tetiklendiğinde iş yapılabilmesi için, bir metod ile event'in ilişkilendirilmesi gerekir.
//Bir event'in method ile ilişkilenebilmesi için, metod imzasının uygun olması gerekir.
//Bir metod, birden fazla nesnenin eventleri ile ilişkilenebilir.
//sender: Event hangi nesne tarafından gönderilmişse, o nesnenin referansını tutar. Dolayısıyla nesneye erişebilir.
//Default Event: Bir control'e çift tıklayarak, bu event ile ilişkilenecek metod yazdırırlabilir.

