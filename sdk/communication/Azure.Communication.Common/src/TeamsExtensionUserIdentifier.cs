// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Runtime.InteropServices;

namespace Azure.Communication
{
    /// <summary>
    /// Represents a Teams extension user identifier.
    /// </summary>
    public class TeamsExtensionUserIdentifier : CommunicationIdentifier
    {
        private string _rawId;

        /// <summary>
        /// Gets the object id of the Teams user.
        /// </summary>
        public string UserId { get; }

        /// <summary>
        /// Gets the resource id of the Teams user.
        /// </summary>
        public string ResourceId { get; }

        /// <summary>
        /// Gets the tenant id of the Teams user.
        /// </summary>
        public string TenantId { get; }

        /// <summary>
        /// Gets the cloud type of the Teams user.
        /// </summary>
        public CommunicationCloudEnvironment Cloud { get; }

        /// <summary>
        /// Returns the canonical string representation of the <see cref="TeamsExtensionUserIdentifier"/>.
        /// You can use the <see cref="RawId"/> for encoding the identifier and then use it as a key in a database.
        /// </summary>
        public override string RawId
        {
            get
            {
                if (_rawId != null)
                    return _rawId;

                if (Cloud == CommunicationCloudEnvironment.Dod)
                {
                    _rawId = $"{TeamsAppDodCloud}{UserId}:{ResourceId}:{TenantId}";
                }
                else if (Cloud == CommunicationCloudEnvironment.Gcch)
                {
                    _rawId = $"{TeamsAppGcchCloud}{UserId}:{ResourceId}:{TenantId}";
                }
                else
                {
                    _rawId = $"{TeamsAppPublicCloud}{UserId}:{ResourceId}:{TenantId}";
                }

                return _rawId;
            }
        }
    }
}
