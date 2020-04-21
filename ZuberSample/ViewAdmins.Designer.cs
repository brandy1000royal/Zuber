namespace ZuberSample
{
    partial class ViewAdmins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAdmins));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1delete = new System.Windows.Forms.Button();
            this.buttoncreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(951, 255);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // button1delete
            // 
            this.button1delete.Location = new System.Drawing.Point(943, 511);
            this.button1delete.Margin = new System.Windows.Forms.Padding(4);
            this.button1delete.Name = "button1delete";
            this.button1delete.Size = new System.Drawing.Size(100, 28);
            this.button1delete.TabIndex = 1;
            this.button1delete.Text = "Delete";
            this.button1delete.UseVisualStyleBackColor = true;
            this.button1delete.Click += new System.EventHandler(this.button1delete_Click);
            // 
            // buttoncreate
            // 
            this.buttoncreate.Location = new System.Drawing.Point(835, 511);
            this.buttoncreate.Margin = new System.Windows.Forms.Padding(4);
            this.buttoncreate.Name = "buttoncreate";
            this.buttoncreate.Size = new System.Drawing.Size(100, 28);
            this.buttoncreate.TabIndex = 2;
            this.buttoncreate.Text = "Create";
            this.buttoncreate.UseVisualStyleBackColor = true;
            this.buttoncreate.Click += new System.EventHandler(this.buttoncreate_Click);
            // 
            // ViewAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttoncreate);
            this.Controls.Add(this.button1delete);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewAdmins";
            this.Text = "View Admins";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewAdmins_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewAdmins_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1delete;
        private System.Windows.Forms.Button buttoncreate;
    }
}