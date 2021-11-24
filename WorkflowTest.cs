using System.Activities;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FakeCRM.SDK
{
    [TestClass]
    public abstract class WorkflowTest<TWorkflow> : TestBase
        where TWorkflow : CodeActivity, new()
    {
        /// <summary>
        /// Gets an <see cref="IDictionary{String, Object}"/> of arguments to be passed into the workflow
        /// </summary>
        protected IDictionary<string, object> InputArguments { get; private set; }

        /// <summary>
        /// Gets the workflow under test
        /// </summary>
        protected TWorkflow Workflow { get; private set; }

        /// <summary>
        /// Gets an instance of <see cref="IWorkflowContextMock"/> for stubbing out the workflow context
        /// </summary>
        protected IWorkflowContextMock WorkflowContextMock { get; private set; }

        /// <summary>
        /// Gets an instance of <see cref="ITracingServiceMock"/> for verifying calls to the tracing service
        /// </summary>
        protected ITracingServiceMock TracingServiceMock { get; private set; }

        /// <summary>
        /// Creates an instance of the specified workflow class and fires its Execute method
        /// </summary>
        /// <returns>An <see cref="IDictionary{String, Object}"/> of output arguments</returns>
        public IDictionary<string, object> ExecuteWorkflow()
        {
            var workflowInvoker = new WorkflowInvoker(this.Workflow);
            var organizationServiceFactory = new OrganizationServiceFactoryMock(this.OrganizationServiceMock);

            workflowInvoker.Extensions.Add(organizationServiceFactory.Object);
            workflowInvoker.Extensions.Add(this.WorkflowContextMock.Object);
            workflowInvoker.Extensions.Add(this.TracingServiceMock.Object);

            return workflowInvoker.Invoke(this.InputArguments);
        }

        [TestInitialize]
        public override void Initialize()
        {
            base.Initialize();

            this.WorkflowContextMock = new WorkflowContextMock();
            this.TracingServiceMock = new TracingServiceMock();
            this.InputArguments = new Dictionary<string, object>();

            // Create an instance of the workflow class under test
            this.Workflow = new TWorkflow();
        }
    }
}
