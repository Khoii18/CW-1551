namespace Quizzgame
{
    partial class editopenend
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
            rt_question = new RichTextBox();
            rt_answer = new RichTextBox();
            label1 = new Label();
            bt_update = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 544);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 41);
            label2.TabIndex = 9;
            label2.Text = "Answer";
            // 
            // rt_question
            // 
            rt_question.Location = new Point(245, 210);
            rt_question.Margin = new Padding(7, 8, 7, 8);
            rt_question.Name = "rt_question";
            rt_question.Size = new Size(635, 264);
            rt_question.TabIndex = 6;
            rt_question.Text = "";
            // 
            // rt_answer
            // 
            rt_answer.Location = new Point(245, 593);
            rt_answer.Margin = new Padding(7, 8, 7, 8);
            rt_answer.Name = "rt_answer";
            rt_answer.Size = new Size(635, 236);
            rt_answer.TabIndex = 7;
            rt_answer.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 161);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 41);
            label1.TabIndex = 8;
            label1.Text = "Question";
            // 
            // bt_update
            // 
            bt_update.Location = new Point(471, 940);
            bt_update.Margin = new Padding(7, 8, 7, 8);
            bt_update.Name = "bt_update";
            bt_update.Size = new Size(182, 63);
            bt_update.TabIndex = 10;
            bt_update.Text = "Update";
            bt_update.UseVisualStyleBackColor = true;
            bt_update.Click += bt_update_Click;
            // 
            // editopenend
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1132, 1110);
            Controls.Add(bt_update);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rt_answer);
            Controls.Add(rt_question);
            Margin = new Padding(7, 8, 7, 8);
            Name = "editopenend";
            Text = "editopenend";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private RichTextBox rt_question;
        private RichTextBox rt_answer;
        private Label label1;
        private Button bt_update;
    }
}