using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading.Tasks;
using Learn.Calculator.StandardCalculator;
using Learn.Logger;
using System.Timers;

namespace Learn.Service
{
    public partial class Calc : ServiceBase
    {
        private readonly IStandardCalculator calculator;
        private readonly ILogger logger;
        private Timer timer1 = null;

        public Calc()
        {
            InitializeComponent();
            calculator = new StandardCalculator();
            logger = new Logger.Logger();
            System.Diagnostics.Debugger.Break();
        }

        protected override void OnStart(string[] args)
        {
#if DEBUG
            System.Diagnostics.Debugger.Launch();
#endif

            timer1 = new Timer();
            this.timer1.Interval = 15000; //every 15 secs
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Tick);
            timer1.Enabled = true;
            logger.TraceLog("Test window service started");

            for (int i = 0; i < 5; i++)
            {
                calculator.Add(i, (i+1));
                logger.TraceLog("XYZ");
            }
        }

        private void timer1_Tick(object sender, ElapsedEventArgs e)
        {
            //Write code here to do some job depends on your requirement
            logger.TraceLog("Timer ticked and some job has been done successfully");
        }

        protected override void OnStop()
        {
            timer1.Enabled = false;
            logger.TraceLog("Test window service stopped");
        }
    }
}
