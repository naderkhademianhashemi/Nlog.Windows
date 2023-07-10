using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace Nlog.Windows.Util
{
    public static class Extens
    {
        public static void LogError(string MSG)
        {
            var config = new LoggingConfiguration();

            var fileTarget = new FileTarget();
            config.AddTarget("file", fileTarget);

            fileTarget.FileName = "${basedir}/Log/NLogFile.txt";
            fileTarget.Layout = "${message}";

            var rule2 = new LoggingRule("*", LogLevel.Debug, fileTarget);
            config.LoggingRules.Add(rule2);

            LogManager.Configuration = config;

            var logger = LogManager.GetLogger("Example");

            logger.Error(MSG);
        }
    }
}
