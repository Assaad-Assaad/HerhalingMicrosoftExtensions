using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhaling_MicrosoftExtensions;

public class ServiceB
{
    private readonly ILogger<ServiceB> _logger;
    private ServiceA _serviceA;
    

    public ServiceB(ILogger<ServiceB> logger, ServiceA serviceA)
    {
        Console.WriteLine("Constructor B Called");
        _logger = logger;
        _serviceA = serviceA;
        
    }

    public async Task Process()
    {
        
        _logger.LogDebug("Log Debug B");
        
    }
}