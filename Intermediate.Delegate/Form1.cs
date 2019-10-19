using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intermediate.Delegate
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
            this.ActiveControl = textName;
        }

        private void btnCalc_Click(object sender, EventArgs e) {
            Student s = new Student();
            s.Name = textName.Text;
            s.Number = textNumber.Text;
            s.PassStatusChanged += S_PassStatusChanged;

            Exam midterm = new Exam();
            midterm.Date = DateTime.Now.AddDays(-45);
            midterm.Result = (double)textMidtermExam.Value;
            s.Midterm = midterm;

            Exam final = new Exam();
            final.Date = DateTime.Now;
            final.Result = (double)textFinalExam.Value;
            s.Final = final;

            listBoxAllStudents.Items.Add(s.NameWithNumber);
            Tools.ClearControl(groupBox1, focusFirstTextBox: true);
        }

        private void S_PassStatusChanged(object sender, PassStatusEventArgs e) {
            Student s = e.Student;
            switch (e.StudentStatus) {
                case StudentStatus.Fail:
                    listBoxSuccess.Items.Remove(s);
                    if (!listBoxFail.Items.Contains(s)) {
                        listBoxFail.Items.Add(s);
                    }
                    break;
                case StudentStatus.Success:
                    listBoxFail.Items.Remove(s);
                    if (!listBoxSuccess.Items.Contains(s)) {
                        listBoxSuccess.Items.Add(s);
                    }
                    break;
                case StudentStatus.Uncertain:
                    break;
                default:
                    break;
            }
        }
    }
}
