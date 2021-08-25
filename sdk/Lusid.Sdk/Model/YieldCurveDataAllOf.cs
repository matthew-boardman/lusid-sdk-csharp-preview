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
    /// YieldCurveDataAllOf
    /// </summary>
    [DataContract]
    public partial class YieldCurveDataAllOf :  IEquatable<YieldCurveDataAllOf>
    {
        /// <summary>
        /// The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData
        /// </summary>
        /// <value>The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MarketDataTypeEnum
        {
            /// <summary>
            /// Enum DiscountFactorCurveData for value: DiscountFactorCurveData
            /// </summary>
            [EnumMember(Value = "DiscountFactorCurveData")]
            DiscountFactorCurveData = 1,

            /// <summary>
            /// Enum EquityVolSurfaceData for value: EquityVolSurfaceData
            /// </summary>
            [EnumMember(Value = "EquityVolSurfaceData")]
            EquityVolSurfaceData = 2,

            /// <summary>
            /// Enum FxVolSurfaceData for value: FxVolSurfaceData
            /// </summary>
            [EnumMember(Value = "FxVolSurfaceData")]
            FxVolSurfaceData = 3,

            /// <summary>
            /// Enum IrVolCubeData for value: IrVolCubeData
            /// </summary>
            [EnumMember(Value = "IrVolCubeData")]
            IrVolCubeData = 4,

            /// <summary>
            /// Enum OpaqueMarketData for value: OpaqueMarketData
            /// </summary>
            [EnumMember(Value = "OpaqueMarketData")]
            OpaqueMarketData = 5,

            /// <summary>
            /// Enum YieldCurveData for value: YieldCurveData
            /// </summary>
            [EnumMember(Value = "YieldCurveData")]
            YieldCurveData = 6

        }

        /// <summary>
        /// The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData
        /// </summary>
        /// <value>The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData</value>
        [DataMember(Name="marketDataType", EmitDefaultValue=false)]
        public MarketDataTypeEnum MarketDataType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="YieldCurveDataAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected YieldCurveDataAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="YieldCurveDataAllOf" /> class.
        /// </summary>
        /// <param name="baseDate">Base date (required).</param>
        /// <param name="instruments">The set of instruments that define the curve. (required).</param>
        /// <param name="quotes">The market quotes corresponding to the the instruments used to define the curve (required).</param>
        /// <param name="marketDataType">The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData (required).</param>
        public YieldCurveDataAllOf(DateTimeOffset? baseDate = default(DateTimeOffset?), List<LusidInstrument> instruments = default(List<LusidInstrument>), List<MarketQuote> quotes = default(List<MarketQuote>), MarketDataTypeEnum marketDataType = default(MarketDataTypeEnum))
        {
            // to ensure "baseDate" is required (not null)
            if (baseDate == null)
            {
                throw new InvalidDataException("baseDate is a required property for YieldCurveDataAllOf and cannot be null");
            }
            else
            {
                this.BaseDate = baseDate;
            }
            
            // to ensure "instruments" is required (not null)
            if (instruments == null)
            {
                throw new InvalidDataException("instruments is a required property for YieldCurveDataAllOf and cannot be null");
            }
            else
            {
                this.Instruments = instruments;
            }
            
            // to ensure "quotes" is required (not null)
            if (quotes == null)
            {
                throw new InvalidDataException("quotes is a required property for YieldCurveDataAllOf and cannot be null");
            }
            else
            {
                this.Quotes = quotes;
            }
            
            // to ensure "marketDataType" is required (not null)
            if (marketDataType == null)
            {
                throw new InvalidDataException("marketDataType is a required property for YieldCurveDataAllOf and cannot be null");
            }
            else
            {
                this.MarketDataType = marketDataType;
            }
            
        }
        
        /// <summary>
        /// Base date
        /// </summary>
        /// <value>Base date</value>
        [DataMember(Name="baseDate", EmitDefaultValue=false)]
        public DateTimeOffset? BaseDate { get; set; }

        /// <summary>
        /// The set of instruments that define the curve.
        /// </summary>
        /// <value>The set of instruments that define the curve.</value>
        [DataMember(Name="instruments", EmitDefaultValue=false)]
        public List<LusidInstrument> Instruments { get; set; }

        /// <summary>
        /// The market quotes corresponding to the the instruments used to define the curve
        /// </summary>
        /// <value>The market quotes corresponding to the the instruments used to define the curve</value>
        [DataMember(Name="quotes", EmitDefaultValue=false)]
        public List<MarketQuote> Quotes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class YieldCurveDataAllOf {\n");
            sb.Append("  BaseDate: ").Append(BaseDate).Append("\n");
            sb.Append("  Instruments: ").Append(Instruments).Append("\n");
            sb.Append("  Quotes: ").Append(Quotes).Append("\n");
            sb.Append("  MarketDataType: ").Append(MarketDataType).Append("\n");
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
            return this.Equals(input as YieldCurveDataAllOf);
        }

        /// <summary>
        /// Returns true if YieldCurveDataAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of YieldCurveDataAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(YieldCurveDataAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BaseDate == input.BaseDate ||
                    (this.BaseDate != null &&
                    this.BaseDate.Equals(input.BaseDate))
                ) && 
                (
                    this.Instruments == input.Instruments ||
                    this.Instruments != null &&
                    input.Instruments != null &&
                    this.Instruments.SequenceEqual(input.Instruments)
                ) && 
                (
                    this.Quotes == input.Quotes ||
                    this.Quotes != null &&
                    input.Quotes != null &&
                    this.Quotes.SequenceEqual(input.Quotes)
                ) && 
                (
                    this.MarketDataType == input.MarketDataType ||
                    (this.MarketDataType != null &&
                    this.MarketDataType.Equals(input.MarketDataType))
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
                if (this.BaseDate != null)
                    hashCode = hashCode * 59 + this.BaseDate.GetHashCode();
                if (this.Instruments != null)
                    hashCode = hashCode * 59 + this.Instruments.GetHashCode();
                if (this.Quotes != null)
                    hashCode = hashCode * 59 + this.Quotes.GetHashCode();
                if (this.MarketDataType != null)
                    hashCode = hashCode * 59 + this.MarketDataType.GetHashCode();
                return hashCode;
            }
        }
    }

}
