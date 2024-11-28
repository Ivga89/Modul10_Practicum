using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_DependencyInjection
{
    internal class Logger : ILogger
    {
        void ILogger.Error()
        {
            throw new NotImplementedException();
        }

        void ILogger.Event()
        {
            throw new NotImplementedException();
        }
    }
}
