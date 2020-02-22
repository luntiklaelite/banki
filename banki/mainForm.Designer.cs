namespace banki
{
    partial class mainForm
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
            this.privetLabel = new System.Windows.Forms.Label();
            this.but_vkladi = new System.Windows.Forms.Button();
            this.but_addVklad = new System.Windows.Forms.Button();
            this.but_goUprUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // privetLabel
            // 
            this.privetLabel.AutoSize = true;
            this.privetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privetLabel.Location = new System.Drawing.Point(12, 9);
            this.privetLabel.Name = "privetLabel";
            this.privetLabel.Size = new System.Drawing.Size(226, 72);
            this.privetLabel.TabIndex = 0;
            this.privetLabel.Text = "Здравствуйте,\r\n\r\nВаша роль в системе:\r\n";
            // 
            // but_vkladi
            // 
            this.but_vkladi.Location = new System.Drawing.Point(12, 93);
            this.but_vkladi.Name = "but_vkladi";
            this.but_vkladi.Size = new System.Drawing.Size(615, 23);
            this.but_vkladi.TabIndex = 1;
            this.but_vkladi.Text = "Посмотреть вклады";
            this.but_vkladi.UseVisualStyleBackColor = true;
            this.but_vkladi.Click += new System.EventHandler(this.but_vkladi_Click);
            // 
            // but_addVklad
            // 
            this.but_addVklad.Location = new System.Drawing.Point(12, 121);
            this.but_addVklad.Name = "but_addVklad";
            this.but_addVklad.Size = new System.Drawing.Size(615, 23);
            this.but_addVklad.TabIndex = 2;
            this.but_addVklad.Text = "Оформить вклад";
            this.but_addVklad.UseVisualStyleBackColor = true;
            this.but_addVklad.Click += new System.EventHandler(this.but_addVklad_Click);
            // 
            // but_goUprUser
            // 
            this.but_goUprUser.Location = new System.Drawing.Point(12, 150);
            this.but_goUprUser.Name = "but_goUprUser";
            this.but_goUprUser.Size = new System.Drawing.Size(615, 23);
            this.but_goUprUser.TabIndex = 3;
            this.but_goUprUser.Text = "Управление пользователями";
            this.but_goUprUser.UseVisualStyleBackColor = true;
            this.but_goUprUser.Click += new System.EventHandler(this.but_goUprUser_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 187);
            this.Controls.Add(this.but_goUprUser);
            this.Controls.Add(this.but_addVklad);
            this.Controls.Add(this.but_vkladi);
            this.Controls.Add(this.privetLabel);
            this.Name = "mainForm";
            this.Text = "Главное меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label privetLabel;
        private System.Windows.Forms.Button but_vkladi;
        private System.Windows.Forms.Button but_addVklad;
        private System.Windows.Forms.Button but_goUprUser;
    }
}