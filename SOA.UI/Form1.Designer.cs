namespace SOA.UI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnWebService = new System.Windows.Forms.Button();
            this.btnWcfService = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnWebService
            // 
            this.btnWebService.Location = new System.Drawing.Point(31, 33);
            this.btnWebService.Name = "btnWebService";
            this.btnWebService.Size = new System.Drawing.Size(130, 48);
            this.btnWebService.TabIndex = 1;
            this.btnWebService.Text = "WebService";
            this.btnWebService.UseVisualStyleBackColor = true;
            this.btnWebService.Click += new System.EventHandler(this.btnWebService_Click);
            // 
            // btnWcfService
            // 
            this.btnWcfService.Location = new System.Drawing.Point(167, 33);
            this.btnWcfService.Name = "btnWcfService";
            this.btnWcfService.Size = new System.Drawing.Size(130, 48);
            this.btnWcfService.TabIndex = 1;
            this.btnWcfService.Text = "WcfService";
            this.btnWcfService.UseVisualStyleBackColor = true;
            this.btnWcfService.Click += new System.EventHandler(this.btnWcfService_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWcfService);
            this.Controls.Add(this.btnWebService);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnWebService;
        private System.Windows.Forms.Button btnWcfService;
    }
}

