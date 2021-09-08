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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// representation of a floating rates leg
    /// </summary>
    [DataContract(Name = "FloatingLeg")]
    [JsonConverter(typeof(JsonSubtypes), "InstrumentType")]
    public partial class FloatingLeg : InstrumentLeg, IEquatable<FloatingLeg>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FloatingLeg" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FloatingLeg() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FloatingLeg" /> class.
        /// </summary>
        /// <param name="startDate">startDate (required).</param>
        /// <param name="maturityDate">maturityDate (required).</param>
        /// <param name="legDefinition">legDefinition (required).</param>
        /// <param name="notional">scaling factor to apply to leg quantities. (required).</param>
        /// <param name="overrides">overrides.</param>
        /// <param name="instrumentType">The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CashSettled, CdsIndex, Basket, FundingLeg, CrossCurrencySwap, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo (required) (default to &quot;FloatingLeg&quot;).</param>
        public FloatingLeg(DateTimeOffset startDate = default(DateTimeOffset), DateTimeOffset maturityDate = default(DateTimeOffset), LegDefinition legDefinition = default(LegDefinition), decimal notional = default(decimal), FixedLegAllOfOverrides overrides = default(FixedLegAllOfOverrides), InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum)) : base(instrumentType)
        {
            this.StartDate = startDate;
            this.MaturityDate = maturityDate;
            // to ensure "legDefinition" is required (not null)
            this.LegDefinition = legDefinition ?? throw new ArgumentNullException("legDefinition is a required property for FloatingLeg and cannot be null");
            this.Notional = notional;
            this.Overrides = overrides;
        }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// Gets or Sets MaturityDate
        /// </summary>
        [DataMember(Name = "maturityDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset MaturityDate { get; set; }

        /// <summary>
        /// Gets or Sets LegDefinition
        /// </summary>
        [DataMember(Name = "legDefinition", IsRequired = true, EmitDefaultValue = false)]
        public LegDefinition LegDefinition { get; set; }

        /// <summary>
        /// scaling factor to apply to leg quantities.
        /// </summary>
        /// <value>scaling factor to apply to leg quantities.</value>
        [DataMember(Name = "notional", IsRequired = true, EmitDefaultValue = true)]
        public decimal Notional { get; set; }

        /// <summary>
        /// Gets or Sets Overrides
        /// </summary>
        [DataMember(Name = "overrides", EmitDefaultValue = true)]
        public FixedLegAllOfOverrides Overrides { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FloatingLeg {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  MaturityDate: ").Append(MaturityDate).Append("\n");
            sb.Append("  LegDefinition: ").Append(LegDefinition).Append("\n");
            sb.Append("  Notional: ").Append(Notional).Append("\n");
            sb.Append("  Overrides: ").Append(Overrides).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as FloatingLeg);
        }

        /// <summary>
        /// Returns true if FloatingLeg instances are equal
        /// </summary>
        /// <param name="input">Instance of FloatingLeg to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FloatingLeg input)
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
                    this.MaturityDate == input.MaturityDate ||
                    (this.MaturityDate != null &&
                    this.MaturityDate.Equals(input.MaturityDate))
                ) && base.Equals(input) && 
                (
                    this.LegDefinition == input.LegDefinition ||
                    (this.LegDefinition != null &&
                    this.LegDefinition.Equals(input.LegDefinition))
                ) && base.Equals(input) && 
                (
                    this.Notional == input.Notional ||
                    this.Notional.Equals(input.Notional)
                ) && base.Equals(input) && 
                (
                    this.Overrides == input.Overrides ||
                    (this.Overrides != null &&
                    this.Overrides.Equals(input.Overrides))
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
                if (this.MaturityDate != null)
                    hashCode = hashCode * 59 + this.MaturityDate.GetHashCode();
                if (this.LegDefinition != null)
                    hashCode = hashCode * 59 + this.LegDefinition.GetHashCode();
                hashCode = hashCode * 59 + this.Notional.GetHashCode();
                if (this.Overrides != null)
                    hashCode = hashCode * 59 + this.Overrides.GetHashCode();
                return hashCode;
            }
        }

    }
}
