using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentShoppingCenter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Form1 FORMA { get; set; }

        public static Employee St { get; set; }

        Model1 db = new Model1();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Нужно ввести логин и пароль!");
                return;
            }

            Employee log = db.Employee.FirstOrDefault(x => x.Login.ToLower() == textBox1.Text.ToLower());

            if ((log != null) && (log.Password == textBox2.Text))
            {
                St = log;
                FORMA = this;
                if (log.Role == "Администратор")
                {
                    Form2 frm = new Form2();
                    frm.Show();
                    this.Hide();
                }

                else if (log.Role == "Менеджер торгового центра")
                {
                    Form4 frm = new Form4();
                    frm.Show();
                    this.Hide();
                }
                else if (log.Role == "Менеджер управления сдачей в аренду")
                {
                    Form3 frm = new Form3();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Роли {log.Role} в системе нет!");
                    return;
                }
            }

            else
            {
                MessageBox.Show("Пользователя с таким логином и паролем нет!");
                return;
            }

        }
        
    }
}