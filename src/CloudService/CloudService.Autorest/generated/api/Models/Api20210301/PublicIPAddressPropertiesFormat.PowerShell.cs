// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301
{
    using Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.PowerShell;

    /// <summary>Public IP address properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(PublicIPAddressPropertiesFormatTypeConverter))]
    public partial class PublicIPAddressPropertiesFormat
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.PublicIPAddressPropertiesFormat"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormat"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormat DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PublicIPAddressPropertiesFormat(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.PublicIPAddressPropertiesFormat"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormat"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormat DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PublicIPAddressPropertiesFormat(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PublicIPAddressPropertiesFormat" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="PublicIPAddressPropertiesFormat" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormat FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.PublicIPAddressPropertiesFormat"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PublicIPAddressPropertiesFormat(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("PublicIPAllocationMethod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).PublicIPAllocationMethod = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPAllocationMethod?) content.GetValueForProperty("PublicIPAllocationMethod",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).PublicIPAllocationMethod, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPAllocationMethod.CreateFrom);
            }
            if (content.Contains("PublicIPAddressVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).PublicIPAddressVersion = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPVersion?) content.GetValueForProperty("PublicIPAddressVersion",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).PublicIPAddressVersion, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPVersion.CreateFrom);
            }
            if (content.Contains("IPConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).IPConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IIPConfiguration) content.GetValueForProperty("IPConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).IPConfiguration, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DnsSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).DnsSetting = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressDnsSettings) content.GetValueForProperty("DnsSetting",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).DnsSetting, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.PublicIPAddressDnsSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("DdosSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).DdosSetting = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IDdosSettings) content.GetValueForProperty("DdosSetting",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).DdosSetting, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.DdosSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IPTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).IPTag = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IIPTag[]) content.GetValueForProperty("IPTag",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).IPTag, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IIPTag>(__y, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPTagTypeConverter.ConvertFrom));
            }
            if (content.Contains("IPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).IPAddress = (string) content.GetValueForProperty("IPAddress",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).IPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("PublicIPPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).PublicIPPrefix = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated) content.GetValueForProperty("PublicIPPrefix",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).PublicIPPrefix, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.SubResourceAutoGeneratedTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdleTimeoutInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).IdleTimeoutInMinute = (int?) content.GetValueForProperty("IdleTimeoutInMinute",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).IdleTimeoutInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ResourceGuid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).ResourceGuid = (string) content.GetValueForProperty("ResourceGuid",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).ResourceGuid, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("ServicePublicIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).ServicePublicIPAddress = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddress) content.GetValueForProperty("ServicePublicIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).ServicePublicIPAddress, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.PublicIPAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("NatGateway"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).NatGateway = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INatGateway) content.GetValueForProperty("NatGateway",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).NatGateway, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.NatGatewayTypeConverter.ConvertFrom);
            }
            if (content.Contains("MigrationPhase"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).MigrationPhase = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.PublicIPAddressMigrationPhase?) content.GetValueForProperty("MigrationPhase",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).MigrationPhase, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.PublicIPAddressMigrationPhase.CreateFrom);
            }
            if (content.Contains("LinkedPublicIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).LinkedPublicIPAddress = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddress) content.GetValueForProperty("LinkedPublicIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).LinkedPublicIPAddress, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.PublicIPAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeleteOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).DeleteOption = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.DeleteOptions?) content.GetValueForProperty("DeleteOption",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).DeleteOption, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.DeleteOptions.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.PublicIPAddressPropertiesFormat"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PublicIPAddressPropertiesFormat(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("PublicIPAllocationMethod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).PublicIPAllocationMethod = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPAllocationMethod?) content.GetValueForProperty("PublicIPAllocationMethod",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).PublicIPAllocationMethod, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPAllocationMethod.CreateFrom);
            }
            if (content.Contains("PublicIPAddressVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).PublicIPAddressVersion = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPVersion?) content.GetValueForProperty("PublicIPAddressVersion",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).PublicIPAddressVersion, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.IPVersion.CreateFrom);
            }
            if (content.Contains("IPConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).IPConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IIPConfiguration) content.GetValueForProperty("IPConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).IPConfiguration, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DnsSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).DnsSetting = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressDnsSettings) content.GetValueForProperty("DnsSetting",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).DnsSetting, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.PublicIPAddressDnsSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("DdosSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).DdosSetting = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IDdosSettings) content.GetValueForProperty("DdosSetting",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).DdosSetting, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.DdosSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IPTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).IPTag = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IIPTag[]) content.GetValueForProperty("IPTag",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).IPTag, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IIPTag>(__y, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPTagTypeConverter.ConvertFrom));
            }
            if (content.Contains("IPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).IPAddress = (string) content.GetValueForProperty("IPAddress",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).IPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("PublicIPPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).PublicIPPrefix = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.ISubResourceAutoGenerated) content.GetValueForProperty("PublicIPPrefix",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).PublicIPPrefix, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.SubResourceAutoGeneratedTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdleTimeoutInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).IdleTimeoutInMinute = (int?) content.GetValueForProperty("IdleTimeoutInMinute",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).IdleTimeoutInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ResourceGuid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).ResourceGuid = (string) content.GetValueForProperty("ResourceGuid",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).ResourceGuid, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("ServicePublicIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).ServicePublicIPAddress = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddress) content.GetValueForProperty("ServicePublicIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).ServicePublicIPAddress, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.PublicIPAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("NatGateway"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).NatGateway = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.INatGateway) content.GetValueForProperty("NatGateway",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).NatGateway, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.NatGatewayTypeConverter.ConvertFrom);
            }
            if (content.Contains("MigrationPhase"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).MigrationPhase = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.PublicIPAddressMigrationPhase?) content.GetValueForProperty("MigrationPhase",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).MigrationPhase, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.PublicIPAddressMigrationPhase.CreateFrom);
            }
            if (content.Contains("LinkedPublicIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).LinkedPublicIPAddress = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddress) content.GetValueForProperty("LinkedPublicIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).LinkedPublicIPAddress, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.PublicIPAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeleteOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).DeleteOption = (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.DeleteOptions?) content.GetValueForProperty("DeleteOption",((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20210301.IPublicIPAddressPropertiesFormatInternal)this).DeleteOption, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.DeleteOptions.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Public IP address properties.
    [System.ComponentModel.TypeConverter(typeof(PublicIPAddressPropertiesFormatTypeConverter))]
    public partial interface IPublicIPAddressPropertiesFormat

    {

    }
}