using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRacing
{
    public class CrashStatusEventArgs : EventArgs
    {
        private bool IsCrash { get; set; }

        private char MyCarPosition { get; set; }

        public CrashStatusEventArgs(bool isCrash)
        {
            this.IsCrash = isCrash;
        }
    }
}
