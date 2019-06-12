namespace Diary
{
    partial class SummaryForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.work = new System.Windows.Forms.TextBox();
            this.labelEvent = new System.Windows.Forms.Label();
            this.life = new System.Windows.Forms.TextBox();
            this.play = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.live = new System.Windows.Forms.TextBox();
            this.language = new System.Windows.Forms.TextBox();
            this.project = new System.Windows.Forms.TextBox();
            this.discipline = new System.Windows.Forms.TextBox();
            this.business = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.exercise = new System.Windows.Forms.TextBox();
            this.communication = new System.Windows.Forms.TextBox();
            this.sleep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.other = new System.Windows.Forms.TextBox();
            this.game = new System.Windows.Forms.TextBox();
            this.animation = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.book = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.TextBox();
            this.TimeTable = new System.Windows.Forms.GroupBox();
            this.totalCount = new System.Windows.Forms.Label();
            this.otherDescription = new System.Windows.Forms.Label();
            this.eroDescription = new System.Windows.Forms.Label();
            this.gameDescription = new System.Windows.Forms.Label();
            this.animationDescription = new System.Windows.Forms.Label();
            this.bookDescription = new System.Windows.Forms.Label();
            this.exerciseDescription = new System.Windows.Forms.Label();
            this.disciplineDescription = new System.Windows.Forms.Label();
            this.communicationDescription = new System.Windows.Forms.Label();
            this.sleepDescription = new System.Windows.Forms.Label();
            this.liveDescription = new System.Windows.Forms.Label();
            this.fantasyDescription = new System.Windows.Forms.Label();
            this.languageDescription = new System.Windows.Forms.Label();
            this.projectDescription = new System.Windows.Forms.Label();
            this.noteDescription = new System.Windows.Forms.Label();
            this.businessDescription = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.playLabel = new System.Windows.Forms.Label();
            this.lifeLabel = new System.Windows.Forms.Label();
            this.workLabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.fantasy = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ero = new System.Windows.Forms.TextBox();
            this.dataGridViewEvent = new System.Windows.Forms.DataGridView();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.TimeTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 37);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 30);
            this.dateTimePicker1.TabIndex = 90;
            this.dateTimePicker1.Value = new System.DateTime(2019, 3, 16, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Diary.Properties.Resources.menustrip_right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fileToolStripMenuItem.Text = "File (&F)";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.openToolStripMenuItem.Text = "Open..";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.viewToolStripMenuItem.Text = "View (&V)";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.optionToolStripMenuItem.Text = "Option (&O)";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.helpToolStripMenuItem.Text = "Help (&H)";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.aboutToolStripMenuItem.Text = "Version";
            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(1768, 892);
            this.ButtonNext.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(100, 30);
            this.ButtonNext.TabIndex = 45;
            this.ButtonNext.Text = "Next";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(1647, 892);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(100, 30);
            this.buttonPrevious.TabIndex = 44;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // work
            // 
            this.work.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.work.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.work.Location = new System.Drawing.Point(96, 50);
            this.work.Margin = new System.Windows.Forms.Padding(2);
            this.work.Name = "work";
            this.work.ReadOnly = true;
            this.work.Size = new System.Drawing.Size(68, 26);
            this.work.TabIndex = 9;
            this.work.Text = "0";
            // 
            // labelEvent
            // 
            this.labelEvent.AutoSize = true;
            this.labelEvent.BackColor = System.Drawing.Color.Transparent;
            this.labelEvent.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEvent.ForeColor = System.Drawing.Color.Green;
            this.labelEvent.Location = new System.Drawing.Point(784, 72);
            this.labelEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEvent.Name = "labelEvent";
            this.labelEvent.Size = new System.Drawing.Size(87, 27);
            this.labelEvent.TabIndex = 19;
            this.labelEvent.Text = "Event";
            // 
            // life
            // 
            this.life.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.life.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.life.Location = new System.Drawing.Point(96, 323);
            this.life.Margin = new System.Windows.Forms.Padding(2);
            this.life.Name = "life";
            this.life.ReadOnly = true;
            this.life.Size = new System.Drawing.Size(68, 26);
            this.life.TabIndex = 20;
            this.life.Text = "0";
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.play.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.play.Location = new System.Drawing.Point(96, 564);
            this.play.Margin = new System.Windows.Forms.Padding(2);
            this.play.Name = "play";
            this.play.ReadOnly = true;
            this.play.Size = new System.Drawing.Size(68, 26);
            this.play.TabIndex = 21;
            this.play.Text = "0";
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.total.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.total.Location = new System.Drawing.Point(107, 787);
            this.total.Margin = new System.Windows.Forms.Padding(2);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(80, 26);
            this.total.TabIndex = 23;
            this.total.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(16, 787);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 27);
            this.label1.TabIndex = 91;
            this.label1.Text = "total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(16, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 94;
            this.label3.Text = "work";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(16, 322);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 27);
            this.label4.TabIndex = 95;
            this.label4.Text = "life";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(16, 558);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 27);
            this.label5.TabIndex = 96;
            this.label5.Text = "play";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(268, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 27);
            this.label6.TabIndex = 110;
            this.label6.Text = "language";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(268, 152);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 27);
            this.label7.TabIndex = 109;
            this.label7.Text = "project";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(268, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 27);
            this.label8.TabIndex = 108;
            this.label8.Text = "business";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(268, 260);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 27);
            this.label9.TabIndex = 107;
            this.label9.Text = "fantasy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(268, 324);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 27);
            this.label10.TabIndex = 106;
            this.label10.Text = "live";
            // 
            // live
            // 
            this.live.BackColor = System.Drawing.SystemColors.Info;
            this.live.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.live.Location = new System.Drawing.Point(429, 324);
            this.live.Margin = new System.Windows.Forms.Padding(2);
            this.live.Name = "live";
            this.live.Size = new System.Drawing.Size(80, 26);
            this.live.TabIndex = 105;
            this.live.TextChanged += new System.EventHandler(this.TimeTable_TextChanged);
            // 
            // language
            // 
            this.language.BackColor = System.Drawing.SystemColors.Info;
            this.language.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.language.Location = new System.Drawing.Point(429, 202);
            this.language.Margin = new System.Windows.Forms.Padding(2);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(80, 26);
            this.language.TabIndex = 104;
            this.language.TextChanged += new System.EventHandler(this.TimeTable_TextChanged);
            // 
            // project
            // 
            this.project.BackColor = System.Drawing.SystemColors.Info;
            this.project.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.project.Location = new System.Drawing.Point(429, 153);
            this.project.Margin = new System.Windows.Forms.Padding(2);
            this.project.Name = "project";
            this.project.Size = new System.Drawing.Size(80, 26);
            this.project.TabIndex = 103;
            this.project.TextChanged += new System.EventHandler(this.TimeTable_TextChanged);
            // 
            // discipline
            // 
            this.discipline.BackColor = System.Drawing.SystemColors.Info;
            this.discipline.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.discipline.Location = new System.Drawing.Point(429, 472);
            this.discipline.Margin = new System.Windows.Forms.Padding(2);
            this.discipline.Name = "discipline";
            this.discipline.Size = new System.Drawing.Size(80, 26);
            this.discipline.TabIndex = 102;
            this.discipline.TextChanged += new System.EventHandler(this.TimeTable_TextChanged);
            // 
            // business
            // 
            this.business.BackColor = System.Drawing.SystemColors.Info;
            this.business.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.business.Location = new System.Drawing.Point(429, 51);
            this.business.Margin = new System.Windows.Forms.Padding(2);
            this.business.Name = "business";
            this.business.Size = new System.Drawing.Size(80, 26);
            this.business.TabIndex = 101;
            this.business.TextChanged += new System.EventHandler(this.TimeTable_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(268, 421);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 27);
            this.label11.TabIndex = 116;
            this.label11.Text = "communic";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(268, 376);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 27);
            this.label12.TabIndex = 115;
            this.label12.Text = "sleep";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.Location = new System.Drawing.Point(268, 509);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 27);
            this.label13.TabIndex = 114;
            this.label13.Text = "exercise";
            // 
            // exercise
            // 
            this.exercise.BackColor = System.Drawing.SystemColors.Info;
            this.exercise.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exercise.Location = new System.Drawing.Point(429, 511);
            this.exercise.Margin = new System.Windows.Forms.Padding(2);
            this.exercise.Name = "exercise";
            this.exercise.Size = new System.Drawing.Size(80, 26);
            this.exercise.TabIndex = 113;
            this.exercise.TextChanged += new System.EventHandler(this.TimeTable_TextChanged);
            // 
            // communication
            // 
            this.communication.BackColor = System.Drawing.SystemColors.Info;
            this.communication.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.communication.Location = new System.Drawing.Point(429, 423);
            this.communication.Margin = new System.Windows.Forms.Padding(2);
            this.communication.Name = "communication";
            this.communication.Size = new System.Drawing.Size(80, 26);
            this.communication.TabIndex = 112;
            this.communication.TextChanged += new System.EventHandler(this.TimeTable_TextChanged);
            // 
            // sleep
            // 
            this.sleep.BackColor = System.Drawing.SystemColors.Info;
            this.sleep.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sleep.Location = new System.Drawing.Point(429, 377);
            this.sleep.Margin = new System.Windows.Forms.Padding(2);
            this.sleep.Name = "sleep";
            this.sleep.Size = new System.Drawing.Size(80, 26);
            this.sleep.TabIndex = 111;
            this.sleep.TextChanged += new System.EventHandler(this.TimeTable_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(268, 643);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 124;
            this.label2.Text = "game";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.Green;
            this.label14.Location = new System.Drawing.Point(268, 607);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 27);
            this.label14.TabIndex = 123;
            this.label14.Text = "anima";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.Green;
            this.label15.Location = new System.Drawing.Point(268, 710);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 27);
            this.label15.TabIndex = 122;
            this.label15.Text = "other";
            // 
            // other
            // 
            this.other.BackColor = System.Drawing.SystemColors.Info;
            this.other.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.other.Location = new System.Drawing.Point(429, 711);
            this.other.Margin = new System.Windows.Forms.Padding(2);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(80, 26);
            this.other.TabIndex = 121;
            this.other.TextChanged += new System.EventHandler(this.TimeTable_TextChanged);
            // 
            // game
            // 
            this.game.BackColor = System.Drawing.SystemColors.Info;
            this.game.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.game.Location = new System.Drawing.Point(429, 645);
            this.game.Margin = new System.Windows.Forms.Padding(2);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(80, 26);
            this.game.TabIndex = 120;
            this.game.TextChanged += new System.EventHandler(this.TimeTable_TextChanged);
            // 
            // animation
            // 
            this.animation.BackColor = System.Drawing.SystemColors.Info;
            this.animation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.animation.Location = new System.Drawing.Point(429, 608);
            this.animation.Margin = new System.Windows.Forms.Padding(2);
            this.animation.Name = "animation";
            this.animation.Size = new System.Drawing.Size(80, 26);
            this.animation.TabIndex = 119;
            this.animation.TextChanged += new System.EventHandler(this.TimeTable_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.Color.Green;
            this.label16.Location = new System.Drawing.Point(268, 559);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 27);
            this.label16.TabIndex = 118;
            this.label16.Text = "book";
            // 
            // book
            // 
            this.book.BackColor = System.Drawing.SystemColors.Info;
            this.book.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.book.Location = new System.Drawing.Point(429, 560);
            this.book.Margin = new System.Windows.Forms.Padding(2);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(80, 26);
            this.book.TabIndex = 117;
            this.book.TextChanged += new System.EventHandler(this.TimeTable_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.Color.Green;
            this.label17.Location = new System.Drawing.Point(268, 102);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 27);
            this.label17.TabIndex = 128;
            this.label17.Text = "note";
            // 
            // note
            // 
            this.note.BackColor = System.Drawing.SystemColors.Info;
            this.note.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.note.Location = new System.Drawing.Point(430, 100);
            this.note.Margin = new System.Windows.Forms.Padding(2);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(80, 26);
            this.note.TabIndex = 125;
            this.note.TextChanged += new System.EventHandler(this.TimeTable_TextChanged);
            // 
            // TimeTable
            // 
            this.TimeTable.BackColor = System.Drawing.Color.Transparent;
            this.TimeTable.Controls.Add(this.totalCount);
            this.TimeTable.Controls.Add(this.otherDescription);
            this.TimeTable.Controls.Add(this.eroDescription);
            this.TimeTable.Controls.Add(this.gameDescription);
            this.TimeTable.Controls.Add(this.animationDescription);
            this.TimeTable.Controls.Add(this.bookDescription);
            this.TimeTable.Controls.Add(this.exerciseDescription);
            this.TimeTable.Controls.Add(this.disciplineDescription);
            this.TimeTable.Controls.Add(this.communicationDescription);
            this.TimeTable.Controls.Add(this.sleepDescription);
            this.TimeTable.Controls.Add(this.liveDescription);
            this.TimeTable.Controls.Add(this.fantasyDescription);
            this.TimeTable.Controls.Add(this.languageDescription);
            this.TimeTable.Controls.Add(this.projectDescription);
            this.TimeTable.Controls.Add(this.noteDescription);
            this.TimeTable.Controls.Add(this.businessDescription);
            this.TimeTable.Controls.Add(this.totalLabel);
            this.TimeTable.Controls.Add(this.playLabel);
            this.TimeTable.Controls.Add(this.lifeLabel);
            this.TimeTable.Controls.Add(this.workLabel);
            this.TimeTable.Controls.Add(this.label20);
            this.TimeTable.Controls.Add(this.fantasy);
            this.TimeTable.Controls.Add(this.label19);
            this.TimeTable.Controls.Add(this.ero);
            this.TimeTable.Controls.Add(this.label17);
            this.TimeTable.Controls.Add(this.note);
            this.TimeTable.Controls.Add(this.label2);
            this.TimeTable.Controls.Add(this.label14);
            this.TimeTable.Controls.Add(this.label15);
            this.TimeTable.Controls.Add(this.other);
            this.TimeTable.Controls.Add(this.game);
            this.TimeTable.Controls.Add(this.animation);
            this.TimeTable.Controls.Add(this.label16);
            this.TimeTable.Controls.Add(this.book);
            this.TimeTable.Controls.Add(this.label11);
            this.TimeTable.Controls.Add(this.label12);
            this.TimeTable.Controls.Add(this.label13);
            this.TimeTable.Controls.Add(this.exercise);
            this.TimeTable.Controls.Add(this.communication);
            this.TimeTable.Controls.Add(this.sleep);
            this.TimeTable.Controls.Add(this.label6);
            this.TimeTable.Controls.Add(this.label7);
            this.TimeTable.Controls.Add(this.label8);
            this.TimeTable.Controls.Add(this.label9);
            this.TimeTable.Controls.Add(this.label10);
            this.TimeTable.Controls.Add(this.live);
            this.TimeTable.Controls.Add(this.language);
            this.TimeTable.Controls.Add(this.project);
            this.TimeTable.Controls.Add(this.discipline);
            this.TimeTable.Controls.Add(this.business);
            this.TimeTable.Controls.Add(this.label5);
            this.TimeTable.Controls.Add(this.label4);
            this.TimeTable.Controls.Add(this.label3);
            this.TimeTable.Controls.Add(this.label1);
            this.TimeTable.Controls.Add(this.total);
            this.TimeTable.Controls.Add(this.play);
            this.TimeTable.Controls.Add(this.life);
            this.TimeTable.Controls.Add(this.work);
            this.TimeTable.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold);
            this.TimeTable.ForeColor = System.Drawing.Color.Green;
            this.TimeTable.Location = new System.Drawing.Point(12, 72);
            this.TimeTable.Name = "TimeTable";
            this.TimeTable.Size = new System.Drawing.Size(749, 852);
            this.TimeTable.TabIndex = 129;
            this.TimeTable.TabStop = false;
            this.TimeTable.Text = "TimeTable";
            // 
            // totalCount
            // 
            this.totalCount.AutoSize = true;
            this.totalCount.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.totalCount.Location = new System.Drawing.Point(258, 792);
            this.totalCount.Name = "totalCount";
            this.totalCount.Size = new System.Drawing.Size(106, 21);
            this.totalCount.TabIndex = 145;
            this.totalCount.Text = "Count: 1";
            this.totalCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // otherDescription
            // 
            this.otherDescription.AutoSize = true;
            this.otherDescription.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.otherDescription.Location = new System.Drawing.Point(529, 716);
            this.otherDescription.Name = "otherDescription";
            this.otherDescription.Size = new System.Drawing.Size(142, 21);
            this.otherDescription.TabIndex = 144;
            this.otherDescription.Text = "11%  Cnt: 8";
            this.otherDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // eroDescription
            // 
            this.eroDescription.AutoSize = true;
            this.eroDescription.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.eroDescription.Location = new System.Drawing.Point(529, 680);
            this.eroDescription.Name = "eroDescription";
            this.eroDescription.Size = new System.Drawing.Size(142, 21);
            this.eroDescription.TabIndex = 143;
            this.eroDescription.Text = "11%  Cnt: 8";
            this.eroDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gameDescription
            // 
            this.gameDescription.AutoSize = true;
            this.gameDescription.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gameDescription.Location = new System.Drawing.Point(529, 650);
            this.gameDescription.Name = "gameDescription";
            this.gameDescription.Size = new System.Drawing.Size(142, 21);
            this.gameDescription.TabIndex = 142;
            this.gameDescription.Text = "11%  Cnt: 8";
            this.gameDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // animationDescription
            // 
            this.animationDescription.AutoSize = true;
            this.animationDescription.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.animationDescription.Location = new System.Drawing.Point(529, 613);
            this.animationDescription.Name = "animationDescription";
            this.animationDescription.Size = new System.Drawing.Size(142, 21);
            this.animationDescription.TabIndex = 135;
            this.animationDescription.Text = "11%  Cnt: 8";
            this.animationDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bookDescription
            // 
            this.bookDescription.AutoSize = true;
            this.bookDescription.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bookDescription.Location = new System.Drawing.Point(529, 564);
            this.bookDescription.Name = "bookDescription";
            this.bookDescription.Size = new System.Drawing.Size(142, 21);
            this.bookDescription.TabIndex = 135;
            this.bookDescription.Text = "11%  Cnt: 8";
            this.bookDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // exerciseDescription
            // 
            this.exerciseDescription.AutoSize = true;
            this.exerciseDescription.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exerciseDescription.Location = new System.Drawing.Point(529, 515);
            this.exerciseDescription.Name = "exerciseDescription";
            this.exerciseDescription.Size = new System.Drawing.Size(142, 21);
            this.exerciseDescription.TabIndex = 141;
            this.exerciseDescription.Text = "11%  Cnt: 8";
            this.exerciseDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // disciplineDescription
            // 
            this.disciplineDescription.AutoSize = true;
            this.disciplineDescription.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.disciplineDescription.Location = new System.Drawing.Point(529, 477);
            this.disciplineDescription.Name = "disciplineDescription";
            this.disciplineDescription.Size = new System.Drawing.Size(142, 21);
            this.disciplineDescription.TabIndex = 135;
            this.disciplineDescription.Text = "11%  Cnt: 8";
            this.disciplineDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // communicationDescription
            // 
            this.communicationDescription.AutoSize = true;
            this.communicationDescription.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.communicationDescription.Location = new System.Drawing.Point(529, 428);
            this.communicationDescription.Name = "communicationDescription";
            this.communicationDescription.Size = new System.Drawing.Size(142, 21);
            this.communicationDescription.TabIndex = 135;
            this.communicationDescription.Text = "11%  Cnt: 8";
            this.communicationDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sleepDescription
            // 
            this.sleepDescription.AutoSize = true;
            this.sleepDescription.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sleepDescription.Location = new System.Drawing.Point(529, 382);
            this.sleepDescription.Name = "sleepDescription";
            this.sleepDescription.Size = new System.Drawing.Size(142, 21);
            this.sleepDescription.TabIndex = 135;
            this.sleepDescription.Text = "11%  Cnt: 8";
            this.sleepDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // liveDescription
            // 
            this.liveDescription.AutoSize = true;
            this.liveDescription.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.liveDescription.Location = new System.Drawing.Point(529, 330);
            this.liveDescription.Name = "liveDescription";
            this.liveDescription.Size = new System.Drawing.Size(142, 21);
            this.liveDescription.TabIndex = 140;
            this.liveDescription.Text = "11%  Cnt: 8";
            this.liveDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fantasyDescription
            // 
            this.fantasyDescription.AutoSize = true;
            this.fantasyDescription.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fantasyDescription.Location = new System.Drawing.Point(529, 265);
            this.fantasyDescription.Name = "fantasyDescription";
            this.fantasyDescription.Size = new System.Drawing.Size(142, 21);
            this.fantasyDescription.TabIndex = 135;
            this.fantasyDescription.Text = "11%  Cnt: 8";
            this.fantasyDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // languageDescription
            // 
            this.languageDescription.AutoSize = true;
            this.languageDescription.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.languageDescription.Location = new System.Drawing.Point(529, 207);
            this.languageDescription.Name = "languageDescription";
            this.languageDescription.Size = new System.Drawing.Size(46, 21);
            this.languageDescription.TabIndex = 139;
            this.languageDescription.Text = "11%";
            this.languageDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // projectDescription
            // 
            this.projectDescription.AutoSize = true;
            this.projectDescription.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.projectDescription.Location = new System.Drawing.Point(529, 158);
            this.projectDescription.Name = "projectDescription";
            this.projectDescription.Size = new System.Drawing.Size(46, 21);
            this.projectDescription.TabIndex = 138;
            this.projectDescription.Text = "11%";
            this.projectDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // noteDescription
            // 
            this.noteDescription.AutoSize = true;
            this.noteDescription.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.noteDescription.Location = new System.Drawing.Point(529, 105);
            this.noteDescription.Name = "noteDescription";
            this.noteDescription.Size = new System.Drawing.Size(46, 21);
            this.noteDescription.TabIndex = 137;
            this.noteDescription.Text = "11%";
            this.noteDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // businessDescription
            // 
            this.businessDescription.AutoSize = true;
            this.businessDescription.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.businessDescription.Location = new System.Drawing.Point(529, 56);
            this.businessDescription.Name = "businessDescription";
            this.businessDescription.Size = new System.Drawing.Size(142, 21);
            this.businessDescription.TabIndex = 134;
            this.businessDescription.Text = "11%  Cnt: 8";
            this.businessDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.totalLabel.Location = new System.Drawing.Point(192, 792);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(46, 21);
            this.totalLabel.TabIndex = 136;
            this.totalLabel.Text = "11%";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // playLabel
            // 
            this.playLabel.AutoSize = true;
            this.playLabel.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.playLabel.Location = new System.Drawing.Point(169, 569);
            this.playLabel.Name = "playLabel";
            this.playLabel.Size = new System.Drawing.Size(46, 21);
            this.playLabel.TabIndex = 135;
            this.playLabel.Text = "11%";
            this.playLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lifeLabel
            // 
            this.lifeLabel.AutoSize = true;
            this.lifeLabel.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lifeLabel.Location = new System.Drawing.Point(169, 328);
            this.lifeLabel.Name = "lifeLabel";
            this.lifeLabel.Size = new System.Drawing.Size(46, 21);
            this.lifeLabel.TabIndex = 134;
            this.lifeLabel.Text = "11%";
            this.lifeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // workLabel
            // 
            this.workLabel.AutoSize = true;
            this.workLabel.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.workLabel.Location = new System.Drawing.Point(169, 50);
            this.workLabel.Name = "workLabel";
            this.workLabel.Size = new System.Drawing.Size(46, 21);
            this.workLabel.TabIndex = 133;
            this.workLabel.Text = "11%";
            this.workLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.Color.Green;
            this.label20.Location = new System.Drawing.Point(268, 470);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(132, 27);
            this.label20.TabIndex = 132;
            this.label20.Text = "discipli";
            // 
            // fantasy
            // 
            this.fantasy.BackColor = System.Drawing.SystemColors.Info;
            this.fantasy.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fantasy.Location = new System.Drawing.Point(430, 261);
            this.fantasy.Margin = new System.Windows.Forms.Padding(2);
            this.fantasy.Name = "fantasy";
            this.fantasy.Size = new System.Drawing.Size(80, 26);
            this.fantasy.TabIndex = 131;
            this.fantasy.TextChanged += new System.EventHandler(this.TimeTable_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.Color.Green;
            this.label19.Location = new System.Drawing.Point(268, 673);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 27);
            this.label19.TabIndex = 130;
            this.label19.Text = "ero";
            // 
            // ero
            // 
            this.ero.BackColor = System.Drawing.SystemColors.Info;
            this.ero.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ero.Location = new System.Drawing.Point(429, 675);
            this.ero.Margin = new System.Windows.Forms.Padding(2);
            this.ero.Name = "ero";
            this.ero.Size = new System.Drawing.Size(80, 26);
            this.ero.TabIndex = 129;
            this.ero.TextChanged += new System.EventHandler(this.TimeTable_TextChanged);
            // 
            // dataGridViewEvent
            // 
            this.dataGridViewEvent.AllowUserToOrderColumns = true;
            this.dataGridViewEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEvent.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEvent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Content,
            this.Duration,
            this.StartTime,
            this.EndTime});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEvent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEvent.GridColor = System.Drawing.SystemColors.Info;
            this.dataGridViewEvent.Location = new System.Drawing.Point(789, 102);
            this.dataGridViewEvent.Name = "dataGridViewEvent";
            this.dataGridViewEvent.RowTemplate.Height = 23;
            this.dataGridViewEvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEvent.Size = new System.Drawing.Size(1079, 785);
            this.dataGridViewEvent.TabIndex = 130;
            // 
            // Content
            // 
            this.Content.HeaderText = "Content";
            this.Content.Name = "Content";
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "StartTime";
            this.StartTime.Name = "StartTime";
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "EndTime";
            this.EndTime.Name = "EndTime";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 200;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.BackgroundImage = global::Diary.Properties.Resources._2017_08_29;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 961);
            this.Controls.Add(this.dataGridViewEvent);
            this.Controls.Add(this.TimeTable);
            this.Controls.Add(this.labelEvent);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SummaryForm";
            this.Text = "Diary.exe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DiaryForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TimeTable.ResumeLayout(false);
            this.TimeTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.TextBox work;
        private System.Windows.Forms.Label labelEvent;
        private System.Windows.Forms.TextBox life;
        private System.Windows.Forms.TextBox play;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox live;
        private System.Windows.Forms.TextBox language;
        private System.Windows.Forms.TextBox project;
        private System.Windows.Forms.TextBox discipline;
        private System.Windows.Forms.TextBox business;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox exercise;
        private System.Windows.Forms.TextBox communication;
        private System.Windows.Forms.TextBox sleep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox other;
        private System.Windows.Forms.TextBox game;
        private System.Windows.Forms.TextBox animation;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox book;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox note;
        private System.Windows.Forms.GroupBox TimeTable;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox ero;
        private System.Windows.Forms.DataGridView dataGridViewEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox fantasy;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Label workLabel;
        private System.Windows.Forms.Label playLabel;
        private System.Windows.Forms.Label lifeLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label otherDescription;
        private System.Windows.Forms.Label eroDescription;
        private System.Windows.Forms.Label gameDescription;
        private System.Windows.Forms.Label animationDescription;
        private System.Windows.Forms.Label bookDescription;
        private System.Windows.Forms.Label exerciseDescription;
        private System.Windows.Forms.Label disciplineDescription;
        private System.Windows.Forms.Label communicationDescription;
        private System.Windows.Forms.Label sleepDescription;
        private System.Windows.Forms.Label liveDescription;
        private System.Windows.Forms.Label fantasyDescription;
        private System.Windows.Forms.Label languageDescription;
        private System.Windows.Forms.Label projectDescription;
        private System.Windows.Forms.Label noteDescription;
        private System.Windows.Forms.Label businessDescription;
        private System.Windows.Forms.Label totalCount;
    }
}

