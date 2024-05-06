using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhaling_MicrosoftExtensions;

public class ServiceC
{
    private readonly ILogger<ServiceC> _logger;
    

    public ServiceC(ILogger<ServiceC> logger)
    {
        Console.WriteLine("Constructor C Called");
        _logger = logger;
        
    }

    public async Task Process()
    {
        
        _logger.LogDebug("Log Debug C");
        
    }
}