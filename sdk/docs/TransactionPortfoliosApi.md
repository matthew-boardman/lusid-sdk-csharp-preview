# Lusid.Sdk.Api.TransactionPortfoliosApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdjustHoldings**](TransactionPortfoliosApi.md#adjustholdings) | **POST** /api/transactionportfolios/{scope}/{code}/holdings | AdjustHoldings: Adjust holdings
[**BuildTransactions**](TransactionPortfoliosApi.md#buildtransactions) | **POST** /api/transactionportfolios/{scope}/{code}/transactions/$build | BuildTransactions: Build transactions
[**CancelAdjustHoldings**](TransactionPortfoliosApi.md#canceladjustholdings) | **DELETE** /api/transactionportfolios/{scope}/{code}/holdings | CancelAdjustHoldings: Cancel adjust holdings
[**CancelTransactions**](TransactionPortfoliosApi.md#canceltransactions) | **DELETE** /api/transactionportfolios/{scope}/{code}/transactions | CancelTransactions: Cancel transactions
[**CreatePortfolio**](TransactionPortfoliosApi.md#createportfolio) | **POST** /api/transactionportfolios/{scope} | CreatePortfolio: Create portfolio
[**DeletePropertiesFromTransaction**](TransactionPortfoliosApi.md#deletepropertiesfromtransaction) | **DELETE** /api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/properties | DeletePropertiesFromTransaction: Delete properties from transaction
[**GetA2BData**](TransactionPortfoliosApi.md#geta2bdata) | **GET** /api/transactionportfolios/{scope}/{code}/a2b | [EXPERIMENTAL] GetA2BData: Get A2B data
[**GetA2BMovements**](TransactionPortfoliosApi.md#geta2bmovements) | **GET** /api/transactionportfolios/{scope}/{code}/a2bmovements | [EXPERIMENTAL] GetA2BMovements: Get an A2B report at the movement level for the given portfolio.
[**GetBucketedCashFlows**](TransactionPortfoliosApi.md#getbucketedcashflows) | **POST** /api/transactionportfolios/{scope}/{code}/bucketedCashFlows | [EXPERIMENTAL] GetBucketedCashFlows: Get bucketed cash flows from a list of portfolios
[**GetDetails**](TransactionPortfoliosApi.md#getdetails) | **GET** /api/transactionportfolios/{scope}/{code}/details | GetDetails: Get details
[**GetHoldings**](TransactionPortfoliosApi.md#getholdings) | **GET** /api/transactionportfolios/{scope}/{code}/holdings | GetHoldings: Get holdings
[**GetHoldingsAdjustment**](TransactionPortfoliosApi.md#getholdingsadjustment) | **GET** /api/transactionportfolios/{scope}/{code}/holdingsadjustments/{effectiveAt} | GetHoldingsAdjustment: Get holdings adjustment
[**GetHoldingsWithOrders**](TransactionPortfoliosApi.md#getholdingswithorders) | **GET** /api/transactionportfolios/{scope}/{code}/holdingsWithOrders | [EXPERIMENTAL] GetHoldingsWithOrders: Get holdings with orders
[**GetPortfolioCashFlows**](TransactionPortfoliosApi.md#getportfoliocashflows) | **GET** /api/transactionportfolios/{scope}/{code}/cashflows | [BETA] GetPortfolioCashFlows: Get portfolio cash flows
[**GetPortfolioCashLadder**](TransactionPortfoliosApi.md#getportfoliocashladder) | **GET** /api/transactionportfolios/{scope}/{code}/cashladder | [EXPERIMENTAL] GetPortfolioCashLadder: Get portfolio cash ladder
[**GetPortfolioCashStatement**](TransactionPortfoliosApi.md#getportfoliocashstatement) | **GET** /api/transactionportfolios/{scope}/{code}/cashstatement | [EARLY ACCESS] GetPortfolioCashStatement: Get portfolio cash statement
[**GetTransactions**](TransactionPortfoliosApi.md#gettransactions) | **GET** /api/transactionportfolios/{scope}/{code}/transactions | GetTransactions: Get transactions
[**GetUpsertablePortfolioCashFlows**](TransactionPortfoliosApi.md#getupsertableportfoliocashflows) | **GET** /api/transactionportfolios/{scope}/{code}/upsertablecashflows | [BETA] GetUpsertablePortfolioCashFlows: Get upsertable portfolio cash flows.
[**ListHoldingsAdjustments**](TransactionPortfoliosApi.md#listholdingsadjustments) | **GET** /api/transactionportfolios/{scope}/{code}/holdingsadjustments | ListHoldingsAdjustments: List holdings adjustments
[**LookThroughTransactions**](TransactionPortfoliosApi.md#lookthroughtransactions) | **GET** /api/transactionportfolios/{scope}/{code}/transactions/$lookthrough | [EXPERIMENTAL] LookThroughTransactions: Look through transactions
[**PatchPortfolioDetails**](TransactionPortfoliosApi.md#patchportfoliodetails) | **PATCH** /api/transactionportfolios/{scope}/{code}/details | [EXPERIMENTAL] PatchPortfolioDetails: Patch portfolio details
[**ResolveInstrument**](TransactionPortfoliosApi.md#resolveinstrument) | **POST** /api/transactionportfolios/{scope}/{code}/$resolve | [EARLY ACCESS] ResolveInstrument: Resolve instrument
[**SetHoldings**](TransactionPortfoliosApi.md#setholdings) | **PUT** /api/transactionportfolios/{scope}/{code}/holdings | SetHoldings: Set holdings
[**UpsertPortfolioDetails**](TransactionPortfoliosApi.md#upsertportfoliodetails) | **POST** /api/transactionportfolios/{scope}/{code}/details | UpsertPortfolioDetails: Upsert portfolio details
[**UpsertTransactionProperties**](TransactionPortfoliosApi.md#upserttransactionproperties) | **POST** /api/transactionportfolios/{scope}/{code}/transactions/{transactionId}/properties | UpsertTransactionProperties: Upsert transaction properties
[**UpsertTransactions**](TransactionPortfoliosApi.md#upserttransactions) | **POST** /api/transactionportfolios/{scope}/{code}/transactions | UpsertTransactions: Upsert transactions


<a name="adjustholdings"></a>
# **AdjustHoldings**
> AdjustHolding AdjustHoldings (string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = null)

AdjustHoldings: Adjust holdings

Adjust one or more holdings of the specified transaction portfolio to the provided targets. LUSID will  automatically construct adjustment transactions to ensure that the holdings which have been adjusted are  always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class AdjustHoldingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which the holdings should be set to the provided targets.
            var adjustHoldingRequest = new List<AdjustHoldingRequest>(); // List<AdjustHoldingRequest> | The selected set of holdings to adjust to the provided targets for the              transaction portfolio.
            var reconciliationMethods = new List<string>(); // List<string> | Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional) 

            try
            {
                // AdjustHoldings: Adjust holdings
                AdjustHolding result = apiInstance.AdjustHoldings(scope, code, effectiveAt, adjustHoldingRequest, reconciliationMethods);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.AdjustHoldings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which the holdings should be set to the provided targets. | 
 **adjustHoldingRequest** | [**List&lt;AdjustHoldingRequest&gt;**](AdjustHoldingRequest.md)| The selected set of holdings to adjust to the provided targets for the              transaction portfolio. | 
 **reconciliationMethods** | [**List&lt;string&gt;**](string.md)| Optional parameter for specifying a reconciliation method: e.g. FxForward. | [optional] 

### Return type

[**AdjustHolding**](AdjustHolding.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The version of the transaction portfolio that contains the newly adjusted holdings |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="buildtransactions"></a>
# **BuildTransactions**
> VersionedResourceListOfOutputTransaction BuildTransactions (string scope, string code, TransactionQueryParameters transactionQueryParameters, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, int? limit = null, string page = null)

BuildTransactions: Build transactions

Builds and returns all transactions that affect the holdings of a portfolio over a given interval of  effective time into a set of output transactions. This includes transactions automatically generated by  LUSID such as holding adjustments.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class BuildTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var transactionQueryParameters = new TransactionQueryParameters(); // TransactionQueryParameters | The query queryParameters which control how the output transactions are built.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.              For example, to return only transactions with a transaction type of 'Buy', specify \"type eq 'Buy'\".              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Instrument\" or \"Transaction\" domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\" or              \"Transaction/strategy/quantsignal\". (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing transactions from a previous call to BuildTransactions. (optional) 

            try
            {
                // BuildTransactions: Build transactions
                VersionedResourceListOfOutputTransaction result = apiInstance.BuildTransactions(scope, code, transactionQueryParameters, asAt, filter, propertyKeys, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.BuildTransactions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **transactionQueryParameters** | [**TransactionQueryParameters**](TransactionQueryParameters.md)| The query queryParameters which control how the output transactions are built. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to build the transactions. Defaults to return the latest              version of each transaction if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Instrument\&quot; or \&quot;Transaction\&quot; domain to decorate onto              the transactions. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;Transaction/strategy/quantsignal\&quot;. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. Defaults to 100 if not specified. | [optional] 
 **page** | **string**| The pagination token to use to continue listing transactions from a previous call to BuildTransactions. | [optional] 

### Return type

[**VersionedResourceListOfOutputTransaction**](VersionedResourceListOfOutputTransaction.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested transactions from the specified transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="canceladjustholdings"></a>
# **CancelAdjustHoldings**
> DeletedEntityResponse CancelAdjustHoldings (string scope, string code, DateTimeOrCutLabel effectiveAt)

CancelAdjustHoldings: Cancel adjust holdings

Cancel all previous holding adjustments made on the specified transaction portfolio for a specified effective  datetime. This should be used to undo holding adjustments made via set holdings or adjust holdings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CancelAdjustHoldingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which the holding adjustments should be undone.

            try
            {
                // CancelAdjustHoldings: Cancel adjust holdings
                DeletedEntityResponse result = apiInstance.CancelAdjustHoldings(scope, code, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.CancelAdjustHoldings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which the holding adjustments should be undone. | 

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the holding adjustments were cancelled |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="canceltransactions"></a>
# **CancelTransactions**
> DeletedEntityResponse CancelTransactions (string scope, string code, List<string> transactionIds)

CancelTransactions: Cancel transactions

Cancel one or more transactions from the transaction portfolio.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CancelTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var transactionIds = new List<string>(); // List<string> | The IDs of the transactions to cancel.

            try
            {
                // CancelTransactions: Cancel transactions
                DeletedEntityResponse result = apiInstance.CancelTransactions(scope, code, transactionIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.CancelTransactions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **transactionIds** | [**List&lt;string&gt;**](string.md)| The IDs of the transactions to cancel. | 

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the transactions were cancelled |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createportfolio"></a>
# **CreatePortfolio**
> Portfolio CreatePortfolio (string scope, CreateTransactionPortfolioRequest createTransactionPortfolioRequest)

CreatePortfolio: Create portfolio

Create a transaction portfolio in a particular scope.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreatePortfolioExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope in which to create the transaction portfolio.
            var createTransactionPortfolioRequest = new CreateTransactionPortfolioRequest(); // CreateTransactionPortfolioRequest | The definition of the transaction portfolio.

            try
            {
                // CreatePortfolio: Create portfolio
                Portfolio result = apiInstance.CreatePortfolio(scope, createTransactionPortfolioRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.CreatePortfolio: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope in which to create the transaction portfolio. | 
 **createTransactionPortfolioRequest** | [**CreateTransactionPortfolioRequest**](CreateTransactionPortfolioRequest.md)| The definition of the transaction portfolio. | 

### Return type

[**Portfolio**](Portfolio.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly-created transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepropertiesfromtransaction"></a>
# **DeletePropertiesFromTransaction**
> DeletedEntityResponse DeletePropertiesFromTransaction (string scope, string code, string transactionId, List<string> propertyKeys)

DeletePropertiesFromTransaction: Delete properties from transaction

Delete one or more properties from a single transaction in a transaction portfolio.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeletePropertiesFromTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var transactionId = transactionId_example;  // string | The unique ID of the transaction from which to delete properties.
            var propertyKeys = new List<string>(); // List<string> | The property keys of the properties to delete.              These must be from the \"Transaction\" domain and have the format {domain}/{scope}/{code}, for example              \"Transaction/strategy/quantsignal\".

            try
            {
                // DeletePropertiesFromTransaction: Delete properties from transaction
                DeletedEntityResponse result = apiInstance.DeletePropertiesFromTransaction(scope, code, transactionId, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.DeletePropertiesFromTransaction: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **transactionId** | **string**| The unique ID of the transaction from which to delete properties. | 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| The property keys of the properties to delete.              These must be from the \&quot;Transaction\&quot; domain and have the format {domain}/{scope}/{code}, for example              \&quot;Transaction/strategy/quantsignal\&quot;. | 

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The datetime that the property was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geta2bdata"></a>
# **GetA2BData**
> VersionedResourceListOfA2BDataRecord GetA2BData (string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = null, string recipeIdScope = null, string recipeIdCode = null, List<string> propertyKeys = null, string filter = null)

[EXPERIMENTAL] GetA2BData: Get A2B data

Get an A2B report for the given portfolio.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetA2BDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the portfolio to retrieve the A2B report for.
            var code = code_example;  // string | The code of the portfolio to retrieve the A2B report for. Together with the scope this              uniquely identifies the portfolio.
            var fromEffectiveAt = fromEffectiveAt_example;  // DateTimeOrCutLabel | The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.
            var toEffectiveAt = toEffectiveAt_example;  // DateTimeOrCutLabel | The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. (optional) 
            var recipeIdScope = recipeIdScope_example;  // string | The scope of the given recipeId (optional) 
            var recipeIdCode = recipeIdCode_example;  // string | The code of the given recipeId (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Instrument\" domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\". (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EXPERIMENTAL] GetA2BData: Get A2B data
                VersionedResourceListOfA2BDataRecord result = apiInstance.GetA2BData(scope, code, fromEffectiveAt, toEffectiveAt, asAt, recipeIdScope, recipeIdCode, propertyKeys, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.GetA2BData: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio to retrieve the A2B report for. | 
 **code** | **string**| The code of the portfolio to retrieve the A2B report for. Together with the scope this              uniquely identifies the portfolio. | 
 **fromEffectiveAt** | **DateTimeOrCutLabel**| The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. | 
 **toEffectiveAt** | **DateTimeOrCutLabel**| The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. | [optional] 
 **recipeIdScope** | **string**| The scope of the given recipeId | [optional] 
 **recipeIdCode** | **string**| The code of the given recipeId | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. | [optional] 
 **filter** | **string**| Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 

### Return type

[**VersionedResourceListOfA2BDataRecord**](VersionedResourceListOfA2BDataRecord.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested portfolio A2B data |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geta2bmovements"></a>
# **GetA2BMovements**
> VersionedResourceListOfA2BMovementRecord GetA2BMovements (string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = null, string recipeIdScope = null, string recipeIdCode = null, List<string> propertyKeys = null, string filter = null)

[EXPERIMENTAL] GetA2BMovements: Get an A2B report at the movement level for the given portfolio.

Get an A2B report at the movement level for the given portfolio.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetA2BMovementsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the portfolio to retrieve the A2B movement report for.
            var code = code_example;  // string | The code of the portfolio to retrieve the A2B movement report for. Together with the scope this              uniquely identifies the portfolio.
            var fromEffectiveAt = fromEffectiveAt_example;  // DateTimeOrCutLabel | The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.
            var toEffectiveAt = toEffectiveAt_example;  // DateTimeOrCutLabel | The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. (optional) 
            var recipeIdScope = recipeIdScope_example;  // string | The scope of the given recipeId (optional) 
            var recipeIdCode = recipeIdCode_example;  // string | The code of the given recipeId (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Instrument\" domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\". (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EXPERIMENTAL] GetA2BMovements: Get an A2B report at the movement level for the given portfolio.
                VersionedResourceListOfA2BMovementRecord result = apiInstance.GetA2BMovements(scope, code, fromEffectiveAt, toEffectiveAt, asAt, recipeIdScope, recipeIdCode, propertyKeys, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.GetA2BMovements: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio to retrieve the A2B movement report for. | 
 **code** | **string**| The code of the portfolio to retrieve the A2B movement report for. Together with the scope this              uniquely identifies the portfolio. | 
 **fromEffectiveAt** | **DateTimeOrCutLabel**| The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. | 
 **toEffectiveAt** | **DateTimeOrCutLabel**| The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version              of each transaction if not specified. | [optional] 
 **recipeIdScope** | **string**| The scope of the given recipeId | [optional] 
 **recipeIdCode** | **string**| The code of the given recipeId | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Instrument\&quot; domain to decorate onto              the results. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot;. | [optional] 
 **filter** | **string**| Expression to filter the result set.              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 

### Return type

[**VersionedResourceListOfA2BMovementRecord**](VersionedResourceListOfA2BMovementRecord.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested portfolio A2B movement data |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbucketedcashflows"></a>
# **GetBucketedCashFlows**
> BucketedCashFlowResponse GetBucketedCashFlows (string scope, string code, BucketedCashFlowRequest bucketedCashFlowRequest = null)

[EXPERIMENTAL] GetBucketedCashFlows: Get bucketed cash flows from a list of portfolios

We bucket/aggregate a transaction portfolio's instruments by date or tenor specified in the request.  The cashflows are grouped by both instrumentId and currency.                If you want transactional level cashflow, please use the 'GetUpsertableCashFlows' endpoint.  If you want instrument cashflow, please use the 'GetPortfolioCashFlows' endpoint.  Note that these endpoints do not apply bucketing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetBucketedCashFlowsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies the portfolio.
            var bucketedCashFlowRequest = new BucketedCashFlowRequest(); // BucketedCashFlowRequest | Request specifying the bucketing of cashflows (optional) 

            try
            {
                // [EXPERIMENTAL] GetBucketedCashFlows: Get bucketed cash flows from a list of portfolios
                BucketedCashFlowResponse result = apiInstance.GetBucketedCashFlows(scope, code, bucketedCashFlowRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.GetBucketedCashFlows: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies the portfolio. | 
 **bucketedCashFlowRequest** | [**BucketedCashFlowRequest**](BucketedCashFlowRequest.md)| Request specifying the bucketing of cashflows | [optional] 

### Return type

[**BucketedCashFlowResponse**](BucketedCashFlowResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested portfolio instruments&#39; bucketed cash flow data |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdetails"></a>
# **GetDetails**
> PortfolioDetails GetDetails (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)

GetDetails: Get details

Get certain details associated with a transaction portfolio.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the              scope this uniquely identifies the transaction portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to returning the latest version of the details if not specified. (optional) 

            try
            {
                // GetDetails: Get details
                PortfolioDetails result = apiInstance.GetDetails(scope, code, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.GetDetails: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the              scope this uniquely identifies the transaction portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to retrieve the details of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the details of the transaction portfolio. Defaults              to returning the latest version of the details if not specified. | [optional] 

### Return type

[**PortfolioDetails**](PortfolioDetails.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The details of the specified transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getholdings"></a>
# **GetHoldings**
> VersionedResourceListOfPortfolioHolding GetHoldings (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, bool? byTaxlots = null)

GetHoldings: Get holdings

Calculate holdings for a transaction portfolio.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetHoldingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.              For example, to filter on the Holding Type, use \"holdingType eq 'p'\".              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Instrument\" or \"Holding\" domain to decorate onto              holdings. These must have the format {domain}/{scope}/{code}, for example \"Instrument/system/Name\" or \"Holding/system/Cost\". (optional) 
            var byTaxlots = true;  // bool? | Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional) 

            try
            {
                // GetHoldings: Get holdings
                VersionedResourceListOfPortfolioHolding result = apiInstance.GetHoldings(scope, code, effectiveAt, asAt, filter, propertyKeys, byTaxlots);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.GetHoldings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set.              For example, to filter on the Holding Type, use \&quot;holdingType eq &#39;p&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Instrument\&quot; or \&quot;Holding\&quot; domain to decorate onto              holdings. These must have the format {domain}/{scope}/{code}, for example \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. | [optional] 
 **byTaxlots** | **bool?**| Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. | [optional] 

### Return type

[**VersionedResourceListOfPortfolioHolding**](VersionedResourceListOfPortfolioHolding.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The holdings and version of the specified transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getholdingsadjustment"></a>
# **GetHoldingsAdjustment**
> HoldingsAdjustment GetHoldingsAdjustment (string scope, string code, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = null, List<string> propertyKeys = null)

GetHoldingsAdjustment: Get holdings adjustment

Get a holdings adjustment made to a transaction portfolio at a specific effective datetime. Note that a  holdings adjustment will only be returned if one exists for the specified effective datetime.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetHoldingsAdjustmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label of the holdings adjustment.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the ‘Instrument' domain to decorate onto holdings adjustments.              These must have the format {domain}/{scope}/{code}, for example 'Instrument/system/Name'.              Note that properties from the 'Holding’ domain are automatically returned. (optional) 

            try
            {
                // GetHoldingsAdjustment: Get holdings adjustment
                HoldingsAdjustment result = apiInstance.GetHoldingsAdjustment(scope, code, effectiveAt, asAt, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.GetHoldingsAdjustment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label of the holdings adjustment. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the holdings adjustment. Defaults to the return the latest              version of the holdings adjustment if not specified. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the ‘Instrument&#39; domain to decorate onto holdings adjustments.              These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39;.              Note that properties from the &#39;Holding’ domain are automatically returned. | [optional] 

### Return type

[**HoldingsAdjustment**](HoldingsAdjustment.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The details of the requested holdings adjustment |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getholdingswithorders"></a>
# **GetHoldingsWithOrders**
> VersionedResourceListWithWarningsOfPortfolioHolding GetHoldingsWithOrders (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, bool? byTaxlots = null, string recipeIdScope = null, string recipeIdCode = null)

[EXPERIMENTAL] GetHoldingsWithOrders: Get holdings with orders

Get the holdings of a transaction portfolio. Create virtual holdings for any outstanding orders,  and account for order state/fulfillment; that is, treat outstanding orders (and related records) as  if they had been realised at moment of query.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetHoldingsWithOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version of the holdings if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.              For example, to filter on the Holding Type, use \"holdingType eq 'p'\"              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Instrument\" or \"Holding\" domain to decorate onto              the holdings. These take the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\" or \"Holding/system/Cost\". (optional) 
            var byTaxlots = true;  // bool? | Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. (optional) 
            var recipeIdScope = recipeIdScope_example;  // string | The scope of the given recipeId (optional) 
            var recipeIdCode = recipeIdCode_example;  // string | The code of the given recipeId (optional) 

            try
            {
                // [EXPERIMENTAL] GetHoldingsWithOrders: Get holdings with orders
                VersionedResourceListWithWarningsOfPortfolioHolding result = apiInstance.GetHoldingsWithOrders(scope, code, effectiveAt, asAt, filter, propertyKeys, byTaxlots, recipeIdScope, recipeIdCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.GetHoldingsWithOrders: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which to retrieve the holdings of the transaction              portfolio. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the holdings of the transaction portfolio. Defaults              to return the latest version of the holdings if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set.              For example, to filter on the Holding Type, use \&quot;holdingType eq &#39;p&#39;\&quot;              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Instrument\&quot; or \&quot;Holding\&quot; domain to decorate onto              the holdings. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or \&quot;Holding/system/Cost\&quot;. | [optional] 
 **byTaxlots** | **bool?**| Whether or not to expand the holdings to return the underlying tax-lots. Defaults to              False. | [optional] 
 **recipeIdScope** | **string**| The scope of the given recipeId | [optional] 
 **recipeIdCode** | **string**| The code of the given recipeId | [optional] 

### Return type

[**VersionedResourceListWithWarningsOfPortfolioHolding**](VersionedResourceListWithWarningsOfPortfolioHolding.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The holdings and version of the specified transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getportfoliocashflows"></a>
# **GetPortfolioCashFlows**
> ResourceListOfInstrumentCashFlow GetPortfolioCashFlows (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOrCutLabel windowStart = null, DateTimeOrCutLabel windowEnd = null, DateTimeOffset? asAt = null, string filter = null, string recipeIdScope = null, string recipeIdCode = null)

[BETA] GetPortfolioCashFlows: Get portfolio cash flows

Get the set of cash flows that occur in a window for the transaction portfolio's instruments.                Note that grouping can affect the quantity of information returned; where a holding is an amalgamation of one or more (e.g. cash) instruments, a unique  transaction identifier will not be available. The same may go for diagnostic information (e.g. multiple sources of an aggregate cash amount on a date that is  not split out. Grouping at the transaction and instrument level is recommended for those seeking to attribute individual flows.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPortfolioCashFlowsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this               uniquely identifies the portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows.  This determines whether cashflows are evaluated in a historic or forward looking context and will, for certain models, affect where data is looked up.  For example, on a swap if the effectiveAt is in the middle of the window, cashflows before it will be historic and resets assumed to exist where if the effectiveAt  is before the start of the range they are forward looking and will be expectations assuming the model supports that.  There is evidently a presumption here about availability of data and that the effectiveAt is realistically on or before the real-world today. (optional) 
            var windowStart = windowStart_example;  // DateTimeOrCutLabel | The lower bound effective datetime or cut label (inclusive) from which to retrieve the cashflows.               There is no lower bound if this is not specified. i.e. it is the minimum date. (optional) 
            var windowEnd = windowEnd_example;  // DateTimeOrCutLabel | The upper bound effective datetime or cut label (inclusive) from which to retrieve the cashflows.               The upper bound defaults to 'max date' if it is not specified (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the data. Defaults to returning the latest version               of each transaction if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.               For example, to return only transactions with a transaction type of 'Buy', specify \"type eq 'Buy'\".               For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var recipeIdScope = recipeIdScope_example;  // string | The scope of the given recipeId (optional) 
            var recipeIdCode = recipeIdCode_example;  // string | The code of the given recipeID (optional) 

            try
            {
                // [BETA] GetPortfolioCashFlows: Get portfolio cash flows
                ResourceListOfInstrumentCashFlow result = apiInstance.GetPortfolioCashFlows(scope, code, effectiveAt, windowStart, windowEnd, asAt, filter, recipeIdScope, recipeIdCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.GetPortfolioCashFlows: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this               uniquely identifies the portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows.  This determines whether cashflows are evaluated in a historic or forward looking context and will, for certain models, affect where data is looked up.  For example, on a swap if the effectiveAt is in the middle of the window, cashflows before it will be historic and resets assumed to exist where if the effectiveAt  is before the start of the range they are forward looking and will be expectations assuming the model supports that.  There is evidently a presumption here about availability of data and that the effectiveAt is realistically on or before the real-world today. | [optional] 
 **windowStart** | **DateTimeOrCutLabel**| The lower bound effective datetime or cut label (inclusive) from which to retrieve the cashflows.               There is no lower bound if this is not specified. i.e. it is the minimum date. | [optional] 
 **windowEnd** | **DateTimeOrCutLabel**| The upper bound effective datetime or cut label (inclusive) from which to retrieve the cashflows.               The upper bound defaults to &#39;max date&#39; if it is not specified | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the data. Defaults to returning the latest version               of each transaction if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.               For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional] 
 **recipeIdScope** | **string**| The scope of the given recipeId | [optional] 
 **recipeIdCode** | **string**| The code of the given recipeID | [optional] 

### Return type

[**ResourceListOfInstrumentCashFlow**](ResourceListOfInstrumentCashFlow.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested portfolio instruments&#39; cash flow data |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getportfoliocashladder"></a>
# **GetPortfolioCashLadder**
> ResourceListOfPortfolioCashLadder GetPortfolioCashLadder (string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = null, string filter = null, string recipeIdScope = null, string recipeIdCode = null)

[EXPERIMENTAL] GetPortfolioCashLadder: Get portfolio cash ladder

Get a cash ladder for a transaction portfolio.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPortfolioCashLadderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.
            var fromEffectiveAt = fromEffectiveAt_example;  // DateTimeOrCutLabel | The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.
            var toEffectiveAt = toEffectiveAt_example;  // DateTimeOrCutLabel | The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows.  This determines whether cashflows are evaluated in a historic or forward looking context and will, for certain models, affect where data is looked up.  For example, on a swap if the effectiveAt is in the middle of the window, cashflows before it will be historic and resets assumed to exist where if the effectiveAt  is before the start of the range they are forward looking and will be expectations assuming the model supports that.  There is evidently a presumption here about availability of data and that the effectiveAt is realistically on or before the real-world today.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.              For example, to return only transactions with a transaction type of 'Buy', specify \"type eq 'Buy'\".              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var recipeIdScope = recipeIdScope_example;  // string | The scope of the given recipeId (optional) 
            var recipeIdCode = recipeIdCode_example;  // string | The code of the given recipeID (optional) 

            try
            {
                // [EXPERIMENTAL] GetPortfolioCashLadder: Get portfolio cash ladder
                ResourceListOfPortfolioCashLadder result = apiInstance.GetPortfolioCashLadder(scope, code, fromEffectiveAt, toEffectiveAt, effectiveAt, asAt, filter, recipeIdScope, recipeIdCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.GetPortfolioCashLadder: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio. | 
 **fromEffectiveAt** | **DateTimeOrCutLabel**| The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. | 
 **toEffectiveAt** | **DateTimeOrCutLabel**| The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows.  This determines whether cashflows are evaluated in a historic or forward looking context and will, for certain models, affect where data is looked up.  For example, on a swap if the effectiveAt is in the middle of the window, cashflows before it will be historic and resets assumed to exist where if the effectiveAt  is before the start of the range they are forward looking and will be expectations assuming the model supports that.  There is evidently a presumption here about availability of data and that the effectiveAt is realistically on or before the real-world today. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional] 
 **recipeIdScope** | **string**| The scope of the given recipeId | [optional] 
 **recipeIdCode** | **string**| The code of the given recipeID | [optional] 

### Return type

[**ResourceListOfPortfolioCashLadder**](ResourceListOfPortfolioCashLadder.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested portfolio cash-ladder |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getportfoliocashstatement"></a>
# **GetPortfolioCashStatement**
> ResourceListOfPortfolioCashFlow GetPortfolioCashStatement (string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAt = null, string filter = null, string recipeIdScope = null, string recipeIdCode = null)

[EARLY ACCESS] GetPortfolioCashStatement: Get portfolio cash statement

Get a cash statement for a transaction portfolio.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPortfolioCashStatementExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio.
            var fromEffectiveAt = fromEffectiveAt_example;  // DateTimeOrCutLabel | The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified.
            var toEffectiveAt = toEffectiveAt_example;  // DateTimeOrCutLabel | The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.              For example, to return only transactions with a transaction type of 'Buy', specify \"type eq 'Buy'\".              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var recipeIdScope = recipeIdScope_example;  // string | The scope of the given recipeId (optional) 
            var recipeIdCode = recipeIdCode_example;  // string | The code of the given recipeID (optional) 

            try
            {
                // [EARLY ACCESS] GetPortfolioCashStatement: Get portfolio cash statement
                ResourceListOfPortfolioCashFlow result = apiInstance.GetPortfolioCashStatement(scope, code, fromEffectiveAt, toEffectiveAt, asAt, filter, recipeIdScope, recipeIdCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.GetPortfolioCashStatement: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this              uniquely identifies the portfolio. | 
 **fromEffectiveAt** | **DateTimeOrCutLabel**| The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. | 
 **toEffectiveAt** | **DateTimeOrCutLabel**| The upper bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no upper bound if this is not specified. | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the portfolio. Defaults to returning the latest version              of each transaction if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set.              For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.              For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional] 
 **recipeIdScope** | **string**| The scope of the given recipeId | [optional] 
 **recipeIdCode** | **string**| The code of the given recipeID | [optional] 

### Return type

[**ResourceListOfPortfolioCashFlow**](ResourceListOfPortfolioCashFlow.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested portfolio cash flow data |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactions"></a>
# **GetTransactions**
> VersionedResourceListOfTransaction GetTransactions (string scope, string code, DateTimeOrCutLabel fromTransactionDate = null, DateTimeOrCutLabel toTransactionDate = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, string page = null, int? limit = null)

GetTransactions: Get transactions

Retrieve all the transactions that occurred during a particular time interval.                If the portfolio is a derived transaction portfolio, the transactions returned are the  union set of all transactions of the parent (and any grandparents, etc.) as well as  those of the derived transaction portfolio itself.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio.
            var fromTransactionDate = fromTransactionDate_example;  // DateTimeOrCutLabel | The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no lower bound if this is not specified. (optional) 
            var toTransactionDate = toTransactionDate_example;  // DateTimeOrCutLabel | The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve transactions. Defaults to returning the latest version               of each transaction if not specified. (optional) 
            var filter = filter_example;  // string | Expression with which to filter the result set.               For example, to return only transactions with a transaction type of 'Buy', specify \"type eq 'Buy'\"               For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the 'Instrument' or 'Transaction' domain to decorate onto               transactions. These must have the format {domain}/{scope}/{code}, for example 'Instrument/system/Name' or               'Transaction/strategy/quantsignal'. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing transactions from a previous call to GetTransactions. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. The current behaviour is               to return all transactions if possible, but this will change to defaulting to 1000 if not specified in the future. It is recommended               to populate this field to enable pagination. (optional) 

            try
            {
                // GetTransactions: Get transactions
                VersionedResourceListOfTransaction result = apiInstance.GetTransactions(scope, code, fromTransactionDate, toTransactionDate, asAt, filter, propertyKeys, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.GetTransactions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio. | 
 **fromTransactionDate** | **DateTimeOrCutLabel**| The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no lower bound if this is not specified. | [optional] 
 **toTransactionDate** | **DateTimeOrCutLabel**| The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve transactions. Defaults to returning the latest version               of each transaction if not specified. | [optional] 
 **filter** | **string**| Expression with which to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;               For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the &#39;Instrument&#39; or &#39;Transaction&#39; domain to decorate onto               transactions. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39; or               &#39;Transaction/strategy/quantsignal&#39;. | [optional] 
 **page** | **string**| The pagination token to use to continue listing transactions from a previous call to GetTransactions. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. The current behaviour is               to return all transactions if possible, but this will change to defaulting to 1000 if not specified in the future. It is recommended               to populate this field to enable pagination. | [optional] 

### Return type

[**VersionedResourceListOfTransaction**](VersionedResourceListOfTransaction.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested transactions from the specified transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getupsertableportfoliocashflows"></a>
# **GetUpsertablePortfolioCashFlows**
> ResourceListOfTransaction GetUpsertablePortfolioCashFlows (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOrCutLabel windowStart = null, DateTimeOrCutLabel windowEnd = null, DateTimeOffset? asAt = null, string filter = null, string recipeIdScope = null, string recipeIdCode = null)

[BETA] GetUpsertablePortfolioCashFlows: Get upsertable portfolio cash flows.

Get the set of cash flows that occur in a window for the given portfolio instruments as a set of upsertable transactions (DTOs).                Note that grouping can affect the quantity of information returned; where a holding is an amalgamation of one or more (e.g. cash) instruments, a unique  transaction identifier will not be available. The same may go for diagnostic information (e.g. multiple sources of an aggregate cash amount on a date that is  not split out. Grouping at the transaction and instrument level is recommended for those seeking to attribute individual flows.                In essence this is identical to the 'GetCashFlows' endpoint but returns the cash flows as a set of transactions suitable for directly putting back into LUSID.  There are a couple of important points:  (1) Internally it can not be fully known where the user wishes to insert these transactions, e.g. portfolio and movement type.      These are therefore defaulted to a sensible option; the user will likely need to change these.  (2) Similarly, knowledge of any properties the user might wish to add to a transaction are unknown and consequently left empty.  (3) The transaction id that is added is simply a concatenation of the original transaction id, instrument id and payment date and direction. The user can happily override this.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetUpsertablePortfolioCashFlowsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this               uniquely identifies the portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows.  This determines whether cashflows are evaluated in a historic or forward looking context and will, for certain models, affect where data is looked up.  For example, on a swap if the effectiveAt is in the middle of the window, cashflows before it will be historic and resets assumed to exist where if the effectiveAt  is before the start of the range they are forward looking and will be expectations assuming the model supports that.  There is evidently a presumption here about availability of data and that the effectiveAt is realistically on or before the real-world today. (optional) 
            var windowStart = windowStart_example;  // DateTimeOrCutLabel | The lower bound effective datetime or cut label (inclusive) from which to retrieve the cashflows.               There is no lower bound if this is not specified. i.e. uses minimum date-time (optional) 
            var windowEnd = windowEnd_example;  // DateTimeOrCutLabel | The upper bound effective datetime or cut label (inclusive) from which to retrieve the cashflows.               The upper bound defaults to 'max date' if it is not specified (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version               of each transaction if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.               For example, to return only transactions with a transaction type of 'Buy', specify \"type eq 'Buy'\".               For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var recipeIdScope = recipeIdScope_example;  // string | The scope of the given recipeId (optional) 
            var recipeIdCode = recipeIdCode_example;  // string | The code of the given recipeID (optional) 

            try
            {
                // [BETA] GetUpsertablePortfolioCashFlows: Get upsertable portfolio cash flows.
                ResourceListOfTransaction result = apiInstance.GetUpsertablePortfolioCashFlows(scope, code, effectiveAt, windowStart, windowEnd, asAt, filter, recipeIdScope, recipeIdCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.GetUpsertablePortfolioCashFlows: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this               uniquely identifies the portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows.  This determines whether cashflows are evaluated in a historic or forward looking context and will, for certain models, affect where data is looked up.  For example, on a swap if the effectiveAt is in the middle of the window, cashflows before it will be historic and resets assumed to exist where if the effectiveAt  is before the start of the range they are forward looking and will be expectations assuming the model supports that.  There is evidently a presumption here about availability of data and that the effectiveAt is realistically on or before the real-world today. | [optional] 
 **windowStart** | **DateTimeOrCutLabel**| The lower bound effective datetime or cut label (inclusive) from which to retrieve the cashflows.               There is no lower bound if this is not specified. i.e. uses minimum date-time | [optional] 
 **windowEnd** | **DateTimeOrCutLabel**| The upper bound effective datetime or cut label (inclusive) from which to retrieve the cashflows.               The upper bound defaults to &#39;max date&#39; if it is not specified | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the portfolio. Defaults to return the latest version               of each transaction if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;.               For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional] 
 **recipeIdScope** | **string**| The scope of the given recipeId | [optional] 
 **recipeIdCode** | **string**| The code of the given recipeID | [optional] 

### Return type

[**ResourceListOfTransaction**](ResourceListOfTransaction.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested portfolio instruments&#39; cash flow data as a set of upsertable transactions |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listholdingsadjustments"></a>
# **ListHoldingsAdjustments**
> ResourceListOfHoldingsAdjustmentHeader ListHoldingsAdjustments (string scope, string code, DateTimeOrCutLabel fromEffectiveAt = null, DateTimeOrCutLabel toEffectiveAt = null, DateTimeOffset? asAt = null)

ListHoldingsAdjustments: List holdings adjustments

List the holdings adjustments made to the specified transaction portfolio over a specified interval of effective time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListHoldingsAdjustmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var fromEffectiveAt = fromEffectiveAt_example;  // DateTimeOrCutLabel | The lower bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. (optional) 
            var toEffectiveAt = toEffectiveAt_example;  // DateTimeOrCutLabel | The upper bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. (optional) 

            try
            {
                // ListHoldingsAdjustments: List holdings adjustments
                ResourceListOfHoldingsAdjustmentHeader result = apiInstance.ListHoldingsAdjustments(scope, code, fromEffectiveAt, toEffectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.ListHoldingsAdjustments: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **fromEffectiveAt** | **DateTimeOrCutLabel**| The lower bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no lower bound if this is not specified. | [optional] 
 **toEffectiveAt** | **DateTimeOrCutLabel**| The upper bound effective datetime or cut label (inclusive) from which to retrieve the holdings              adjustments. There is no upper bound if this is not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the holdings adjustments. Defaults to return the              latest version of each holding adjustment if not specified. | [optional] 

### Return type

[**ResourceListOfHoldingsAdjustmentHeader**](ResourceListOfHoldingsAdjustmentHeader.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The record of holdings adjustments made to the specified transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="lookthroughtransactions"></a>
# **LookThroughTransactions**
> VersionedResourceListOfTransaction LookThroughTransactions (string scope, string code, DateTimeOrCutLabel fromTransactionDate = null, DateTimeOrCutLabel toTransactionDate = null, DateTimeOffset? asAt = null, string filter = null, List<string> propertyKeys = null, string page = null, int? limit = null)

[EXPERIMENTAL] LookThroughTransactions: Look through transactions

Retrieve all the transactions that occurred during a particular time interval.                If the portfolio is part of a fund as defined in Fund Accounting documents, the transactions returned are the  union set of all transactions in portfolios of the same type, in any funds invested in by the portfolio's fund  (and any funds invested in from that fund, etc.).  The transactions will be scaled according to the ratio of the value of the investment in the fund to the NAV of the fund itself.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class LookThroughTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio.
            var fromTransactionDate = fromTransactionDate_example;  // DateTimeOrCutLabel | The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no lower bound if this is not specified. (optional) 
            var toTransactionDate = toTransactionDate_example;  // DateTimeOrCutLabel | The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve transactions. Defaults to returning the latest version               of each transaction if not specified. (optional) 
            var filter = filter_example;  // string | Expression with which to filter the result set.               For example, to return only transactions with a transaction type of 'Buy', specify \"type eq 'Buy'\"               For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the 'Instrument' or 'Transaction' domain to decorate onto               transactions. These must have the format {domain}/{scope}/{code}, for example 'Instrument/system/Name' or               'Transaction/strategy/quantsignal'. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing transactions from a previous call to LookThroughTransactions. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. This will default to 1000 if not specified. (optional) 

            try
            {
                // [EXPERIMENTAL] LookThroughTransactions: Look through transactions
                VersionedResourceListOfTransaction result = apiInstance.LookThroughTransactions(scope, code, fromTransactionDate, toTransactionDate, asAt, filter, propertyKeys, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.LookThroughTransactions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies               the transaction portfolio. | 
 **fromTransactionDate** | **DateTimeOrCutLabel**| The lower bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no lower bound if this is not specified. | [optional] 
 **toTransactionDate** | **DateTimeOrCutLabel**| The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.               There is no upper bound if this is not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve transactions. Defaults to returning the latest version               of each transaction if not specified. | [optional] 
 **filter** | **string**| Expression with which to filter the result set.               For example, to return only transactions with a transaction type of &#39;Buy&#39;, specify \&quot;type eq &#39;Buy&#39;\&quot;               For more information about filtering LUSID results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the &#39;Instrument&#39; or &#39;Transaction&#39; domain to decorate onto               transactions. These must have the format {domain}/{scope}/{code}, for example &#39;Instrument/system/Name&#39; or               &#39;Transaction/strategy/quantsignal&#39;. | [optional] 
 **page** | **string**| The pagination token to use to continue listing transactions from a previous call to LookThroughTransactions. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. This will default to 1000 if not specified. | [optional] 

### Return type

[**VersionedResourceListOfTransaction**](VersionedResourceListOfTransaction.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested transactions from the specified transaction portfolio |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchportfoliodetails"></a>
# **PatchPortfolioDetails**
> PortfolioDetails PatchPortfolioDetails (string scope, string code, List<Operation> operation, DateTimeOrCutLabel effectiveAt = null)

[EXPERIMENTAL] PatchPortfolioDetails: Patch portfolio details

Create or update certain details for a particular transaction portfolio.  The behaviour is defined by the JSON Patch specification.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.  Currently supported properties are: SubHoldingKeys, BaseCurrency

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class PatchPortfolioDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.
            var operation = new List<Operation>(); // List<Operation> | The patch document.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified.               Note that this will affect all bitemporal entities in the request, but will not be used for any perpetual entities. (optional) 

            try
            {
                // [EXPERIMENTAL] PatchPortfolioDetails: Patch portfolio details
                PortfolioDetails result = apiInstance.PatchPortfolioDetails(scope, code, operation, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.PatchPortfolioDetails: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio. | 
 **operation** | [**List&lt;Operation&gt;**](Operation.md)| The patch document. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified.               Note that this will affect all bitemporal entities in the request, but will not be used for any perpetual entities. | [optional] 

### Return type

[**PortfolioDetails**](PortfolioDetails.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The newly patched details |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resolveinstrument"></a>
# **ResolveInstrument**
> UpsertPortfolioTransactionsResponse ResolveInstrument (string scope, string code, string instrumentIdentifierType, string instrumentIdentifierValue, DateTimeOrCutLabel fromEffectiveAt = null, bool? reResolve = null, Dictionary<string, string> requestBody = null)

[EARLY ACCESS] ResolveInstrument: Resolve instrument

Try to resolve the instrument for transaction and holdings for a given instrument identifier and a specified  period of time. Also update the instrument identifiers with the given instrument identifiers collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ResolveInstrumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var instrumentIdentifierType = instrumentIdentifierType_example;  // string | The instrument identifier type.
            var instrumentIdentifierValue = instrumentIdentifierValue_example;  // string | The value for the given instrument identifier.
            var fromEffectiveAt = fromEffectiveAt_example;  // DateTimeOrCutLabel | The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. (optional) 
            var reResolve = true;  // bool? | When set to true, instrument resolution will be attempted for all transactions and holdings for the given identifier and date range.              When set to false (default behaviour), instrument resolution will only be attempted for those transactions and holdings that were previously unresolved. (optional)  (default to false)
            var requestBody = new Dictionary<string, string>(); // Dictionary<string, string> | The dictionary with the instrument identifiers to be updated on the             transaction and holdings. (optional) 

            try
            {
                // [EARLY ACCESS] ResolveInstrument: Resolve instrument
                UpsertPortfolioTransactionsResponse result = apiInstance.ResolveInstrument(scope, code, instrumentIdentifierType, instrumentIdentifierValue, fromEffectiveAt, reResolve, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.ResolveInstrument: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **instrumentIdentifierType** | **string**| The instrument identifier type. | 
 **instrumentIdentifierValue** | **string**| The value for the given instrument identifier. | 
 **fromEffectiveAt** | **DateTimeOrCutLabel**| The lower bound effective datetime or cut label (inclusive) from which to retrieve the data.              There is no lower bound if this is not specified. | [optional] 
 **reResolve** | **bool?**| When set to true, instrument resolution will be attempted for all transactions and holdings for the given identifier and date range.              When set to false (default behaviour), instrument resolution will only be attempted for those transactions and holdings that were previously unresolved. | [optional] [default to false]
 **requestBody** | [**Dictionary&lt;string, string&gt;**](string.md)| The dictionary with the instrument identifiers to be updated on the             transaction and holdings. | [optional] 

### Return type

[**UpsertPortfolioTransactionsResponse**](UpsertPortfolioTransactionsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The version of the transaction portfolio that contains the newly updated or inserted transactions |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setholdings"></a>
# **SetHoldings**
> AdjustHolding SetHoldings (string scope, string code, DateTimeOrCutLabel effectiveAt, List<AdjustHoldingRequest> adjustHoldingRequest, List<string> reconciliationMethods = null)

SetHoldings: Set holdings

Set the holdings of the specified transaction portfolio to the provided targets. LUSID will automatically  construct adjustment transactions to ensure that the entire set of holdings for the transaction portfolio  are always set to the provided targets for the specified effective datetime. Read more about the difference between  adjusting and setting holdings here https://support.lusid.com/how-do-i-adjust-my-holdings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class SetHoldingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which the holdings should be set to the provided targets.
            var adjustHoldingRequest = new List<AdjustHoldingRequest>(); // List<AdjustHoldingRequest> | The complete set of target holdings for the transaction portfolio.
            var reconciliationMethods = new List<string>(); // List<string> | Optional parameter for specifying a reconciliation method: e.g. FxForward. (optional) 

            try
            {
                // SetHoldings: Set holdings
                AdjustHolding result = apiInstance.SetHoldings(scope, code, effectiveAt, adjustHoldingRequest, reconciliationMethods);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.SetHoldings: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which the holdings should be set to the provided targets. | 
 **adjustHoldingRequest** | [**List&lt;AdjustHoldingRequest&gt;**](AdjustHoldingRequest.md)| The complete set of target holdings for the transaction portfolio. | 
 **reconciliationMethods** | [**List&lt;string&gt;**](string.md)| Optional parameter for specifying a reconciliation method: e.g. FxForward. | [optional] 

### Return type

[**AdjustHolding**](AdjustHolding.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The version of the transaction portfolio that contains the newly set holdings |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertportfoliodetails"></a>
# **UpsertPortfolioDetails**
> PortfolioDetails UpsertPortfolioDetails (string scope, string code, CreatePortfolioDetails createPortfolioDetails, DateTimeOrCutLabel effectiveAt = null)

UpsertPortfolioDetails: Upsert portfolio details

Create or update certain details for a particular transaction portfolio. The details are updated if they already exist, and inserted if they do not.                Note that not all elements of a transaction portfolio definition are  modifiable once it has been created due to the potential implications for data already stored.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertPortfolioDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio.
            var createPortfolioDetails = new CreatePortfolioDetails(); // CreatePortfolioDetails | The details to create or update for the specified transaction portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // UpsertPortfolioDetails: Upsert portfolio details
                PortfolioDetails result = apiInstance.UpsertPortfolioDetails(scope, code, createPortfolioDetails, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.UpsertPortfolioDetails: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the               scope this uniquely identifies the transaction portfolio. | 
 **createPortfolioDetails** | [**CreatePortfolioDetails**](CreatePortfolioDetails.md)| The details to create or update for the specified transaction portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime or cut label at which the updated or inserted details should become valid.               Defaults to the current LUSID system datetime if not specified. | [optional] 

### Return type

[**PortfolioDetails**](PortfolioDetails.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The newly updated or inserted details |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upserttransactionproperties"></a>
# **UpsertTransactionProperties**
> UpsertTransactionPropertiesResponse UpsertTransactionProperties (string scope, string code, string transactionId, Dictionary<string, PerpetualProperty> requestBody)

UpsertTransactionProperties: Upsert transaction properties

Create or update one or more transaction properties for a single transaction in the transaction portfolio.  Each property will be updated if it already exists and created if it does not.  Both transaction and portfolio must exist at the time when properties are created or updated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertTransactionPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var transactionId = transactionId_example;  // string | The unique ID of the transaction to create or update properties for.
            var requestBody = new Dictionary<string, PerpetualProperty>(); // Dictionary<string, PerpetualProperty> | The properties and their associated values to create or update.

            try
            {
                // UpsertTransactionProperties: Upsert transaction properties
                UpsertTransactionPropertiesResponse result = apiInstance.UpsertTransactionProperties(scope, code, transactionId, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.UpsertTransactionProperties: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **transactionId** | **string**| The unique ID of the transaction to create or update properties for. | 
 **requestBody** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md)| The properties and their associated values to create or update. | 

### Return type

[**UpsertTransactionPropertiesResponse**](UpsertTransactionPropertiesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The version of the transaction portfolio that contains the newly updated or inserted transaction property |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upserttransactions"></a>
# **UpsertTransactions**
> UpsertPortfolioTransactionsResponse UpsertTransactions (string scope, string code, List<TransactionRequest> transactionRequest)

UpsertTransactions: Upsert transactions

Create or update transactions in the transaction portfolio. A transaction will be updated  if it already exists and created if it does not.  The maximum number of transactions that this method can upsert per request is 10,000.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionPortfoliosApi(config);
            var scope = scope_example;  // string | The scope of the transaction portfolio.
            var code = code_example;  // string | The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio.
            var transactionRequest = new List<TransactionRequest>(); // List<TransactionRequest> | A list of transactions to be created or updated.

            try
            {
                // UpsertTransactions: Upsert transactions
                UpsertPortfolioTransactionsResponse result = apiInstance.UpsertTransactions(scope, code, transactionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionPortfoliosApi.UpsertTransactions: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the transaction portfolio. | 
 **code** | **string**| The code of the transaction portfolio. Together with the scope this uniquely identifies              the transaction portfolio. | 
 **transactionRequest** | [**List&lt;TransactionRequest&gt;**](TransactionRequest.md)| A list of transactions to be created or updated. | 

### Return type

[**UpsertPortfolioTransactionsResponse**](UpsertPortfolioTransactionsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The version of the transaction portfolio that contains the newly updated or inserted transactions |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

