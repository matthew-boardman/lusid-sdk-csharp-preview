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
    /// CreateRelationshipRequest
    /// </summary>
    [DataContract(Name = "CreateRelationshipRequest")]
    public partial class CreateRelationshipRequest : IEquatable<CreateRelationshipRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRelationshipRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateRelationshipRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRelationshipRequest" /> class.
        /// </summary>
        /// <param name="sourceEntityId">The identifier of the source entity. (required).</param>
        /// <param name="targetEntityId">The identifier of the target entity. (required).</param>
        /// <param name="effectiveFrom">The effective date of the relationship to be created.</param>
        public CreateRelationshipRequest(Dictionary<string, string> sourceEntityId = default(Dictionary<string, string>), Dictionary<string, string> targetEntityId = default(Dictionary<string, string>), DateTimeOrCutLabel effectiveFrom = default(DateTimeOrCutLabel))
        {
            // to ensure "sourceEntityId" is required (not null)
            this.SourceEntityId = sourceEntityId ?? throw new ArgumentNullException("sourceEntityId is a required property for CreateRelationshipRequest and cannot be null");
            // to ensure "targetEntityId" is required (not null)
            this.TargetEntityId = targetEntityId ?? throw new ArgumentNullException("targetEntityId is a required property for CreateRelationshipRequest and cannot be null");
            this.EffectiveFrom = effectiveFrom;
        }

        /// <summary>
        /// The identifier of the source entity.
        /// </summary>
        /// <value>The identifier of the source entity.</value>
        [DataMember(Name = "sourceEntityId", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> SourceEntityId { get; set; }

        /// <summary>
        /// The identifier of the target entity.
        /// </summary>
        /// <value>The identifier of the target entity.</value>
        [DataMember(Name = "targetEntityId", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> TargetEntityId { get; set; }

        /// <summary>
        /// The effective date of the relationship to be created
        /// </summary>
        /// <value>The effective date of the relationship to be created</value>
        [DataMember(Name = "effectiveFrom", EmitDefaultValue = true)]
        public DateTimeOrCutLabel EffectiveFrom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRelationshipRequest {\n");
            sb.Append("  SourceEntityId: ").Append(SourceEntityId).Append("\n");
            sb.Append("  TargetEntityId: ").Append(TargetEntityId).Append("\n");
            sb.Append("  EffectiveFrom: ").Append(EffectiveFrom).Append("\n");
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
            return this.Equals(input as CreateRelationshipRequest);
        }

        /// <summary>
        /// Returns true if CreateRelationshipRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateRelationshipRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateRelationshipRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceEntityId == input.SourceEntityId ||
                    this.SourceEntityId != null &&
                    input.SourceEntityId != null &&
                    this.SourceEntityId.SequenceEqual(input.SourceEntityId)
                ) && 
                (
                    this.TargetEntityId == input.TargetEntityId ||
                    this.TargetEntityId != null &&
                    input.TargetEntityId != null &&
                    this.TargetEntityId.SequenceEqual(input.TargetEntityId)
                ) && 
                (
                    this.EffectiveFrom == input.EffectiveFrom ||
                    (this.EffectiveFrom != null &&
                    this.EffectiveFrom.Equals(input.EffectiveFrom))
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
                if (this.SourceEntityId != null)
                    hashCode = hashCode * 59 + this.SourceEntityId.GetHashCode();
                if (this.TargetEntityId != null)
                    hashCode = hashCode * 59 + this.TargetEntityId.GetHashCode();
                if (this.EffectiveFrom != null)
                    hashCode = hashCode * 59 + this.EffectiveFrom.GetHashCode();
                return hashCode;
            }
        }

    }
}
