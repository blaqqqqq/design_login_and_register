using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace design_register
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Label title,nama,email,tgl,pass,cpass;
        TextBox name,mail,umur,pas,cpas;
        Button cacc;
        private void Form1_Load(object sender, EventArgs e)
        {
            title = new Label();
            title.Text = "Register Account";
            title.Location = new Point(35, 30);
            title.Size = new Size(300, 40);
            title.Font = new Font("Arial", title.Font.Size * 3, FontStyle.Bold);
            this.Controls.Add(title);

            nama = new Label();
            nama.Text = "Full Name";
            nama.Location = new Point(39, 90);
            nama.Size = new Size(100, 15);
            nama.Font = new Font("Arial", nama.Font.Size);
            this.Controls.Add(nama);

            name = new TextBox();
            name.Location = new Point(39, 110);
            name.Size = new Size(200, 100);
            this.Controls.Add(name);

            email = new Label();
            email.Text = "Email";
            email.Location = new Point(39, 138);
            email.Size = new Size(100, 15);
            email.Font = new Font("Arial", email.Font.Size);
            this.Controls.Add(email);

            mail = new TextBox();
            mail.Location = new Point(39, 155);
            mail.Size = new Size(200, 100);
            this.Controls.Add(mail);

            tgl = new Label();
            tgl.Text = "Tanggal Lahir";
            tgl.Location = new Point(39, 180);
            tgl.Size = new Size(100, 15);
            tgl.Font = new Font("Arial", email.Font.Size);
            this.Controls.Add(tgl);

            umur = new TextBox();
            umur.Location = new Point(39, 200);
            umur.Size = new Size(200, 100);
            this.Controls.Add(umur);

            pass = new Label();
            pass.Text = "Password";
            pass.Location = new Point(289, 90);
            pass.Size = new Size(100, 15);
            pass.Font = new Font("Arial", email.Font.Size);
            this.Controls.Add(pass);

            pas = new TextBox();
            pas.Location = new Point(289, 110);
            pas.Size = new Size(200, 100);
            this.Controls.Add(pas);

            cpass = new Label();
            cpass.Text = "Confirm Password";
            cpass.Location = new Point(289, 138);
            cpass.Size = new Size(100, 15);
            cpass.Font = new Font("Arial", email.Font.Size);
            this.Controls.Add(cpass);

            cpas = new TextBox();
            cpas.Location = new Point(289, 155);
            cpas.Size = new Size(200, 100);
            this.Controls.Add(cpas);

            cacc = new Button();
            cacc.Text = "Create Account";
            cacc.Location = new Point(289, 200);
            cacc.Size = new Size(200, 30);
            cacc.Click += Cacc_Click;
            this.Controls.Add(cacc);

        }

        private void Cacc_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
