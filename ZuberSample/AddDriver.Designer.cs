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
            this.textBoxadddrivercar = new System.Windows.Forms.TextBox();
            this.buttonsubmitadd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Driver\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Driver\'s Car Type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Driver\'s Post";
            // 
            // textBoxadddrivername
            // 
            this.textBoxadddrivername.Location = new System.Drawing.Point(66, 134);
            this.textBoxadddrivername.Name = "textBoxadddrivername";
            this.textBoxadddrivername.Size = new System.Drawing.Size(100, 20);
            this.textBoxadddrivername.TabIndex = 4;
            // 
            // textBoxadddriverpost
            // 
            this.textBoxadddriverpost.Location = new System.Drawing.Point(64, 261);
            this.textBoxadddriverpost.Name = "textBoxadddriverpost";
            this.textBoxadddriverpost.Size = new System.Drawing.Size(100, 20);
            this.textBoxadddriverpost.TabIndex = 6;
            // 
            // textBoxadddrivercar
            // 
            this.textBoxadddrivercar.Location = new System.Drawing.Point(64, 199);
            this.textBoxadddrivercar.Name = "textBoxadddrivercar";
            this.textBoxadddrivercar.Size = new System.Drawing.Size(100, 20);
            this.textBoxadddrivercar.TabIndex = 7;
            // 
            // buttonsubmitadd
            // 
            this.buttonsubmitadd.Location = new System.Drawing.Point(318, 273);
            this.buttonsubmitadd.Name = "buttonsubmitadd";
            this.buttonsubmitadd.Size = new System.Drawing.Size(201, 77);
            this.buttonsubmitadd.TabIndex = 8;
            this.buttonsubmitadd.Text = "Submit";
            this.buttonsubmitadd.UseVisualStyleBackColor = true;
            // 
            // AddDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonsubmitadd);
            this.Controls.Add(this.textBoxadddrivercar);
            this.Controls.Add(this.textBoxadddriverpost);
            this.Controls.Add(this.textBoxadddrivername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox textBoxadddrivercar;
        private System.Windows.Forms.Button buttonsubmitadd;
    }
}