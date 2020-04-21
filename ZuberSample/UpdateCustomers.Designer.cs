namespace ZuberSample
{
    partial class UpdateCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCustomers));
            this.textBoxtelephoneupdate = new System.Windows.Forms.TextBox();
            this.textBoxnameupdate = new System.Windows.Forms.TextBox();
            this.textBoxdestinationupdate = new System.Windows.Forms.TextBox();
            this.textBoxlocationupdate = new System.Windows.Forms.TextBox();
            this.labeltelephoneupdate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonsubmitupdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxtelephoneupdate
            // 
            this.textBoxtelephoneupdate.Location = new System.Drawing.Point(103, 370);
            this.textBoxtelephoneupdate.Name = "textBoxtelephoneupdate";
            this.textBoxtelephoneupdate.Size = new System.Drawing.Size(131, 22);
            this.textBoxtelephoneupdate.TabIndex = 4;
            // 
            // textBoxnameupdate
            // 
            this.textBoxnameupdate.Location = new System.Drawing.Point(103, 150);
            this.textBoxnameupdate.Name = "textBoxnameupdate";
            this.textBoxnameupdate.Size = new System.Drawing.Size(131, 22);
            this.textBoxnameupdate.TabIndex = 5;
            // 
            // textBoxdestinationupdate
            // 
            this.textBoxdestinationupdate.Location = new System.Drawing.Point(103, 289);
            this.textBoxdestinationupdate.Name = "textBoxdestinationupdate";
            this.textBoxdestinationupdate.Size = new System.Drawing.Size(131, 22);
            this.textBoxdestinationupdate.TabIndex = 6;
            // 
            // textBoxlocationupdate
            // 
            this.textBoxlocationupdate.Location = new System.Drawing.Point(103, 212);
            this.textBoxlocationupdate.Name = "textBoxlocationupdate";
            this.textBoxlocationupdate.Size = new System.Drawing.Size(131, 22);
            this.textBoxlocationupdate.TabIndex = 7;
            // 
            // labeltelephoneupdate
            // 
            this.labeltelephoneupdate.AutoSize = true;
            this.labeltelephoneupdate.Location = new System.Drawing.Point(100, 350);
            this.labeltelephoneupdate.Name = "labeltelephoneupdate";
            this.labeltelephoneupdate.Size = new System.Drawing.Size(126, 17);
            this.labeltelephoneupdate.TabIndex = 8;
            this.labeltelephoneupdate.Text = "Telephone Update";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name Update";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Destination Update";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Location Update";
            // 
            // buttonsubmitupdate
            // 
            this.buttonsubmitupdate.Location = new System.Drawing.Point(497, 332);
            this.buttonsubmitupdate.Name = "buttonsubmitupdate";
            this.buttonsubmitupdate.Size = new System.Drawing.Size(173, 69);
            this.buttonsubmitupdate.TabIndex = 12;
            this.buttonsubmitupdate.Text = "Submit Changes";
            this.buttonsubmitupdate.UseVisualStyleBackColor = true;
            this.buttonsubmitupdate.Click += new System.EventHandler(this.buttonsubmitupdate_Click);
            // 
            // UpdateCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonsubmitupdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeltelephoneupdate);
            this.Controls.Add(this.textBoxlocationupdate);
            this.Controls.Add(this.textBoxdestinationupdate);
            this.Controls.Add(this.textBoxnameupdate);
            this.Controls.Add(this.textBoxtelephoneupdate);
            this.Name = "UpdateCustomers";
            this.Text = "UpdateCustomers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxtelephoneupdate;
        private System.Windows.Forms.TextBox textBoxnameupdate;
        private System.Windows.Forms.TextBox textBoxdestinationupdate;
        private System.Windows.Forms.TextBox textBoxlocationupdate;
        private System.Windows.Forms.Label labeltelephoneupdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonsubmitupdate;
    }
}