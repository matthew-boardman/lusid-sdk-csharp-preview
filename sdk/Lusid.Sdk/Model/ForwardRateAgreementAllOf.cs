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
    /// ForwardRateAgreementAllOf
    /// </summary>
    [DataContract]
    public partial class ForwardRateAgreementAllOf :  IEquatable<ForwardRateAgreementAllOf>
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
        /// Initializes a new instance of the <see cref="ForwardRateAgreementAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ForwardRateAgreementAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ForwardRateAgreementAllOf" /> class.
        /// </summary>
        /// <param name="startDate">The start date of the instrument. This is normally synonymous with the trade-date. (required).</param>
        /// <param name="maturityDate">The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates beyond their last payment date (required).</param>
        /// <param name="domCcy">The domestic currency of the instrument. (required).</param>
        /// <param name="fixingDate">The date at which the rate to be paid, the reference rate, is confirmed/observed (required).</param>
        /// <param name="fraRate">The rate at which the FRA is traded. (required).</param>
        /// <param name="notional">The amount for which the FRA is traded. (required).</param>
        /// <param name="instrumentType">The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CashSettled, CdsIndex, Basket, FundingLeg, CrossCurrencySwap, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo (required).</param>
        public ForwardRateAgreementAllOf(DateTimeOffset? startDate = default(DateTimeOffset?), DateTimeOffset? maturityDate = default(DateTimeOffset?), string domCcy = default(string), DateTimeOffset? fixingDate = default(DateTimeOffset?), decimal? fraRate = default(decimal?), decimal? notional = default(decimal?), InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum))
        {
            // to ensure "startDate" is required (not null)
            if (startDate == null)
            {
                throw new InvalidDataException("startDate is a required property for ForwardRateAgreementAllOf and cannot be null");
            }
            else
            {
                this.StartDate = startDate;
            }
            
            // to ensure "maturityDate" is required (not null)
            if (maturityDate == null)
            {
                throw new InvalidDataException("maturityDate is a required property for ForwardRateAgreementAllOf and cannot be null");
            }
            else
            {
                this.MaturityDate = maturityDate;
            }
            
            // to ensure "domCcy" is required (not null)
            if (domCcy == null)
            {
                throw new InvalidDataException("domCcy is a required property for ForwardRateAgreementAllOf and cannot be null");
            }
            else
            {
                this.DomCcy = domCcy;
            }
            
            // to ensure "fixingDate" is required (not null)
            if (fixingDate == null)
            {
                throw new InvalidDataException("fixingDate is a required property for ForwardRateAgreementAllOf and cannot be null");
            }
            else
            {
                this.FixingDate = fixingDate;
            }
            
            // to ensure "fraRate" is required (not null)
            if (fraRate == null)
            {
                throw new InvalidDataException("fraRate is a required property for ForwardRateAgreementAllOf and cannot be null");
            }
            else
            {
                this.FraRate = fraRate;
            }
            
            // to ensure "notional" is required (not null)
            if (notional == null)
            {
                throw new InvalidDataException("notional is a required property for ForwardRateAgreementAllOf and cannot be null");
            }
            else
            {
                this.Notional = notional;
            }
            
            // to ensure "instrumentType" is required (not null)
            if (instrumentType == null)
            {
                throw new InvalidDataException("instrumentType is a required property for ForwardRateAgreementAllOf and cannot be null");
            }
            else
            {
                this.InstrumentType = instrumentType;
            }
            
        }
        
        /// <summary>
        /// The start date of the instrument. This is normally synonymous with the trade-date.
        /// </summary>
        /// <value>The start date of the instrument. This is normally synonymous with the trade-date.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTimeOffset? StartDate { get; set; }

        /// <summary>
        /// The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates beyond their last payment date
        /// </summary>
        /// <value>The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates beyond their last payment date</value>
        [DataMember(Name="maturityDate", EmitDefaultValue=false)]
        public DateTimeOffset? MaturityDate { get; set; }

        /// <summary>
        /// The domestic currency of the instrument.
        /// </summary>
        /// <value>The domestic currency of the instrument.</value>
        [DataMember(Name="domCcy", EmitDefaultValue=false)]
        public string DomCcy { get; set; }

        /// <summary>
        /// The date at which the rate to be paid, the reference rate, is confirmed/observed
        /// </summary>
        /// <value>The date at which the rate to be paid, the reference rate, is confirmed/observed</value>
        [DataMember(Name="fixingDate", EmitDefaultValue=false)]
        public DateTimeOffset? FixingDate { get; set; }

        /// <summary>
        /// The rate at which the FRA is traded.
        /// </summary>
        /// <value>The rate at which the FRA is traded.</value>
        [DataMember(Name="fraRate", EmitDefaultValue=false)]
        public decimal? FraRate { get; set; }

        /// <summary>
        /// The amount for which the FRA is traded.
        /// </summary>
        /// <value>The amount for which the FRA is traded.</value>
        [DataMember(Name="notional", EmitDefaultValue=false)]
        public decimal? Notional { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForwardRateAgreementAllOf {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  MaturityDate: ").Append(MaturityDate).Append("\n");
            sb.Append("  DomCcy: ").Append(DomCcy).Append("\n");
            sb.Append("  FixingDate: ").Append(FixingDate).Append("\n");
            sb.Append("  FraRate: ").Append(FraRate).Append("\n");
            sb.Append("  Notional: ").Append(Notional).Append("\n");
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
            return this.Equals(input as ForwardRateAgreementAllOf);
        }

        /// <summary>
        /// Returns true if ForwardRateAgreementAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ForwardRateAgreementAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForwardRateAgreementAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.MaturityDate == input.MaturityDate ||
                    (this.MaturityDate != null &&
                    this.MaturityDate.Equals(input.MaturityDate))
                ) && 
                (
                    this.DomCcy == input.DomCcy ||
                    (this.DomCcy != null &&
                    this.DomCcy.Equals(input.DomCcy))
                ) && 
                (
                    this.FixingDate == input.FixingDate ||
                    (this.FixingDate != null &&
                    this.FixingDate.Equals(input.FixingDate))
                ) && 
                (
                    this.FraRate == input.FraRate ||
                    (this.FraRate != null &&
                    this.FraRate.Equals(input.FraRate))
                ) && 
                (
                    this.Notional == input.Notional ||
                    (this.Notional != null &&
                    this.Notional.Equals(input.Notional))
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
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.MaturityDate != null)
                    hashCode = hashCode * 59 + this.MaturityDate.GetHashCode();
                if (this.DomCcy != null)
                    hashCode = hashCode * 59 + this.DomCcy.GetHashCode();
                if (this.FixingDate != null)
                    hashCode = hashCode * 59 + this.FixingDate.GetHashCode();
                if (this.FraRate != null)
                    hashCode = hashCode * 59 + this.FraRate.GetHashCode();
                if (this.Notional != null)
                    hashCode = hashCode * 59 + this.Notional.GetHashCode();
                if (this.InstrumentType != null)
                    hashCode = hashCode * 59 + this.InstrumentType.GetHashCode();
                return hashCode;
            }
        }
    }

}
