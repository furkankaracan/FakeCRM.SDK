using System;
using Microsoft.Xrm.Sdk;
using Moq;

namespace FakeCRM.SDK
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/api/microsoft.xrm.sdk.ipluginexecutioncontext?view=dynamics-general-ce-9
    /// </summary>
    /// <typeparam name="TContext"></typeparam>
    public interface IExecutionContextMock<TContext> : IMock<TContext>
        where TContext : class, IExecutionContext
    {
        /// <summary>
        /// Gets or sets the GUID of the business unit that the user making the request, also known as the calling user, belongs to.
        /// </summary>
        Guid BusinessUnitId { get; set; }

        /// <summary>
        /// Gets or sets the GUID for tracking plug-in or custom workflow activity execution.
        /// </summary>
        Guid CorrelationId { get; set; }

        /// <summary>
        /// Gets or sets the current depth of execution in the call stack.
        /// </summary>
        int Depth { get; set; }

        /// <summary>
        /// Gets or sets the GUID of the system user account under which the current pipeline is executing.
        /// </summary>
        Guid InitiatingUserId { get; set; }

        /// <summary>
        /// Gets or sets the parameters of the request message that triggered the event that caused the plug-in to execute.
        /// </summary>
        ParameterCollection InputParameters { get; set; }

        /// <summary>
        /// Gets or sets whether the plug-in is executing from the Microsoft Dynamics 365 
        /// for Microsoft Office Outlook with Offline Access client while it is offline.
        /// </summary>
        bool IsExecutingOffline { get; set; }

        /// <summary>
        /// Gets or sets a value indicating if the plug-in is executing within the database transaction.
        /// </summary>
        bool IsInTransaction { get; set; }

        /// <summary>
        /// Gets or sets a value indicating if the plug-in is executing as a result of the Microsoft Dynamics 365
        /// for Microsoft Office Outlook with Offline Access client transitioning from offline to online 
        /// and synchronizing with the Microsoft Dynamics 365 server.
        /// </summary>
        bool IsOfflinePlayback { get; set; }

        /// <summary>
        /// Gets or sets a value indicating if the plug-in is executing in the sandbox.
        /// </summary>
        int IsolationMode { get; set; }

        /// <summary>
        /// Gets or sets the name of the Web service message that is being processed by the event execution pipeline.
        /// </summary>
        string MessageName { get; set; }

        /// <summary>
        /// Gets or sets the mode of plug-in execution.
        /// </summary>
        int Mode { get; set; }

        /// <summary>
        /// Gets or sets the date and time that the related System Job was created.
        /// </summary>
        DateTime OperationCreatedOn { get; set; }

        /// <summary>
        /// Gets or sets the GUID of the related System Job.
        /// </summary>
        Guid OperationId { get; set; }

        /// <summary>
        /// Gets or sets the GUID of the organization that the entity belongs to and the plug-in executes under.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the unique name of the organization that the entity currently being processed belongs to and the plug-in executes under.
        /// </summary>
        string OrganizationName { get; set; }

        /// <summary>
        /// Gets or sets the parameters of the response message after the core platform operation has completed.
        /// </summary>
        ParameterCollection OutputParameters { get; set; }

        /// <summary>
        /// Gets or sets a reference to the related SdkMessageProcessingingStep or ServiceEndpoint.
        /// </summary>
        EntityReference OwningExtension { get; set; }

        /// <summary>
        /// Gets or sets a collection of Post-images for the context being mocked
        /// </summary>
        EntityImageCollection PostEntityImages { get; set; }

        /// <summary>
        /// Gets or sets a collection of Pre-images for the context being mocked
        /// </summary>
        EntityImageCollection PreEntityImages { get; set; }

        /// <summary>
        /// Gets or sets the id of the entity invoking the context being mocked
        /// </summary>
        Guid PrimaryEntityId { get; set; }

        /// <summary>
        /// Gets or sets the primary logical name of the entity invoking the context being mocked
        /// </summary>
        string PrimaryEntityName { get; set; }

        /// <summary>
        /// Gets or sets the request id of the context being mocked
        /// </summary>
        Guid? RequestId { get; set; }

        /// <summary>
        /// Gets or sets the secondary logical name of the entity invoking the context being mocked
        /// </summary>
        string SecondaryEntityName { get; set; }

        /// <summary>
        /// Gets or sets a collection of shared variables for the context being mocked
        /// </summary>
        ParameterCollection SharedVariables { get; set; }

        /// <summary>
        /// Gets or sets the id of the User as whom the mocked context is being executed
        /// </summary>
        Guid UserId { get; set; }

        /// <summary>
        /// Add an image to the PreEntityImages collection
        /// </summary>
        /// <param name="imageName">The alias of the image being added</param>
        /// <param name="image">The image being added</param>
        void AddPreImage(string imageName, Entity image);

        /// <summary>
        /// Add an image to the PostEntityImages collection
        /// </summary>
        /// <param name="imageName">The alias of the image being added</param>
        /// <param name="image">The image being added</param>
        void AddPostImage(string imageName, Entity image);
    }
}
