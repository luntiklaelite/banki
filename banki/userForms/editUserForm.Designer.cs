namespace banki.userForms
{
    partial class editUserForm
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
            this.but_editUser = new System.Windows.Forms.Button();
            this.dateFie = new System.Windows.Forms.DateTimePicker();
            this.fioFie = new System.Windows.Forms.TextBox();
            this.passFie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.loginFie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_role = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // but_editUser
            // 
            this.but_editUser.Location = new System.Drawing.Point(9, 178);
            this.but_editUser.Name = "but_editUser";
            this.but_editUser.Size = new System.Drawing.Size(392, 31);
            this.but_editUser.TabIndex = 21;
            this.but_editUser.Text = "Изменить пользователя";
            this.but_editUser.UseVisualStyleBackColor = true;
            this.but_editUser.Click += new System.EventHandler(this.but_editUser_Click);
            // 
            // dateFie
            // 
            this.dateFie.Location = new System.Drawing.Point(180, 113);
            this.dateFie.Name = "dateFie";
            this.dateFie.Size = new System.Drawing.Size(221, 20);
            this.dateFie.TabIndex = 20;
            // 
            // fioFie
            // 
            this.fioFie.Location = new System.Drawing.Point(180, 81);
            this.fioFie.Name = "fioFie";
            this.fioFie.Size = new System.Drawing.Size(221, 20);
            this.fioFie.TabIndex = 18;
            // 
            // passFie
            // 
            this.passFie.Location = new System.Drawing.Point(180, 46);
            this.passFie.Name = "passFie";
            this.passFie.Size = new System.Drawing.Size(221, 20);
            this.passFie.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(111, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Роль:";
            // 
            // loginFie
            // 
            this.loginFie.Location = new System.Drawing.Point(180, 12);
            this.loginFie.Name = "loginFie";
            this.loginFie.Size = new System.Drawing.Size(221, 20);
            this.loginFie.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Дата рождения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(111, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(86, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(99, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Логин:";
            // 
            // combo_role
            // 
            this.combo_role.FormattingEnabled = true;
            this.combo_role.Location = new System.Drawing.Point(180, 144);
            this.combo_role.Name = "combo_role";
            this.combo_role.Size = new System.Drawing.Size(221, 21);
            this.combo_role.TabIndex = 22;
            // 
            // editUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 219);
            this.Controls.Add(this.combo_role);
            this.Controls.Add(this.but_editUser);
            this.Controls.Add(this.dateFie);
            this.Controls.Add(this.fioFie);
            this.Controls.Add(this.passFie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loginFie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "editUserForm";
            this.Text = "Изменить пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_editUser;
        private System.Windows.Forms.DateTimePicker dateFie;
        private System.Windows.Forms.TextBox fioFie;
        private System.Windows.Forms.TextBox passFie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox loginFie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_role;
    }
}