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
    /// A set of conventions that describe the conventions for calculation of payments made on rates interbank lending and similar.  Based on ISDA 2006 conventions and similar documentation. Please see the knowledge base for further documentation.
    /// </summary>
    [DataContract]
    public partial class IndexConvention :  IEquatable<IndexConvention>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexConvention" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IndexConvention() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexConvention" /> class.
        /// </summary>
        /// <param name="fixingReference">The reference rate name for fixings (required).</param>
        /// <param name="publicationDayLag">Number of days between spot and publication of the rate. (required).</param>
        /// <param name="paymentTenor">The tenor of the payment. For an OIS index this is always 1 day. For other indices, e.g. LIBOR it will have a variable tenor typically between 1 day and 1 year. (required).</param>
        /// <param name="dayCountConvention">when calculating the fraction of a year between two dates, what convention is used to represent the number of days in a year              and difference between them.  Supported string (enumeration) values are: [Actual360, Act360, MoneyMarket, Actual365, Act365, Thirty360, ThirtyU360, Bond, ThirtyE360, EuroBond, ActualActual, ActAct, ActActIsda, ActActIsma, ActActIcma, OneOne, Act364, Act365F, Act365L, Act365_25, Act252, Bus252, NL360, NL365]. (required).</param>
        /// <param name="currency">Currency of the index convention. (required).</param>
        /// <param name="scope">The scope used when updating or inserting the convention..</param>
        /// <param name="code">The code of the convention..</param>
        public IndexConvention(string fixingReference = default(string), int? publicationDayLag = default(int?), string paymentTenor = default(string), string dayCountConvention = default(string), string currency = default(string), string scope = default(string), string code = default(string))
        {
            // to ensure "fixingReference" is required (not null)
            if (fixingReference == null)
            {
                throw new InvalidDataException("fixingReference is a required property for IndexConvention and cannot be null");
            }
            else
            {
                this.FixingReference = fixingReference;
            }
            
            // to ensure "publicationDayLag" is required (not null)
            if (publicationDayLag == null)
            {
                throw new InvalidDataException("publicationDayLag is a required property for IndexConvention and cannot be null");
            }
            else
            {
                this.PublicationDayLag = publicationDayLag;
            }
            
            // to ensure "paymentTenor" is required (not null)
            if (paymentTenor == null)
            {
                throw new InvalidDataException("paymentTenor is a required property for IndexConvention and cannot be null");
            }
            else
            {
                this.PaymentTenor = paymentTenor;
            }
            
            // to ensure "dayCountConvention" is required (not null)
            if (dayCountConvention == null)
            {
                throw new InvalidDataException("dayCountConvention is a required property for IndexConvention and cannot be null");
            }
            else
            {
                this.DayCountConvention = dayCountConvention;
            }
            
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for IndexConvention and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }
            
            this.Scope = scope;
            this.Code = code;
            this.Scope = scope;
            this.Code = code;
        }
        
        /// <summary>
        /// The reference rate name for fixings
        /// </summary>
        /// <value>The reference rate name for fixings</value>
        [DataMember(Name="fixingReference", EmitDefaultValue=false)]
        public string FixingReference { get; set; }

        /// <summary>
        /// Number of days between spot and publication of the rate.
        /// </summary>
        /// <value>Number of days between spot and publication of the rate.</value>
        [DataMember(Name="publicationDayLag", EmitDefaultValue=false)]
        public int? PublicationDayLag { get; set; }

        /// <summary>
        /// The tenor of the payment. For an OIS index this is always 1 day. For other indices, e.g. LIBOR it will have a variable tenor typically between 1 day and 1 year.
        /// </summary>
        /// <value>The tenor of the payment. For an OIS index this is always 1 day. For other indices, e.g. LIBOR it will have a variable tenor typically between 1 day and 1 year.</value>
        [DataMember(Name="paymentTenor", EmitDefaultValue=false)]
        public string PaymentTenor { get; set; }

        /// <summary>
        /// when calculating the fraction of a year between two dates, what convention is used to represent the number of days in a year              and difference between them.  Supported string (enumeration) values are: [Actual360, Act360, MoneyMarket, Actual365, Act365, Thirty360, ThirtyU360, Bond, ThirtyE360, EuroBond, ActualActual, ActAct, ActActIsda, ActActIsma, ActActIcma, OneOne, Act364, Act365F, Act365L, Act365_25, Act252, Bus252, NL360, NL365].
        /// </summary>
        /// <value>when calculating the fraction of a year between two dates, what convention is used to represent the number of days in a year              and difference between them.  Supported string (enumeration) values are: [Actual360, Act360, MoneyMarket, Actual365, Act365, Thirty360, ThirtyU360, Bond, ThirtyE360, EuroBond, ActualActual, ActAct, ActActIsda, ActActIsma, ActActIcma, OneOne, Act364, Act365F, Act365L, Act365_25, Act252, Bus252, NL360, NL365].</value>
        [DataMember(Name="dayCountConvention", EmitDefaultValue=false)]
        public string DayCountConvention { get; set; }

        /// <summary>
        /// Currency of the index convention.
        /// </summary>
        /// <value>Currency of the index convention.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// The scope used when updating or inserting the convention.
        /// </summary>
        /// <value>The scope used when updating or inserting the convention.</value>
        [DataMember(Name="scope", EmitDefaultValue=true)]
        public string Scope { get; set; }

        /// <summary>
        /// The code of the convention.
        /// </summary>
        /// <value>The code of the convention.</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IndexConvention {\n");
            sb.Append("  FixingReference: ").Append(FixingReference).Append("\n");
            sb.Append("  PublicationDayLag: ").Append(PublicationDayLag).Append("\n");
            sb.Append("  PaymentTenor: ").Append(PaymentTenor).Append("\n");
            sb.Append("  DayCountConvention: ").Append(DayCountConvention).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(input as IndexConvention);
        }

        /// <summary>
        /// Returns true if IndexConvention instances are equal
        /// </summary>
        /// <param name="input">Instance of IndexConvention to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndexConvention input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FixingReference == input.FixingReference ||
                    (this.FixingReference != null &&
                    this.FixingReference.Equals(input.FixingReference))
                ) && 
                (
                    this.PublicationDayLag == input.PublicationDayLag ||
                    (this.PublicationDayLag != null &&
                    this.PublicationDayLag.Equals(input.PublicationDayLag))
                ) && 
                (
                    this.PaymentTenor == input.PaymentTenor ||
                    (this.PaymentTenor != null &&
                    this.PaymentTenor.Equals(input.PaymentTenor))
                ) && 
                (
                    this.DayCountConvention == input.DayCountConvention ||
                    (this.DayCountConvention != null &&
                    this.DayCountConvention.Equals(input.DayCountConvention))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                if (this.FixingReference != null)
                    hashCode = hashCode * 59 + this.FixingReference.GetHashCode();
                if (this.PublicationDayLag != null)
                    hashCode = hashCode * 59 + this.PublicationDayLag.GetHashCode();
                if (this.PaymentTenor != null)
                    hashCode = hashCode * 59 + this.PaymentTenor.GetHashCode();
                if (this.DayCountConvention != null)
                    hashCode = hashCode * 59 + this.DayCountConvention.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                return hashCode;
            }
        }
    }

}
