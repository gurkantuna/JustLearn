using JustLearn.CustomControls;

namespace Intermediate.Delegate
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
        private void InitializeComponent() {
            this.btnCalc = new System.Windows.Forms.Button();
            this.listBoxAllStudents = new System.Windows.Forms.ListBox();
            this.textName = new TextBoxCustom();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textFinalExam = new System.Windows.Forms.NumericUpDown();
            this.textMidtermExam = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNumber = new TextBoxCustom();
            this.listBoxSuccess = new System.Windows.Forms.ListBox();
            this.listBoxFail = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textFinalExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMidtermExam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(355, 29);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // listBoxAllStudents
            // 
            this.listBoxAllStudents.FormattingEnabled = true;
            this.listBoxAllStudents.Location = new System.Drawing.Point(12, 107);
            this.listBoxAllStudents.Name = "listBoxAllStudents";
            this.listBoxAllStudents.Size = new System.Drawing.Size(162, 212);
            this.listBoxAllStudents.TabIndex = 0;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(9, 32);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name LastName";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textFinalExam);
            this.groupBox1.Controls.Add(this.textMidtermExam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textNumber);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.btnCalc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // textFinalExam
            // 
            this.textFinalExam.Location = new System.Drawing.Point(279, 32);
            this.textFinalExam.Name = "textFinalExam";
            this.textFinalExam.Size = new System.Drawing.Size(70, 20);
            this.textFinalExam.TabIndex = 3;
            // 
            // textMidtermExam
            // 
            this.textMidtermExam.Location = new System.Drawing.Point(188, 32);
            this.textMidtermExam.Name = "textMidtermExam";
            this.textMidtermExam.Size = new System.Drawing.Size(70, 20);
            this.textMidtermExam.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(276, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Final Exam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(185, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Midterm Exam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(112, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number";
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(115, 32);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(64, 20);
            this.textNumber.TabIndex = 1;
            // 
            // listBoxSuccess
            // 
            this.listBoxSuccess.FormattingEnabled = true;
            this.listBoxSuccess.Location = new System.Drawing.Point(185, 107);
            this.listBoxSuccess.Name = "listBoxSuccess";
            this.listBoxSuccess.Size = new System.Drawing.Size(162, 212);
            this.listBoxSuccess.TabIndex = 1;
            // 
            // listBoxFail
            // 
            this.listBoxFail.FormattingEnabled = true;
            this.listBoxFail.Location = new System.Drawing.Point(362, 107);
            this.listBoxFail.Name = "listBoxFail";
            this.listBoxFail.Size = new System.Drawing.Size(162, 212);
            this.listBoxFail.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(234, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "SUCCESS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(427, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "FAIL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 356);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxFail);
            this.Controls.Add(this.listBoxSuccess);
            this.Controls.Add(this.listBoxAllStudents);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textFinalExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMidtermExam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ListBox listBoxAllStudents;
        //private System.Windows.Forms.TextBox textName;
        //private System.Windows.Forms.TextBox textNumber;
        TextBoxCustom textName;
        TextBoxCustom textNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown textFinalExam;
        private System.Windows.Forms.NumericUpDown textMidtermExam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxSuccess;
        private System.Windows.Forms.ListBox listBoxFail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

