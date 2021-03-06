using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FakeCRM.SDK
{
    [TestClass]
    public abstract class TestBase
    {
        /// <summary>
        /// Gets an instance of <see cref="IOrganizationServiceMock"/> for mocking calls to Dynamics 365
        /// </summary>
        protected OrganizationServiceMock OrganizationServiceMock { get; private set; }

        /// <summary>
        /// Setup basic mocks that are used throughout the test fixture.
        /// </summary>
        [TestInitialize]
        public virtual void Initialize()
        {
            this.OrganizationServiceMock = new OrganizationServiceMock();
        }
    }
}
