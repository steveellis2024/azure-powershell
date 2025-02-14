// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Extensions;

    /// <summary>Result of the List private link resources operation.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.DoNotFormat]
    public partial class PrivateLinkResourcesListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IPrivateLinkResourcesListResult,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IPrivateLinkResourcesListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>A link for the next page of private link resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IPrivateLinkResource> _value;

        /// <summary>A collection of private link resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IPrivateLinkResource> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PrivateLinkResourcesListResult" /> instance.</summary>
        public PrivateLinkResourcesListResult()
        {

        }
    }
    /// Result of the List private link resources operation.
    public partial interface IPrivateLinkResourcesListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.IJsonSerializable
    {
        /// <summary>A link for the next page of private link resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A link for the next page of private link resources.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>A collection of private link resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A collection of private link resources",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IPrivateLinkResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IPrivateLinkResource> Value { get; set; }

    }
    /// Result of the List private link resources operation.
    internal partial interface IPrivateLinkResourcesListResultInternal

    {
        /// <summary>A link for the next page of private link resources.</summary>
        string NextLink { get; set; }
        /// <summary>A collection of private link resources</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceBus.Models.IPrivateLinkResource> Value { get; set; }

    }
}