using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    interface ISeries
    {
        void setStart(int a);
        int getNext();
        void reset();
    }
}
