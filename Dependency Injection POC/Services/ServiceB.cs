using Dependency_Injection_POC.Services.Interfaces;
using System.Diagnostics;

namespace Dependency_Injection_POC.Services
{
    public class ServiceB : IServiceB
    {
        public string ServicesBaseMethod()
        {
            return "Service B";
        }
    }
}
