using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_04_Accounts_Group_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string myText = Logger.GetLoginEvents();
            logingEventslbl.Text = myText;
        }
    }
}
