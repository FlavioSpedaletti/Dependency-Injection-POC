using Dependency_Injection_POC.Services.Interfaces;
using System.Diagnostics;

namespace Dependency_Injection_POC.Services
{
    public class ServiceA : IServiceA
    {
        public string ServicesBaseMethod()
        {
            return "Service A";
        }
    }
}
