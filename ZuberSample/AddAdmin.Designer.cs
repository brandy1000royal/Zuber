namespace ZuberSample
{
    partial class AddAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxaddadminname = new System.Windows.Forms.TextBox();
            this.textBoxaddadminpassword = new System.Windows.Forms.TextBox();
            this.textBoxaddadminusername = new System.Windows.Forms.TextBox();
            this.buttonaddnewadmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(101, 126);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // textBoxaddadminname
            // 
            this.textBoxaddadminname.Location = new System.Drawing.Point(93, 87);
            this.textBoxaddadminname.Name = "textBoxaddadminname";
            this.textBoxaddadminname.Size = new System.Drawing.Size(126, 20);
            this.textBoxaddadminname.TabIndex = 3;
            // 
            // textBoxaddadminpassword
            // 
            this.textBoxaddadminpassword.Location = new System.Drawing.Point(93, 195);
            this.textBoxaddadminpassword.Name = "textBoxaddadminpassword";
            this.textBoxaddadminpassword.Size = new System.Drawing.Size(126, 20);
            this.textBoxaddadminpassword.TabIndex = 4;
            // 
            // textBoxaddadminusername
            // 
            this.textBoxaddadminusername.Location = new System.Drawing.Point(93, 142);
            this.textBoxaddadminusername.Name = "textBoxaddadminusername";
            this.textBoxaddadminusername.Size = new System.Drawing.Size(126, 20);
            this.textBoxaddadminusername.TabIndex = 5;
            // 
            // buttonaddnewadmin
            // 
            this.buttonaddnewadmin.Location = new System.Drawing.Point(385, 282);
            this.buttonaddnewadmin.Name = "buttonaddnewadmin";
            this.buttonaddnewadmin.Size = new System.Drawing.Size(201, 80);
            this.buttonaddnewadmin.TabIndex = 6;
            this.buttonaddnewadmin.Text = "Submit";
            this.buttonaddnewadmin.UseVisualStyleBackColor = true;
            this.buttonaddnewadmin.Click += new System.EventHandler(this.buttonaddnewadmin_Click);
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonaddnewadmin);
            this.Controls.Add(this.textBoxaddadminusername);
            this.Controls.Add(this.textBoxaddadminpassword);
            this.Controls.Add(this.textBoxaddadminname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.Name = "AddAdmin";
            this.Text = "AddAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxaddadminname;
        private System.Windows.Forms.TextBox textBoxaddadminpassword;
        private System.Windows.Forms.TextBox textBoxaddadminusername;
        private System.Windows.Forms.Button buttonaddnewadmin;
    }
}