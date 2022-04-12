
namespace StudentDatabase
{
    partial class StudentDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDatabase));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.StudentData = new System.Windows.Forms.DataGridView();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.Firstnametxt = new System.Windows.Forms.TextBox();
            this.Lastnametxt = new System.Windows.Forms.TextBox();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.Agetxt = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.StudentIDtxt = new System.Windows.Forms.TextBox();
            this.schoolgradeLabel = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.virtualAddressLabel = new System.Windows.Forms.Label();
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Countlbl = new System.Windows.Forms.Label();
            this.StudentCountlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentData)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(1058, 56);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(904, 69);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "One80 Youth Student Database";
            // 
            // StudentData
            // 
            this.StudentData.AllowUserToAddRows = false;
            this.StudentData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentData.Location = new System.Drawing.Point(768, 142);
            this.StudentData.Name = "StudentData";
            this.StudentData.RowHeadersWidth = 82;
            this.StudentData.RowTemplate.Height = 33;
            this.StudentData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentData.Size = new System.Drawing.Size(1576, 542);
            this.StudentData.TabIndex = 17;
            this.StudentData.TabStop = false;
            this.StudentData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentData_CellClick);
            // 
            // nameLabel1
            // 
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.Location = new System.Drawing.Point(1098, 1063);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(184, 37);
            this.nameLabel1.TabIndex = 12;
            this.nameLabel1.Text = "First Name";
            // 
            // Firstnametxt
            // 
            this.Firstnametxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstnametxt.Location = new System.Drawing.Point(1288, 1063);
            this.Firstnametxt.Name = "Firstnametxt";
            this.Firstnametxt.Size = new System.Drawing.Size(264, 44);
            this.Firstnametxt.TabIndex = 3;
            // 
            // Lastnametxt
            // 
            this.Lastnametxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lastnametxt.Location = new System.Drawing.Point(1288, 956);
            this.Lastnametxt.Name = "Lastnametxt";
            this.Lastnametxt.Size = new System.Drawing.Size(264, 44);
            this.Lastnametxt.TabIndex = 2;
            // 
            // nameLabel2
            // 
            this.nameLabel2.AutoSize = true;
            this.nameLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel2.Location = new System.Drawing.Point(1098, 958);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(179, 37);
            this.nameLabel2.TabIndex = 11;
            this.nameLabel2.Text = "Last Name";
            // 
            // Agetxt
            // 
            this.Agetxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agetxt.Location = new System.Drawing.Point(1712, 871);
            this.Agetxt.Name = "Agetxt";
            this.Agetxt.Size = new System.Drawing.Size(264, 44);
            this.Agetxt.TabIndex = 4;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(1596, 878);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(77, 37);
            this.yearLabel.TabIndex = 13;
            this.yearLabel.Text = "Age";
            // 
            // StudentIDtxt
            // 
            this.StudentIDtxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDtxt.Location = new System.Drawing.Point(1288, 871);
            this.StudentIDtxt.Name = "StudentIDtxt";
            this.StudentIDtxt.Size = new System.Drawing.Size(264, 44);
            this.StudentIDtxt.TabIndex = 1;
            // 
            // schoolgradeLabel
            // 
            this.schoolgradeLabel.AutoSize = true;
            this.schoolgradeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolgradeLabel.Location = new System.Drawing.Point(1098, 878);
            this.schoolgradeLabel.Name = "schoolgradeLabel";
            this.schoolgradeLabel.Size = new System.Drawing.Size(175, 37);
            this.schoolgradeLabel.TabIndex = 14;
            this.schoolgradeLabel.Text = "Student ID";
            // 
            // Emailtxt
            // 
            this.Emailtxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emailtxt.Location = new System.Drawing.Point(1712, 960);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(264, 44);
            this.Emailtxt.TabIndex = 5;
            // 
            // virtualAddressLabel
            // 
            this.virtualAddressLabel.AutoSize = true;
            this.virtualAddressLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virtualAddressLabel.Location = new System.Drawing.Point(1596, 967);
            this.virtualAddressLabel.Name = "virtualAddressLabel";
            this.virtualAddressLabel.Size = new System.Drawing.Size(104, 37);
            this.virtualAddressLabel.TabIndex = 15;
            this.virtualAddressLabel.Text = "Email";
            // 
            // Phonetxt
            // 
            this.Phonetxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonetxt.Location = new System.Drawing.Point(1712, 1063);
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(264, 44);
            this.Phonetxt.TabIndex = 6;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(1596, 1070);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(112, 37);
            this.numberLabel.TabIndex = 16;
            this.numberLabel.Text = "Phone";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.AddBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(1105, 1149);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(196, 78);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.UpdateBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(1331, 1149);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(195, 78);
            this.UpdateBtn.TabIndex = 8;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Tomato;
            this.DeleteBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(1562, 1149);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(195, 78);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Resetbtn
            // 
            this.Resetbtn.BackColor = System.Drawing.Color.PowderBlue;
            this.Resetbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetbtn.Location = new System.Drawing.Point(1779, 1149);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(195, 78);
            this.Resetbtn.TabIndex = 10;
            this.Resetbtn.Text = "Reset";
            this.Resetbtn.UseVisualStyleBackColor = false;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // Searchtxt
            // 
            this.Searchtxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchtxt.Location = new System.Drawing.Point(1306, 779);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(530, 44);
            this.Searchtxt.TabIndex = 18;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(1001, 786);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(276, 37);
            this.SearchLabel.TabIndex = 19;
            this.SearchLabel.Text = "Search Database";
            // 
            // Searchbtn
            // 
            this.Searchbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.Searchbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.Location = new System.Drawing.Point(1871, 760);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(196, 78);
            this.Searchbtn.TabIndex = 20;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = false;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(2642, 40);
            this.MenuStrip.TabIndex = 22;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.closeApplicationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(334, 44);
            this.exportToolStripMenuItem.Text = "Export to Excel";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(334, 44);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.closeApplicationToolStripMenuItem_Click);
            // 
            // Countlbl
            // 
            this.Countlbl.AutoSize = true;
            this.Countlbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Countlbl.Location = new System.Drawing.Point(1700, 713);
            this.Countlbl.Name = "Countlbl";
            this.Countlbl.Size = new System.Drawing.Size(57, 37);
            this.Countlbl.TabIndex = 24;
            this.Countlbl.Text = "??";
            // 
            // StudentCountlbl
            // 
            this.StudentCountlbl.AutoSize = true;
            this.StudentCountlbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentCountlbl.Location = new System.Drawing.Point(1328, 713);
            this.StudentCountlbl.Name = "StudentCountlbl";
            this.StudentCountlbl.Size = new System.Drawing.Size(366, 37);
            this.StudentCountlbl.TabIndex = 25;
            this.StudentCountlbl.Text = "Total Student Records:";
            // 
            // StudentDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(2642, 1399);
            this.Controls.Add(this.StudentCountlbl);
            this.Controls.Add(this.Countlbl);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.Searchtxt);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.Phonetxt);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.virtualAddressLabel);
            this.Controls.Add(this.StudentIDtxt);
            this.Controls.Add(this.schoolgradeLabel);
            this.Controls.Add(this.Agetxt);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.Lastnametxt);
            this.Controls.Add(this.nameLabel2);
            this.Controls.Add(this.Firstnametxt);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.StudentData);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "StudentDatabase";
            this.ShowIcon = false;
            this.Text = "One80 Youth Student Database";
            this.Load += new System.EventHandler(this.StudentDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentData)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridView StudentData;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.TextBox Firstnametxt;
        private System.Windows.Forms.TextBox Lastnametxt;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.TextBox Agetxt;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox StudentIDtxt;
        private System.Windows.Forms.Label schoolgradeLabel;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.Label virtualAddressLabel;
        private System.Windows.Forms.TextBox Phonetxt;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.Label Countlbl;
        private System.Windows.Forms.Label StudentCountlbl;
    }
}

