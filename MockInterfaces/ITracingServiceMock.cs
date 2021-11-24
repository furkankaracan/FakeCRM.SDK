using System;
using Microsoft.Xrm.Sdk;
using Moq;

namespace FakeCRM.SDK
{
    public interface ITracingServiceMock : IMock<ITracingService>
    {
        /// <summary>
        /// Verify that the Trace method has been called
        /// </summary>
        /// <param name="times">The number of times the method was called</param>
        void VerifyTrace(Times times);

        /// <summary>
        /// Verify that the Trace method has been called
        /// </summary>
        /// <param name="times">The number of times the method was called</param>
        void VerifyTrace(Func<Times> times);
    }
}
