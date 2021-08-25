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
    /// IL Fx-Forward Instrument; Lusid-ibor internal representation of a Fx Forward instrument
    /// </summary>
    [DataContract]
    public partial class FxForward : LusidInstrument,  IEquatable<FxForward>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FxForward" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FxForward() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FxForward" /> class.
        /// </summary>
        /// <param name="startDate">The start date of the instrument. This is normally synonymous with the trade-date. (required).</param>
        /// <param name="maturityDate">The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.              For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as              Constant Maturity Swaps (CMS) often have sensitivities to rates beyond their last payment date (required).</param>
        /// <param name="domAmount">The amount that is to be paid in the domestic currency on the maturity date. (required).</param>
        /// <param name="domCcy">The domestic currency of the instrument. (required).</param>
        /// <param name="fgnAmount">The amount that is to be paid in the foreign currency on the maturity date (required).</param>
        /// <param name="fgnCcy">The foreign (other) currency of the instrument. In the NDF case, only payments are made in the domestic currency.              For the outright forward, currencies are exchanged. By domestic is then that of the portfolio. (required).</param>
        /// <param name="refSpotRate">The reference Fx Spot rate for currency pair Foreign-Domestic that was seen on the trade start date (time)..</param>
        /// <param name="isNdf">Is the contract an Fx-Forward of \&quot;Non-Deliverable\&quot; type, meaning a single payment in the domestic currency based on the change in fx-rate vs              a reference rate is used..</param>
        /// <param name="fixingDate">The fixing date ..</param>
        public FxForward(DateTimeOffset? startDate = default(DateTimeOffset?), DateTimeOffset? maturityDate = default(DateTimeOffset?), decimal? domAmount = default(decimal?), string domCcy = default(string), decimal? fgnAmount = default(decimal?), string fgnCcy = default(string), decimal? refSpotRate = default(decimal?), bool? isNdf = default(bool?), DateTimeOffset? fixingDate = default(DateTimeOffset?), InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum)) : base(instrumentType)
        {
            // to ensure "startDate" is required (not null)
            if (startDate == null)
            {
                throw new InvalidDataException("startDate is a required property for FxForward and cannot be null");
            }
            else
            {
                this.StartDate = startDate;
            }
            
            // to ensure "maturityDate" is required (not null)
            if (maturityDate == null)
            {
                throw new InvalidDataException("maturityDate is a required property for FxForward and cannot be null");
            }
            else
            {
                this.MaturityDate = maturityDate;
            }
            
            // to ensure "domAmount" is required (not null)
            if (domAmount == null)
            {
                throw new InvalidDataException("domAmount is a required property for FxForward and cannot be null");
            }
            else
            {
                this.DomAmount = domAmount;
            }
            
            // to ensure "domCcy" is required (not null)
            if (domCcy == null)
            {
                throw new InvalidDataException("domCcy is a required property for FxForward and cannot be null");
            }
            else
            {
                this.DomCcy = domCcy;
            }
            
            // to ensure "fgnAmount" is required (not null)
            if (fgnAmount == null)
            {
                throw new InvalidDataException("fgnAmount is a required property for FxForward and cannot be null");
            }
            else
            {
                this.FgnAmount = fgnAmount;
            }
            
            // to ensure "fgnCcy" is required (not null)
            if (fgnCcy == null)
            {
                throw new InvalidDataException("fgnCcy is a required property for FxForward and cannot be null");
            }
            else
            {
                this.FgnCcy = fgnCcy;
            }
            
            this.RefSpotRate = refSpotRate;
            this.IsNdf = isNdf;
            this.FixingDate = fixingDate;
        }
        
        /// <summary>
        /// The start date of the instrument. This is normally synonymous with the trade-date.
        /// </summary>
        /// <value>The start date of the instrument. This is normally synonymous with the trade-date.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTimeOffset? StartDate { get; set; }

        /// <summary>
        /// The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.              For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as              Constant Maturity Swaps (CMS) often have sensitivities to rates beyond their last payment date
        /// </summary>
        /// <value>The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.              For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as              Constant Maturity Swaps (CMS) often have sensitivities to rates beyond their last payment date</value>
        [DataMember(Name="maturityDate", EmitDefaultValue=false)]
        public DateTimeOffset? MaturityDate { get; set; }

        /// <summary>
        /// The amount that is to be paid in the domestic currency on the maturity date.
        /// </summary>
        /// <value>The amount that is to be paid in the domestic currency on the maturity date.</value>
        [DataMember(Name="domAmount", EmitDefaultValue=false)]
        public decimal? DomAmount { get; set; }

        /// <summary>
        /// The domestic currency of the instrument.
        /// </summary>
        /// <value>The domestic currency of the instrument.</value>
        [DataMember(Name="domCcy", EmitDefaultValue=false)]
        public string DomCcy { get; set; }

        /// <summary>
        /// The amount that is to be paid in the foreign currency on the maturity date
        /// </summary>
        /// <value>The amount that is to be paid in the foreign currency on the maturity date</value>
        [DataMember(Name="fgnAmount", EmitDefaultValue=false)]
        public decimal? FgnAmount { get; set; }

        /// <summary>
        /// The foreign (other) currency of the instrument. In the NDF case, only payments are made in the domestic currency.              For the outright forward, currencies are exchanged. By domestic is then that of the portfolio.
        /// </summary>
        /// <value>The foreign (other) currency of the instrument. In the NDF case, only payments are made in the domestic currency.              For the outright forward, currencies are exchanged. By domestic is then that of the portfolio.</value>
        [DataMember(Name="fgnCcy", EmitDefaultValue=false)]
        public string FgnCcy { get; set; }

        /// <summary>
        /// The reference Fx Spot rate for currency pair Foreign-Domestic that was seen on the trade start date (time).
        /// </summary>
        /// <value>The reference Fx Spot rate for currency pair Foreign-Domestic that was seen on the trade start date (time).</value>
        [DataMember(Name="refSpotRate", EmitDefaultValue=false)]
        public decimal? RefSpotRate { get; set; }

        /// <summary>
        /// Is the contract an Fx-Forward of \&quot;Non-Deliverable\&quot; type, meaning a single payment in the domestic currency based on the change in fx-rate vs              a reference rate is used.
        /// </summary>
        /// <value>Is the contract an Fx-Forward of \&quot;Non-Deliverable\&quot; type, meaning a single payment in the domestic currency based on the change in fx-rate vs              a reference rate is used.</value>
        [DataMember(Name="isNdf", EmitDefaultValue=false)]
        public bool? IsNdf { get; set; }

        /// <summary>
        /// The fixing date .
        /// </summary>
        /// <value>The fixing date .</value>
        [DataMember(Name="fixingDate", EmitDefaultValue=false)]
        public DateTimeOffset? FixingDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FxForward {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  MaturityDate: ").Append(MaturityDate).Append("\n");
            sb.Append("  DomAmount: ").Append(DomAmount).Append("\n");
            sb.Append("  DomCcy: ").Append(DomCcy).Append("\n");
            sb.Append("  FgnAmount: ").Append(FgnAmount).Append("\n");
            sb.Append("  FgnCcy: ").Append(FgnCcy).Append("\n");
            sb.Append("  RefSpotRate: ").Append(RefSpotRate).Append("\n");
            sb.Append("  IsNdf: ").Append(IsNdf).Append("\n");
            sb.Append("  FixingDate: ").Append(FixingDate).Append("\n");
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
            return this.Equals(input as FxForward);
        }

        /// <summary>
        /// Returns true if FxForward instances are equal
        /// </summary>
        /// <param name="input">Instance of FxForward to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FxForward input)
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
                    this.DomAmount == input.DomAmount ||
                    (this.DomAmount != null &&
                    this.DomAmount.Equals(input.DomAmount))
                ) && base.Equals(input) && 
                (
                    this.DomCcy == input.DomCcy ||
                    (this.DomCcy != null &&
                    this.DomCcy.Equals(input.DomCcy))
                ) && base.Equals(input) && 
                (
                    this.FgnAmount == input.FgnAmount ||
                    (this.FgnAmount != null &&
                    this.FgnAmount.Equals(input.FgnAmount))
                ) && base.Equals(input) && 
                (
                    this.FgnCcy == input.FgnCcy ||
                    (this.FgnCcy != null &&
                    this.FgnCcy.Equals(input.FgnCcy))
                ) && base.Equals(input) && 
                (
                    this.RefSpotRate == input.RefSpotRate ||
                    (this.RefSpotRate != null &&
                    this.RefSpotRate.Equals(input.RefSpotRate))
                ) && base.Equals(input) && 
                (
                    this.IsNdf == input.IsNdf ||
                    (this.IsNdf != null &&
                    this.IsNdf.Equals(input.IsNdf))
                ) && base.Equals(input) && 
                (
                    this.FixingDate == input.FixingDate ||
                    (this.FixingDate != null &&
                    this.FixingDate.Equals(input.FixingDate))
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
                if (this.DomAmount != null)
                    hashCode = hashCode * 59 + this.DomAmount.GetHashCode();
                if (this.DomCcy != null)
                    hashCode = hashCode * 59 + this.DomCcy.GetHashCode();
                if (this.FgnAmount != null)
                    hashCode = hashCode * 59 + this.FgnAmount.GetHashCode();
                if (this.FgnCcy != null)
                    hashCode = hashCode * 59 + this.FgnCcy.GetHashCode();
                if (this.RefSpotRate != null)
                    hashCode = hashCode * 59 + this.RefSpotRate.GetHashCode();
                if (this.IsNdf != null)
                    hashCode = hashCode * 59 + this.IsNdf.GetHashCode();
                if (this.FixingDate != null)
                    hashCode = hashCode * 59 + this.FixingDate.GetHashCode();
                return hashCode;
            }
        }
    }

}
