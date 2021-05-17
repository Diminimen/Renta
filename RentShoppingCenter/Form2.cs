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
    public partial class Form2 : Form
    {

       
        public Form2()
        {
            InitializeComponent();
        }
        public Model1 db = new Model1();
         Employee str { get; set; }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            employeeBindingSource.DataSource = db.Employee.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee st = (Employee)employeeBindingSource.Current;
            Form5 fr5 = new Form5();
            fr5.db = db;
            fr5.st = st;
            DialogResult dr = fr5.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // обновляем данные для ЭУ DataGridView
                employeeBindingSource.DataSource = db.Employee.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* // получаем текущий объект (на него указывается в DataGridView)
            Employee st = Employee.bindingSource.Current;
            Form5 fr5 = new Form5();
            fr5.db = db;
            fr5.st = st;
            DialogResult dr = fr5.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // обновляем данные для ЭУ DataGridView
                bindingSource.DataSource = db.Employee.ToList();
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // сбрасываем старое подключение к данным
            employeeBindingSource.DataSource = null;
            employeeBindingSource.DataSource = db.Employee.ToList<Employee>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee st = (Employee)employeeBindingSource.Current;

            DialogResult dr = MessageBox.Show(
                "Вы действительно хотите удалить логин " + st.Login,
                "Удаление логина прошло успешно", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // удаление записи из базы данных
                db.Employee.Remove(st);

                try
                {
                    db.SaveChanges();
                    employeeBindingSource.DataSource = db.Employee.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
