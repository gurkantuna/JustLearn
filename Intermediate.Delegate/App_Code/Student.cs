namespace Intermediate.Delegate {
    public delegate void PassStatusEventHandler(object sender, PassStatusEventArgs e);

    public class Student
    {
        /// <summary>
        /// Studens's Fisrt and LastName
        /// </summary>
        public string Name { get; set; }

        public string Number { get; set; }

        /// <summary>
        /// Midterm Exam
        /// </summary>
        private Exam _midterm;
        public Exam Midterm
        {
            get { return _midterm; }
            set
            {
                _midterm = value;
                StatusControl();
            }
        }

        /// <summary>
        /// Final Exam
        /// </summary>
        private Exam _final;
        public Exam Final
        {
            get { return _final; }
            set
            {
                _final = value;
                StatusControl();
            }
        }

        /// <summary>
        /// Student's achievement status(This status is not dependent on the lesson because of simplicity)
        /// </summary>
        private void StatusControl()
        {
            PassStatusEventArgs arg = new PassStatusEventArgs();
            arg.Student = this;

            if (PassStatusChanged != null)
            {
                if (Average > 60 && Average <= 100)
                {
                    arg.StudentStatus = StudentStatus.Success;
                }
                else if (Average > 0 && Average <= 60)
                {
                    arg.StudentStatus = StudentStatus.Fail;
                }
                else
                {
                    arg.StudentStatus = StudentStatus.Uncertain;
                }

                PassStatusChanged(this, arg);
            }
        }

        /// <summary>
        /// Average for that lesson
        /// </summary>
        public double Average
        {
            get
            {
                return Midterm.Result * 0.4 + Final.Result * 0.6;
            }
        }

        public event PassStatusEventHandler PassStatusChanged;

        public override string ToString()
        {
            return $"{this.Name}-{this.Number} - AVG:{this.Average}";
        }

        public string NameWithNumber
        {
            get => $"{this.Name}-{this.Number}";
        }
    }
}
