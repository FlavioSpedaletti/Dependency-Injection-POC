using Dependency_Injection_POC.Services.Interfaces;

namespace Dependency_Injection_POC.Helpers
{
    public class TestHelper
    {
        private readonly IServiceA _serviceA;

        public TestHelper(IServiceA serviceA)
        {
            _serviceA = serviceA;
        }

        public string HelperMethod()
        {
            return _serviceA.ServicesBaseMethod();
        }
    }
}
