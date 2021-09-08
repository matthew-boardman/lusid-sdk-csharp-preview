/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3467
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// A structure used to describe the structure of an order or orders that make up a non-trivial trade.
    /// </summary>
    [DataContract(Name = "Package")]
    public partial class Package : IEquatable<Package>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Package" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Package() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Package" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="orderIds">A related order ids. (required).</param>
        /// <param name="orderInstructionIds">A related order instruction id. (required).</param>
        /// <param name="properties">Client-defined properties associated with this execution..</param>
        /// <param name="version">version.</param>
        /// <param name="links">Collection of links..</param>
        public Package(ResourceId id = default(ResourceId), List<ResourceId> orderIds = default(List<ResourceId>), List<ResourceId> orderInstructionIds = default(List<ResourceId>), Dictionary<string, PerpetualProperty> properties = default(Dictionary<string, PerpetualProperty>), Version version = default(Version), List<Link> links = default(List<Link>))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for Package and cannot be null");
            // to ensure "orderIds" is required (not null)
            this.OrderIds = orderIds ?? throw new ArgumentNullException("orderIds is a required property for Package and cannot be null");
            // to ensure "orderInstructionIds" is required (not null)
            this.OrderInstructionIds = orderInstructionIds ?? throw new ArgumentNullException("orderInstructionIds is a required property for Package and cannot be null");
            this.Properties = properties;
            this.Version = version;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// A related order ids.
        /// </summary>
        /// <value>A related order ids.</value>
        [DataMember(Name = "orderIds", IsRequired = true, EmitDefaultValue = false)]
        public List<ResourceId> OrderIds { get; set; }

        /// <summary>
        /// A related order instruction id.
        /// </summary>
        /// <value>A related order instruction id.</value>
        [DataMember(Name = "orderInstructionIds", IsRequired = true, EmitDefaultValue = false)]
        public List<ResourceId> OrderInstructionIds { get; set; }

        /// <summary>
        /// Client-defined properties associated with this execution.
        /// </summary>
        /// <value>Client-defined properties associated with this execution.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, PerpetualProperty> Properties { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public Version Version { get; set; }

        /// <summary>
        /// Collection of links.
        /// </summary>
        /// <value>Collection of links.</value>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Package {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrderIds: ").Append(OrderIds).Append("\n");
            sb.Append("  OrderInstructionIds: ").Append(OrderInstructionIds).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Package);
        }

        /// <summary>
        /// Returns true if Package instances are equal
        /// </summary>
        /// <param name="input">Instance of Package to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Package input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OrderIds == input.OrderIds ||
                    this.OrderIds != null &&
                    input.OrderIds != null &&
                    this.OrderIds.SequenceEqual(input.OrderIds)
                ) && 
                (
                    this.OrderInstructionIds == input.OrderInstructionIds ||
                    this.OrderInstructionIds != null &&
                    input.OrderInstructionIds != null &&
                    this.OrderInstructionIds.SequenceEqual(input.OrderInstructionIds)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OrderIds != null)
                    hashCode = hashCode * 59 + this.OrderIds.GetHashCode();
                if (this.OrderInstructionIds != null)
                    hashCode = hashCode * 59 + this.OrderInstructionIds.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
