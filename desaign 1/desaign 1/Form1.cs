using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desaign_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Label login,gmail,pass;
        TextBox isi;
        TextBox pas;
        Button enter,akun;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            login = new Label();
            login.Text = "Masukan untuk Order Online";
            login.Location = new Point(80, 60);
            login.Size = new Size(500, 40);
            login.Font = new Font("Arial", Font.Size * 3, FontStyle.Bold);
            this.Controls.Add(login);

            gmail = new Label();
            gmail.Text = "Email";
            gmail.Location = new Point(86, 130);
            gmail.Size = new Size(100, 30);
            gmail.Font = new Font("Arial", Font.Size * 2);
            this.Controls.Add(gmail);

            isi = new TextBox();
            isi.Location = new Point(85, 160);
            isi.Size = new Size(250, 100);
            this.Controls.Add(isi);

            pass = new Label();
            pass.Text = "Password";
            pass.Location = new Point(86, 180);
            pass.Size = new Size(120, 30);
            pass.Font = new Font("Arial", Font.Size * 2);
            this.Controls.Add(pass);

            pas = new TextBox();
            pas.Location = new Point(85, 210);
            pas.Size = new Size(250, 100);
            this.Controls.Add(pas);

            enter = new Button();
            enter.Text = "MASUK";
            enter.Location = new Point(85, 240);
            enter.Size = new Size(100, 30);
            enter.Font = new Font("Arial", Font.Size * 1);
            enter.Click += Enter_Click;
            this.Controls.Add(enter);

            akun = new Button();
            akun.Text = "Register";
            akun.Location = new Point(200, 240);
            akun.Size = new Size(100, 30);
            akun.Font = new Font("Arial", Font.Size * 1);
            akun.Click += Enter_Click;
            this.Controls.Add(akun);


        }


        private void Enter_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
