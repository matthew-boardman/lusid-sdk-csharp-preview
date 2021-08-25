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
    /// An identifier that uniquely describes an item of structured market data such as an interest rate curve or volatility surface.
    /// </summary>
    [DataContract]
    public partial class StructuredMarketDataId :  IEquatable<StructuredMarketDataId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredMarketDataId" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StructuredMarketDataId() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredMarketDataId" /> class.
        /// </summary>
        /// <param name="provider">The platform or vendor that provided the structured market data, e.g. &#39;DataScope&#39;, &#39;LUSID&#39;, &#39;ISDA&#39; etc. (required).</param>
        /// <param name="priceSource">The source or originator of the structured market data, e.g. a bank or financial institution..</param>
        /// <param name="lineage">Description of the structured market data&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;..</param>
        /// <param name="effectiveAt">The effectiveAt or cut label that this item of structured market data is/was updated/inserted with..</param>
        /// <param name="marketElementType">The type of the market element that the market entity represents, e.g. a vol surface or credit curve.</param>
        /// <param name="marketAsset">The name of the market entity that the document represents.</param>
        public StructuredMarketDataId(string provider = default(string), string priceSource = default(string), string lineage = default(string), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel), string marketElementType = default(string), string marketAsset = default(string))
        {
            // to ensure "provider" is required (not null)
            if (provider == null)
            {
                throw new InvalidDataException("provider is a required property for StructuredMarketDataId and cannot be null");
            }
            else
            {
                this.Provider = provider;
            }
            
            this.PriceSource = priceSource;
            this.Lineage = lineage;
            this.EffectiveAt = effectiveAt;
            this.MarketElementType = marketElementType;
            this.MarketAsset = marketAsset;
            this.PriceSource = priceSource;
            this.Lineage = lineage;
            this.EffectiveAt = effectiveAt;
            this.MarketElementType = marketElementType;
            this.MarketAsset = marketAsset;
        }
        
        /// <summary>
        /// The platform or vendor that provided the structured market data, e.g. &#39;DataScope&#39;, &#39;LUSID&#39;, &#39;ISDA&#39; etc.
        /// </summary>
        /// <value>The platform or vendor that provided the structured market data, e.g. &#39;DataScope&#39;, &#39;LUSID&#39;, &#39;ISDA&#39; etc.</value>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; set; }

        /// <summary>
        /// The source or originator of the structured market data, e.g. a bank or financial institution.
        /// </summary>
        /// <value>The source or originator of the structured market data, e.g. a bank or financial institution.</value>
        [DataMember(Name="priceSource", EmitDefaultValue=true)]
        public string PriceSource { get; set; }

        /// <summary>
        /// Description of the structured market data&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;.
        /// </summary>
        /// <value>Description of the structured market data&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;.</value>
        [DataMember(Name="lineage", EmitDefaultValue=true)]
        public string Lineage { get; set; }

        /// <summary>
        /// The effectiveAt or cut label that this item of structured market data is/was updated/inserted with.
        /// </summary>
        /// <value>The effectiveAt or cut label that this item of structured market data is/was updated/inserted with.</value>
        [DataMember(Name="effectiveAt", EmitDefaultValue=true)]
        public DateTimeOrCutLabel EffectiveAt { get; set; }

        /// <summary>
        /// The type of the market element that the market entity represents, e.g. a vol surface or credit curve
        /// </summary>
        /// <value>The type of the market element that the market entity represents, e.g. a vol surface or credit curve</value>
        [DataMember(Name="marketElementType", EmitDefaultValue=true)]
        public string MarketElementType { get; set; }

        /// <summary>
        /// The name of the market entity that the document represents
        /// </summary>
        /// <value>The name of the market entity that the document represents</value>
        [DataMember(Name="marketAsset", EmitDefaultValue=true)]
        public string MarketAsset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StructuredMarketDataId {\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  PriceSource: ").Append(PriceSource).Append("\n");
            sb.Append("  Lineage: ").Append(Lineage).Append("\n");
            sb.Append("  EffectiveAt: ").Append(EffectiveAt).Append("\n");
            sb.Append("  MarketElementType: ").Append(MarketElementType).Append("\n");
            sb.Append("  MarketAsset: ").Append(MarketAsset).Append("\n");
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
            return this.Equals(input as StructuredMarketDataId);
        }

        /// <summary>
        /// Returns true if StructuredMarketDataId instances are equal
        /// </summary>
        /// <param name="input">Instance of StructuredMarketDataId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StructuredMarketDataId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.PriceSource == input.PriceSource ||
                    (this.PriceSource != null &&
                    this.PriceSource.Equals(input.PriceSource))
                ) && 
                (
                    this.Lineage == input.Lineage ||
                    (this.Lineage != null &&
                    this.Lineage.Equals(input.Lineage))
                ) && 
                (
                    this.EffectiveAt == input.EffectiveAt ||
                    (this.EffectiveAt != null &&
                    this.EffectiveAt.Equals(input.EffectiveAt))
                ) && 
                (
                    this.MarketElementType == input.MarketElementType ||
                    (this.MarketElementType != null &&
                    this.MarketElementType.Equals(input.MarketElementType))
                ) && 
                (
                    this.MarketAsset == input.MarketAsset ||
                    (this.MarketAsset != null &&
                    this.MarketAsset.Equals(input.MarketAsset))
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
                if (this.Provider != null)
                    hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.PriceSource != null)
                    hashCode = hashCode * 59 + this.PriceSource.GetHashCode();
                if (this.Lineage != null)
                    hashCode = hashCode * 59 + this.Lineage.GetHashCode();
                if (this.EffectiveAt != null)
                    hashCode = hashCode * 59 + this.EffectiveAt.GetHashCode();
                if (this.MarketElementType != null)
                    hashCode = hashCode * 59 + this.MarketElementType.GetHashCode();
                if (this.MarketAsset != null)
                    hashCode = hashCode * 59 + this.MarketAsset.GetHashCode();
                return hashCode;
            }
        }
    }

}
