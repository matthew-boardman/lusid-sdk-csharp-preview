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
    /// CalendarDate
    /// </summary>
    [DataContract]
    public partial class CalendarDate :  IEquatable<CalendarDate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarDate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CalendarDate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarDate" /> class.
        /// </summary>
        /// <param name="href">href.</param>
        /// <param name="dateIdentifier">dateIdentifier (required).</param>
        /// <param name="fromUtc">fromUtc (required).</param>
        /// <param name="toUtc">toUtc (required).</param>
        /// <param name="localDate">localDate (required).</param>
        /// <param name="timezone">timezone (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="sourceData">sourceData.</param>
        public CalendarDate(string href = default(string), string dateIdentifier = default(string), DateTimeOffset? fromUtc = default(DateTimeOffset?), DateTimeOffset? toUtc = default(DateTimeOffset?), string localDate = default(string), string timezone = default(string), string description = default(string), string type = default(string), DateAttributes attributes = default(DateAttributes), Dictionary<string, string> sourceData = default(Dictionary<string, string>))
        {
            this.Href = href;
            // to ensure "dateIdentifier" is required (not null)
            if (dateIdentifier == null)
            {
                throw new InvalidDataException("dateIdentifier is a required property for CalendarDate and cannot be null");
            }
            else
            {
                this.DateIdentifier = dateIdentifier;
            }
            
            // to ensure "fromUtc" is required (not null)
            if (fromUtc == null)
            {
                throw new InvalidDataException("fromUtc is a required property for CalendarDate and cannot be null");
            }
            else
            {
                this.FromUtc = fromUtc;
            }
            
            // to ensure "toUtc" is required (not null)
            if (toUtc == null)
            {
                throw new InvalidDataException("toUtc is a required property for CalendarDate and cannot be null");
            }
            else
            {
                this.ToUtc = toUtc;
            }
            
            // to ensure "localDate" is required (not null)
            if (localDate == null)
            {
                throw new InvalidDataException("localDate is a required property for CalendarDate and cannot be null");
            }
            else
            {
                this.LocalDate = localDate;
            }
            
            // to ensure "timezone" is required (not null)
            if (timezone == null)
            {
                throw new InvalidDataException("timezone is a required property for CalendarDate and cannot be null");
            }
            else
            {
                this.Timezone = timezone;
            }
            
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for CalendarDate and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for CalendarDate and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            
            this.SourceData = sourceData;
            this.Href = href;
            this.Attributes = attributes;
            this.SourceData = sourceData;
        }
        
        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="href", EmitDefaultValue=true)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets DateIdentifier
        /// </summary>
        [DataMember(Name="dateIdentifier", EmitDefaultValue=false)]
        public string DateIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets FromUtc
        /// </summary>
        [DataMember(Name="fromUtc", EmitDefaultValue=false)]
        public DateTimeOffset? FromUtc { get; set; }

        /// <summary>
        /// Gets or Sets ToUtc
        /// </summary>
        [DataMember(Name="toUtc", EmitDefaultValue=false)]
        public DateTimeOffset? ToUtc { get; set; }

        /// <summary>
        /// Gets or Sets LocalDate
        /// </summary>
        [DataMember(Name="localDate", EmitDefaultValue=false)]
        public string LocalDate { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public DateAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or Sets SourceData
        /// </summary>
        [DataMember(Name="sourceData", EmitDefaultValue=true)]
        public Dictionary<string, string> SourceData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CalendarDate {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  DateIdentifier: ").Append(DateIdentifier).Append("\n");
            sb.Append("  FromUtc: ").Append(FromUtc).Append("\n");
            sb.Append("  ToUtc: ").Append(ToUtc).Append("\n");
            sb.Append("  LocalDate: ").Append(LocalDate).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  SourceData: ").Append(SourceData).Append("\n");
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
            return this.Equals(input as CalendarDate);
        }

        /// <summary>
        /// Returns true if CalendarDate instances are equal
        /// </summary>
        /// <param name="input">Instance of CalendarDate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CalendarDate input)
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
                    this.DateIdentifier == input.DateIdentifier ||
                    (this.DateIdentifier != null &&
                    this.DateIdentifier.Equals(input.DateIdentifier))
                ) && 
                (
                    this.FromUtc == input.FromUtc ||
                    (this.FromUtc != null &&
                    this.FromUtc.Equals(input.FromUtc))
                ) && 
                (
                    this.ToUtc == input.ToUtc ||
                    (this.ToUtc != null &&
                    this.ToUtc.Equals(input.ToUtc))
                ) && 
                (
                    this.LocalDate == input.LocalDate ||
                    (this.LocalDate != null &&
                    this.LocalDate.Equals(input.LocalDate))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.SourceData == input.SourceData ||
                    this.SourceData != null &&
                    input.SourceData != null &&
                    this.SourceData.SequenceEqual(input.SourceData)
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
                if (this.DateIdentifier != null)
                    hashCode = hashCode * 59 + this.DateIdentifier.GetHashCode();
                if (this.FromUtc != null)
                    hashCode = hashCode * 59 + this.FromUtc.GetHashCode();
                if (this.ToUtc != null)
                    hashCode = hashCode * 59 + this.ToUtc.GetHashCode();
                if (this.LocalDate != null)
                    hashCode = hashCode * 59 + this.LocalDate.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.SourceData != null)
                    hashCode = hashCode * 59 + this.SourceData.GetHashCode();
                return hashCode;
            }
        }
    }

}
