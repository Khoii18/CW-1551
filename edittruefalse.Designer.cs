namespace Quizzgame
{
    partial class edittruefalse
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
            label2 = new Label();
            label1 = new Label();
            rt_truefalseqs = new RichTextBox();
            cb_truefalse = new ComboBox();
            bt_update = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(634, 137);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(215, 41);
            label2.TabIndex = 9;
            label2.Text = "correct Answer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 79);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(280, 41);
            label1.TabIndex = 8;
            label1.Text = "True/False Question";
            // 
            // rt_truefalseqs
            // 
            rt_truefalseqs.Location = new Point(80, 128);
            rt_truefalseqs.Margin = new Padding(7, 8, 7, 8);
            rt_truefalseqs.Name = "rt_truefalseqs";
            rt_truefalseqs.Size = new Size(463, 504);
            rt_truefalseqs.TabIndex = 6;
            rt_truefalseqs.Text = "";
            // 
            // cb_truefalse
            // 
            cb_truefalse.FormattingEnabled = true;
            cb_truefalse.Items.AddRange(new object[] { "True", "False" });
            cb_truefalse.Location = new Point(634, 221);
            cb_truefalse.Margin = new Padding(7, 8, 7, 8);
            cb_truefalse.Name = "cb_truefalse";
            cb_truefalse.Size = new Size(288, 49);
            cb_truefalse.TabIndex = 5;
            // 
            // bt_update
            // 
            bt_update.Location = new Point(746, 350);
            bt_update.Margin = new Padding(7, 8, 7, 8);
            bt_update.Name = "bt_update";
            bt_update.Size = new Size(182, 63);
            bt_update.TabIndex = 10;
            bt_update.Text = "Update";
            bt_update.UseVisualStyleBackColor = true;
            bt_update.Click += bt_update_Click;
            // 
            // edittruefalse
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 907);
            Controls.Add(bt_update);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rt_truefalseqs);
            Controls.Add(cb_truefalse);
            Margin = new Padding(7, 8, 7, 8);
            Name = "edittruefalse";
            Text = "edittruefalse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private RichTextBox rt_truefalseqs;
        private ComboBox cb_truefalse;
        private Button bt_update;
    }
}