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
    /// RelationshipDefinition
    /// </summary>
    [DataContract]
    public partial class RelationshipDefinition :  IEquatable<RelationshipDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelationshipDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RelationshipDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RelationshipDefinition" /> class.
        /// </summary>
        /// <param name="version">version.</param>
        /// <param name="relationshipDefinitionId">relationshipDefinitionId (required).</param>
        /// <param name="sourceEntityType">The entity type of the source entity object. (required).</param>
        /// <param name="targetEntityType">The entity type of the target entity object. (required).</param>
        /// <param name="displayName">The display name of the relationship. (required).</param>
        /// <param name="outwardDescription">The description to relate source entity object and target entity object (required).</param>
        /// <param name="inwardDescription">The description to relate target entity object and source entity object (required).</param>
        /// <param name="lifeTime">Describes how the relationships can change over time. (required).</param>
        /// <param name="relationshipCardinality">Describes the cardinality of the relationship between source entity and target entity. (required).</param>
        /// <param name="links">Collection of links..</param>
        public RelationshipDefinition(Version version = default(Version), ResourceId relationshipDefinitionId = default(ResourceId), string sourceEntityType = default(string), string targetEntityType = default(string), string displayName = default(string), string outwardDescription = default(string), string inwardDescription = default(string), string lifeTime = default(string), string relationshipCardinality = default(string), List<Link> links = default(List<Link>))
        {
            // to ensure "relationshipDefinitionId" is required (not null)
            if (relationshipDefinitionId == null)
            {
                throw new InvalidDataException("relationshipDefinitionId is a required property for RelationshipDefinition and cannot be null");
            }
            else
            {
                this.RelationshipDefinitionId = relationshipDefinitionId;
            }
            
            // to ensure "sourceEntityType" is required (not null)
            if (sourceEntityType == null)
            {
                throw new InvalidDataException("sourceEntityType is a required property for RelationshipDefinition and cannot be null");
            }
            else
            {
                this.SourceEntityType = sourceEntityType;
            }
            
            // to ensure "targetEntityType" is required (not null)
            if (targetEntityType == null)
            {
                throw new InvalidDataException("targetEntityType is a required property for RelationshipDefinition and cannot be null");
            }
            else
            {
                this.TargetEntityType = targetEntityType;
            }
            
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for RelationshipDefinition and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }
            
            // to ensure "outwardDescription" is required (not null)
            if (outwardDescription == null)
            {
                throw new InvalidDataException("outwardDescription is a required property for RelationshipDefinition and cannot be null");
            }
            else
            {
                this.OutwardDescription = outwardDescription;
            }
            
            // to ensure "inwardDescription" is required (not null)
            if (inwardDescription == null)
            {
                throw new InvalidDataException("inwardDescription is a required property for RelationshipDefinition and cannot be null");
            }
            else
            {
                this.InwardDescription = inwardDescription;
            }
            
            // to ensure "lifeTime" is required (not null)
            if (lifeTime == null)
            {
                throw new InvalidDataException("lifeTime is a required property for RelationshipDefinition and cannot be null");
            }
            else
            {
                this.LifeTime = lifeTime;
            }
            
            // to ensure "relationshipCardinality" is required (not null)
            if (relationshipCardinality == null)
            {
                throw new InvalidDataException("relationshipCardinality is a required property for RelationshipDefinition and cannot be null");
            }
            else
            {
                this.RelationshipCardinality = relationshipCardinality;
            }
            
            this.Links = links;
            this.Version = version;
            this.Links = links;
        }
        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public Version Version { get; set; }

        /// <summary>
        /// Gets or Sets RelationshipDefinitionId
        /// </summary>
        [DataMember(Name="relationshipDefinitionId", EmitDefaultValue=false)]
        public ResourceId RelationshipDefinitionId { get; set; }

        /// <summary>
        /// The entity type of the source entity object.
        /// </summary>
        /// <value>The entity type of the source entity object.</value>
        [DataMember(Name="sourceEntityType", EmitDefaultValue=false)]
        public string SourceEntityType { get; set; }

        /// <summary>
        /// The entity type of the target entity object.
        /// </summary>
        /// <value>The entity type of the target entity object.</value>
        [DataMember(Name="targetEntityType", EmitDefaultValue=false)]
        public string TargetEntityType { get; set; }

        /// <summary>
        /// The display name of the relationship.
        /// </summary>
        /// <value>The display name of the relationship.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The description to relate source entity object and target entity object
        /// </summary>
        /// <value>The description to relate source entity object and target entity object</value>
        [DataMember(Name="outwardDescription", EmitDefaultValue=false)]
        public string OutwardDescription { get; set; }

        /// <summary>
        /// The description to relate target entity object and source entity object
        /// </summary>
        /// <value>The description to relate target entity object and source entity object</value>
        [DataMember(Name="inwardDescription", EmitDefaultValue=false)]
        public string InwardDescription { get; set; }

        /// <summary>
        /// Describes how the relationships can change over time.
        /// </summary>
        /// <value>Describes how the relationships can change over time.</value>
        [DataMember(Name="lifeTime", EmitDefaultValue=false)]
        public string LifeTime { get; set; }

        /// <summary>
        /// Describes the cardinality of the relationship between source entity and target entity.
        /// </summary>
        /// <value>Describes the cardinality of the relationship between source entity and target entity.</value>
        [DataMember(Name="relationshipCardinality", EmitDefaultValue=false)]
        public string RelationshipCardinality { get; set; }

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
            sb.Append("class RelationshipDefinition {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  RelationshipDefinitionId: ").Append(RelationshipDefinitionId).Append("\n");
            sb.Append("  SourceEntityType: ").Append(SourceEntityType).Append("\n");
            sb.Append("  TargetEntityType: ").Append(TargetEntityType).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  OutwardDescription: ").Append(OutwardDescription).Append("\n");
            sb.Append("  InwardDescription: ").Append(InwardDescription).Append("\n");
            sb.Append("  LifeTime: ").Append(LifeTime).Append("\n");
            sb.Append("  RelationshipCardinality: ").Append(RelationshipCardinality).Append("\n");
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
            return this.Equals(input as RelationshipDefinition);
        }

        /// <summary>
        /// Returns true if RelationshipDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of RelationshipDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelationshipDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.RelationshipDefinitionId == input.RelationshipDefinitionId ||
                    (this.RelationshipDefinitionId != null &&
                    this.RelationshipDefinitionId.Equals(input.RelationshipDefinitionId))
                ) && 
                (
                    this.SourceEntityType == input.SourceEntityType ||
                    (this.SourceEntityType != null &&
                    this.SourceEntityType.Equals(input.SourceEntityType))
                ) && 
                (
                    this.TargetEntityType == input.TargetEntityType ||
                    (this.TargetEntityType != null &&
                    this.TargetEntityType.Equals(input.TargetEntityType))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.OutwardDescription == input.OutwardDescription ||
                    (this.OutwardDescription != null &&
                    this.OutwardDescription.Equals(input.OutwardDescription))
                ) && 
                (
                    this.InwardDescription == input.InwardDescription ||
                    (this.InwardDescription != null &&
                    this.InwardDescription.Equals(input.InwardDescription))
                ) && 
                (
                    this.LifeTime == input.LifeTime ||
                    (this.LifeTime != null &&
                    this.LifeTime.Equals(input.LifeTime))
                ) && 
                (
                    this.RelationshipCardinality == input.RelationshipCardinality ||
                    (this.RelationshipCardinality != null &&
                    this.RelationshipCardinality.Equals(input.RelationshipCardinality))
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.RelationshipDefinitionId != null)
                    hashCode = hashCode * 59 + this.RelationshipDefinitionId.GetHashCode();
                if (this.SourceEntityType != null)
                    hashCode = hashCode * 59 + this.SourceEntityType.GetHashCode();
                if (this.TargetEntityType != null)
                    hashCode = hashCode * 59 + this.TargetEntityType.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.OutwardDescription != null)
                    hashCode = hashCode * 59 + this.OutwardDescription.GetHashCode();
                if (this.InwardDescription != null)
                    hashCode = hashCode * 59 + this.InwardDescription.GetHashCode();
                if (this.LifeTime != null)
                    hashCode = hashCode * 59 + this.LifeTime.GetHashCode();
                if (this.RelationshipCardinality != null)
                    hashCode = hashCode * 59 + this.RelationshipCardinality.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }

}
