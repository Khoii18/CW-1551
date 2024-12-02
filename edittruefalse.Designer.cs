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
            label2.Location = new Point(261, 50);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 9;
            label2.Text = "correct Answer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 29);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 8;
            label1.Text = "True/False Question";
            // 
            // rt_truefalseqs
            // 
            rt_truefalseqs.Location = new Point(33, 47);
            rt_truefalseqs.Name = "rt_truefalseqs";
            rt_truefalseqs.Size = new Size(193, 187);
            rt_truefalseqs.TabIndex = 6;
            rt_truefalseqs.Text = "";
            // 
            // cb_truefalse
            // 
            cb_truefalse.FormattingEnabled = true;
            cb_truefalse.Items.AddRange(new object[] { "True", "False" });
            cb_truefalse.Location = new Point(261, 81);
            cb_truefalse.Name = "cb_truefalse";
            cb_truefalse.Size = new Size(121, 23);
            cb_truefalse.TabIndex = 5;
            // 
            // bt_update
            // 
            bt_update.Location = new Point(307, 128);
            bt_update.Name = "bt_update";
            bt_update.Size = new Size(75, 23);
            bt_update.TabIndex = 10;
            bt_update.Text = "Update";
            bt_update.UseVisualStyleBackColor = true;
            // 
            // edittruefalse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 302);
            Controls.Add(bt_update);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rt_truefalseqs);
            Controls.Add(cb_truefalse);
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