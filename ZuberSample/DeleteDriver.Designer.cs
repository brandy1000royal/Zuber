namespace ZuberSample
{
    partial class DeleteDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteDriver));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxdeletedriver = new System.Windows.Forms.TextBox();
            this.comboBoxdeletedriver = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttondeletedriver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter ID of Driver to be Deleted";
            // 
            // textBoxdeletedriver
            // 
            this.textBoxdeletedriver.Location = new System.Drawing.Point(192, 164);
            this.textBoxdeletedriver.Name = "textBoxdeletedriver";
            this.textBoxdeletedriver.Size = new System.Drawing.Size(283, 20);
            this.textBoxdeletedriver.TabIndex = 1;
            // 
            // comboBoxdeletedriver
            // 
            this.comboBoxdeletedriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxdeletedriver.FormattingEnabled = true;
            this.comboBoxdeletedriver.Items.AddRange(new object[] {
            "Termination",
            "Resignation",
            "Vacation Leave"});
            this.comboBoxdeletedriver.Location = new System.Drawing.Point(192, 227);
            this.comboBoxdeletedriver.Name = "comboBoxdeletedriver";
            this.comboBoxdeletedriver.Size = new System.Drawing.Size(283, 21);
            this.comboBoxdeletedriver.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Reason for Delete";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttondeletedriver
            // 
            this.buttondeletedriver.Location = new System.Drawing.Point(257, 284);
            this.buttondeletedriver.Name = "buttondeletedriver";
            this.buttondeletedriver.Size = new System.Drawing.Size(188, 85);
            this.buttondeletedriver.TabIndex = 4;
            this.buttondeletedriver.Text = "Delete";
            this.buttondeletedriver.UseVisualStyleBackColor = true;
            // 
            // DeleteDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttondeletedriver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxdeletedriver);
            this.Controls.Add(this.textBoxdeletedriver);
            this.Controls.Add(this.label1);
            this.Name = "DeleteDriver";
            this.Text = "DeleteDriver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxdeletedriver;
        private System.Windows.Forms.ComboBox comboBoxdeletedriver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttondeletedriver;
    }
}