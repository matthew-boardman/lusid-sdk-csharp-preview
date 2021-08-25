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
    /// InstrumentSearchProperty
    /// </summary>
    [DataContract]
    public partial class InstrumentSearchProperty :  IEquatable<InstrumentSearchProperty>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentSearchProperty" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InstrumentSearchProperty() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentSearchProperty" /> class.
        /// </summary>
        /// <param name="key">The property key of instrument property to search for. This will be from the &#39;Instrument&#39; domain and will take the format {domain}/{scope}/{code} e.g. &#39;Instrument/system/Isin&#39; or &#39;Instrument/MyScope/AssetClass&#39;. (required).</param>
        /// <param name="value">The value of the property e.g. &#39;US0378331005&#39; or &#39;Equity&#39;. (required).</param>
        public InstrumentSearchProperty(string key = default(string), string value = default(string))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new InvalidDataException("key is a required property for InstrumentSearchProperty and cannot be null");
            }
            else
            {
                this.Key = key;
            }
            
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for InstrumentSearchProperty and cannot be null");
            }
            else
            {
                this.Value = value;
            }
            
        }
        
        /// <summary>
        /// The property key of instrument property to search for. This will be from the &#39;Instrument&#39; domain and will take the format {domain}/{scope}/{code} e.g. &#39;Instrument/system/Isin&#39; or &#39;Instrument/MyScope/AssetClass&#39;.
        /// </summary>
        /// <value>The property key of instrument property to search for. This will be from the &#39;Instrument&#39; domain and will take the format {domain}/{scope}/{code} e.g. &#39;Instrument/system/Isin&#39; or &#39;Instrument/MyScope/AssetClass&#39;.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// The value of the property e.g. &#39;US0378331005&#39; or &#39;Equity&#39;.
        /// </summary>
        /// <value>The value of the property e.g. &#39;US0378331005&#39; or &#39;Equity&#39;.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstrumentSearchProperty {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as InstrumentSearchProperty);
        }

        /// <summary>
        /// Returns true if InstrumentSearchProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of InstrumentSearchProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstrumentSearchProperty input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }

}
