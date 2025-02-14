// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Result of AmlCompute Nodes</summary>
    public partial class AmlComputeNodesInformation :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAmlComputeNodesInformation,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAmlComputeNodesInformationInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAmlComputeNodesInformationInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Internal Acessors for Node</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAmlComputeNodeInformation[] Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAmlComputeNodesInformationInternal.Node { get => this._node; set { {_node = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The continuation token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Node" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAmlComputeNodeInformation[] _node;

        /// <summary>The collection of returned AmlCompute nodes details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAmlComputeNodeInformation[] Node { get => this._node; }

        /// <summary>Creates an new <see cref="AmlComputeNodesInformation" /> instance.</summary>
        public AmlComputeNodesInformation()
        {

        }
    }
    /// Result of AmlCompute Nodes
    public partial interface IAmlComputeNodesInformation :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>The continuation token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The continuation token.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>The collection of returned AmlCompute nodes details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The collection of returned AmlCompute nodes details.",
        SerializedName = @"nodes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAmlComputeNodeInformation) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAmlComputeNodeInformation[] Node { get;  }

    }
    /// Result of AmlCompute Nodes
    internal partial interface IAmlComputeNodesInformationInternal

    {
        /// <summary>The continuation token.</summary>
        string NextLink { get; set; }
        /// <summary>The collection of returned AmlCompute nodes details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAmlComputeNodeInformation[] Node { get; set; }

    }
}