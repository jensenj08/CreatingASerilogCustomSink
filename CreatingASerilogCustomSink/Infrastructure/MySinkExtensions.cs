using Serilog;
using Serilog.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreatingASerilogCustomSink.Infrastructure
{
    public static class MySinkExtensions
    {
        public static LoggerConfiguration MySink(
                  this LoggerSinkConfiguration loggerConfiguration,
                  string url, 
                  string password,
                  IFormatProvider formatProvider = null)
        {
            return loggerConfiguration.Sink(new MySink(formatProvider, url, password));
        }
    }
}
