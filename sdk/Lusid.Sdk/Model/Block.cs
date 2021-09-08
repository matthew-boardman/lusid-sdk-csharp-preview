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
    /// A block of orders for the same instrument, intended to record for example a trader&#39;s aggregation  of outstanding orders at a given time.
    /// </summary>
    [DataContract(Name = "Block")]
    public partial class Block : IEquatable<Block>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Block" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Block() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Block" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="orderIds">The related order ids. (required).</param>
        /// <param name="properties">Client-defined properties associated with this block..</param>
        /// <param name="instrumentIdentifiers">The instrument ordered. (required).</param>
        /// <param name="lusidInstrumentId">The LUSID instrument id for the instrument ordered. (required).</param>
        /// <param name="quantity">The total quantity of given instrument ordered. (required).</param>
        /// <param name="side">The client&#39;s representation of the block&#39;s side (buy, sell, short, etc) (required).</param>
        /// <param name="type">The block order&#39;s type (examples: Limit, Market, ...) (required).</param>
        /// <param name="timeInForce">The block orders&#39; time in force (examples: Day, GoodTilCancel, ...) (required).</param>
        /// <param name="createdDate">The date on which the block was made (required).</param>
        /// <param name="limitPrice">limitPrice.</param>
        /// <param name="stopPrice">stopPrice.</param>
        /// <param name="version">version.</param>
        /// <param name="links">Collection of links..</param>
        public Block(ResourceId id = default(ResourceId), List<ResourceId> orderIds = default(List<ResourceId>), Dictionary<string, PerpetualProperty> properties = default(Dictionary<string, PerpetualProperty>), Dictionary<string, string> instrumentIdentifiers = default(Dictionary<string, string>), string lusidInstrumentId = default(string), decimal quantity = default(decimal), string side = default(string), string type = default(string), string timeInForce = default(string), DateTimeOffset createdDate = default(DateTimeOffset), CurrencyAndAmount limitPrice = default(CurrencyAndAmount), CurrencyAndAmount stopPrice = default(CurrencyAndAmount), Version version = default(Version), List<Link> links = default(List<Link>))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for Block and cannot be null");
            // to ensure "orderIds" is required (not null)
            this.OrderIds = orderIds ?? throw new ArgumentNullException("orderIds is a required property for Block and cannot be null");
            // to ensure "instrumentIdentifiers" is required (not null)
            this.InstrumentIdentifiers = instrumentIdentifiers ?? throw new ArgumentNullException("instrumentIdentifiers is a required property for Block and cannot be null");
            // to ensure "lusidInstrumentId" is required (not null)
            this.LusidInstrumentId = lusidInstrumentId ?? throw new ArgumentNullException("lusidInstrumentId is a required property for Block and cannot be null");
            this.Quantity = quantity;
            // to ensure "side" is required (not null)
            this.Side = side ?? throw new ArgumentNullException("side is a required property for Block and cannot be null");
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for Block and cannot be null");
            // to ensure "timeInForce" is required (not null)
            this.TimeInForce = timeInForce ?? throw new ArgumentNullException("timeInForce is a required property for Block and cannot be null");
            this.CreatedDate = createdDate;
            this.Properties = properties;
            this.LimitPrice = limitPrice;
            this.StopPrice = stopPrice;
            this.Version = version;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// The related order ids.
        /// </summary>
        /// <value>The related order ids.</value>
        [DataMember(Name = "orderIds", IsRequired = true, EmitDefaultValue = false)]
        public List<ResourceId> OrderIds { get; set; }

        /// <summary>
        /// Client-defined properties associated with this block.
        /// </summary>
        /// <value>Client-defined properties associated with this block.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, PerpetualProperty> Properties { get; set; }

        /// <summary>
        /// The instrument ordered.
        /// </summary>
        /// <value>The instrument ordered.</value>
        [DataMember(Name = "instrumentIdentifiers", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> InstrumentIdentifiers { get; set; }

        /// <summary>
        /// The LUSID instrument id for the instrument ordered.
        /// </summary>
        /// <value>The LUSID instrument id for the instrument ordered.</value>
        [DataMember(Name = "lusidInstrumentId", IsRequired = true, EmitDefaultValue = false)]
        public string LusidInstrumentId { get; set; }

        /// <summary>
        /// The total quantity of given instrument ordered.
        /// </summary>
        /// <value>The total quantity of given instrument ordered.</value>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The client&#39;s representation of the block&#39;s side (buy, sell, short, etc)
        /// </summary>
        /// <value>The client&#39;s representation of the block&#39;s side (buy, sell, short, etc)</value>
        [DataMember(Name = "side", IsRequired = true, EmitDefaultValue = false)]
        public string Side { get; set; }

        /// <summary>
        /// The block order&#39;s type (examples: Limit, Market, ...)
        /// </summary>
        /// <value>The block order&#39;s type (examples: Limit, Market, ...)</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The block orders&#39; time in force (examples: Day, GoodTilCancel, ...)
        /// </summary>
        /// <value>The block orders&#39; time in force (examples: Day, GoodTilCancel, ...)</value>
        [DataMember(Name = "timeInForce", IsRequired = true, EmitDefaultValue = false)]
        public string TimeInForce { get; set; }

        /// <summary>
        /// The date on which the block was made
        /// </summary>
        /// <value>The date on which the block was made</value>
        [DataMember(Name = "createdDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or Sets LimitPrice
        /// </summary>
        [DataMember(Name = "limitPrice", EmitDefaultValue = false)]
        public CurrencyAndAmount LimitPrice { get; set; }

        /// <summary>
        /// Gets or Sets StopPrice
        /// </summary>
        [DataMember(Name = "stopPrice", EmitDefaultValue = false)]
        public CurrencyAndAmount StopPrice { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public Version Version { get; set; }

        /// <summary>
        /// Collection of links.
        /// </summary>
        /// <value>Collection of links.</value>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Block {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrderIds: ").Append(OrderIds).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  InstrumentIdentifiers: ").Append(InstrumentIdentifiers).Append("\n");
            sb.Append("  LusidInstrumentId: ").Append(LusidInstrumentId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  LimitPrice: ").Append(LimitPrice).Append("\n");
            sb.Append("  StopPrice: ").Append(StopPrice).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as Block);
        }

        /// <summary>
        /// Returns true if Block instances are equal
        /// </summary>
        /// <param name="input">Instance of Block to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Block input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OrderIds == input.OrderIds ||
                    this.OrderIds != null &&
                    input.OrderIds != null &&
                    this.OrderIds.SequenceEqual(input.OrderIds)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.InstrumentIdentifiers == input.InstrumentIdentifiers ||
                    this.InstrumentIdentifiers != null &&
                    input.InstrumentIdentifiers != null &&
                    this.InstrumentIdentifiers.SequenceEqual(input.InstrumentIdentifiers)
                ) && 
                (
                    this.LusidInstrumentId == input.LusidInstrumentId ||
                    (this.LusidInstrumentId != null &&
                    this.LusidInstrumentId.Equals(input.LusidInstrumentId))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.TimeInForce == input.TimeInForce ||
                    (this.TimeInForce != null &&
                    this.TimeInForce.Equals(input.TimeInForce))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.LimitPrice == input.LimitPrice ||
                    (this.LimitPrice != null &&
                    this.LimitPrice.Equals(input.LimitPrice))
                ) && 
                (
                    this.StopPrice == input.StopPrice ||
                    (this.StopPrice != null &&
                    this.StopPrice.Equals(input.StopPrice))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OrderIds != null)
                    hashCode = hashCode * 59 + this.OrderIds.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.InstrumentIdentifiers != null)
                    hashCode = hashCode * 59 + this.InstrumentIdentifiers.GetHashCode();
                if (this.LusidInstrumentId != null)
                    hashCode = hashCode * 59 + this.LusidInstrumentId.GetHashCode();
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TimeInForce != null)
                    hashCode = hashCode * 59 + this.TimeInForce.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.LimitPrice != null)
                    hashCode = hashCode * 59 + this.LimitPrice.GetHashCode();
                if (this.StopPrice != null)
                    hashCode = hashCode * 59 + this.StopPrice.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
