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
using JsonSubTypes;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// A base class for any form of market data with structure
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "MarketDataType")]
    [JsonSubtypes.KnownSubType(typeof(YieldCurveData), "YieldCurveData")]
    [JsonSubtypes.KnownSubType(typeof(EquityVolSurfaceData), "EquityVolSurfaceData")]
    [JsonSubtypes.KnownSubType(typeof(OpaqueMarketData), "OpaqueMarketData")]
    [JsonSubtypes.KnownSubType(typeof(FxVolSurfaceData), "FxVolSurfaceData")]
    [JsonSubtypes.KnownSubType(typeof(IrVolCubeData), "IrVolCubeData")]
    [JsonSubtypes.KnownSubType(typeof(DiscountFactorCurveData), "DiscountFactorCurveData")]
    public partial class ComplexMarketData :  IEquatable<ComplexMarketData>
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
        /// Initializes a new instance of the <see cref="ComplexMarketData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComplexMarketData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexMarketData" /> class.
        /// </summary>
        /// <param name="marketDataType">The available values are: DiscountFactorCurveData, EquityVolSurfaceData, FxVolSurfaceData, IrVolCubeData, OpaqueMarketData, YieldCurveData (required).</param>
        public ComplexMarketData(MarketDataTypeEnum marketDataType = default(MarketDataTypeEnum))
        {
            // to ensure "marketDataType" is required (not null)
            if (marketDataType == null)
            {
                throw new InvalidDataException("marketDataType is a required property for ComplexMarketData and cannot be null");
            }
            else
            {
                this.MarketDataType = marketDataType;
            }
            
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComplexMarketData {\n");
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
            return this.Equals(input as ComplexMarketData);
        }

        /// <summary>
        /// Returns true if ComplexMarketData instances are equal
        /// </summary>
        /// <param name="input">Instance of ComplexMarketData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComplexMarketData input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.MarketDataType != null)
                    hashCode = hashCode * 59 + this.MarketDataType.GetHashCode();
                return hashCode;
            }
        }
    }

}
