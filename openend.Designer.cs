namespace Quizzgame
{
    partial class openend
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
            bt_add = new Button();
            rt_question = new RichTextBox();
            rt_answer = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // bt_add
            // 
            bt_add.Location = new Point(140, 322);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(91, 23);
            bt_add.TabIndex = 0;
            bt_add.Text = "Add Question";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // rt_question
            // 
            rt_question.Location = new Point(47, 74);
            rt_question.Name = "rt_question";
            rt_question.Size = new Size(264, 99);
            rt_question.TabIndex = 1;
            rt_question.Text = "";
            // 
            // rt_answer
            // 
            rt_answer.Location = new Point(47, 214);
            rt_answer.Name = "rt_answer";
            rt_answer.Size = new Size(264, 89);
            rt_answer.TabIndex = 2;
            rt_answer.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 56);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 3;
            label1.Text = "Question";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 196);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 4;
            label2.Text = "Answer";
            // 
            // openend
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 410);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rt_answer);
            Controls.Add(rt_question);
            Controls.Add(bt_add);
            Name = "openend";
            Text = "OpenEndQuestion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_add;
        private RichTextBox rt_question;
        private RichTextBox rt_answer;
        private Label label1;
        private Label label2;
    }
}