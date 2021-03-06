using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;

namespace FakeCRM.SDK
{
    [TestClass]
    public abstract class PluginTest<TPlugin> : TestBase
        where TPlugin : IPlugin, new()
    {
        /// <summary>
        /// Gets an instance of <see cref="UnitTesting.TracingServiceMock"/> for checking tracing events against
        /// </summary>
        protected ITracingServiceMock TracingServiceMock { get; private set; }

        /// <summary>
        /// Gets an instance of <see cref="UnitTesting.PluginExecutionContextMock"/> for stubbing out the plugin context
        /// </summary>
        protected PluginExecutionContextMock PluginExecutionContextMock { get; private set; }

        /// <summary>
        /// Gets the plugin under test
        /// </summary>
        protected TPlugin Plugin { get; private set; }

        /// <summary>
        /// Creates an instance of the specified Plugin class and fires its Execute method
        /// </summary>
        public void ExecutePlugin()
        {
            var serviceProvider = new ServiceProviderMock(this.PluginExecutionContextMock, this.OrganizationServiceMock, this.TracingServiceMock);

            this.Plugin.Execute(serviceProvider.Object);
        }

        /// <inheritdoc/>
        [TestInitialize]
        public override void Initialize()
        {
            base.Initialize();

            this.PluginExecutionContextMock = new PluginExecutionContextMock();
            this.TracingServiceMock = new TracingServiceMock();

            // Create an instance of the plugin class under test
            this.Plugin = new TPlugin();
        }
    }
}
