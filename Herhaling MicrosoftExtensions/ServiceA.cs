using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhaling_MicrosoftExtensions;

public class ServiceA
{
    private readonly ILogger<ServiceA> _logger;
    

    public ServiceA(ILogger<ServiceA> logger)
    {
        Console.WriteLine("Constructor A Called");
        _logger = logger;
        
    }

    public async Task Process()
    {
         _logger.LogTrace("Log Trace A");
        
    }
}