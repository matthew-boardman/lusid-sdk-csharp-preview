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
    /// Defines DayOfWeek
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DayOfWeek
    {
        /// <summary>
        /// Enum Sunday for value: Sunday
        /// </summary>
        [EnumMember(Value = "Sunday")]
        Sunday = 1,

        /// <summary>
        /// Enum Monday for value: Monday
        /// </summary>
        [EnumMember(Value = "Monday")]
        Monday = 2,

        /// <summary>
        /// Enum Tuesday for value: Tuesday
        /// </summary>
        [EnumMember(Value = "Tuesday")]
        Tuesday = 3,

        /// <summary>
        /// Enum Wednesday for value: Wednesday
        /// </summary>
        [EnumMember(Value = "Wednesday")]
        Wednesday = 4,

        /// <summary>
        /// Enum Thursday for value: Thursday
        /// </summary>
        [EnumMember(Value = "Thursday")]
        Thursday = 5,

        /// <summary>
        /// Enum Friday for value: Friday
        /// </summary>
        [EnumMember(Value = "Friday")]
        Friday = 6,

        /// <summary>
        /// Enum Saturday for value: Saturday
        /// </summary>
        [EnumMember(Value = "Saturday")]
        Saturday = 7

    }

}
