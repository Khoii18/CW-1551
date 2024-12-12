namespace Quizzgame
{
    partial class editmultiplechoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editmultiplechoice));
            label2 = new Label();
            tb_correctanswer = new TextBox();
            rt_mcquestion = new RichTextBox();
            label1 = new Label();
            tb_choice4 = new TextBox();
            tb_choice3 = new TextBox();
            tb_choice2 = new TextBox();
            tb_choice1 = new TextBox();
            bt_confirm = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 134);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 17;
            label2.Text = "Correct Answer";
            // 
            // tb_correctanswer
            // 
            tb_correctanswer.Location = new Point(309, 166);
            tb_correctanswer.Name = "tb_correctanswer";
            tb_correctanswer.Size = new Size(100, 23);
            tb_correctanswer.TabIndex = 16;
            // 
            // rt_mcquestion
            // 
            rt_mcquestion.Location = new Point(64, 53);
            rt_mcquestion.Name = "rt_mcquestion";
            rt_mcquestion.Size = new Size(201, 96);
            rt_mcquestion.TabIndex = 15;
            rt_mcquestion.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 14;
            label1.Text = "Edit MultipleChoice";
            // 
            // tb_choice4
            // 
            tb_choice4.Location = new Point(64, 301);
            tb_choice4.Name = "tb_choice4";
            tb_choice4.Size = new Size(100, 23);
            tb_choice4.TabIndex = 13;
            // 
            // tb_choice3
            // 
            tb_choice3.Location = new Point(64, 259);
            tb_choice3.Name = "tb_choice3";
            tb_choice3.Size = new Size(100, 23);
            tb_choice3.TabIndex = 12;
            // 
            // tb_choice2
            // 
            tb_choice2.Location = new Point(64, 216);
            tb_choice2.Name = "tb_choice2";
            tb_choice2.Size = new Size(100, 23);
            tb_choice2.TabIndex = 11;
            // 
            // tb_choice1
            // 
            tb_choice1.Location = new Point(64, 171);
            tb_choice1.Name = "tb_choice1";
            tb_choice1.Size = new Size(100, 23);
            tb_choice1.TabIndex = 10;
            // 
            // bt_confirm
            // 
            bt_confirm.Location = new Point(314, 301);
            bt_confirm.Name = "bt_confirm";
            bt_confirm.Size = new Size(89, 23);
            bt_confirm.TabIndex = 9;
            bt_confirm.Text = "Confirm Edit";
            bt_confirm.UseVisualStyleBackColor = true;
            bt_confirm.Click += bt_confirm_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 174);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 19;
            label3.Text = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 219);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 20;
            label4.Text = "2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 263);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 21;
            label5.Text = "3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 304);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 22;
            label6.Text = "4";
            // 
            // editmultiplechoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(483, 377);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_correctanswer);
            Controls.Add(rt_mcquestion);
            Controls.Add(label1);
            Controls.Add(tb_choice4);
            Controls.Add(tb_choice3);
            Controls.Add(tb_choice2);
            Controls.Add(tb_choice1);
            Controls.Add(bt_confirm);
            Name = "editmultiplechoice";
            Text = "editmultiplechoice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox tb_correctanswer;
        private RichTextBox rt_mcquestion;
        private Label label1;
        private TextBox tb_choice4;
        private TextBox tb_choice3;
        private TextBox tb_choice2;
        private TextBox tb_choice1;
        private Button bt_confirm;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}