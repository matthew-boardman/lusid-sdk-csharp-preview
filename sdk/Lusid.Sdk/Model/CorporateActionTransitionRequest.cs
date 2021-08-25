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
    /// A &#39;transition&#39; within a corporate action, representing a set of output movements paired to a single input position
    /// </summary>
    [DataContract]
    public partial class CorporateActionTransitionRequest :  IEquatable<CorporateActionTransitionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorporateActionTransitionRequest" /> class.
        /// </summary>
        /// <param name="inputTransition">inputTransition.</param>
        /// <param name="outputTransitions">outputTransitions.</param>
        public CorporateActionTransitionRequest(CorporateActionTransitionComponentRequest inputTransition = default(CorporateActionTransitionComponentRequest), List<CorporateActionTransitionComponentRequest> outputTransitions = default(List<CorporateActionTransitionComponentRequest>))
        {
            this.OutputTransitions = outputTransitions;
            this.InputTransition = inputTransition;
            this.OutputTransitions = outputTransitions;
        }
        
        /// <summary>
        /// Gets or Sets InputTransition
        /// </summary>
        [DataMember(Name="inputTransition", EmitDefaultValue=false)]
        public CorporateActionTransitionComponentRequest InputTransition { get; set; }

        /// <summary>
        /// Gets or Sets OutputTransitions
        /// </summary>
        [DataMember(Name="outputTransitions", EmitDefaultValue=true)]
        public List<CorporateActionTransitionComponentRequest> OutputTransitions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CorporateActionTransitionRequest {\n");
            sb.Append("  InputTransition: ").Append(InputTransition).Append("\n");
            sb.Append("  OutputTransitions: ").Append(OutputTransitions).Append("\n");
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
            return this.Equals(input as CorporateActionTransitionRequest);
        }

        /// <summary>
        /// Returns true if CorporateActionTransitionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CorporateActionTransitionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CorporateActionTransitionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InputTransition == input.InputTransition ||
                    (this.InputTransition != null &&
                    this.InputTransition.Equals(input.InputTransition))
                ) && 
                (
                    this.OutputTransitions == input.OutputTransitions ||
                    this.OutputTransitions != null &&
                    input.OutputTransitions != null &&
                    this.OutputTransitions.SequenceEqual(input.OutputTransitions)
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
                if (this.InputTransition != null)
                    hashCode = hashCode * 59 + this.InputTransition.GetHashCode();
                if (this.OutputTransitions != null)
                    hashCode = hashCode * 59 + this.OutputTransitions.GetHashCode();
                return hashCode;
            }
        }
    }

}
