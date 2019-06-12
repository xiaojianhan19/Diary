namespace Diary
{
    partial class ScheduleForm
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
            this.ToDiaryForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToDiaryForm
            // 
            this.ToDiaryForm.Location = new System.Drawing.Point(828, 713);
            this.ToDiaryForm.Name = "ToDiaryForm";
            this.ToDiaryForm.Size = new System.Drawing.Size(142, 30);
            this.ToDiaryForm.TabIndex = 28;
            this.ToDiaryForm.Text = "DiaryForm";
            this.ToDiaryForm.UseVisualStyleBackColor = true;
            //this.ToDiaryForm.Click += new System.EventHandler(this.ToDiaryForm_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::Diary.Properties.Resources._0008020255472759_b;
            this.ClientSize = new System.Drawing.Size(982, 755);
            this.Controls.Add(this.ToDiaryForm);
            this.Name = "ScheduleForm";
            this.Text = "ScheduleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ToDiaryForm;
    }
}