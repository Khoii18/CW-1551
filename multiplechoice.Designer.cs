namespace Quizzgame
{
    partial class multiplechoice
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
            components = new System.ComponentModel.Container();
            bt_addquestion = new Button();
            tb_choice1 = new TextBox();
            tb_choice2 = new TextBox();
            tb_choice3 = new TextBox();
            tb_choice4 = new TextBox();
            label1 = new Label();
            rt_mcquestion = new RichTextBox();
            tb_correctanswer = new TextBox();
            label2 = new Label();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // bt_addquestion
            // 
            bt_addquestion.Location = new Point(38, 330);
            bt_addquestion.Name = "bt_addquestion";
            bt_addquestion.Size = new Size(89, 23);
            bt_addquestion.TabIndex = 0;
            bt_addquestion.Text = "Add Question";
            bt_addquestion.UseVisualStyleBackColor = true;
            bt_addquestion.Click += bt_addquestion_Click;
            // 
            // tb_choice1
            // 
            tb_choice1.Location = new Point(27, 158);
            tb_choice1.Name = "tb_choice1";
            tb_choice1.Size = new Size(100, 23);
            tb_choice1.TabIndex = 1;
            // 
            // tb_choice2
            // 
            tb_choice2.Location = new Point(27, 203);
            tb_choice2.Name = "tb_choice2";
            tb_choice2.Size = new Size(100, 23);
            tb_choice2.TabIndex = 2;
            // 
            // tb_choice3
            // 
            tb_choice3.Location = new Point(27, 246);
            tb_choice3.Name = "tb_choice3";
            tb_choice3.Size = new Size(100, 23);
            tb_choice3.TabIndex = 3;
            // 
            // tb_choice4
            // 
            tb_choice4.Location = new Point(27, 288);
            tb_choice4.Name = "tb_choice4";
            tb_choice4.Size = new Size(100, 23);
            tb_choice4.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 22);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 5;
            label1.Text = "MultipleChoice";
            // 
            // rt_mcquestion
            // 
            rt_mcquestion.Location = new Point(27, 40);
            rt_mcquestion.Name = "rt_mcquestion";
            rt_mcquestion.Size = new Size(201, 96);
            rt_mcquestion.TabIndex = 6;
            rt_mcquestion.Text = "";
            // 
            // tb_correctanswer
            // 
            tb_correctanswer.Location = new Point(309, 167);
            tb_correctanswer.Name = "tb_correctanswer";
            tb_correctanswer.Size = new Size(100, 23);
            tb_correctanswer.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 136);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 8;
            label2.Text = "Correct Answer";
            // 
            // multiplechoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 450);
            Controls.Add(label2);
            Controls.Add(tb_correctanswer);
            Controls.Add(rt_mcquestion);
            Controls.Add(label1);
            Controls.Add(tb_choice4);
            Controls.Add(tb_choice3);
            Controls.Add(tb_choice2);
            Controls.Add(tb_choice1);
            Controls.Add(bt_addquestion);
            Name = "multiplechoice";
            Text = "MultipleChoice";
            Load += multiplechoice_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_addquestion;
        private TextBox tb_choice1;
        private TextBox tb_choice2;
        private TextBox tb_choice3;
        private TextBox tb_choice4;
        private Label label1;
        private RichTextBox rt_mcquestion;
        private TextBox tb_correctanswer;
        private Label label2;
        private BindingSource bindingSource1;
    }
}