
namespace Login
{
    partial class Signup
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
            this.SignupUsernamelabel = new System.Windows.Forms.Label();
            this.SignupUsernametextBox = new System.Windows.Forms.TextBox();
            this.SignupPasstextBox = new System.Windows.Forms.TextBox();
            this.PassSihnuplabel = new System.Windows.Forms.Label();
            this.SignupConfirmPasstextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPassSignuplabel = new System.Windows.Forms.Label();
            this.Signingupbutton = new System.Windows.Forms.Button();
            this.Signupbackbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignupUsernamelabel
            // 
            this.SignupUsernamelabel.AutoSize = true;
            this.SignupUsernamelabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupUsernamelabel.Location = new System.Drawing.Point(192, 91);
            this.SignupUsernamelabel.Name = "SignupUsernamelabel";
            this.SignupUsernamelabel.Size = new System.Drawing.Size(87, 21);
            this.SignupUsernamelabel.TabIndex = 0;
            this.SignupUsernamelabel.Text = "Username";
            // 
            // SignupUsernametextBox
            // 
            this.SignupUsernametextBox.Location = new System.Drawing.Point(369, 91);
            this.SignupUsernametextBox.Name = "SignupUsernametextBox";
            this.SignupUsernametextBox.Size = new System.Drawing.Size(141, 20);
            this.SignupUsernametextBox.TabIndex = 1;
            // 
            // SignupPasstextBox
            // 
            this.SignupPasstextBox.Location = new System.Drawing.Point(369, 162);
            this.SignupPasstextBox.Name = "SignupPasstextBox";
            this.SignupPasstextBox.PasswordChar = '*';
            this.SignupPasstextBox.Size = new System.Drawing.Size(141, 20);
            this.SignupPasstextBox.TabIndex = 3;
            // 
            // PassSihnuplabel
            // 
            this.PassSihnuplabel.AutoSize = true;
            this.PassSihnuplabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassSihnuplabel.Location = new System.Drawing.Point(192, 162);
            this.PassSihnuplabel.Name = "PassSihnuplabel";
            this.PassSihnuplabel.Size = new System.Drawing.Size(82, 21);
            this.PassSihnuplabel.TabIndex = 2;
            this.PassSihnuplabel.Text = "Password";
            // 
            // SignupConfirmPasstextBox
            // 
            this.SignupConfirmPasstextBox.Location = new System.Drawing.Point(369, 233);
            this.SignupConfirmPasstextBox.Name = "SignupConfirmPasstextBox";
            this.SignupConfirmPasstextBox.PasswordChar = '*';
            this.SignupConfirmPasstextBox.Size = new System.Drawing.Size(141, 20);
            this.SignupConfirmPasstextBox.TabIndex = 5;
            // 
            // ConfirmPassSignuplabel
            // 
            this.ConfirmPassSignuplabel.AutoSize = true;
            this.ConfirmPassSignuplabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassSignuplabel.Location = new System.Drawing.Point(192, 233);
            this.ConfirmPassSignuplabel.Name = "ConfirmPassSignuplabel";
            this.ConfirmPassSignuplabel.Size = new System.Drawing.Size(149, 21);
            this.ConfirmPassSignuplabel.TabIndex = 4;
            this.ConfirmPassSignuplabel.Text = "Confirm Password";
            // 
            // Signingupbutton
            // 
            this.Signingupbutton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signingupbutton.Location = new System.Drawing.Point(300, 320);
            this.Signingupbutton.Name = "Signingupbutton";
            this.Signingupbutton.Size = new System.Drawing.Size(143, 23);
            this.Signingupbutton.TabIndex = 6;
            this.Signingupbutton.Text = "Signup";
            this.Signingupbutton.UseVisualStyleBackColor = true;
            this.Signingupbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Signupbackbutton
            // 
            this.Signupbackbutton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signupbackbutton.Location = new System.Drawing.Point(640, 400);
            this.Signupbackbutton.Name = "Signupbackbutton";
            this.Signupbackbutton.Size = new System.Drawing.Size(120, 23);
            this.Signupbackbutton.TabIndex = 7;
            this.Signupbackbutton.Text = "Back";
            this.Signupbackbutton.UseVisualStyleBackColor = true;
            this.Signupbackbutton.Click += new System.EventHandler(this.Signupbackbutton_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Signupbackbutton);
            this.Controls.Add(this.Signingupbutton);
            this.Controls.Add(this.SignupConfirmPasstextBox);
            this.Controls.Add(this.ConfirmPassSignuplabel);
            this.Controls.Add(this.SignupPasstextBox);
            this.Controls.Add(this.PassSihnuplabel);
            this.Controls.Add(this.SignupUsernametextBox);
            this.Controls.Add(this.SignupUsernamelabel);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Signup_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignupUsernamelabel;
        private System.Windows.Forms.TextBox SignupUsernametextBox;
        private System.Windows.Forms.TextBox SignupPasstextBox;
        private System.Windows.Forms.Label PassSihnuplabel;
        private System.Windows.Forms.TextBox SignupConfirmPasstextBox;
        private System.Windows.Forms.Label ConfirmPassSignuplabel;
        private System.Windows.Forms.Button Signingupbutton;
        private System.Windows.Forms.Button Signupbackbutton;
    }
}