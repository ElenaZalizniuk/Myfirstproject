using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Exam
{
    public partial class Teacher : Form
    {/// <summary>
    /// fields for work
    /// </summary>
        string log = "teacher";
        string passw = "password";

        public Teacher()
        {
            InitializeComponent();
        }
        /// <summary>
        /// method for check login & password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btOk_Click(object sender, EventArgs e)
        {                       
                if (this.tbLogin.Text == string.Empty || this.tbPassw.Text == string.Empty)
                {
                    MessageBox.Show("Введите логин и пароль", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (this.tbLogin.Text != string.Empty && this.tbPassw.Text != string.Empty && log == this.tbLogin.Text && passw == this.tbPassw.Text)
                {
                    MessageBox.Show("Добро пожаловать!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Close();

                }
                else if (this.tbLogin.Text != string.Empty && this.tbPassw.Text != string.Empty && log != this.tbLogin.Text || passw != this.tbPassw.Text)
                    MessageBox.Show("Неправильный логин или пароль", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
           
        }
    }
}
