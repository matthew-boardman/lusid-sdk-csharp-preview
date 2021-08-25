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
    /// The combination of a library to use and a model in that library that defines which pricing code will evaluate instruments  having a particular type/class. This allows us to control the model type and library for a given instrument.
    /// </summary>
    [DataContract]
    public partial class ModelSelection :  IEquatable<ModelSelection>
    {
        /// <summary>
        /// The available values are: Lusid, RefinitivQps, RefinitivTracsWeb, VolMaster, IsdaCds
        /// </summary>
        /// <value>The available values are: Lusid, RefinitivQps, RefinitivTracsWeb, VolMaster, IsdaCds</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LibraryEnum
        {
            /// <summary>
            /// Enum Lusid for value: Lusid
            /// </summary>
            [EnumMember(Value = "Lusid")]
            Lusid = 1,

            /// <summary>
            /// Enum RefinitivQps for value: RefinitivQps
            /// </summary>
            [EnumMember(Value = "RefinitivQps")]
            RefinitivQps = 2,

            /// <summary>
            /// Enum RefinitivTracsWeb for value: RefinitivTracsWeb
            /// </summary>
            [EnumMember(Value = "RefinitivTracsWeb")]
            RefinitivTracsWeb = 3,

            /// <summary>
            /// Enum VolMaster for value: VolMaster
            /// </summary>
            [EnumMember(Value = "VolMaster")]
            VolMaster = 4,

            /// <summary>
            /// Enum IsdaCds for value: IsdaCds
            /// </summary>
            [EnumMember(Value = "IsdaCds")]
            IsdaCds = 5

        }

        /// <summary>
        /// The available values are: Lusid, RefinitivQps, RefinitivTracsWeb, VolMaster, IsdaCds
        /// </summary>
        /// <value>The available values are: Lusid, RefinitivQps, RefinitivTracsWeb, VolMaster, IsdaCds</value>
        [DataMember(Name="library", EmitDefaultValue=false)]
        public LibraryEnum Library { get; set; }
        /// <summary>
        /// The available values are: SimpleStatic, Discounting, VendorDefault, BlackScholes, ConstantTimeValueOfMoney, Bachelier, ForwardWithPoints, ForwardWithPointsUndiscounted, ForwardSpecifiedRate, ForwardSpecifiedRateUndiscounted, IndexNav, IndexPrice, InlinedIndex
        /// </summary>
        /// <value>The available values are: SimpleStatic, Discounting, VendorDefault, BlackScholes, ConstantTimeValueOfMoney, Bachelier, ForwardWithPoints, ForwardWithPointsUndiscounted, ForwardSpecifiedRate, ForwardSpecifiedRateUndiscounted, IndexNav, IndexPrice, InlinedIndex</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModelEnum
        {
            /// <summary>
            /// Enum SimpleStatic for value: SimpleStatic
            /// </summary>
            [EnumMember(Value = "SimpleStatic")]
            SimpleStatic = 1,

            /// <summary>
            /// Enum Discounting for value: Discounting
            /// </summary>
            [EnumMember(Value = "Discounting")]
            Discounting = 2,

            /// <summary>
            /// Enum VendorDefault for value: VendorDefault
            /// </summary>
            [EnumMember(Value = "VendorDefault")]
            VendorDefault = 3,

            /// <summary>
            /// Enum BlackScholes for value: BlackScholes
            /// </summary>
            [EnumMember(Value = "BlackScholes")]
            BlackScholes = 4,

            /// <summary>
            /// Enum ConstantTimeValueOfMoney for value: ConstantTimeValueOfMoney
            /// </summary>
            [EnumMember(Value = "ConstantTimeValueOfMoney")]
            ConstantTimeValueOfMoney = 5,

            /// <summary>
            /// Enum Bachelier for value: Bachelier
            /// </summary>
            [EnumMember(Value = "Bachelier")]
            Bachelier = 6,

            /// <summary>
            /// Enum ForwardWithPoints for value: ForwardWithPoints
            /// </summary>
            [EnumMember(Value = "ForwardWithPoints")]
            ForwardWithPoints = 7,

            /// <summary>
            /// Enum ForwardWithPointsUndiscounted for value: ForwardWithPointsUndiscounted
            /// </summary>
            [EnumMember(Value = "ForwardWithPointsUndiscounted")]
            ForwardWithPointsUndiscounted = 8,

            /// <summary>
            /// Enum ForwardSpecifiedRate for value: ForwardSpecifiedRate
            /// </summary>
            [EnumMember(Value = "ForwardSpecifiedRate")]
            ForwardSpecifiedRate = 9,

            /// <summary>
            /// Enum ForwardSpecifiedRateUndiscounted for value: ForwardSpecifiedRateUndiscounted
            /// </summary>
            [EnumMember(Value = "ForwardSpecifiedRateUndiscounted")]
            ForwardSpecifiedRateUndiscounted = 10,

            /// <summary>
            /// Enum IndexNav for value: IndexNav
            /// </summary>
            [EnumMember(Value = "IndexNav")]
            IndexNav = 11,

            /// <summary>
            /// Enum IndexPrice for value: IndexPrice
            /// </summary>
            [EnumMember(Value = "IndexPrice")]
            IndexPrice = 12,

            /// <summary>
            /// Enum InlinedIndex for value: InlinedIndex
            /// </summary>
            [EnumMember(Value = "InlinedIndex")]
            InlinedIndex = 13

        }

        /// <summary>
        /// The available values are: SimpleStatic, Discounting, VendorDefault, BlackScholes, ConstantTimeValueOfMoney, Bachelier, ForwardWithPoints, ForwardWithPointsUndiscounted, ForwardSpecifiedRate, ForwardSpecifiedRateUndiscounted, IndexNav, IndexPrice, InlinedIndex
        /// </summary>
        /// <value>The available values are: SimpleStatic, Discounting, VendorDefault, BlackScholes, ConstantTimeValueOfMoney, Bachelier, ForwardWithPoints, ForwardWithPointsUndiscounted, ForwardSpecifiedRate, ForwardSpecifiedRateUndiscounted, IndexNav, IndexPrice, InlinedIndex</value>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public ModelEnum Model { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelSelection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModelSelection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelSelection" /> class.
        /// </summary>
        /// <param name="library">The available values are: Lusid, RefinitivQps, RefinitivTracsWeb, VolMaster, IsdaCds (required).</param>
        /// <param name="model">The available values are: SimpleStatic, Discounting, VendorDefault, BlackScholes, ConstantTimeValueOfMoney, Bachelier, ForwardWithPoints, ForwardWithPointsUndiscounted, ForwardSpecifiedRate, ForwardSpecifiedRateUndiscounted, IndexNav, IndexPrice, InlinedIndex (required).</param>
        public ModelSelection(LibraryEnum library = default(LibraryEnum), ModelEnum model = default(ModelEnum))
        {
            // to ensure "library" is required (not null)
            if (library == null)
            {
                throw new InvalidDataException("library is a required property for ModelSelection and cannot be null");
            }
            else
            {
                this.Library = library;
            }
            
            // to ensure "model" is required (not null)
            if (model == null)
            {
                throw new InvalidDataException("model is a required property for ModelSelection and cannot be null");
            }
            else
            {
                this.Model = model;
            }
            
        }
        


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelSelection {\n");
            sb.Append("  Library: ").Append(Library).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
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
            return this.Equals(input as ModelSelection);
        }

        /// <summary>
        /// Returns true if ModelSelection instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelSelection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelSelection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Library == input.Library ||
                    (this.Library != null &&
                    this.Library.Equals(input.Library))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
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
                if (this.Library != null)
                    hashCode = hashCode * 59 + this.Library.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                return hashCode;
            }
        }
    }

}
