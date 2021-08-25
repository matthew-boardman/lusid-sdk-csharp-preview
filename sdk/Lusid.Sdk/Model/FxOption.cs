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
    /// Lusid-ibor internal representation of a plain vanilla FX Option instrument.
    /// </summary>
    [DataContract]
    public partial class FxOption : LusidInstrument,  IEquatable<FxOption>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FxOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FxOption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FxOption" /> class.
        /// </summary>
        /// <param name="startDate">The start date of the instrument. This is normally synonymous with the trade-date. (required).</param>
        /// <param name="optionMaturityDate">The maturity date of the option. (required).</param>
        /// <param name="optionSettlementDate">The settlement date of the option. (required).</param>
        /// <param name="isDeliveryNotCash">True of the option is settled in cash false if delivery. (required).</param>
        /// <param name="isCallNotPut">True if the option is a call, false if the option is a put. (required).</param>
        /// <param name="strike">The strike of the option. (required).</param>
        /// <param name="domCcy">The domestic currency of the instrument. (required).</param>
        /// <param name="fgnCcy">The foreign currency of the FX. (required).</param>
        /// <param name="premium">premium.</param>
        public FxOption(DateTimeOffset? startDate = default(DateTimeOffset?), DateTimeOffset? optionMaturityDate = default(DateTimeOffset?), DateTimeOffset? optionSettlementDate = default(DateTimeOffset?), bool? isDeliveryNotCash = default(bool?), bool? isCallNotPut = default(bool?), decimal? strike = default(decimal?), string domCcy = default(string), string fgnCcy = default(string), Premium premium = default(Premium), InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum)) : base(instrumentType)
        {
            // to ensure "startDate" is required (not null)
            if (startDate == null)
            {
                throw new InvalidDataException("startDate is a required property for FxOption and cannot be null");
            }
            else
            {
                this.StartDate = startDate;
            }
            
            // to ensure "optionMaturityDate" is required (not null)
            if (optionMaturityDate == null)
            {
                throw new InvalidDataException("optionMaturityDate is a required property for FxOption and cannot be null");
            }
            else
            {
                this.OptionMaturityDate = optionMaturityDate;
            }
            
            // to ensure "optionSettlementDate" is required (not null)
            if (optionSettlementDate == null)
            {
                throw new InvalidDataException("optionSettlementDate is a required property for FxOption and cannot be null");
            }
            else
            {
                this.OptionSettlementDate = optionSettlementDate;
            }
            
            // to ensure "isDeliveryNotCash" is required (not null)
            if (isDeliveryNotCash == null)
            {
                throw new InvalidDataException("isDeliveryNotCash is a required property for FxOption and cannot be null");
            }
            else
            {
                this.IsDeliveryNotCash = isDeliveryNotCash;
            }
            
            // to ensure "isCallNotPut" is required (not null)
            if (isCallNotPut == null)
            {
                throw new InvalidDataException("isCallNotPut is a required property for FxOption and cannot be null");
            }
            else
            {
                this.IsCallNotPut = isCallNotPut;
            }
            
            // to ensure "strike" is required (not null)
            if (strike == null)
            {
                throw new InvalidDataException("strike is a required property for FxOption and cannot be null");
            }
            else
            {
                this.Strike = strike;
            }
            
            // to ensure "domCcy" is required (not null)
            if (domCcy == null)
            {
                throw new InvalidDataException("domCcy is a required property for FxOption and cannot be null");
            }
            else
            {
                this.DomCcy = domCcy;
            }
            
            // to ensure "fgnCcy" is required (not null)
            if (fgnCcy == null)
            {
                throw new InvalidDataException("fgnCcy is a required property for FxOption and cannot be null");
            }
            else
            {
                this.FgnCcy = fgnCcy;
            }
            
            this.Premium = premium;
        }
        
        /// <summary>
        /// The start date of the instrument. This is normally synonymous with the trade-date.
        /// </summary>
        /// <value>The start date of the instrument. This is normally synonymous with the trade-date.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTimeOffset? StartDate { get; set; }

        /// <summary>
        /// The maturity date of the option.
        /// </summary>
        /// <value>The maturity date of the option.</value>
        [DataMember(Name="optionMaturityDate", EmitDefaultValue=false)]
        public DateTimeOffset? OptionMaturityDate { get; set; }

        /// <summary>
        /// The settlement date of the option.
        /// </summary>
        /// <value>The settlement date of the option.</value>
        [DataMember(Name="optionSettlementDate", EmitDefaultValue=false)]
        public DateTimeOffset? OptionSettlementDate { get; set; }

        /// <summary>
        /// True of the option is settled in cash false if delivery.
        /// </summary>
        /// <value>True of the option is settled in cash false if delivery.</value>
        [DataMember(Name="isDeliveryNotCash", EmitDefaultValue=false)]
        public bool? IsDeliveryNotCash { get; set; }

        /// <summary>
        /// True if the option is a call, false if the option is a put.
        /// </summary>
        /// <value>True if the option is a call, false if the option is a put.</value>
        [DataMember(Name="isCallNotPut", EmitDefaultValue=false)]
        public bool? IsCallNotPut { get; set; }

        /// <summary>
        /// The strike of the option.
        /// </summary>
        /// <value>The strike of the option.</value>
        [DataMember(Name="strike", EmitDefaultValue=false)]
        public decimal? Strike { get; set; }

        /// <summary>
        /// The domestic currency of the instrument.
        /// </summary>
        /// <value>The domestic currency of the instrument.</value>
        [DataMember(Name="domCcy", EmitDefaultValue=false)]
        public string DomCcy { get; set; }

        /// <summary>
        /// The foreign currency of the FX.
        /// </summary>
        /// <value>The foreign currency of the FX.</value>
        [DataMember(Name="fgnCcy", EmitDefaultValue=false)]
        public string FgnCcy { get; set; }

        /// <summary>
        /// Gets or Sets Premium
        /// </summary>
        [DataMember(Name="premium", EmitDefaultValue=false)]
        public Premium Premium { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FxOption {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  OptionMaturityDate: ").Append(OptionMaturityDate).Append("\n");
            sb.Append("  OptionSettlementDate: ").Append(OptionSettlementDate).Append("\n");
            sb.Append("  IsDeliveryNotCash: ").Append(IsDeliveryNotCash).Append("\n");
            sb.Append("  IsCallNotPut: ").Append(IsCallNotPut).Append("\n");
            sb.Append("  Strike: ").Append(Strike).Append("\n");
            sb.Append("  DomCcy: ").Append(DomCcy).Append("\n");
            sb.Append("  FgnCcy: ").Append(FgnCcy).Append("\n");
            sb.Append("  Premium: ").Append(Premium).Append("\n");
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
            return this.Equals(input as FxOption);
        }

        /// <summary>
        /// Returns true if FxOption instances are equal
        /// </summary>
        /// <param name="input">Instance of FxOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FxOption input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && base.Equals(input) && 
                (
                    this.OptionMaturityDate == input.OptionMaturityDate ||
                    (this.OptionMaturityDate != null &&
                    this.OptionMaturityDate.Equals(input.OptionMaturityDate))
                ) && base.Equals(input) && 
                (
                    this.OptionSettlementDate == input.OptionSettlementDate ||
                    (this.OptionSettlementDate != null &&
                    this.OptionSettlementDate.Equals(input.OptionSettlementDate))
                ) && base.Equals(input) && 
                (
                    this.IsDeliveryNotCash == input.IsDeliveryNotCash ||
                    (this.IsDeliveryNotCash != null &&
                    this.IsDeliveryNotCash.Equals(input.IsDeliveryNotCash))
                ) && base.Equals(input) && 
                (
                    this.IsCallNotPut == input.IsCallNotPut ||
                    (this.IsCallNotPut != null &&
                    this.IsCallNotPut.Equals(input.IsCallNotPut))
                ) && base.Equals(input) && 
                (
                    this.Strike == input.Strike ||
                    (this.Strike != null &&
                    this.Strike.Equals(input.Strike))
                ) && base.Equals(input) && 
                (
                    this.DomCcy == input.DomCcy ||
                    (this.DomCcy != null &&
                    this.DomCcy.Equals(input.DomCcy))
                ) && base.Equals(input) && 
                (
                    this.FgnCcy == input.FgnCcy ||
                    (this.FgnCcy != null &&
                    this.FgnCcy.Equals(input.FgnCcy))
                ) && base.Equals(input) && 
                (
                    this.Premium == input.Premium ||
                    (this.Premium != null &&
                    this.Premium.Equals(input.Premium))
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
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.OptionMaturityDate != null)
                    hashCode = hashCode * 59 + this.OptionMaturityDate.GetHashCode();
                if (this.OptionSettlementDate != null)
                    hashCode = hashCode * 59 + this.OptionSettlementDate.GetHashCode();
                if (this.IsDeliveryNotCash != null)
                    hashCode = hashCode * 59 + this.IsDeliveryNotCash.GetHashCode();
                if (this.IsCallNotPut != null)
                    hashCode = hashCode * 59 + this.IsCallNotPut.GetHashCode();
                if (this.Strike != null)
                    hashCode = hashCode * 59 + this.Strike.GetHashCode();
                if (this.DomCcy != null)
                    hashCode = hashCode * 59 + this.DomCcy.GetHashCode();
                if (this.FgnCcy != null)
                    hashCode = hashCode * 59 + this.FgnCcy.GetHashCode();
                if (this.Premium != null)
                    hashCode = hashCode * 59 + this.Premium.GetHashCode();
                return hashCode;
            }
        }
    }

}
