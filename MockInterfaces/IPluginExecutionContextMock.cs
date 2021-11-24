using Microsoft.Xrm.Sdk;


namespace FakeCRM.SDK
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/api/microsoft.xrm.sdk.ipluginexecutioncontext?view=dynamics-general-ce-9
    /// </summary>
    public interface IPluginExecutionContextMock : IExecutionContextMock<IPluginExecutionContext>
    {
        /// <summary>
        /// Gets or sets the parent context of the plugin being mocked
        /// </summary>
        IPluginExecutionContext ParentContext { get; set; }

        /// <summary>
        /// Gets or sets the execution stage of the plugin being mocked
        /// </summary>
        int Stage { get; set; }
    }
}
