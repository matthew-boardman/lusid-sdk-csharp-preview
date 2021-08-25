/* 
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3429
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// The time an entity was modified (amendment and/or historical correction).
    /// </summary>
    [DataContract]
    public partial class Change :  IEquatable<Change>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Change" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Change() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Change" /> class.
        /// </summary>
        /// <param name="href">href.</param>
        /// <param name="entityId">entityId (required).</param>
        /// <param name="corrected">corrected (required).</param>
        /// <param name="correctionEffectiveAt">correctionEffectiveAt.</param>
        /// <param name="correctionAsAt">correctionAsAt.</param>
        /// <param name="amended">amended (required).</param>
        /// <param name="amendmentEffectiveAt">amendmentEffectiveAt.</param>
        /// <param name="amendmentAsAt">amendmentAsAt.</param>
        /// <param name="links">Collection of links..</param>
        public Change(string href = default(string), ResourceId entityId = default(ResourceId), bool? corrected = default(bool?), DateTimeOffset? correctionEffectiveAt = default(DateTimeOffset?), DateTimeOffset? correctionAsAt = default(DateTimeOffset?), bool? amended = default(bool?), DateTimeOffset? amendmentEffectiveAt = default(DateTimeOffset?), DateTimeOffset? amendmentAsAt = default(DateTimeOffset?), List<Link> links = default(List<Link>))
        {
            this.Href = href;
            // to ensure "entityId" is required (not null)
            if (entityId == null)
            {
                throw new InvalidDataException("entityId is a required property for Change and cannot be null");
            }
            else
            {
                this.EntityId = entityId;
            }
            
            // to ensure "corrected" is required (not null)
            if (corrected == null)
            {
                throw new InvalidDataException("corrected is a required property for Change and cannot be null");
            }
            else
            {
                this.Corrected = corrected;
            }
            
            this.CorrectionEffectiveAt = correctionEffectiveAt;
            this.CorrectionAsAt = correctionAsAt;
            // to ensure "amended" is required (not null)
            if (amended == null)
            {
                throw new InvalidDataException("amended is a required property for Change and cannot be null");
            }
            else
            {
                this.Amended = amended;
            }
            
            this.AmendmentEffectiveAt = amendmentEffectiveAt;
            this.AmendmentAsAt = amendmentAsAt;
            this.Links = links;
            this.Href = href;
            this.CorrectionEffectiveAt = correctionEffectiveAt;
            this.CorrectionAsAt = correctionAsAt;
            this.AmendmentEffectiveAt = amendmentEffectiveAt;
            this.AmendmentAsAt = amendmentAsAt;
            this.Links = links;
        }
        
        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=true)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets EntityId
        /// </summary>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public ResourceId EntityId { get; set; }

        /// <summary>
        /// Gets or Sets Corrected
        /// </summary>
        [DataMember(Name="corrected", EmitDefaultValue=false)]
        public bool? Corrected { get; set; }

        /// <summary>
        /// Gets or Sets CorrectionEffectiveAt
        /// </summary>
        [DataMember(Name="correctionEffectiveAt", EmitDefaultValue=true)]
        public DateTimeOffset? CorrectionEffectiveAt { get; set; }

        /// <summary>
        /// Gets or Sets CorrectionAsAt
        /// </summary>
        [DataMember(Name="correctionAsAt", EmitDefaultValue=true)]
        public DateTimeOffset? CorrectionAsAt { get; set; }

        /// <summary>
        /// Gets or Sets Amended
        /// </summary>
        [DataMember(Name="amended", EmitDefaultValue=false)]
        public bool? Amended { get; set; }

        /// <summary>
        /// Gets or Sets AmendmentEffectiveAt
        /// </summary>
        [DataMember(Name="amendmentEffectiveAt", EmitDefaultValue=true)]
        public DateTimeOffset? AmendmentEffectiveAt { get; set; }

        /// <summary>
        /// Gets or Sets AmendmentAsAt
        /// </summary>
        [DataMember(Name="amendmentAsAt", EmitDefaultValue=true)]
        public DateTimeOffset? AmendmentAsAt { get; set; }

        /// <summary>
        /// Collection of links.
        /// </summary>
        /// <value>Collection of links.</value>
        [DataMember(Name="links", EmitDefaultValue=true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Change {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  Corrected: ").Append(Corrected).Append("\n");
            sb.Append("  CorrectionEffectiveAt: ").Append(CorrectionEffectiveAt).Append("\n");
            sb.Append("  CorrectionAsAt: ").Append(CorrectionAsAt).Append("\n");
            sb.Append("  Amended: ").Append(Amended).Append("\n");
            sb.Append("  AmendmentEffectiveAt: ").Append(AmendmentEffectiveAt).Append("\n");
            sb.Append("  AmendmentAsAt: ").Append(AmendmentAsAt).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Change);
        }

        /// <summary>
        /// Returns true if Change instances are equal
        /// </summary>
        /// <param name="input">Instance of Change to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Change input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.Corrected == input.Corrected ||
                    (this.Corrected != null &&
                    this.Corrected.Equals(input.Corrected))
                ) && 
                (
                    this.CorrectionEffectiveAt == input.CorrectionEffectiveAt ||
                    (this.CorrectionEffectiveAt != null &&
                    this.CorrectionEffectiveAt.Equals(input.CorrectionEffectiveAt))
                ) && 
                (
                    this.CorrectionAsAt == input.CorrectionAsAt ||
                    (this.CorrectionAsAt != null &&
                    this.CorrectionAsAt.Equals(input.CorrectionAsAt))
                ) && 
                (
                    this.Amended == input.Amended ||
                    (this.Amended != null &&
                    this.Amended.Equals(input.Amended))
                ) && 
                (
                    this.AmendmentEffectiveAt == input.AmendmentEffectiveAt ||
                    (this.AmendmentEffectiveAt != null &&
                    this.AmendmentEffectiveAt.Equals(input.AmendmentEffectiveAt))
                ) && 
                (
                    this.AmendmentAsAt == input.AmendmentAsAt ||
                    (this.AmendmentAsAt != null &&
                    this.AmendmentAsAt.Equals(input.AmendmentAsAt))
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
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.Corrected != null)
                    hashCode = hashCode * 59 + this.Corrected.GetHashCode();
                if (this.CorrectionEffectiveAt != null)
                    hashCode = hashCode * 59 + this.CorrectionEffectiveAt.GetHashCode();
                if (this.CorrectionAsAt != null)
                    hashCode = hashCode * 59 + this.CorrectionAsAt.GetHashCode();
                if (this.Amended != null)
                    hashCode = hashCode * 59 + this.Amended.GetHashCode();
                if (this.AmendmentEffectiveAt != null)
                    hashCode = hashCode * 59 + this.AmendmentEffectiveAt.GetHashCode();
                if (this.AmendmentAsAt != null)
                    hashCode = hashCode * 59 + this.AmendmentAsAt.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }

}
