namespace WF_Exam
{
    partial class Questionform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questionform));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Question = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.answerA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.answerB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.answerC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.answerD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.correctanswer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAddQ = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rbNet = new System.Windows.Forms.RadioButton();
            this.rbPlus = new System.Windows.Forms.RadioButton();
            this.btLoadTest = new System.Windows.Forms.Button();
            this.btCorrect = new System.Windows.Forms.Button();
            this.btDeleteTest = new System.Windows.Forms.Button();
            this.rbTeacher = new System.Windows.Forms.RadioButton();
            this.rbStud = new System.Windows.Forms.RadioButton();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbGroup = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.tbCoransw = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRes = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btSavetest = new System.Windows.Forms.Button();
            this.btWatch = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correctFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addQuestionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showResultsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correctFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.btRes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbLn = new System.Windows.Forms.Label();
            this.lbN = new System.Windows.Forms.Label();
            this.lbF = new System.Windows.Forms.Label();
            this.lbg = new System.Windows.Forms.Label();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.BackColor = System.Drawing.Color.LightBlue;
            this.listView1.CausesValidation = false;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Question,
            this.answerA,
            this.answerB,
            this.answerC,
            this.answerD,
            this.correctanswer});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Question
            // 
            resources.ApplyResources(this.Question, "Question");
            // 
            // answerA
            // 
            resources.ApplyResources(this.answerA, "answerA");
            // 
            // answerB
            // 
            resources.ApplyResources(this.answerB, "answerB");
            // 
            // answerC
            // 
            resources.ApplyResources(this.answerC, "answerC");
            // 
            // answerD
            // 
            resources.ApplyResources(this.answerD, "answerD");
            // 
            // correctanswer
            // 
            resources.ApplyResources(this.correctanswer, "correctanswer");
            // 
            // btAddQ
            // 
            resources.ApplyResources(this.btAddQ, "btAddQ");
            this.btAddQ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAddQ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btAddQ.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btAddQ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btAddQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btAddQ.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btAddQ.Name = "btAddQ";
            this.btAddQ.UseVisualStyleBackColor = false;
            this.btAddQ.Click += new System.EventHandler(this.btAddQ_Click);
            // 
            // btSave
            // 
            resources.ApplyResources(this.btSave, "btSave");
            this.btSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btSave.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btSave.Name = "btSave";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // rbNet
            // 
            resources.ApplyResources(this.rbNet, "rbNet");
            this.rbNet.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbNet.Name = "rbNet";
            this.rbNet.TabStop = true;
            this.toolTip1.SetToolTip(this.rbNet, resources.GetString("rbNet.ToolTip"));
            this.rbNet.UseVisualStyleBackColor = true;
            // 
            // rbPlus
            // 
            resources.ApplyResources(this.rbPlus, "rbPlus");
            this.rbPlus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbPlus.Name = "rbPlus";
            this.rbPlus.TabStop = true;
            this.toolTip1.SetToolTip(this.rbPlus, resources.GetString("rbPlus.ToolTip"));
            this.rbPlus.UseVisualStyleBackColor = true;
            // 
            // btLoadTest
            // 
            resources.ApplyResources(this.btLoadTest, "btLoadTest");
            this.btLoadTest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btLoadTest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btLoadTest.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btLoadTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btLoadTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btLoadTest.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btLoadTest.Name = "btLoadTest";
            this.btLoadTest.UseVisualStyleBackColor = false;
            this.btLoadTest.Click += new System.EventHandler(this.btLoadTest_Click);
            // 
            // btCorrect
            // 
            resources.ApplyResources(this.btCorrect, "btCorrect");
            this.btCorrect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCorrect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btCorrect.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btCorrect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btCorrect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btCorrect.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btCorrect.Name = "btCorrect";
            this.btCorrect.UseVisualStyleBackColor = false;
            this.btCorrect.Click += new System.EventHandler(this.btCorrect_Click);
            // 
            // btDeleteTest
            // 
            resources.ApplyResources(this.btDeleteTest, "btDeleteTest");
            this.btDeleteTest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDeleteTest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btDeleteTest.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btDeleteTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btDeleteTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btDeleteTest.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btDeleteTest.Name = "btDeleteTest";
            this.btDeleteTest.UseVisualStyleBackColor = false;
            this.btDeleteTest.Click += new System.EventHandler(this.btDeleteTest_Click);
            // 
            // rbTeacher
            // 
            resources.ApplyResources(this.rbTeacher, "rbTeacher");
            this.rbTeacher.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbTeacher.Name = "rbTeacher";
            this.rbTeacher.TabStop = true;
            this.rbTeacher.UseVisualStyleBackColor = true;
            this.rbTeacher.CheckedChanged += new System.EventHandler(this.rbTeacher_CheckedChanged);
            // 
            // rbStud
            // 
            resources.ApplyResources(this.rbStud, "rbStud");
            this.rbStud.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbStud.Name = "rbStud";
            this.rbStud.TabStop = true;
            this.rbStud.UseVisualStyleBackColor = true;
            this.rbStud.CheckedChanged += new System.EventHandler(this.rbStud_CheckedChanged);
            // 
            // tbLname
            // 
            resources.ApplyResources(this.tbLname, "tbLname");
            this.tbLname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbLname.Name = "tbLname";
            this.toolTip1.SetToolTip(this.tbLname, resources.GetString("tbLname.ToolTip"));
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbName.Name = "tbName";
            this.toolTip1.SetToolTip(this.tbName, resources.GetString("tbName.ToolTip"));
            // 
            // tbFname
            // 
            resources.ApplyResources(this.tbFname, "tbFname");
            this.tbFname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbFname.Name = "tbFname";
            this.toolTip1.SetToolTip(this.tbFname, resources.GetString("tbFname.ToolTip"));
            // 
            // tbGroup
            // 
            resources.ApplyResources(this.tbGroup, "tbGroup");
            this.tbGroup.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbGroup.Name = "tbGroup";
            this.toolTip1.SetToolTip(this.tbGroup, resources.GetString("tbGroup.ToolTip"));
            // 
            // btStart
            // 
            resources.ApplyResources(this.btStart, "btStart");
            this.btStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btStart.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btStart.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btStart.Name = "btStart";
            this.toolTip1.SetToolTip(this.btStart, resources.GetString("btStart.ToolTip"));
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // tbCoransw
            // 
            resources.ApplyResources(this.tbCoransw, "tbCoransw");
            this.tbCoransw.Name = "tbCoransw";
            // 
            // btClear
            // 
            resources.ApplyResources(this.btClear, "btClear");
            this.btClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btClear.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btClear.Name = "btClear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Name = "label4";
            // 
            // tbRes
            // 
            resources.ApplyResources(this.tbRes, "tbRes");
            this.tbRes.Name = "tbRes";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btSavetest
            // 
            resources.ApplyResources(this.btSavetest, "btSavetest");
            this.btSavetest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSavetest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btSavetest.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btSavetest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btSavetest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btSavetest.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btSavetest.Name = "btSavetest";
            this.btSavetest.UseVisualStyleBackColor = false;
            this.btSavetest.Click += new System.EventHandler(this.btSavetest_Click);
            // 
            // btWatch
            // 
            resources.ApplyResources(this.btWatch, "btWatch");
            this.btWatch.Name = "btWatch";
            // 
            // btOK
            // 
            resources.ApplyResources(this.btOK, "btOK");
            this.btOK.Name = "btOK";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTestToolStripMenuItem,
            this.correctFileToolStripMenuItem1,
            this.deleteFileToolStripMenuItem1,
            this.addQuestionToolStripMenuItem1,
            this.saveFileToolStripMenuItem1,
            this.clearDataToolStripMenuItem1,
            this.showResultsToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // loadTestToolStripMenuItem
            // 
            this.loadTestToolStripMenuItem.Name = "loadTestToolStripMenuItem";
            resources.ApplyResources(this.loadTestToolStripMenuItem, "loadTestToolStripMenuItem");
            this.loadTestToolStripMenuItem.Click += new System.EventHandler(this.loadTestToolStripMenuItem_Click);
            // 
            // correctFileToolStripMenuItem1
            // 
            this.correctFileToolStripMenuItem1.Name = "correctFileToolStripMenuItem1";
            resources.ApplyResources(this.correctFileToolStripMenuItem1, "correctFileToolStripMenuItem1");
            this.correctFileToolStripMenuItem1.Click += new System.EventHandler(this.correctFileToolStripMenuItem1_Click);
            // 
            // deleteFileToolStripMenuItem1
            // 
            this.deleteFileToolStripMenuItem1.Name = "deleteFileToolStripMenuItem1";
            resources.ApplyResources(this.deleteFileToolStripMenuItem1, "deleteFileToolStripMenuItem1");
            this.deleteFileToolStripMenuItem1.Click += new System.EventHandler(this.deleteFileToolStripMenuItem1_Click);
            // 
            // addQuestionToolStripMenuItem1
            // 
            this.addQuestionToolStripMenuItem1.Name = "addQuestionToolStripMenuItem1";
            resources.ApplyResources(this.addQuestionToolStripMenuItem1, "addQuestionToolStripMenuItem1");
            this.addQuestionToolStripMenuItem1.Click += new System.EventHandler(this.addQuestionToolStripMenuItem1_Click);
            // 
            // saveFileToolStripMenuItem1
            // 
            this.saveFileToolStripMenuItem1.Name = "saveFileToolStripMenuItem1";
            resources.ApplyResources(this.saveFileToolStripMenuItem1, "saveFileToolStripMenuItem1");
            this.saveFileToolStripMenuItem1.Click += new System.EventHandler(this.saveFileToolStripMenuItem1_Click);
            // 
            // clearDataToolStripMenuItem1
            // 
            this.clearDataToolStripMenuItem1.Name = "clearDataToolStripMenuItem1";
            resources.ApplyResources(this.clearDataToolStripMenuItem1, "clearDataToolStripMenuItem1");
            this.clearDataToolStripMenuItem1.Click += new System.EventHandler(this.clearDataToolStripMenuItem1_Click);
            // 
            // showResultsToolStripMenuItem1
            // 
            this.showResultsToolStripMenuItem1.Name = "showResultsToolStripMenuItem1";
            resources.ApplyResources(this.showResultsToolStripMenuItem1, "showResultsToolStripMenuItem1");
            this.showResultsToolStripMenuItem1.Click += new System.EventHandler(this.showResultsToolStripMenuItem1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.aboutToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.correctFileToolStripMenuItem,
            this.addQuestionToolStripMenuItem,
            this.deleteFileToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            resources.ApplyResources(this.loadFileToolStripMenuItem, "loadFileToolStripMenuItem");
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // correctFileToolStripMenuItem
            // 
            this.correctFileToolStripMenuItem.Name = "correctFileToolStripMenuItem";
            resources.ApplyResources(this.correctFileToolStripMenuItem, "correctFileToolStripMenuItem");
            this.correctFileToolStripMenuItem.Click += new System.EventHandler(this.correctFileToolStripMenuItem_Click);
            // 
            // addQuestionToolStripMenuItem
            // 
            this.addQuestionToolStripMenuItem.Name = "addQuestionToolStripMenuItem";
            resources.ApplyResources(this.addQuestionToolStripMenuItem, "addQuestionToolStripMenuItem");
            this.addQuestionToolStripMenuItem.Click += new System.EventHandler(this.addQuestionToolStripMenuItem_Click);
            // 
            // deleteFileToolStripMenuItem
            // 
            this.deleteFileToolStripMenuItem.Name = "deleteFileToolStripMenuItem";
            resources.ApplyResources(this.deleteFileToolStripMenuItem, "deleteFileToolStripMenuItem");
            this.deleteFileToolStripMenuItem.Click += new System.EventHandler(this.deleteFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            resources.ApplyResources(this.saveFileToolStripMenuItem, "saveFileToolStripMenuItem");
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearDataToolStripMenuItem,
            this.showResultsToolStripMenuItem});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            resources.ApplyResources(this.serviceToolStripMenuItem, "serviceToolStripMenuItem");
            // 
            // clearDataToolStripMenuItem
            // 
            this.clearDataToolStripMenuItem.Name = "clearDataToolStripMenuItem";
            resources.ApplyResources(this.clearDataToolStripMenuItem, "clearDataToolStripMenuItem");
            this.clearDataToolStripMenuItem.Click += new System.EventHandler(this.clearDataToolStripMenuItem_Click);
            // 
            // showResultsToolStripMenuItem
            // 
            this.showResultsToolStripMenuItem.Name = "showResultsToolStripMenuItem";
            resources.ApplyResources(this.showResultsToolStripMenuItem, "showResultsToolStripMenuItem");
            this.showResultsToolStripMenuItem.Click += new System.EventHandler(this.showResultsToolStripMenuItem_Click);
            // 
            // tbCode
            // 
            resources.ApplyResources(this.tbCode, "tbCode");
            this.tbCode.Name = "tbCode";
            // 
            // btRes
            // 
            this.btRes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btRes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btRes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btRes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btRes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.btRes, "btRes");
            this.btRes.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btRes.Name = "btRes";
            this.btRes.UseVisualStyleBackColor = false;
            this.btRes.Click += new System.EventHandler(this.btRes_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbTeacher);
            this.panel1.Controls.Add(this.rbStud);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbNet);
            this.panel2.Controls.Add(this.rbPlus);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lbLn
            // 
            resources.ApplyResources(this.lbLn, "lbLn");
            this.lbLn.Name = "lbLn";
            // 
            // lbN
            // 
            resources.ApplyResources(this.lbN, "lbN");
            this.lbN.Name = "lbN";
            // 
            // lbF
            // 
            resources.ApplyResources(this.lbF, "lbF");
            this.lbF.Name = "lbF";
            // 
            // lbg
            // 
            resources.ApplyResources(this.lbg, "lbg");
            this.lbg.Name = "lbg";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Questionform
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lbg);
            this.Controls.Add(this.lbF);
            this.Controls.Add(this.lbN);
            this.Controls.Add(this.lbLn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btRes);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btWatch);
            this.Controls.Add(this.btSavetest);
            this.Controls.Add(this.tbRes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.tbCoransw);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.tbGroup);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.btDeleteTest);
            this.Controls.Add(this.btCorrect);
            this.Controls.Add(this.btLoadTest);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btAddQ);
            this.Controls.Add(this.listView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Questionform";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Questionform_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Question;
        private System.Windows.Forms.ColumnHeader answerA;
        private System.Windows.Forms.ColumnHeader answerB;
        private System.Windows.Forms.ColumnHeader answerC;
        private System.Windows.Forms.ColumnHeader answerD;
        private System.Windows.Forms.ColumnHeader correctanswer;
        private System.Windows.Forms.Button btAddQ;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RadioButton rbNet;
        private System.Windows.Forms.RadioButton rbPlus;
        private System.Windows.Forms.Button btLoadTest;
        private System.Windows.Forms.Button btCorrect;
        private System.Windows.Forms.Button btDeleteTest;
        private System.Windows.Forms.RadioButton rbStud;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbGroup;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox tbCoransw;
        private System.Windows.Forms.RadioButton rbTeacher;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btSavetest;
        private System.Windows.Forms.Button btWatch;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Button btRes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbLn;
        private System.Windows.Forms.Label lbN;
        private System.Windows.Forms.Label lbF;
        private System.Windows.Forms.Label lbg;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correctFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correctFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addQuestionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDataToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showResultsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

