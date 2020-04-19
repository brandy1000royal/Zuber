namespace ZuberSample
{
    partial class UpdateAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAdmin));
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonsubmitupdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(92, 372);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(131, 22);
            this.textBoxPassword.TabIndex = 1;
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(92, 299);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(131, 22);
            this.textBoxusername.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(92, 225);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(131, 22);
            this.textBoxName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password Update";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(100, 279);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(123, 17);
            this.labelUsername.TabIndex = 6;
            this.labelUsername.Text = "Username Update";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name Update";
            // 
            // buttonsubmitupdate
            // 
            this.buttonsubmitupdate.Location = new System.Drawing.Point(502, 352);
            this.buttonsubmitupdate.Name = "buttonsubmitupdate";
            this.buttonsubmitupdate.Size = new System.Drawing.Size(173, 69);
            this.buttonsubmitupdate.TabIndex = 8;
            this.buttonsubmitupdate.Text = "Submit Changes";
            this.buttonsubmitupdate.UseVisualStyleBackColor = true;
            this.buttonsubmitupdate.Click += new System.EventHandler(this.buttonsubmitupdate_Click);
            // 
            // UpdateAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonsubmitupdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxusername);
            this.Controls.Add(this.textBoxPassword);
            this.Name = "UpdateAdmin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonsubmitupdate;
    }
}