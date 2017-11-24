using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WF_Exam
{
    public partial class Questionform : Form
    {
        enum Nums : int { Minone = -1, Null, One, Two, Three, Four, Five, Eighty = 80, Onehundred = 100 };
        string filtr = "TextFiles(*.txt;*.log)|*.txt;*log|All files(*.*)|*.*";
        string PathCnet = @"C#\\TestC#.txt";
        string PathCplus = @"C++\\TestC++.txt";
        string code = "1234";

        public Questionform()
        {
            InitializeComponent();

        }
        /// <summary>
        /// method for creating questions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddQ_Click(object sender, EventArgs e)
        {
            try
            {///creating new object of ListViewItem to fill it new data
                this.listView1.Items.Add(new ListViewItem(new string[] { "", "", "", "", "", "" }));
                foreach (ListViewItem i in this.listView1.Items)
                {///delegates to getting data from ADDdataform
                    General.GetQ = () => i.SubItems[(int)Nums.Null].Text;
                    General.GetA = () => i.SubItems[(int)Nums.One].Text;
                    General.GetB = () => i.SubItems[(int)Nums.Two].Text;
                    General.GetC = () => i.SubItems[(int)Nums.Three].Text;
                    General.GetD = () => i.SubItems[(int)Nums.Four].Text;
                    General.GetCor = () => i.SubItems[(int)Nums.Five].Text;

                    ///delegates to setting data to ADDdataform
                    General.SetQ = (x) => i.SubItems[(int)Nums.Null].Text = x;
                    General.SetA = (x) => i.SubItems[(int)Nums.One].Text = x;
                    General.SetB = (x) => i.SubItems[(int)Nums.Two].Text = x;
                    General.SetC = (x) => i.SubItems[(int)Nums.Three].Text = x;
                    General.SetD = (x) => i.SubItems[(int)Nums.Four].Text = x;
                    General.SetCor = (x) => i.SubItems[(int)Nums.Five].Text = x;

                }
                ///create & open ADDdataform
                var add = new ADD_data();
                add.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        /// <summary>
        /// Menu method for creating questions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btAddQ_Click(sender, e);
        }
        /// <summary>
        /// Contextmenu method for creating questions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addQuestionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.btAddQ_Click(sender, e);
        }
        /// <summary>
        /// method for saving questions to file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder test = new StringBuilder();
                foreach (ListViewItem item in this.listView1.Items)
                {
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        test.Append(subItem.Text);
                        test.Append(';');
                    }
                    test.Append(Environment.NewLine);
                }

                if (rbNet.Checked)
                {
                    File.WriteAllText(PathCnet, test.ToString());
                    MessageBox.Show("Файл был сохранен", "Information",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (rbPlus.Checked)
                {
                    File.WriteAllText(PathCplus, test.ToString());
                    MessageBox.Show("Файл был сохранен", "Information",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!rbNet.Checked || !rbPlus.Checked)
                {
                    MessageBox.Show("Пожалуйста, выберите предмет!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        /// <summary>
        /// Menu for saving questions to file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btSave_Click(sender, e);
        }
        /// <summary>
        /// Contextmenu for saving questions to file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.btSave_Click(sender, e);
        }
        /// <summary>
        /// close form with warning about exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Questionform_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var q = MessageBox.Show("Are you sure you want to close?", "WARNING!", MessageBoxButtons.YesNo);
                if (q == DialogResult.Yes)
                {
                    e.Cancel = false;
                }

                else
                    e.Cancel = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// load text from file to the ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLoadTest_Click(object sender, EventArgs e)
        {
            StreamReader s = null;
            string allLines = null;
            string Path = null;
            try
            {
                if (rbNet.Checked)
                {
                    Path = PathCnet;
                }
                else if (rbPlus.Checked)
                {
                    Path = PathCplus;
                }

                else if (!rbNet.Checked && !rbPlus.Checked)
                {
                    MessageBox.Show("Пожалуйста, выберите предмет!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                using (s = new StreamReader(Path, true))
                    do
                    {
                        allLines = s.ReadLine();
                        this.listView1.Items.Add(new ListViewItem
                            (allLines.Split(new char[] { ';', '\n' })));
                    }
                    while (!s.EndOfStream);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (s != null)
                {
                    s.Close();
                    s = null;
                }
            }
        }
        /// <summary>
        /// Menu load text from file to the ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btLoadTest_Click(sender, e);
        }
        /// <summary>
        /// ContextMenu load text from file to the ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btLoadTest_Click(sender, e);
        }
        /// <summary>
        /// correct data of selected items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCorrect_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.listView1.SelectedIndices == null)
                    return;
                else
                {
                    foreach (ListViewItem i in this.listView1.SelectedItems)
                    {

                        General.GetQ = () => i.SubItems[(int)Nums.Null].Text;
                        General.GetA = () => i.SubItems[(int)Nums.One].Text;
                        General.GetB = () => i.SubItems[(int)Nums.Two].Text;
                        General.GetC = () => i.SubItems[(int)Nums.Three].Text;
                        General.GetD = () => i.SubItems[(int)Nums.Four].Text;
                        General.GetCor = () => i.SubItems[(int)Nums.Five].Text;

                        ///delegates to setting data to ADDdataform
                        General.SetQ = (x) => i.SubItems[(int)Nums.Null].Text = x;
                        General.SetA = (x) => i.SubItems[(int)Nums.One].Text = x;
                        General.SetB = (x) => i.SubItems[(int)Nums.Two].Text = x;
                        General.SetC = (x) => i.SubItems[(int)Nums.Three].Text = x;
                        General.SetD = (x) => i.SubItems[(int)Nums.Four].Text = x;
                        General.SetCor = (x) => i.SubItems[(int)Nums.Five].Text = x;
                        var add = new ADD_data();
                        add.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// menu correct data of selected items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void correctFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btCorrect_Click(sender, e);
        }
        /// <summary>
        /// contextmenu correct data of selected items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void correctFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.btCorrect_Click(sender, e);
        }
        /// <summary>
        /// method for delete test
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDeleteTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var f = filtr;
                    if (File.Exists(this.openFileDialog1.FileName))
                    {
                        var q = MessageBox.Show(string.Format("Вы уверены, что хотите удалить тест {0} ?", this.openFileDialog1.FileName),
                            "WARNING!", MessageBoxButtons.YesNoCancel);
                        if (q == DialogResult.Yes)
                        {
                            File.Delete(this.openFileDialog1.FileName);
                            MessageBox.Show("Файл был удален!", "Information",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Menu method for delete test
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btDeleteTest_Click(sender, e);
        }
        /// <summary>
        /// contextmenu method for delete test
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.btDeleteTest_Click(sender, e);
        }
        /// <summary>
        /// conditions for students
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbStud_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                    this.rbTeacher.Enabled = false;
                    this.listView1.Visible = false;
                    this.btAddQ.Visible = false;
                    this.btCorrect.Visible = false;
                    this.btDeleteTest.Visible = false;
                    this.btLoadTest.Visible = false;
                    this.btSave.Visible = false;
                    this.btClear.Visible = false;
                    this.btWatch.Visible = false;
                    ///////
                    this.tbCode.Visible = false;
                    this.btRes.Visible = false;
                    this.lbLn.Visible = true;
                    this.lbN.Visible = true;
                    this.lbF.Visible = true;
                    this.lbg.Visible = true;
                    this.tbLname.Visible = true;
                    this.tbName.Visible = true;
                    this.tbFname.Visible = true;
                    this.tbGroup.Visible = true;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// timer for test
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("Время для сдачи теста вышло", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.timer1.Enabled = false;
                //Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// method for passing the test
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btStart_Click(object sender, EventArgs e)
        {
            int count = (int)Nums.Null;
            string coransw = null;
            int questions = (int)Nums.Null;
            try
            {
                if (this.tbName.Text == string.Empty || this.tbFname.Text == string.Empty || this.tbLname.Text == string.Empty)
                    MessageBox.Show("Необходимо ввести ФИО, группу и выбрать предмет!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                else
                {
                    if (rbNet.Checked || rbPlus.Checked)
                    {
                        this.listView1.Items.Clear();
                        this.btLoadTest_Click(sender, e);
                        //timer1.Interval = 10000;
                        //this.timer1.Enabled = true;

                        foreach (ListViewItem i in this.listView1.Items)
                        {///delegates to getting data from ADDdataform
                            General.GetQ = () => i.SubItems[(int)Nums.Null].Text;
                            General.GetA = () => i.SubItems[(int)Nums.One].Text;
                            General.GetB = () => i.SubItems[(int)Nums.Two].Text;
                            General.GetC = () => i.SubItems[(int)Nums.Three].Text;
                            General.GetD = () => i.SubItems[(int)Nums.Four].Text;
                            General.GetCor = () => i.SubItems[(int)Nums.Five].Text;

                            ///delegates to setting data to ADDdataform
                            General.SetQ = (x) => i.SubItems[(int)Nums.Null].Text = x;
                            General.SetA = (x) => i.SubItems[(int)Nums.One].Text = x;
                            General.SetB = (x) => i.SubItems[(int)Nums.Two].Text = x;
                            General.SetC = (x) => i.SubItems[(int)Nums.Three].Text = x;
                            General.SetD = (x) => i.SubItems[(int)Nums.Four].Text = x;
                            General.SetCor = (x) => i.SubItems[(int)Nums.Five].Text = x;

                            coransw = i.SubItems[(int)Nums.Five].Text;

                            ///create & open ADDdataform
                            var add = new ADD_data();
                            add.tbCorrect.Visible = false;
                            add.lbcoransw.Visible = false;
                            add.ShowDialog();
                            this.tbCoransw.Text = count.ToString();

                            if (add.rbA.Checked)
                            {
                                if (coransw == "1")
                                {
                                    count++;
                                }
                            }
                            if (add.rbB.Checked)
                            {
                                if (coransw == "2")
                                {
                                    count++;
                                }
                            }
                            if (add.rbC.Checked)
                            {
                                if (coransw == "3")
                                {
                                    count++;
                                }
                            }
                            if (add.rbD.Checked)
                            {
                                if (coransw == "4")
                                {
                                    count++;
                                }
                            }

                            this.tbCoransw.Text = count.ToString();
                            questions++;
                        }
                        {
                            var res = count * (int)Nums.Onehundred / questions;
                            if (res > (int)Nums.Eighty)
                                this.tbRes.Text = "Сдан";
                            else
                                this.tbRes.Text = "Не сдан";
                            this.btSavetest_Click(sender, e);
                        }
                    }
                    if (!rbNet.Checked && !rbPlus.Checked)
                    {
                        MessageBox.Show("Пожалуйста, выберите предмет!", "Ошибка!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// conditions for teacher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbTeacher_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var t = new Teacher();
                t.ShowDialog();

                this.rbStud.Enabled = false;
                this.listView1.Visible = true;
                this.btAddQ.Visible = true;
                this.btCorrect.Visible = true;
                this.btDeleteTest.Visible = true;
                this.btLoadTest.Visible = true;
                this.btSave.Visible = true;
                this.btClear.Visible = true;
                this.btWatch.Visible = true;
                this.tbCode.Visible = true;
                this.btRes.Visible = true;
                this.btSave.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// clear data of listView & textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClear_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            this.tbCode.Clear();
        }
        /// <summary>
        /// Menu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btClear_Click(sender, e);
        }
        /// <summary>
        /// Contextmenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.btClear_Click(sender, e);
        }
        /// <summary>
        /// Save test with it coding
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSavetest_Click(object sender, EventArgs e)
        {
            string l = this.tbLname.Text;
            string n = this.tbName.Text;
            string f = this.tbFname.Text;
            string g = this.tbGroup.Text;
            string a = this.tbCoransw.Text;
            string r = this.tbRes.Text;

            try
            {
                this.tbCode.Text =string.Format( "{0}{1}{2} группа{3} правильных {4} тест {5} \r\n" ,l,n,f,g,a,r);
                File.AppendAllText("res.txt", this.tbCode.Text);
                this.tbCode.Text = File.ReadAllText("res.txt");
                var buf = Encoding.Unicode.GetBytes(this.tbCode.Text);
                var key = Encoding.Unicode.GetBytes(code);
                for (var i = 0; i < buf.Length; ++i)
                    buf[i] ^= key[i % key.Length];

                this.tbCode.Text = Encoding.Unicode.GetString(buf);
                File.WriteAllText("code.txt", this.tbCode.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// watch data of the testsresults
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRes_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("code.txt"))
                {
                    this.tbCode.Text = File.ReadAllText("code.txt");
                    var buf = Encoding.Unicode.GetBytes(this.tbCode.Text);
                    var key = Encoding.Unicode.GetBytes(code);
                    for (var i = 0; i < buf.Length; ++i)
                        buf[i] ^= key[i % key.Length];
                    this.tbCode.Text = Encoding.Unicode.GetString(buf);
                }
                else
                    MessageBox.Show("Файл не найден", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Menu watch data of the testsresults
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btRes_Click(sender, e);
        }
        /// <summary>
        /// ContextMenu watch data of the testsresults
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showResultsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.btRes_Click(sender, e);
        }
        /// <summary>
        /// about programm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ab = new AboutBox1();
            ab.ShowDialog();
        }
    }
}
