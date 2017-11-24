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
    public partial class ADD_data : Form
    {/// <summary>
     /// field for work with test
     /// </summary>
        public string coransw = null;
        public ADD_data()
        {
            InitializeComponent();
            ///delegates for getting data from form 1
            this.tbQ.Text = General.GetQ();
            this.tbA.Text = General.GetA();
            this.tbB.Text = General.GetB();
            this.tbC.Text = General.GetC();
            this.tbD.Text = General.GetD();
            this.tbCorrect.Text = General.GetCor();

        }
        /// <summary>
        /// method for closing form with setting data to Form 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ADD_data_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                General.SetQ(this.tbQ.Text);
                General.SetA(this.tbA.Text);
                General.SetB(this.tbB.Text);
                General.SetC(this.tbC.Text);
                General.SetD(this.tbD.Text);
                General.SetCor(this.tbCorrect.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        /// <summary>
        /// use button for closing form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNext_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
