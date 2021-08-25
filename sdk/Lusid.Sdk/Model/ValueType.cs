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
    /// A list of types, familiar to the Ui, that define the expected input or output types on a piece of data
    /// </summary>
    /// <value>A list of types, familiar to the Ui, that define the expected input or output types on a piece of data</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ValueType
    {
        /// <summary>
        /// Enum String for value: String
        /// </summary>
        [EnumMember(Value = "String")]
        String = 1,

        /// <summary>
        /// Enum Int for value: Int
        /// </summary>
        [EnumMember(Value = "Int")]
        Int = 2,

        /// <summary>
        /// Enum Decimal for value: Decimal
        /// </summary>
        [EnumMember(Value = "Decimal")]
        Decimal = 3,

        /// <summary>
        /// Enum DateTime for value: DateTime
        /// </summary>
        [EnumMember(Value = "DateTime")]
        DateTime = 4,

        /// <summary>
        /// Enum Boolean for value: Boolean
        /// </summary>
        [EnumMember(Value = "Boolean")]
        Boolean = 5,

        /// <summary>
        /// Enum Map for value: Map
        /// </summary>
        [EnumMember(Value = "Map")]
        Map = 6,

        /// <summary>
        /// Enum List for value: List
        /// </summary>
        [EnumMember(Value = "List")]
        List = 7,

        /// <summary>
        /// Enum PropertyArray for value: PropertyArray
        /// </summary>
        [EnumMember(Value = "PropertyArray")]
        PropertyArray = 8,

        /// <summary>
        /// Enum Percentage for value: Percentage
        /// </summary>
        [EnumMember(Value = "Percentage")]
        Percentage = 9,

        /// <summary>
        /// Enum Code for value: Code
        /// </summary>
        [EnumMember(Value = "Code")]
        Code = 10,

        /// <summary>
        /// Enum Id for value: Id
        /// </summary>
        [EnumMember(Value = "Id")]
        Id = 11,

        /// <summary>
        /// Enum Uri for value: Uri
        /// </summary>
        [EnumMember(Value = "Uri")]
        Uri = 12,

        /// <summary>
        /// Enum CurrencyAndAmount for value: CurrencyAndAmount
        /// </summary>
        [EnumMember(Value = "CurrencyAndAmount")]
        CurrencyAndAmount = 13,

        /// <summary>
        /// Enum TradePrice for value: TradePrice
        /// </summary>
        [EnumMember(Value = "TradePrice")]
        TradePrice = 14,

        /// <summary>
        /// Enum Currency for value: Currency
        /// </summary>
        [EnumMember(Value = "Currency")]
        Currency = 15,

        /// <summary>
        /// Enum MetricValue for value: MetricValue
        /// </summary>
        [EnumMember(Value = "MetricValue")]
        MetricValue = 16,

        /// <summary>
        /// Enum ResourceId for value: ResourceId
        /// </summary>
        [EnumMember(Value = "ResourceId")]
        ResourceId = 17,

        /// <summary>
        /// Enum ResultValue for value: ResultValue
        /// </summary>
        [EnumMember(Value = "ResultValue")]
        ResultValue = 18,

        /// <summary>
        /// Enum CutLocalTime for value: CutLocalTime
        /// </summary>
        [EnumMember(Value = "CutLocalTime")]
        CutLocalTime = 19,

        /// <summary>
        /// Enum DateOrCutLabel for value: DateOrCutLabel
        /// </summary>
        [EnumMember(Value = "DateOrCutLabel")]
        DateOrCutLabel = 20

    }

}
