namespace Quizzgame
{
    partial class truefalse
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
            cb_truefalse = new ComboBox();
            rt_truefalseqs = new RichTextBox();
            bt_addquestion = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // cb_truefalse
            // 
            cb_truefalse.FormattingEnabled = true;
            cb_truefalse.Items.AddRange(new object[] { "True", "False" });
            cb_truefalse.Location = new Point(617, 194);
            cb_truefalse.Margin = new Padding(7, 8, 7, 8);
            cb_truefalse.Name = "cb_truefalse";
            cb_truefalse.Size = new Size(288, 49);
            cb_truefalse.TabIndex = 0;
            // 
            // rt_truefalseqs
            // 
            rt_truefalseqs.Location = new Point(63, 101);
            rt_truefalseqs.Margin = new Padding(7, 8, 7, 8);
            rt_truefalseqs.Name = "rt_truefalseqs";
            rt_truefalseqs.Size = new Size(463, 504);
            rt_truefalseqs.TabIndex = 1;
            rt_truefalseqs.Text = "";
            // 
            // bt_addquestion
            // 
            bt_addquestion.Location = new Point(617, 309);
            bt_addquestion.Margin = new Padding(7, 8, 7, 8);
            bt_addquestion.Name = "bt_addquestion";
            bt_addquestion.Size = new Size(216, 63);
            bt_addquestion.TabIndex = 2;
            bt_addquestion.Text = "Add Question";
            bt_addquestion.UseVisualStyleBackColor = true;
            bt_addquestion.Click += bt_addquestion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 52);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(280, 41);
            label1.TabIndex = 3;
            label1.Text = "True/False Question";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(617, 109);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(215, 41);
            label2.TabIndex = 4;
            label2.Text = "correct Answer";
            // 
            // truefalse
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1088, 776);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bt_addquestion);
            Controls.Add(rt_truefalseqs);
            Controls.Add(cb_truefalse);
            Margin = new Padding(7, 8, 7, 8);
            Name = "truefalse";
            Text = "TrueFalse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_truefalse;
        private RichTextBox rt_truefalseqs;
        private Button bt_addquestion;
        private Label label1;
        private Label label2;
    }
}