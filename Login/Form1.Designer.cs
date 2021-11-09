
namespace Login
{
    partial class Dashboard
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
            this.Usenamelabel = new System.Windows.Forms.Label();
            this.Passlabel = new System.Windows.Forms.Label();
            this.UsernametextBox = new System.Windows.Forms.TextBox();
            this.PasstextBox = new System.Windows.Forms.TextBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.Signupbutton = new System.Windows.Forms.Button();
            this.NewAccountlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Usenamelabel
            // 
            this.Usenamelabel.AutoSize = true;
            this.Usenamelabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usenamelabel.Location = new System.Drawing.Point(222, 123);
            this.Usenamelabel.Name = "Usenamelabel";
            this.Usenamelabel.Size = new System.Drawing.Size(87, 21);
            this.Usenamelabel.TabIndex = 0;
            this.Usenamelabel.Text = "Username";
            // 
            // Passlabel
            // 
            this.Passlabel.AutoSize = true;
            this.Passlabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passlabel.Location = new System.Drawing.Point(222, 179);
            this.Passlabel.Name = "Passlabel";
            this.Passlabel.Size = new System.Drawing.Size(82, 21);
            this.Passlabel.TabIndex = 1;
            this.Passlabel.Text = "Password";
            // 
            // UsernametextBox
            // 
            this.UsernametextBox.Location = new System.Drawing.Point(365, 126);
            this.UsernametextBox.Name = "UsernametextBox";
            this.UsernametextBox.Size = new System.Drawing.Size(158, 20);
            this.UsernametextBox.TabIndex = 2;
            // 
            // PasstextBox
            // 
            this.PasstextBox.Location = new System.Drawing.Point(365, 180);
            this.PasstextBox.Name = "PasstextBox";
            this.PasstextBox.PasswordChar = '*';
            this.PasstextBox.Size = new System.Drawing.Size(158, 20);
            this.PasstextBox.TabIndex = 3;
            // 
            // Loginbutton
            // 
            this.Loginbutton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbutton.Location = new System.Drawing.Point(234, 288);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(114, 23);
            this.Loginbutton.TabIndex = 4;
            this.Loginbutton.Text = "Login";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // Signupbutton
            // 
            this.Signupbutton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signupbutton.Location = new System.Drawing.Point(410, 288);
            this.Signupbutton.Name = "Signupbutton";
            this.Signupbutton.Size = new System.Drawing.Size(113, 23);
            this.Signupbutton.TabIndex = 5;
            this.Signupbutton.Text = "Signup";
            this.Signupbutton.UseVisualStyleBackColor = true;
            this.Signupbutton.Click += new System.EventHandler(this.Signupbutton_Click);
            // 
            // NewAccountlabel
            // 
            this.NewAccountlabel.AutoSize = true;
            this.NewAccountlabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAccountlabel.Location = new System.Drawing.Point(222, 243);
            this.NewAccountlabel.Name = "NewAccountlabel";
            this.NewAccountlabel.Size = new System.Drawing.Size(319, 19);
            this.NewAccountlabel.TabIndex = 6;
            this.NewAccountlabel.Text = "Don\'t have an account? Create a one...Signup now";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewAccountlabel);
            this.Controls.Add(this.Signupbutton);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.PasstextBox);
            this.Controls.Add(this.UsernametextBox);
            this.Controls.Add(this.Passlabel);
            this.Controls.Add(this.Usenamelabel);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usenamelabel;
        private System.Windows.Forms.Label Passlabel;
        private System.Windows.Forms.TextBox UsernametextBox;
        private System.Windows.Forms.TextBox PasstextBox;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Button Signupbutton;
        private System.Windows.Forms.Label NewAccountlabel;
    }
}

