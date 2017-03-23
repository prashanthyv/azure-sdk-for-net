// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent
{
    using Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;

    /// <summary>
    /// An immutable client-side representation of an application gateway SSL certificate.
    /// </summary>
    public interface IApplicationGatewaySslCertificate  :
        IHasInner<Models.ApplicationGatewaySslCertificateInner>,
        IChildResource<Microsoft.Azure.Management.Network.Fluent.IApplicationGateway>
    {
        /// <summary>
        /// Gets the public data of the certificate.
        /// </summary>
        string PublicData { get; }
    }
}