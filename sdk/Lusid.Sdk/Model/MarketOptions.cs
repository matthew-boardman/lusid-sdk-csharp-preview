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
    /// The set of options that control miscellaneous and default market resolution behaviour.  These are aimed at a &#39;crude&#39; level of control for those who do not wish to fine tune the way that data is resolved.  For clients who wish to simply match instruments to prices this is quite possibly sufficient. For those wishing to control market data sources  according to requirements based on accuracy or timeliness it is not. In more advanced cases the options should largely be ignored and rules specified  per source. Be aware that where no specified rule matches the final fallback is on to the logic implied here.
    /// </summary>
    [DataContract]
    public partial class MarketOptions :  IEquatable<MarketOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketOptions" /> class.
        /// </summary>
        /// <param name="defaultSupplier">The default supplier of data. This controls which &#39;dialect&#39; is used to find particular market data. e.g. one supplier might address data by RIC, another by PermId.</param>
        /// <param name="defaultInstrumentCodeType">When instrument quotes are searched for, what identifier should be used by default.</param>
        /// <param name="defaultScope">For default rules, which scope should data be searched for in.</param>
        /// <param name="attemptToInferMissingFx">if true will calculate a missing Fx pair (e.g. THBJPY) from the inverse JPYTHB or from standardised pairs against USD, e.g. THBUSD and JPYUSD.</param>
        public MarketOptions(string defaultSupplier = default(string), string defaultInstrumentCodeType = default(string), string defaultScope = default(string), bool? attemptToInferMissingFx = default(bool?))
        {
            this.DefaultSupplier = defaultSupplier;
            this.DefaultInstrumentCodeType = defaultInstrumentCodeType;
            this.DefaultScope = defaultScope;
            this.DefaultSupplier = defaultSupplier;
            this.DefaultInstrumentCodeType = defaultInstrumentCodeType;
            this.DefaultScope = defaultScope;
            this.AttemptToInferMissingFx = attemptToInferMissingFx;
        }
        
        /// <summary>
        /// The default supplier of data. This controls which &#39;dialect&#39; is used to find particular market data. e.g. one supplier might address data by RIC, another by PermId
        /// </summary>
        /// <value>The default supplier of data. This controls which &#39;dialect&#39; is used to find particular market data. e.g. one supplier might address data by RIC, another by PermId</value>
        [DataMember(Name="defaultSupplier", EmitDefaultValue=true)]
        public string DefaultSupplier { get; set; }

        /// <summary>
        /// When instrument quotes are searched for, what identifier should be used by default
        /// </summary>
        /// <value>When instrument quotes are searched for, what identifier should be used by default</value>
        [DataMember(Name="defaultInstrumentCodeType", EmitDefaultValue=true)]
        public string DefaultInstrumentCodeType { get; set; }

        /// <summary>
        /// For default rules, which scope should data be searched for in
        /// </summary>
        /// <value>For default rules, which scope should data be searched for in</value>
        [DataMember(Name="defaultScope", EmitDefaultValue=true)]
        public string DefaultScope { get; set; }

        /// <summary>
        /// if true will calculate a missing Fx pair (e.g. THBJPY) from the inverse JPYTHB or from standardised pairs against USD, e.g. THBUSD and JPYUSD
        /// </summary>
        /// <value>if true will calculate a missing Fx pair (e.g. THBJPY) from the inverse JPYTHB or from standardised pairs against USD, e.g. THBUSD and JPYUSD</value>
        [DataMember(Name="attemptToInferMissingFx", EmitDefaultValue=false)]
        public bool? AttemptToInferMissingFx { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketOptions {\n");
            sb.Append("  DefaultSupplier: ").Append(DefaultSupplier).Append("\n");
            sb.Append("  DefaultInstrumentCodeType: ").Append(DefaultInstrumentCodeType).Append("\n");
            sb.Append("  DefaultScope: ").Append(DefaultScope).Append("\n");
            sb.Append("  AttemptToInferMissingFx: ").Append(AttemptToInferMissingFx).Append("\n");
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
            return this.Equals(input as MarketOptions);
        }

        /// <summary>
        /// Returns true if MarketOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of MarketOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultSupplier == input.DefaultSupplier ||
                    (this.DefaultSupplier != null &&
                    this.DefaultSupplier.Equals(input.DefaultSupplier))
                ) && 
                (
                    this.DefaultInstrumentCodeType == input.DefaultInstrumentCodeType ||
                    (this.DefaultInstrumentCodeType != null &&
                    this.DefaultInstrumentCodeType.Equals(input.DefaultInstrumentCodeType))
                ) && 
                (
                    this.DefaultScope == input.DefaultScope ||
                    (this.DefaultScope != null &&
                    this.DefaultScope.Equals(input.DefaultScope))
                ) && 
                (
                    this.AttemptToInferMissingFx == input.AttemptToInferMissingFx ||
                    (this.AttemptToInferMissingFx != null &&
                    this.AttemptToInferMissingFx.Equals(input.AttemptToInferMissingFx))
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
                if (this.DefaultSupplier != null)
                    hashCode = hashCode * 59 + this.DefaultSupplier.GetHashCode();
                if (this.DefaultInstrumentCodeType != null)
                    hashCode = hashCode * 59 + this.DefaultInstrumentCodeType.GetHashCode();
                if (this.DefaultScope != null)
                    hashCode = hashCode * 59 + this.DefaultScope.GetHashCode();
                if (this.AttemptToInferMissingFx != null)
                    hashCode = hashCode * 59 + this.AttemptToInferMissingFx.GetHashCode();
                return hashCode;
            }
        }
    }

}
