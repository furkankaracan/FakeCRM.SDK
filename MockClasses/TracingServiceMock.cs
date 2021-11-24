using System;
using Microsoft.Xrm.Sdk;
using Moq;

namespace FakeCRM.SDK
{
    public class TracingServiceMock : Mock<ITracingService>, ITracingServiceMock
    {
        public void VerifyTrace(Times times)
        {
            this.Verify(service => service.Trace(It.IsAny<string>(), It.IsAny<object[]>()), times);
        }

        public void VerifyTrace(Func<Times> times)
        {
            this.Verify(service => service.Trace(It.IsAny<string>(), It.IsAny<object[]>()), times);
        }
    }
}
