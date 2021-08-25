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
    /// BasketAllOf
    /// </summary>
    [DataContract]
    public partial class BasketAllOf :  IEquatable<BasketAllOf>
    {
        /// <summary>
        /// The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CashSettled, CdsIndex, Basket, FundingLeg, CrossCurrencySwap, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo
        /// </summary>
        /// <value>The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CashSettled, CdsIndex, Basket, FundingLeg, CrossCurrencySwap, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InstrumentTypeEnum
        {
            /// <summary>
            /// Enum QuotedSecurity for value: QuotedSecurity
            /// </summary>
            [EnumMember(Value = "QuotedSecurity")]
            QuotedSecurity = 1,

            /// <summary>
            /// Enum InterestRateSwap for value: InterestRateSwap
            /// </summary>
            [EnumMember(Value = "InterestRateSwap")]
            InterestRateSwap = 2,

            /// <summary>
            /// Enum FxForward for value: FxForward
            /// </summary>
            [EnumMember(Value = "FxForward")]
            FxForward = 3,

            /// <summary>
            /// Enum Future for value: Future
            /// </summary>
            [EnumMember(Value = "Future")]
            Future = 4,

            /// <summary>
            /// Enum ExoticInstrument for value: ExoticInstrument
            /// </summary>
            [EnumMember(Value = "ExoticInstrument")]
            ExoticInstrument = 5,

            /// <summary>
            /// Enum FxOption for value: FxOption
            /// </summary>
            [EnumMember(Value = "FxOption")]
            FxOption = 6,

            /// <summary>
            /// Enum CreditDefaultSwap for value: CreditDefaultSwap
            /// </summary>
            [EnumMember(Value = "CreditDefaultSwap")]
            CreditDefaultSwap = 7,

            /// <summary>
            /// Enum InterestRateSwaption for value: InterestRateSwaption
            /// </summary>
            [EnumMember(Value = "InterestRateSwaption")]
            InterestRateSwaption = 8,

            /// <summary>
            /// Enum Bond for value: Bond
            /// </summary>
            [EnumMember(Value = "Bond")]
            Bond = 9,

            /// <summary>
            /// Enum EquityOption for value: EquityOption
            /// </summary>
            [EnumMember(Value = "EquityOption")]
            EquityOption = 10,

            /// <summary>
            /// Enum FixedLeg for value: FixedLeg
            /// </summary>
            [EnumMember(Value = "FixedLeg")]
            FixedLeg = 11,

            /// <summary>
            /// Enum FloatingLeg for value: FloatingLeg
            /// </summary>
            [EnumMember(Value = "FloatingLeg")]
            FloatingLeg = 12,

            /// <summary>
            /// Enum BespokeCashFlowsLeg for value: BespokeCashFlowsLeg
            /// </summary>
            [EnumMember(Value = "BespokeCashFlowsLeg")]
            BespokeCashFlowsLeg = 13,

            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 14,

            /// <summary>
            /// Enum TermDeposit for value: TermDeposit
            /// </summary>
            [EnumMember(Value = "TermDeposit")]
            TermDeposit = 15,

            /// <summary>
            /// Enum ContractForDifference for value: ContractForDifference
            /// </summary>
            [EnumMember(Value = "ContractForDifference")]
            ContractForDifference = 16,

            /// <summary>
            /// Enum EquitySwap for value: EquitySwap
            /// </summary>
            [EnumMember(Value = "EquitySwap")]
            EquitySwap = 17,

            /// <summary>
            /// Enum CashPerpetual for value: CashPerpetual
            /// </summary>
            [EnumMember(Value = "CashPerpetual")]
            CashPerpetual = 18,

            /// <summary>
            /// Enum CashSettled for value: CashSettled
            /// </summary>
            [EnumMember(Value = "CashSettled")]
            CashSettled = 19,

            /// <summary>
            /// Enum CdsIndex for value: CdsIndex
            /// </summary>
            [EnumMember(Value = "CdsIndex")]
            CdsIndex = 20,

            /// <summary>
            /// Enum Basket for value: Basket
            /// </summary>
            [EnumMember(Value = "Basket")]
            Basket = 21,

            /// <summary>
            /// Enum FundingLeg for value: FundingLeg
            /// </summary>
            [EnumMember(Value = "FundingLeg")]
            FundingLeg = 22,

            /// <summary>
            /// Enum CrossCurrencySwap for value: CrossCurrencySwap
            /// </summary>
            [EnumMember(Value = "CrossCurrencySwap")]
            CrossCurrencySwap = 23,

            /// <summary>
            /// Enum FxSwap for value: FxSwap
            /// </summary>
            [EnumMember(Value = "FxSwap")]
            FxSwap = 24,

            /// <summary>
            /// Enum ForwardRateAgreement for value: ForwardRateAgreement
            /// </summary>
            [EnumMember(Value = "ForwardRateAgreement")]
            ForwardRateAgreement = 25,

            /// <summary>
            /// Enum SimpleInstrument for value: SimpleInstrument
            /// </summary>
            [EnumMember(Value = "SimpleInstrument")]
            SimpleInstrument = 26,

            /// <summary>
            /// Enum Repo for value: Repo
            /// </summary>
            [EnumMember(Value = "Repo")]
            Repo = 27

        }

        /// <summary>
        /// The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CashSettled, CdsIndex, Basket, FundingLeg, CrossCurrencySwap, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo
        /// </summary>
        /// <value>The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CashSettled, CdsIndex, Basket, FundingLeg, CrossCurrencySwap, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo</value>
        [DataMember(Name="instrumentType", EmitDefaultValue=false)]
        public InstrumentTypeEnum InstrumentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BasketAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BasketAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BasketAllOf" /> class.
        /// </summary>
        /// <param name="basketName">basketName (required).</param>
        /// <param name="basketType">What contents does the basket have. The validation will check that the instrument types contained match those expected.  Supported string (enumeration) values are: [Bonds, Credits, Equities, EquitySwap]. (required).</param>
        /// <param name="weightedInstruments">weightedInstruments (required).</param>
        /// <param name="instrumentType">The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CashSettled, CdsIndex, Basket, FundingLeg, CrossCurrencySwap, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo (required).</param>
        public BasketAllOf(BasketIdentifier basketName = default(BasketIdentifier), string basketType = default(string), WeightedInstruments weightedInstruments = default(WeightedInstruments), InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum))
        {
            // to ensure "basketName" is required (not null)
            if (basketName == null)
            {
                throw new InvalidDataException("basketName is a required property for BasketAllOf and cannot be null");
            }
            else
            {
                this.BasketName = basketName;
            }
            
            // to ensure "basketType" is required (not null)
            if (basketType == null)
            {
                throw new InvalidDataException("basketType is a required property for BasketAllOf and cannot be null");
            }
            else
            {
                this.BasketType = basketType;
            }
            
            // to ensure "weightedInstruments" is required (not null)
            if (weightedInstruments == null)
            {
                throw new InvalidDataException("weightedInstruments is a required property for BasketAllOf and cannot be null");
            }
            else
            {
                this.WeightedInstruments = weightedInstruments;
            }
            
            // to ensure "instrumentType" is required (not null)
            if (instrumentType == null)
            {
                throw new InvalidDataException("instrumentType is a required property for BasketAllOf and cannot be null");
            }
            else
            {
                this.InstrumentType = instrumentType;
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
            sb.Append("class BasketAllOf {\n");
            sb.Append("  BasketName: ").Append(BasketName).Append("\n");
            sb.Append("  BasketType: ").Append(BasketType).Append("\n");
            sb.Append("  WeightedInstruments: ").Append(WeightedInstruments).Append("\n");
            sb.Append("  InstrumentType: ").Append(InstrumentType).Append("\n");
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
            return this.Equals(input as BasketAllOf);
        }

        /// <summary>
        /// Returns true if BasketAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of BasketAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BasketAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BasketName == input.BasketName ||
                    (this.BasketName != null &&
                    this.BasketName.Equals(input.BasketName))
                ) && 
                (
                    this.BasketType == input.BasketType ||
                    (this.BasketType != null &&
                    this.BasketType.Equals(input.BasketType))
                ) && 
                (
                    this.WeightedInstruments == input.WeightedInstruments ||
                    (this.WeightedInstruments != null &&
                    this.WeightedInstruments.Equals(input.WeightedInstruments))
                ) && 
                (
                    this.InstrumentType == input.InstrumentType ||
                    (this.InstrumentType != null &&
                    this.InstrumentType.Equals(input.InstrumentType))
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
                if (this.BasketName != null)
                    hashCode = hashCode * 59 + this.BasketName.GetHashCode();
                if (this.BasketType != null)
                    hashCode = hashCode * 59 + this.BasketType.GetHashCode();
                if (this.WeightedInstruments != null)
                    hashCode = hashCode * 59 + this.WeightedInstruments.GetHashCode();
                if (this.InstrumentType != null)
                    hashCode = hashCode * 59 + this.InstrumentType.GetHashCode();
                return hashCode;
            }
        }
    }

}
