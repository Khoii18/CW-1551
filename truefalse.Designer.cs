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
            cb_truefalse.Location = new Point(254, 71);
            cb_truefalse.Name = "cb_truefalse";
            cb_truefalse.Size = new Size(121, 23);
            cb_truefalse.TabIndex = 0;
            // 
            // rt_truefalseqs
            // 
            rt_truefalseqs.Location = new Point(26, 37);
            rt_truefalseqs.Name = "rt_truefalseqs";
            rt_truefalseqs.Size = new Size(193, 187);
            rt_truefalseqs.TabIndex = 1;
            rt_truefalseqs.Text = "";
            // 
            // bt_addquestion
            // 
            bt_addquestion.Location = new Point(254, 113);
            bt_addquestion.Name = "bt_addquestion";
            bt_addquestion.Size = new Size(89, 23);
            bt_addquestion.TabIndex = 2;
            bt_addquestion.Text = "Add Question";
            bt_addquestion.UseVisualStyleBackColor = true;
            bt_addquestion.Click += bt_addquestion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 19);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 3;
            label1.Text = "True/False Question";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 40);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 4;
            label2.Text = "correct Answer";
            // 
            // truefalse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 284);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bt_addquestion);
            Controls.Add(rt_truefalseqs);
            Controls.Add(cb_truefalse);
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