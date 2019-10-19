using System;

namespace Intermediate.Delegate
{
    public class PassStatusEventArgs : EventArgs
    {
        public Student Student { get; set; }
        public StudentStatus StudentStatus { get; set; }
    }
}
