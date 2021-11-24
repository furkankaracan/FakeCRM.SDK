using System;
using Moq;

namespace FakeCRM.SDK
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/api/system.iserviceprovider?redirectedfrom=MSDN&view=net-6.0
    /// </summary>
    public interface IServiceProviderMock : IMock<IServiceProvider>
    {
    }
}
