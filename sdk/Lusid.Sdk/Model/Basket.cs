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
    /// Class that models a basket of risky instruments that can default.  Upon default, the weight of a defaulting instrument can (will) change and this then affects the behaviour of the basket.
    /// </summary>
    [DataContract]
    public partial class Basket : LusidInstrument,  IEquatable<Basket>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Basket" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Basket() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Basket" /> class.
        /// </summary>
        /// <param name="basketName">basketName (required).</param>
        /// <param name="basketType">What contents does the basket have. The validation will check that the instrument types contained match those expected.  Supported string (enumeration) values are: [Bonds, Credits, Equities, EquitySwap]. (required).</param>
        /// <param name="weightedInstruments">weightedInstruments (required).</param>
        public Basket(BasketIdentifier basketName = default(BasketIdentifier), string basketType = default(string), WeightedInstruments weightedInstruments = default(WeightedInstruments), InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum)) : base(instrumentType)
        {
            // to ensure "basketName" is required (not null)
            if (basketName == null)
            {
                throw new InvalidDataException("basketName is a required property for Basket and cannot be null");
            }
            else
            {
                this.BasketName = basketName;
            }
            
            // to ensure "basketType" is required (not null)
            if (basketType == null)
            {
                throw new InvalidDataException("basketType is a required property for Basket and cannot be null");
            }
            else
            {
                this.BasketType = basketType;
            }
            
            // to ensure "weightedInstruments" is required (not null)
            if (weightedInstruments == null)
            {
                throw new InvalidDataException("weightedInstruments is a required property for Basket and cannot be null");
            }
            else
            {
                this.WeightedInstruments = weightedInstruments;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets BasketName
        /// </summary>
        [DataMember(Name="basketName", EmitDefaultValue=false)]
        public BasketIdentifier BasketName { get; set; }

        /// <summary>
        /// What contents does the basket have. The validation will check that the instrument types contained match those expected.  Supported string (enumeration) values are: [Bonds, Credits, Equities, EquitySwap].
        /// </summary>
        /// <value>What contents does the basket have. The validation will check that the instrument types contained match those expected.  Supported string (enumeration) values are: [Bonds, Credits, Equities, EquitySwap].</value>
        [DataMember(Name="basketType", EmitDefaultValue=false)]
        public string BasketType { get; set; }

        /// <summary>
        /// Gets or Sets WeightedInstruments
        /// </summary>
        [DataMember(Name="weightedInstruments", EmitDefaultValue=false)]
        public WeightedInstruments WeightedInstruments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Basket {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  BasketName: ").Append(BasketName).Append("\n");
            sb.Append("  BasketType: ").Append(BasketType).Append("\n");
            sb.Append("  WeightedInstruments: ").Append(WeightedInstruments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as Basket);
        }

        /// <summary>
        /// Returns true if Basket instances are equal
        /// </summary>
        /// <param name="input">Instance of Basket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Basket input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.BasketName == input.BasketName ||
                    (this.BasketName != null &&
                    this.BasketName.Equals(input.BasketName))
                ) && base.Equals(input) && 
                (
                    this.BasketType == input.BasketType ||
                    (this.BasketType != null &&
                    this.BasketType.Equals(input.BasketType))
                ) && base.Equals(input) && 
                (
                    this.WeightedInstruments == input.WeightedInstruments ||
                    (this.WeightedInstruments != null &&
                    this.WeightedInstruments.Equals(input.WeightedInstruments))
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
                int hashCode = base.GetHashCode();
                if (this.BasketName != null)
                    hashCode = hashCode * 59 + this.BasketName.GetHashCode();
                if (this.BasketType != null)
                    hashCode = hashCode * 59 + this.BasketType.GetHashCode();
                if (this.WeightedInstruments != null)
                    hashCode = hashCode * 59 + this.WeightedInstruments.GetHashCode();
                return hashCode;
            }
        }
    }

}
