namespace Diary
{
    partial class CollectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label LevelLabel;
            this.ToDiaryForm = new System.Windows.Forms.Button();
            this.ToCSummaryForm = new System.Windows.Forms.Button();
            this.LevelCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.InputTimeLabel = new System.Windows.Forms.Label();
            this.RealeaseTimeLabel = new System.Windows.Forms.Label();
            this.CollectionName = new System.Windows.Forms.TextBox();
            this.CollectionType = new System.Windows.Forms.TextBox();
            this.InputTime = new System.Windows.Forms.TextBox();
            this.RealeaseTime = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            LevelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LevelLabel
            // 
            LevelLabel.AutoSize = true;
            LevelLabel.BackColor = System.Drawing.Color.Transparent;
            LevelLabel.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            LevelLabel.ForeColor = System.Drawing.Color.Green;
            LevelLabel.Location = new System.Drawing.Point(1699, 194);
            LevelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            LevelLabel.Name = "LevelLabel";
            LevelLabel.Size = new System.Drawing.Size(87, 27);
            LevelLabel.TabIndex = 137;
            LevelLabel.Text = "Level";
            // 
            // ToDiaryForm
            // 
            this.ToDiaryForm.Location = new System.Drawing.Point(115, 11);
            this.ToDiaryForm.Margin = new System.Windows.Forms.Padding(2);
            this.ToDiaryForm.Name = "ToDiaryForm";
            this.ToDiaryForm.Size = new System.Drawing.Size(100, 30);
            this.ToDiaryForm.TabIndex = 135;
            this.ToDiaryForm.Text = "DiaryForm";
            this.ToDiaryForm.UseVisualStyleBackColor = true;
            this.ToDiaryForm.Click += new System.EventHandler(this.ToDiaryForm_Click);
            // 
            // ToCSummaryForm
            // 
            this.ToCSummaryForm.Location = new System.Drawing.Point(11, 11);
            this.ToCSummaryForm.Margin = new System.Windows.Forms.Padding(2);
            this.ToCSummaryForm.Name = "ToCSummaryForm";
            this.ToCSummaryForm.Size = new System.Drawing.Size(100, 30);
            this.ToCSummaryForm.TabIndex = 134;
            this.ToCSummaryForm.Text = "CSummaryForm";
            this.ToCSummaryForm.UseVisualStyleBackColor = true;
            // 
            // LevelCheckedListBox
            // 
            this.LevelCheckedListBox.BackColor = System.Drawing.SystemColors.Info;
            this.LevelCheckedListBox.CheckOnClick = true;
            this.LevelCheckedListBox.Font = new System.Drawing.Font("宋体", 11F);
            this.LevelCheckedListBox.FormattingEnabled = true;
            this.LevelCheckedListBox.Items.AddRange(new object[] {
            "White",
            "Green",
            "Blue",
            "Yellow",
            "Orange",
            "Pink",
            "Red"});
            this.LevelCheckedListBox.Location = new System.Drawing.Point(1704, 224);
            this.LevelCheckedListBox.Name = "LevelCheckedListBox";
            this.LevelCheckedListBox.Size = new System.Drawing.Size(120, 137);
            this.LevelCheckedListBox.TabIndex = 136;
            this.LevelCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.LevelCheckedListBox_ItemCheck);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameLabel.ForeColor = System.Drawing.Color.Green;
            this.NameLabel.Location = new System.Drawing.Point(1699, 37);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(72, 27);
            this.NameLabel.TabIndex = 138;
            this.NameLabel.Text = "Name";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TypeLabel.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TypeLabel.ForeColor = System.Drawing.Color.Green;
            this.TypeLabel.Location = new System.Drawing.Point(1699, 115);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(72, 27);
            this.TypeLabel.TabIndex = 139;
            this.TypeLabel.Text = "Type";
            // 
            // InputTimeLabel
            // 
            this.InputTimeLabel.AutoSize = true;
            this.InputTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.InputTimeLabel.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InputTimeLabel.ForeColor = System.Drawing.Color.Green;
            this.InputTimeLabel.Location = new System.Drawing.Point(1699, 384);
            this.InputTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InputTimeLabel.Name = "InputTimeLabel";
            this.InputTimeLabel.Size = new System.Drawing.Size(117, 27);
            this.InputTimeLabel.TabIndex = 140;
            this.InputTimeLabel.Text = "InpTime";
            // 
            // RealeaseTimeLabel
            // 
            this.RealeaseTimeLabel.AutoSize = true;
            this.RealeaseTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.RealeaseTimeLabel.Font = new System.Drawing.Font("楷体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RealeaseTimeLabel.ForeColor = System.Drawing.Color.Green;
            this.RealeaseTimeLabel.Location = new System.Drawing.Point(1699, 463);
            this.RealeaseTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RealeaseTimeLabel.Name = "RealeaseTimeLabel";
            this.RealeaseTimeLabel.Size = new System.Drawing.Size(117, 27);
            this.RealeaseTimeLabel.TabIndex = 141;
            this.RealeaseTimeLabel.Text = "RelTime";
            // 
            // CollectionName
            // 
            this.CollectionName.BackColor = System.Drawing.SystemColors.Info;
            this.CollectionName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CollectionName.Location = new System.Drawing.Point(1704, 75);
            this.CollectionName.Margin = new System.Windows.Forms.Padding(2);
            this.CollectionName.Name = "CollectionName";
            this.CollectionName.Size = new System.Drawing.Size(80, 26);
            this.CollectionName.TabIndex = 142;
            // 
            // CollectionType
            // 
            this.CollectionType.BackColor = System.Drawing.SystemColors.Info;
            this.CollectionType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CollectionType.Location = new System.Drawing.Point(1704, 153);
            this.CollectionType.Margin = new System.Windows.Forms.Padding(2);
            this.CollectionType.Name = "CollectionType";
            this.CollectionType.Size = new System.Drawing.Size(80, 26);
            this.CollectionType.TabIndex = 143;
            // 
            // InputTime
            // 
            this.InputTime.BackColor = System.Drawing.SystemColors.Info;
            this.InputTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InputTime.Location = new System.Drawing.Point(1704, 423);
            this.InputTime.Margin = new System.Windows.Forms.Padding(2);
            this.InputTime.Name = "InputTime";
            this.InputTime.Size = new System.Drawing.Size(80, 26);
            this.InputTime.TabIndex = 144;
            // 
            // RealeaseTime
            // 
            this.RealeaseTime.BackColor = System.Drawing.SystemColors.Info;
            this.RealeaseTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RealeaseTime.Location = new System.Drawing.Point(1704, 507);
            this.RealeaseTime.Margin = new System.Windows.Forms.Padding(2);
            this.RealeaseTime.Name = "RealeaseTime";
            this.RealeaseTime.Size = new System.Drawing.Size(80, 26);
            this.RealeaseTime.TabIndex = 145;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1704, 564);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 146;
            this.button1.Text = "DiaryForm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1904, 961);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RealeaseTime);
            this.Controls.Add(this.InputTime);
            this.Controls.Add(this.CollectionType);
            this.Controls.Add(this.CollectionName);
            this.Controls.Add(this.RealeaseTimeLabel);
            this.Controls.Add(this.InputTimeLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(LevelLabel);
            this.Controls.Add(this.LevelCheckedListBox);
            this.Controls.Add(this.ToDiaryForm);
            this.Controls.Add(this.ToCSummaryForm);
            this.Name = "CollectionForm";
            this.Text = "CSummaryForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToDiaryForm;
        private System.Windows.Forms.Button ToCSummaryForm;
        private System.Windows.Forms.CheckedListBox LevelCheckedListBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label InputTimeLabel;
        private System.Windows.Forms.Label RealeaseTimeLabel;
        private System.Windows.Forms.TextBox CollectionName;
        private System.Windows.Forms.TextBox CollectionType;
        private System.Windows.Forms.TextBox InputTime;
        private System.Windows.Forms.TextBox RealeaseTime;
        private System.Windows.Forms.Button button1;

    }
}