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
    /// An item of structured market data that is to be inserted into Lusid. This will typically be a Json or Xml document that  contains a set of market quotes (tradables) that can be used to construct a composite view of a market property such as the  interest rates over time; commonly referred to as an interest rate, projection or discount curve. Other examples include  volatility surfaces and credit spread curves.
    /// </summary>
    [DataContract]
    public partial class StructuredMarketData :  IEquatable<StructuredMarketData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredMarketData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StructuredMarketData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredMarketData" /> class.
        /// </summary>
        /// <param name="documentFormat">The format of the accompanying document. (required).</param>
        /// <param name="version">The semantic version of the document format; MAJOR.MINOR.PATCH.</param>
        /// <param name="name">The name or description for the document.</param>
        /// <param name="document">The document that will be stored (or retrieved) and which describes a structured market data entity such as a credit or interest rate curve (required).</param>
        public StructuredMarketData(string documentFormat = default(string), string version = default(string), string name = default(string), string document = default(string))
        {
            // to ensure "documentFormat" is required (not null)
            if (documentFormat == null)
            {
                throw new InvalidDataException("documentFormat is a required property for StructuredMarketData and cannot be null");
            }
            else
            {
                this.DocumentFormat = documentFormat;
            }
            
            this.Version = version;
            this.Name = name;
            // to ensure "document" is required (not null)
            if (document == null)
            {
                throw new InvalidDataException("document is a required property for StructuredMarketData and cannot be null");
            }
            else
            {
                this.Document = document;
            }
            
            this.Version = version;
            this.Name = name;
        }
        
        /// <summary>
        /// The format of the accompanying document.
        /// </summary>
        /// <value>The format of the accompanying document.</value>
        [DataMember(Name="documentFormat", EmitDefaultValue=false)]
        public string DocumentFormat { get; set; }

        /// <summary>
        /// The semantic version of the document format; MAJOR.MINOR.PATCH
        /// </summary>
        /// <value>The semantic version of the document format; MAJOR.MINOR.PATCH</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public string Version { get; set; }

        /// <summary>
        /// The name or description for the document
        /// </summary>
        /// <value>The name or description for the document</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// The document that will be stored (or retrieved) and which describes a structured market data entity such as a credit or interest rate curve
        /// </summary>
        /// <value>The document that will be stored (or retrieved) and which describes a structured market data entity such as a credit or interest rate curve</value>
        [DataMember(Name="document", EmitDefaultValue=false)]
        public string Document { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StructuredMarketData {\n");
            sb.Append("  DocumentFormat: ").Append(DocumentFormat).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
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
            return this.Equals(input as StructuredMarketData);
        }

        /// <summary>
        /// Returns true if StructuredMarketData instances are equal
        /// </summary>
        /// <param name="input">Instance of StructuredMarketData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StructuredMarketData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentFormat == input.DocumentFormat ||
                    (this.DocumentFormat != null &&
                    this.DocumentFormat.Equals(input.DocumentFormat))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Document == input.Document ||
                    (this.Document != null &&
                    this.Document.Equals(input.Document))
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
                if (this.DocumentFormat != null)
                    hashCode = hashCode * 59 + this.DocumentFormat.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Document != null)
                    hashCode = hashCode * 59 + this.Document.GetHashCode();
                return hashCode;
            }
        }
    }

}
