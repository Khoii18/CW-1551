namespace Quizzgame
{
    partial class Player
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
            bt_start = new Button();
            bt_next = new Button();
            bt_exit = new Button();
            rt_question = new RichTextBox();
            rt_answer = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // bt_start
            // 
            bt_start.BackColor = SystemColors.ButtonFace;
            bt_start.Location = new Point(389, 825);
            bt_start.Margin = new Padding(7, 8, 7, 8);
            bt_start.Name = "bt_start";
            bt_start.Size = new Size(182, 63);
            bt_start.TabIndex = 0;
            bt_start.Text = "Start";
            bt_start.UseVisualStyleBackColor = false;
            bt_start.Click += bt_start_Click;
            // 
            // bt_next
            // 
            bt_next.BackColor = SystemColors.ButtonFace;
            bt_next.Location = new Point(852, 825);
            bt_next.Margin = new Padding(7, 8, 7, 8);
            bt_next.Name = "bt_next";
            bt_next.Size = new Size(182, 63);
            bt_next.TabIndex = 1;
            bt_next.Text = "Next";
            bt_next.UseVisualStyleBackColor = false;
            bt_next.Click += bt_next_Click;
            // 
            // bt_exit
            // 
            bt_exit.BackColor = SystemColors.ButtonFace;
            bt_exit.Location = new Point(1317, 825);
            bt_exit.Margin = new Padding(7, 8, 7, 8);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new Size(182, 63);
            bt_exit.TabIndex = 3;
            bt_exit.Text = "Exit Game";
            bt_exit.UseVisualStyleBackColor = false;
            bt_exit.Click += bt_exit_Click;
            // 
            // rt_question
            // 
            rt_question.Location = new Point(172, 249);
            rt_question.Margin = new Padding(7, 8, 7, 8);
            rt_question.Name = "rt_question";
            rt_question.Size = new Size(623, 455);
            rt_question.TabIndex = 4;
            rt_question.Text = "";
            // 
            // rt_answer
            // 
            rt_answer.Location = new Point(1078, 249);
            rt_answer.Margin = new Padding(7, 8, 7, 8);
            rt_answer.Name = "rt_answer";
            rt_answer.Size = new Size(643, 455);
            rt_answer.TabIndex = 5;
            rt_answer.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(852, 60);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 43);
            label1.TabIndex = 6;
            label1.Text = "Quizz Game";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 180);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 41);
            label2.TabIndex = 7;
            label2.Text = "Question";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1083, 180);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 41);
            label3.TabIndex = 8;
            label3.Text = "Answer";
            // 
            // Player
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1892, 1006);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rt_answer);
            Controls.Add(rt_question);
            Controls.Add(bt_exit);
            Controls.Add(bt_next);
            Controls.Add(bt_start);
            Cursor = Cursors.IBeam;
            Margin = new Padding(7, 8, 7, 8);
            Name = "Player";
            Text = "PlayerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_start;
        private Button bt_next;
        private Button bt_exit;
        private RichTextBox rt_question;
        private RichTextBox rt_answer;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}