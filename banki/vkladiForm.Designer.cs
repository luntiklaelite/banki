namespace banki
{
    partial class vkladiForm
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
            this.grid_vkladi = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_infoUser = new System.Windows.Forms.Button();
            this.but_infoDep = new System.Windows.Forms.Button();
            this.poiskFie = new System.Windows.Forms.TextBox();
            this.but_poisk = new System.Windows.Forms.Button();
            this.but_vidan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_vkladi)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_vkladi
            // 
            this.grid_vkladi.AllowUserToAddRows = false;
            this.grid_vkladi.AllowUserToDeleteRows = false;
            this.grid_vkladi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_vkladi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grid_vkladi.Location = new System.Drawing.Point(12, 12);
            this.grid_vkladi.MultiSelect = false;
            this.grid_vkladi.Name = "grid_vkladi";
            this.grid_vkladi.ReadOnly = true;
            this.grid_vkladi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_vkladi.Size = new System.Drawing.Size(603, 387);
            this.grid_vkladi.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Логин";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Название вклада";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Сумма вклада";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 115;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "До:";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Получит:";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // but_infoUser
            // 
            this.but_infoUser.Location = new System.Drawing.Point(12, 405);
            this.but_infoUser.Name = "but_infoUser";
            this.but_infoUser.Size = new System.Drawing.Size(214, 52);
            this.but_infoUser.TabIndex = 1;
            this.but_infoUser.Text = "Информация о пользователе";
            this.but_infoUser.UseVisualStyleBackColor = true;
            this.but_infoUser.Click += new System.EventHandler(this.but_infoUser_Click);
            // 
            // but_infoDep
            // 
            this.but_infoDep.Location = new System.Drawing.Point(401, 405);
            this.but_infoDep.Name = "but_infoDep";
            this.but_infoDep.Size = new System.Drawing.Size(214, 52);
            this.but_infoDep.TabIndex = 2;
            this.but_infoDep.Text = "Информация о выбранном депозите";
            this.but_infoDep.UseVisualStyleBackColor = true;
            this.but_infoDep.Click += new System.EventHandler(this.but_infoDep_Click);
            // 
            // poiskFie
            // 
            this.poiskFie.Location = new System.Drawing.Point(232, 405);
            this.poiskFie.Name = "poiskFie";
            this.poiskFie.Size = new System.Drawing.Size(163, 20);
            this.poiskFie.TabIndex = 3;
            // 
            // but_poisk
            // 
            this.but_poisk.Location = new System.Drawing.Point(232, 434);
            this.but_poisk.Name = "but_poisk";
            this.but_poisk.Size = new System.Drawing.Size(163, 23);
            this.but_poisk.TabIndex = 4;
            this.but_poisk.Text = "Найти";
            this.but_poisk.UseVisualStyleBackColor = true;
            this.but_poisk.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_vidan
            // 
            this.but_vidan.Location = new System.Drawing.Point(12, 463);
            this.but_vidan.Name = "but_vidan";
            this.but_vidan.Size = new System.Drawing.Size(603, 23);
            this.but_vidan.TabIndex = 5;
            this.but_vidan.Text = "Пометить, что вклад выдан";
            this.but_vidan.UseVisualStyleBackColor = true;
            this.but_vidan.Click += new System.EventHandler(this.but_vidan_Click);
            // 
            // vkladiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 494);
            this.Controls.Add(this.but_vidan);
            this.Controls.Add(this.but_poisk);
            this.Controls.Add(this.poiskFie);
            this.Controls.Add(this.but_infoDep);
            this.Controls.Add(this.but_infoUser);
            this.Controls.Add(this.grid_vkladi);
            this.Name = "vkladiForm";
            this.Text = "Список вкладов";
            ((System.ComponentModel.ISupportInitialize)(this.grid_vkladi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_vkladi;
        private System.Windows.Forms.Button but_infoUser;
        private System.Windows.Forms.Button but_infoDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox poiskFie;
        private System.Windows.Forms.Button but_poisk;
        private System.Windows.Forms.Button but_vidan;
    }
}