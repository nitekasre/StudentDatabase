
namespace StudentDatabase
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.One80Logo = new System.Windows.Forms.PictureBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.UserNamelbl = new System.Windows.Forms.Label();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.Cancelbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.One80Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // One80Logo
            // 
            this.One80Logo.Image = ((System.Drawing.Image)(resources.GetObject("One80Logo.Image")));
            this.One80Logo.Location = new System.Drawing.Point(32, 44);
            this.One80Logo.Name = "One80Logo";
            this.One80Logo.Size = new System.Drawing.Size(254, 248);
            this.One80Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.One80Logo.TabIndex = 0;
            this.One80Logo.TabStop = false;
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Loginbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.Location = new System.Drawing.Point(774, 372);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(183, 79);
            this.Loginbtn.TabIndex = 3;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // UserNamelbl
            // 
            this.UserNamelbl.AutoSize = true;
            this.UserNamelbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNamelbl.Location = new System.Drawing.Point(648, 170);
            this.UserNamelbl.Name = "UserNamelbl";
            this.UserNamelbl.Size = new System.Drawing.Size(202, 37);
            this.UserNamelbl.TabIndex = 5;
            this.UserNamelbl.Text = "User Name: ";
            // 
            // Usertxt
            // 
            this.Usertxt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usertxt.Location = new System.Drawing.Point(856, 167);
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(364, 44);
            this.Usertxt.TabIndex = 1;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtxt.Location = new System.Drawing.Point(856, 291);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.PasswordChar = '*';
            this.Passwordtxt.Size = new System.Drawing.Size(364, 44);
            this.Passwordtxt.TabIndex = 2;
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlbl.Location = new System.Drawing.Point(648, 294);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(186, 37);
            this.Passwordlbl.TabIndex = 6;
            this.Passwordlbl.Text = "Password: ";
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.BackColor = System.Drawing.Color.Tomato;
            this.Cancelbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.Location = new System.Drawing.Point(1001, 372);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(183, 79);
            this.Cancelbtn.TabIndex = 4;
            this.Cancelbtn.Text = "Exit";
            this.Cancelbtn.UseVisualStyleBackColor = false;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1372, 568);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Passwordlbl);
            this.Controls.Add(this.Usertxt);
            this.Controls.Add(this.UserNamelbl);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.One80Logo);
            this.MaximizeBox = false;
            this.Name = "LoginScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login to One80 Student Database";
            ((System.ComponentModel.ISupportInitialize)(this.One80Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox One80Logo;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Label UserNamelbl;
        private System.Windows.Forms.TextBox Usertxt;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.Button Cancelbtn;
    }
}