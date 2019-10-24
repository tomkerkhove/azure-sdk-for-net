// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for Mount operation.
    /// </summary>
    public partial class BlobMountHeaders
    {
        /// <summary>
        /// Initializes a new instance of the BlobMountHeaders class.
        /// </summary>
        public BlobMountHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlobMountHeaders class.
        /// </summary>
        /// <param name="location">Provided location for blob</param>
        /// <param name="dockerUploadUUID">Identifies the docker upload uuid
        /// for the current request.</param>
        /// <param name="dockerContentDigest">Digest of the targeted content
        /// for the request.</param>
        public BlobMountHeaders(string location = default(string), string dockerUploadUUID = default(string), string dockerContentDigest = default(string))
        {
            Location = location;
            DockerUploadUUID = dockerUploadUUID;
            DockerContentDigest = dockerContentDigest;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets provided location for blob
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets identifies the docker upload uuid for the current
        /// request.
        /// </summary>
        [JsonProperty(PropertyName = "Docker-Upload-UUID")]
        public string DockerUploadUUID { get; set; }

        /// <summary>
        /// Gets or sets digest of the targeted content for the request.
        /// </summary>
        [JsonProperty(PropertyName = "Docker-Content-Digest")]
        public string DockerContentDigest { get; set; }

    }
}