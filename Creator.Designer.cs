namespace Quizzgame
{
    partial class Creator
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
            rt_displayall = new RichTextBox();
            bt_add = new Button();
            bt_edit = new Button();
            bt_delete = new Button();
            cb_type = new ComboBox();
            bt_displayall = new Button();
            tb_index = new TextBox();
            SuspendLayout();
            // 
            // rt_displayall
            // 
            rt_displayall.Location = new Point(22, 57);
            rt_displayall.Name = "rt_displayall";
            rt_displayall.Size = new Size(225, 328);
            rt_displayall.TabIndex = 0;
            rt_displayall.Text = "";
            // 
            // bt_add
            // 
            bt_add.AllowDrop = true;
            bt_add.Location = new Point(385, 56);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(75, 23);
            bt_add.TabIndex = 1;
            bt_add.Text = "Add";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // bt_edit
            // 
            bt_edit.Location = new Point(385, 188);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(75, 23);
            bt_edit.TabIndex = 2;
            bt_edit.Text = "Edit";
            bt_edit.UseVisualStyleBackColor = true;
            bt_edit.Click += bt_edit_Click;
            // 
            // bt_delete
            // 
            bt_delete.Location = new Point(385, 123);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(75, 23);
            bt_delete.TabIndex = 3;
            bt_delete.Text = "Delete";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += bt_delete_Click;
            // 
            // cb_type
            // 
            cb_type.FormattingEnabled = true;
            cb_type.Items.AddRange(new object[] { "multiplechoice", "openend", "truefalse" });
            cb_type.Location = new Point(253, 57);
            cb_type.Name = "cb_type";
            cb_type.Size = new Size(121, 23);
            cb_type.TabIndex = 4;
            // 
            // bt_displayall
            // 
            bt_displayall.Location = new Point(276, 105);
            bt_displayall.Name = "bt_displayall";
            bt_displayall.Size = new Size(75, 23);
            bt_displayall.TabIndex = 5;
            bt_displayall.Text = "Display All";
            bt_displayall.UseVisualStyleBackColor = true;
            bt_displayall.Click += bt_displayall_Click;
            // 
            // tb_index
            // 
            tb_index.Location = new Point(385, 228);
            tb_index.Name = "tb_index";
            tb_index.Size = new Size(47, 23);
            tb_index.TabIndex = 6;
            // 
            // Creator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 427);
            Controls.Add(tb_index);
            Controls.Add(bt_displayall);
            Controls.Add(cb_type);
            Controls.Add(bt_delete);
            Controls.Add(bt_edit);
            Controls.Add(bt_add);
            Controls.Add(rt_displayall);
            Name = "Creator";
            Text = "CreatorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rt_displayall;
        private Button bt_add;
        private Button bt_edit;
        private Button bt_delete;
        private ComboBox cb_type;
        private Button bt_displayall;
        private TextBox tb_index;
    }
}