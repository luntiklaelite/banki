namespace banki
{
    partial class addVkladForm
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
            this.combo_users = new System.Windows.Forms.ComboBox();
            this.combo_vkladi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.summFie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.but_addVklad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combo_users
            // 
            this.combo_users.FormattingEnabled = true;
            this.combo_users.Location = new System.Drawing.Point(232, 18);
            this.combo_users.Name = "combo_users";
            this.combo_users.Size = new System.Drawing.Size(411, 21);
            this.combo_users.TabIndex = 0;
            // 
            // combo_vkladi
            // 
            this.combo_vkladi.FormattingEnabled = true;
            this.combo_vkladi.Location = new System.Drawing.Point(232, 52);
            this.combo_vkladi.Name = "combo_vkladi";
            this.combo_vkladi.Size = new System.Drawing.Size(411, 21);
            this.combo_vkladi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пользователь:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Доступные вклады:";
            // 
            // summFie
            // 
            this.summFie.Location = new System.Drawing.Point(232, 86);
            this.summFie.Name = "summFie";
            this.summFie.Size = new System.Drawing.Size(411, 20);
            this.summFie.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сумма вклада:";
            // 
            // but_addVklad
            // 
            this.but_addVklad.Location = new System.Drawing.Point(16, 120);
            this.but_addVklad.Name = "but_addVklad";
            this.but_addVklad.Size = new System.Drawing.Size(627, 30);
            this.but_addVklad.TabIndex = 6;
            this.but_addVklad.Text = "Добавить вклад";
            this.but_addVklad.UseVisualStyleBackColor = true;
            this.but_addVklad.Click += new System.EventHandler(this.but_addVklad_Click);
            // 
            // addVkladForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 165);
            this.Controls.Add(this.but_addVklad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.summFie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_vkladi);
            this.Controls.Add(this.combo_users);
            this.Name = "addVkladForm";
            this.Text = "addVkladForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_users;
        private System.Windows.Forms.ComboBox combo_vkladi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox summFie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_addVklad;
    }
}