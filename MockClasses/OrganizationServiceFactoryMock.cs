using System;
using Microsoft.Xrm.Sdk;
using Moq;

namespace FakeCRM.SDK
{
    public class OrganizationServiceFactoryMock : Mock<IOrganizationServiceFactory>, IOrganizationServiceFactoryMock
    {
        private readonly IOrganizationServiceMock organizationServiceMock;

        /// <summary>
        /// Initialises a new instance of the <see cref="OrganizationServiceFactoryMock"/> class
        /// </summary>
        /// <param name="organizationServiceMock">An instance of <see cref="IOrganizationServiceMock"/> for mocking calls to Dynamics 365</param>
        public OrganizationServiceFactoryMock(IOrganizationServiceMock organizationServiceMock)
            : base()
        {
            this.organizationServiceMock = organizationServiceMock;

            this.Setup(factory => factory.CreateOrganizationService(It.IsAny<Guid>())).Returns(this.organizationServiceMock.Object);
        }
    }
}
