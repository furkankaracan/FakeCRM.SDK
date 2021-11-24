using Microsoft.Xrm.Sdk.Workflow;

namespace FakeCRM.SDK
{
    public class WorkflowContextMock : ExecutionContextMock<IWorkflowContext>, IWorkflowContextMock
    {
        private IWorkflowContext parentContext;
        private string stageName;
        private int workflowCategory;
        private int workflowMode;

        public WorkflowContextMock()
           : base()
        {
        }

        public IWorkflowContext ParentContext
        {
            get
            {
                return this.parentContext;
            }

            set
            {
                this.parentContext = value;
                this.SetupGet(context => context.ParentContext).Returns(value);
            }
        }

        public string StageName
        {
            get
            {
                return this.stageName;
            }

            set
            {
                this.stageName = value;
                this.SetupGet(context => context.StageName).Returns(value);
            }
        }

        public int WorkflowCategory
        {
            get
            {
                return this.workflowCategory;
            }

            set
            {
                this.workflowCategory = value;
                this.SetupGet(context => context.WorkflowCategory).Returns(value);
            }
        }

        public int WorkflowMode
        {
            get
            {
                return this.workflowMode;
            }

            set
            {
                this.workflowMode = value;
                this.SetupGet(context => context.WorkflowMode).Returns(value);
            }
        }
    }
}
