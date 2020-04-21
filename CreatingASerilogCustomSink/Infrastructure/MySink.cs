using Serilog.Core;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreatingASerilogCustomSink.Infrastructure
{
    public class MySink : ILogEventSink 
    {
        private readonly IFormatProvider _formatProvider;
        private readonly string _url;
        private readonly string _password;

        public MySink(IFormatProvider formatProvider, string url, string password)
        {
            _formatProvider = formatProvider;
            _url = url;
            _password = password; 
        }

        public void Emit(LogEvent logEvent)
        {
            var message = logEvent.RenderMessage(_formatProvider);
            var error = "Posting error to " + _url + "using password " + _password + ": " + DateTimeOffset.Now.ToString() + " " + message; 
            Console.WriteLine(error);
        }
    }
}
