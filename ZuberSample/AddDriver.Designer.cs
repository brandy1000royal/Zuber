namespace ZuberSample
{
    partial class AddDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDriver));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxadddrivername = new System.Windows.Forms.TextBox();
            this.textBoxadddriverpost = new System.Windows.Forms.TextBox();
            this.textBoxadddrivercartype = new System.Windows.Forms.TextBox();
            this.buttonsubmitadd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Driver\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Driver\'s Car Type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Driver\'s Post";
            // 
            // textBoxadddrivername
            // 
            this.textBoxadddrivername.Location = new System.Drawing.Point(88, 165);
            this.textBoxadddrivername.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxadddrivername.Name = "textBoxadddrivername";
            this.textBoxadddrivername.Size = new System.Drawing.Size(132, 22);
            this.textBoxadddrivername.TabIndex = 4;
            // 
            // textBoxadddriverpost
            // 
            this.textBoxadddriverpost.Location = new System.Drawing.Point(85, 321);
            this.textBoxadddriverpost.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxadddriverpost.Name = "textBoxadddriverpost";
            this.textBoxadddriverpost.Size = new System.Drawing.Size(132, 22);
            this.textBoxadddriverpost.TabIndex = 6;
            // 
            // textBoxadddrivercartype
            // 
            this.textBoxadddrivercartype.Location = new System.Drawing.Point(85, 245);
            this.textBoxadddrivercartype.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxadddrivercartype.Name = "textBoxadddrivercartype";
            this.textBoxadddrivercartype.Size = new System.Drawing.Size(132, 22);
            this.textBoxadddrivercartype.TabIndex = 7;
            // 
            // buttonsubmitadd
            // 
            this.buttonsubmitadd.Location = new System.Drawing.Point(424, 336);
            this.buttonsubmitadd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsubmitadd.Name = "buttonsubmitadd";
            this.buttonsubmitadd.Size = new System.Drawing.Size(268, 95);
            this.buttonsubmitadd.TabIndex = 8;
            this.buttonsubmitadd.Text = "Submit";
            this.buttonsubmitadd.UseVisualStyleBackColor = true;
            this.buttonsubmitadd.Click += new System.EventHandler(this.buttonsubmitadd_Click);
            // 
            // AddDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonsubmitadd);
            this.Controls.Add(this.textBoxadddrivercartype);
            this.Controls.Add(this.textBoxadddriverpost);
            this.Controls.Add(this.textBoxadddrivername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddDriver";
            this.Text = "AddDriver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxadddrivername;
        private System.Windows.Forms.TextBox textBoxadddriverpost;
        private System.Windows.Forms.TextBox textBoxadddrivercartype;
        private System.Windows.Forms.Button buttonsubmitadd;
    }
}