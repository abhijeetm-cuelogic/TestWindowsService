using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Logger
{
    public interface ILogger
    {
        void TraceLog(string message);
        void TraceLog(Exception message);
    }
}
