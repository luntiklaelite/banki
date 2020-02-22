namespace banki
{
    partial class uprUserForm
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
            this.gridUsers = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_addUser = new System.Windows.Forms.Button();
            this.but_editUser = new System.Windows.Forms.Button();
            this.but_delUser = new System.Windows.Forms.Button();
            this.poiskFie = new System.Windows.Forms.TextBox();
            this.but_poisk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUsers
            // 
            this.gridUsers.AllowUserToAddRows = false;
            this.gridUsers.AllowUserToDeleteRows = false;
            this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gridUsers.Location = new System.Drawing.Point(12, 12);
            this.gridUsers.MultiSelect = false;
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.ReadOnly = true;
            this.gridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUsers.Size = new System.Drawing.Size(653, 387);
            this.gridUsers.TabIndex = 1;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Логин";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ФИО";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата рождения";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Роль в системе";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // but_addUser
            // 
            this.but_addUser.Location = new System.Drawing.Point(12, 405);
            this.but_addUser.Name = "but_addUser";
            this.but_addUser.Size = new System.Drawing.Size(210, 31);
            this.but_addUser.TabIndex = 2;
            this.but_addUser.Text = "Добавить пользователя";
            this.but_addUser.UseVisualStyleBackColor = true;
            this.but_addUser.Click += new System.EventHandler(this.but_addUser_Click);
            // 
            // but_editUser
            // 
            this.but_editUser.Location = new System.Drawing.Point(234, 405);
            this.but_editUser.Name = "but_editUser";
            this.but_editUser.Size = new System.Drawing.Size(210, 31);
            this.but_editUser.TabIndex = 3;
            this.but_editUser.Text = "Изменить пользователя";
            this.but_editUser.UseVisualStyleBackColor = true;
            this.but_editUser.Click += new System.EventHandler(this.but_editUser_Click);
            // 
            // but_delUser
            // 
            this.but_delUser.Location = new System.Drawing.Point(455, 405);
            this.but_delUser.Name = "but_delUser";
            this.but_delUser.Size = new System.Drawing.Size(210, 31);
            this.but_delUser.TabIndex = 4;
            this.but_delUser.Text = "Удалить пользователя";
            this.but_delUser.UseVisualStyleBackColor = true;
            this.but_delUser.Click += new System.EventHandler(this.but_delUser_Click);
            // 
            // poiskFie
            // 
            this.poiskFie.Location = new System.Drawing.Point(12, 450);
            this.poiskFie.Name = "poiskFie";
            this.poiskFie.Size = new System.Drawing.Size(210, 20);
            this.poiskFie.TabIndex = 5;
            // 
            // but_poisk
            // 
            this.but_poisk.Location = new System.Drawing.Point(234, 448);
            this.but_poisk.Name = "but_poisk";
            this.but_poisk.Size = new System.Drawing.Size(75, 23);
            this.but_poisk.TabIndex = 6;
            this.but_poisk.Text = "Найти";
            this.but_poisk.UseVisualStyleBackColor = true;
            this.but_poisk.Click += new System.EventHandler(this.but_poisk_Click);
            // 
            // uprUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 482);
            this.Controls.Add(this.but_poisk);
            this.Controls.Add(this.poiskFie);
            this.Controls.Add(this.but_delUser);
            this.Controls.Add(this.but_editUser);
            this.Controls.Add(this.but_addUser);
            this.Controls.Add(this.gridUsers);
            this.Name = "uprUserForm";
            this.Text = "Управление пользователями";
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button but_addUser;
        private System.Windows.Forms.Button but_editUser;
        private System.Windows.Forms.Button but_delUser;
        private System.Windows.Forms.TextBox poiskFie;
        private System.Windows.Forms.Button but_poisk;
    }
}