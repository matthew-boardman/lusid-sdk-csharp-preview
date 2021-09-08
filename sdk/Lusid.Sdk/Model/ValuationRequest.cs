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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// Specification object for the parameters of a valuation
    /// </summary>
    [DataContract(Name = "ValuationRequest")]
    public partial class ValuationRequest : IEquatable<ValuationRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValuationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValuationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValuationRequest" /> class.
        /// </summary>
        /// <param name="recipeId">recipeId.</param>
        /// <param name="asAt">The asAt date to use.</param>
        /// <param name="metrics">The set of specifications to calculate or retrieve during the valuation and present in the results. For example:  AggregateSpec(&#39;Holding/default/PV&#39;,&#39;Sum&#39;) for returning the PV (present value) of holdings  AggregateSpec(&#39;Holding/default/Units&#39;,&#39;Sum&#39;) for returning the units of holidays  AggregateSpec(&#39;Instrument/default/LusidInstrumentId&#39;,&#39;Value&#39;) for returning the Lusid Instrument identifier (required).</param>
        /// <param name="groupBy">The set of items by which to perform grouping. This primarily matters when one or more of the metric operators is a mapping  that reduces set size, e.g. sum or proportion. The group-by statement determines the set of keys by which to break the results out..</param>
        /// <param name="filters">A set of filters to use to reduce the data found in a request. Equivalent to the &#39;where ...&#39; part of a Sql select statement.  For example, filter a set of values within a given range or matching a particular value..</param>
        /// <param name="sort">A (possibly empty/null) set of specifications for how to order the results..</param>
        /// <param name="reportCurrency">Three letter ISO currency string indicating what currency to report in for ReportCurrency denominated queries.  If not present, then the currency of the relevant portfolio will be used in its place..</param>
        /// <param name="equipWithSubtotals">Flag directing the Valuation call to populate the results with subtotals of aggregates..</param>
        /// <param name="portfolioEntityIds">The set of portfolio or portfolio group identifier(s) that is to be valued..</param>
        /// <param name="valuationSchedule">valuationSchedule.</param>
        public ValuationRequest(ResourceId recipeId = default(ResourceId), DateTimeOffset? asAt = default(DateTimeOffset?), List<AggregateSpec> metrics = default(List<AggregateSpec>), List<string> groupBy = default(List<string>), List<PropertyFilter> filters = default(List<PropertyFilter>), List<OrderBySpec> sort = default(List<OrderBySpec>), string reportCurrency = default(string), bool equipWithSubtotals = default(bool), List<PortfolioEntityId> portfolioEntityIds = default(List<PortfolioEntityId>), ValuationSchedule valuationSchedule = default(ValuationSchedule))
        {
            // to ensure "metrics" is required (not null)
            this.Metrics = metrics ?? throw new ArgumentNullException("metrics is a required property for ValuationRequest and cannot be null");
            this.RecipeId = recipeId;
            this.AsAt = asAt;
            this.GroupBy = groupBy;
            this.Filters = filters;
            this.Sort = sort;
            this.ReportCurrency = reportCurrency;
            this.EquipWithSubtotals = equipWithSubtotals;
            this.PortfolioEntityIds = portfolioEntityIds;
            this.ValuationSchedule = valuationSchedule;
        }

        /// <summary>
        /// Gets or Sets RecipeId
        /// </summary>
        [DataMember(Name = "recipeId", EmitDefaultValue = false)]
        public ResourceId RecipeId { get; set; }

        /// <summary>
        /// The asAt date to use
        /// </summary>
        /// <value>The asAt date to use</value>
        [DataMember(Name = "asAt", EmitDefaultValue = true)]
        public DateTimeOffset? AsAt { get; set; }

        /// <summary>
        /// The set of specifications to calculate or retrieve during the valuation and present in the results. For example:  AggregateSpec(&#39;Holding/default/PV&#39;,&#39;Sum&#39;) for returning the PV (present value) of holdings  AggregateSpec(&#39;Holding/default/Units&#39;,&#39;Sum&#39;) for returning the units of holidays  AggregateSpec(&#39;Instrument/default/LusidInstrumentId&#39;,&#39;Value&#39;) for returning the Lusid Instrument identifier
        /// </summary>
        /// <value>The set of specifications to calculate or retrieve during the valuation and present in the results. For example:  AggregateSpec(&#39;Holding/default/PV&#39;,&#39;Sum&#39;) for returning the PV (present value) of holdings  AggregateSpec(&#39;Holding/default/Units&#39;,&#39;Sum&#39;) for returning the units of holidays  AggregateSpec(&#39;Instrument/default/LusidInstrumentId&#39;,&#39;Value&#39;) for returning the Lusid Instrument identifier</value>
        [DataMember(Name = "metrics", IsRequired = true, EmitDefaultValue = false)]
        public List<AggregateSpec> Metrics { get; set; }

        /// <summary>
        /// The set of items by which to perform grouping. This primarily matters when one or more of the metric operators is a mapping  that reduces set size, e.g. sum or proportion. The group-by statement determines the set of keys by which to break the results out.
        /// </summary>
        /// <value>The set of items by which to perform grouping. This primarily matters when one or more of the metric operators is a mapping  that reduces set size, e.g. sum or proportion. The group-by statement determines the set of keys by which to break the results out.</value>
        [DataMember(Name = "groupBy", EmitDefaultValue = true)]
        public List<string> GroupBy { get; set; }

        /// <summary>
        /// A set of filters to use to reduce the data found in a request. Equivalent to the &#39;where ...&#39; part of a Sql select statement.  For example, filter a set of values within a given range or matching a particular value.
        /// </summary>
        /// <value>A set of filters to use to reduce the data found in a request. Equivalent to the &#39;where ...&#39; part of a Sql select statement.  For example, filter a set of values within a given range or matching a particular value.</value>
        [DataMember(Name = "filters", EmitDefaultValue = true)]
        public List<PropertyFilter> Filters { get; set; }

        /// <summary>
        /// A (possibly empty/null) set of specifications for how to order the results.
        /// </summary>
        /// <value>A (possibly empty/null) set of specifications for how to order the results.</value>
        [DataMember(Name = "sort", EmitDefaultValue = true)]
        public List<OrderBySpec> Sort { get; set; }

        /// <summary>
        /// Three letter ISO currency string indicating what currency to report in for ReportCurrency denominated queries.  If not present, then the currency of the relevant portfolio will be used in its place.
        /// </summary>
        /// <value>Three letter ISO currency string indicating what currency to report in for ReportCurrency denominated queries.  If not present, then the currency of the relevant portfolio will be used in its place.</value>
        [DataMember(Name = "reportCurrency", EmitDefaultValue = true)]
        public string ReportCurrency { get; set; }

        /// <summary>
        /// Flag directing the Valuation call to populate the results with subtotals of aggregates.
        /// </summary>
        /// <value>Flag directing the Valuation call to populate the results with subtotals of aggregates.</value>
        [DataMember(Name = "equipWithSubtotals", EmitDefaultValue = true)]
        public bool EquipWithSubtotals { get; set; }

        /// <summary>
        /// The set of portfolio or portfolio group identifier(s) that is to be valued.
        /// </summary>
        /// <value>The set of portfolio or portfolio group identifier(s) that is to be valued.</value>
        [DataMember(Name = "portfolioEntityIds", EmitDefaultValue = true)]
        public List<PortfolioEntityId> PortfolioEntityIds { get; set; }

        /// <summary>
        /// Gets or Sets ValuationSchedule
        /// </summary>
        [DataMember(Name = "valuationSchedule", EmitDefaultValue = false)]
        public ValuationSchedule ValuationSchedule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValuationRequest {\n");
            sb.Append("  RecipeId: ").Append(RecipeId).Append("\n");
            sb.Append("  AsAt: ").Append(AsAt).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  ReportCurrency: ").Append(ReportCurrency).Append("\n");
            sb.Append("  EquipWithSubtotals: ").Append(EquipWithSubtotals).Append("\n");
            sb.Append("  PortfolioEntityIds: ").Append(PortfolioEntityIds).Append("\n");
            sb.Append("  ValuationSchedule: ").Append(ValuationSchedule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as ValuationRequest);
        }

        /// <summary>
        /// Returns true if ValuationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ValuationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValuationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecipeId == input.RecipeId ||
                    (this.RecipeId != null &&
                    this.RecipeId.Equals(input.RecipeId))
                ) && 
                (
                    this.AsAt == input.AsAt ||
                    (this.AsAt != null &&
                    this.AsAt.Equals(input.AsAt))
                ) && 
                (
                    this.Metrics == input.Metrics ||
                    this.Metrics != null &&
                    input.Metrics != null &&
                    this.Metrics.SequenceEqual(input.Metrics)
                ) && 
                (
                    this.GroupBy == input.GroupBy ||
                    this.GroupBy != null &&
                    input.GroupBy != null &&
                    this.GroupBy.SequenceEqual(input.GroupBy)
                ) && 
                (
                    this.Filters == input.Filters ||
                    this.Filters != null &&
                    input.Filters != null &&
                    this.Filters.SequenceEqual(input.Filters)
                ) && 
                (
                    this.Sort == input.Sort ||
                    this.Sort != null &&
                    input.Sort != null &&
                    this.Sort.SequenceEqual(input.Sort)
                ) && 
                (
                    this.ReportCurrency == input.ReportCurrency ||
                    (this.ReportCurrency != null &&
                    this.ReportCurrency.Equals(input.ReportCurrency))
                ) && 
                (
                    this.EquipWithSubtotals == input.EquipWithSubtotals ||
                    this.EquipWithSubtotals.Equals(input.EquipWithSubtotals)
                ) && 
                (
                    this.PortfolioEntityIds == input.PortfolioEntityIds ||
                    this.PortfolioEntityIds != null &&
                    input.PortfolioEntityIds != null &&
                    this.PortfolioEntityIds.SequenceEqual(input.PortfolioEntityIds)
                ) && 
                (
                    this.ValuationSchedule == input.ValuationSchedule ||
                    (this.ValuationSchedule != null &&
                    this.ValuationSchedule.Equals(input.ValuationSchedule))
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
                if (this.RecipeId != null)
                    hashCode = hashCode * 59 + this.RecipeId.GetHashCode();
                if (this.AsAt != null)
                    hashCode = hashCode * 59 + this.AsAt.GetHashCode();
                if (this.Metrics != null)
                    hashCode = hashCode * 59 + this.Metrics.GetHashCode();
                if (this.GroupBy != null)
                    hashCode = hashCode * 59 + this.GroupBy.GetHashCode();
                if (this.Filters != null)
                    hashCode = hashCode * 59 + this.Filters.GetHashCode();
                if (this.Sort != null)
                    hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.ReportCurrency != null)
                    hashCode = hashCode * 59 + this.ReportCurrency.GetHashCode();
                hashCode = hashCode * 59 + this.EquipWithSubtotals.GetHashCode();
                if (this.PortfolioEntityIds != null)
                    hashCode = hashCode * 59 + this.PortfolioEntityIds.GetHashCode();
                if (this.ValuationSchedule != null)
                    hashCode = hashCode * 59 + this.ValuationSchedule.GetHashCode();
                return hashCode;
            }
        }

    }
}
