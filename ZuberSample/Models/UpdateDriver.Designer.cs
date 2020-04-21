namespace ZuberSample.Models
{
    partial class UpdateDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDriver));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonsubmitupdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxcartypeupdate = new System.Windows.Forms.TextBox();
            this.textBoxpostupdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(124, 196);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(131, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name Update";
            // 
            // buttonsubmitupdate
            // 
            this.buttonsubmitupdate.Location = new System.Drawing.Point(528, 347);
            this.buttonsubmitupdate.Name = "buttonsubmitupdate";
            this.buttonsubmitupdate.Size = new System.Drawing.Size(173, 69);
            this.buttonsubmitupdate.TabIndex = 9;
            this.buttonsubmitupdate.Text = "Submit Changes";
            this.buttonsubmitupdate.UseVisualStyleBackColor = true;
            this.buttonsubmitupdate.Click += new System.EventHandler(this.buttonsubmitupdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Car Type Update";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Post Update";
            // 
            // textBoxcartypeupdate
            // 
            this.textBoxcartypeupdate.Location = new System.Drawing.Point(124, 249);
            this.textBoxcartypeupdate.Name = "textBoxcartypeupdate";
            this.textBoxcartypeupdate.Size = new System.Drawing.Size(131, 22);
            this.textBoxcartypeupdate.TabIndex = 12;
            // 
            // textBoxpostupdate
            // 
            this.textBoxpostupdate.Location = new System.Drawing.Point(124, 317);
            this.textBoxpostupdate.Name = "textBoxpostupdate";
            this.textBoxpostupdate.Size = new System.Drawing.Size(131, 22);
            this.textBoxpostupdate.TabIndex = 13;
            // 
            // UpdateDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxpostupdate);
            this.Controls.Add(this.textBoxcartypeupdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonsubmitupdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxName);
            this.Name = "UpdateDriver";
            this.Text = "UpdateDriver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonsubmitupdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxcartypeupdate;
        private System.Windows.Forms.TextBox textBoxpostupdate;
    }
}