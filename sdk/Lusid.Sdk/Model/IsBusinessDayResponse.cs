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
    /// Whether or not a DateTimeOffset is a business DateTime
    /// </summary>
    [DataContract(Name = "IsBusinessDayResponse")]
    public partial class IsBusinessDayResponse : IEquatable<IsBusinessDayResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsBusinessDayResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IsBusinessDayResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IsBusinessDayResponse" /> class.
        /// </summary>
        /// <param name="requestedDateTime">requestedDateTime (required).</param>
        /// <param name="isBusinessDay">isBusinessDay (required).</param>
        public IsBusinessDayResponse(DateTimeOffset requestedDateTime = default(DateTimeOffset), bool isBusinessDay = default(bool))
        {
            this.RequestedDateTime = requestedDateTime;
            this.IsBusinessDay = isBusinessDay;
        }

        /// <summary>
        /// Gets or Sets RequestedDateTime
        /// </summary>
        [DataMember(Name = "requestedDateTime", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset RequestedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets IsBusinessDay
        /// </summary>
        [DataMember(Name = "isBusinessDay", IsRequired = true, EmitDefaultValue = true)]
        public bool IsBusinessDay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IsBusinessDayResponse {\n");
            sb.Append("  RequestedDateTime: ").Append(RequestedDateTime).Append("\n");
            sb.Append("  IsBusinessDay: ").Append(IsBusinessDay).Append("\n");
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
            return this.Equals(input as IsBusinessDayResponse);
        }

        /// <summary>
        /// Returns true if IsBusinessDayResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of IsBusinessDayResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IsBusinessDayResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestedDateTime == input.RequestedDateTime ||
                    (this.RequestedDateTime != null &&
                    this.RequestedDateTime.Equals(input.RequestedDateTime))
                ) && 
                (
                    this.IsBusinessDay == input.IsBusinessDay ||
                    this.IsBusinessDay.Equals(input.IsBusinessDay)
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
                if (this.RequestedDateTime != null)
                    hashCode = hashCode * 59 + this.RequestedDateTime.GetHashCode();
                hashCode = hashCode * 59 + this.IsBusinessDay.GetHashCode();
                return hashCode;
            }
        }

    }
}
