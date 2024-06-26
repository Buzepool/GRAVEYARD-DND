namespace Cemitério_DND
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_name = new TextBox();
            txt_class = new TextBox();
            txt_nvl = new TextBox();
            btn_confirm = new Button();
            ls_characters = new ListView();
            Nome = new ColumnHeader();
            Classe = new ColumnHeader();
            Nível = new ColumnHeader();
            btn_delete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGreen;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = Color.White;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(113, 40);
            label1.Name = "label1";
            label1.Size = new Size(250, 56);
            label1.TabIndex = 0;
            label1.Text = "Informations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGreen;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.White;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(12, 133);
            label2.Name = "label2";
            label2.Size = new Size(103, 39);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGreen;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 20F);
            label3.ForeColor = Color.White;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(12, 249);
            label3.Name = "label3";
            label3.Size = new Size(92, 39);
            label3.TabIndex = 2;
            label3.Text = "Class :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkGreen;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 20F);
            label4.ForeColor = Color.White;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(12, 375);
            label4.Name = "label4";
            label4.Size = new Size(93, 39);
            label4.TabIndex = 3;
            label4.Text = "Level :";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(12, 193);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(421, 23);
            txt_name.TabIndex = 4;
            // 
            // txt_class
            // 
            txt_class.Location = new Point(12, 316);
            txt_class.Name = "txt_class";
            txt_class.Size = new Size(421, 23);
            txt_class.TabIndex = 5;
            // 
            // txt_nvl
            // 
            txt_nvl.Location = new Point(12, 453);
            txt_nvl.Name = "txt_nvl";
            txt_nvl.Size = new Size(421, 23);
            txt_nvl.TabIndex = 6;
            // 
            // btn_confirm
            // 
            btn_confirm.BackgroundImage = (Image)resources.GetObject("btn_confirm.BackgroundImage");
            btn_confirm.ForeColor = Color.White;
            btn_confirm.Location = new Point(113, 533);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(219, 33);
            btn_confirm.TabIndex = 7;
            btn_confirm.Text = "Confirm";
            btn_confirm.TextImageRelation = TextImageRelation.TextAboveImage;
            btn_confirm.UseVisualStyleBackColor = true;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // ls_characters
            // 
            ls_characters.BackgroundImage = (Image)resources.GetObject("ls_characters.BackgroundImage");
            ls_characters.Columns.AddRange(new ColumnHeader[] { Nome, Classe, Nível });
            ls_characters.ForeColor = Color.White;
            ls_characters.FullRowSelect = true;
            ls_characters.Location = new Point(644, 193);
            ls_characters.Name = "ls_characters";
            ls_characters.RightToLeft = RightToLeft.No;
            ls_characters.Size = new Size(501, 283);
            ls_characters.TabIndex = 8;
            ls_characters.UseCompatibleStateImageBehavior = false;
            ls_characters.View = View.Details;
            ls_characters.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Nome
            // 
            Nome.Text = "Level";
            Nome.Width = 240;
            // 
            // Classe
            // 
            Classe.Text = "Class";
            Classe.Width = 200;
            // 
            // Nível
            // 
            Nível.Text = "Level";
            // 
            // btn_delete
            // 
            btn_delete.BackgroundImage = (Image)resources.GetObject("btn_delete.BackgroundImage");
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(777, 505);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(219, 33);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Delete";
            btn_delete.TextImageRelation = TextImageRelation.TextAboveImage;
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1264, 681);
            Controls.Add(btn_delete);
            Controls.Add(ls_characters);
            Controls.Add(btn_confirm);
            Controls.Add(txt_nvl);
            Controls.Add(txt_class);
            Controls.Add(txt_name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "DnD Graveyard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_name;
        private TextBox txt_class;
        private TextBox txt_nvl;
        private Button btn_confirm;
        private ListView ls_characters;
        private ColumnHeader Nome;
        private ColumnHeader Classe;
        private ColumnHeader Nível;
        private Button btn_delete;
    }
}
