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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public Model1 db { get; set; }
        public Employee st { get; set; }
    }
}
