using Microsoft.Xrm.Sdk.Workflow;

namespace FakeCRM.SDK
{

    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/api/microsoft.xrm.sdk.workflow.iworkflowcontext?view=dynamics-workflow-ce-9
    /// </summary>
    public interface IWorkflowContextMock : IExecutionContextMock<IWorkflowContext>
    {
        /// <summary>
        /// Gets or sets the parent context.
        /// </summary>
        IWorkflowContext ParentContext { get; set; }

        /// <summary>
        /// Gets or sets the stage information of the process instance.
        /// </summary>
        string StageName { get; set; }

        /// <summary>
        /// Gets or sets the process category information of the process instance: workflow or dialog.
        /// </summary>
        int WorkflowCategory { get; set; }

        /// <summary>
        /// Gets or sets how the workflow is to be executed.
        /// </summary>
        int WorkflowMode { get; set; }
    }
}
