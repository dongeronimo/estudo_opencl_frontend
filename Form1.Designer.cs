namespace Frontend
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDeviceEnumeration = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEnumerar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNumberOfPlatforms = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageDeviceEnumeration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDeviceEnumeration);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(449, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageDeviceEnumeration
            // 
            this.tabPageDeviceEnumeration.Controls.Add(this.labelNumberOfPlatforms);
            this.tabPageDeviceEnumeration.Controls.Add(this.label2);
            this.tabPageDeviceEnumeration.Controls.Add(this.label1);
            this.tabPageDeviceEnumeration.Controls.Add(this.dataGridView1);
            this.tabPageDeviceEnumeration.Controls.Add(this.btnEnumerar);
            this.tabPageDeviceEnumeration.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeviceEnumeration.Name = "tabPageDeviceEnumeration";
            this.tabPageDeviceEnumeration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeviceEnumeration.Size = new System.Drawing.Size(441, 399);
            this.tabPageDeviceEnumeration.TabIndex = 0;
            this.tabPageDeviceEnumeration.Text = "Devices";
            this.tabPageDeviceEnumeration.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(441, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEnumerar
            // 
            this.btnEnumerar.Location = new System.Drawing.Point(7, 7);
            this.btnEnumerar.Name = "btnEnumerar";
            this.btnEnumerar.Size = new System.Drawing.Size(75, 23);
            this.btnEnumerar.TabIndex = 0;
            this.btnEnumerar.Text = "Enumerar";
            this.btnEnumerar.UseVisualStyleBackColor = true;
            this.btnEnumerar.Click += new System.EventHandler(this.btnEnumerar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(182, 347);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enumera as plataformas e dispostivos OpenCL no sistema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Platforms:";
            // 
            // labelNumberOfPlatforms
            // 
            this.labelNumberOfPlatforms.AutoSize = true;
            this.labelNumberOfPlatforms.Location = new System.Drawing.Point(249, 36);
            this.labelNumberOfPlatforms.Name = "labelNumberOfPlatforms";
            this.labelNumberOfPlatforms.Size = new System.Drawing.Size(35, 13);
            this.labelNumberOfPlatforms.TabIndex = 4;
            this.labelNumberOfPlatforms.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageDeviceEnumeration.ResumeLayout(false);
            this.tabPageDeviceEnumeration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDeviceEnumeration;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEnumerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelNumberOfPlatforms;
        private System.Windows.Forms.Label label2;
    }
}

