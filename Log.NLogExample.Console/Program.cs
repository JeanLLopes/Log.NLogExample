using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Log.NLogExample.Console
{
    class Program
    {

        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            CalculoTeste();
        }

        private static void CalculoTeste()
        {
            int zero = 0;
            try
            {
                var result = 100 / zero;
            }
            catch (Exception ex)
            {
                logger.ErrorException("Error", ex);
                //int k = 42;
                //int l = 100;
                //logger.Trace("Sample trace message, k={0}, l={1}", k, l);
                //logger.Debug("Sample debug message, k={0}, l={1}", k, l);
                //logger.Info("Sample informational message, k={0}, l={1}", k, l);
                //logger.Warn("Sample warning message, k={0}, l={1}", k, l);
                //logger.Error("Sample error message, k={0}, l={1}", k, l);
                //logger.Fatal("Sample fatal error message, k={0}, l={1}", k, l);
                //logger.Log(LogLevel.Info, "Sample informational message, k={0}, l={1}", k, l);

            }
        }


        
        
    }
}
