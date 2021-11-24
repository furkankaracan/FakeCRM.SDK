using Microsoft.Xrm.Sdk;

namespace FakeCRM.SDK
{
    public class PluginExecutionContextMock : ExecutionContextMock<IPluginExecutionContext>, IPluginExecutionContextMock
    {
        private IPluginExecutionContext parentContext;
        private int stage;

        public PluginExecutionContextMock()
           : base()
        {
        }

        public IPluginExecutionContext ParentContext
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

        public int Stage
        {
            get
            {
                return this.stage;
            }

            set
            {
                this.stage = value;
                this.SetupGet(context => context.Stage).Returns(value);
            }
        }
    }
}
