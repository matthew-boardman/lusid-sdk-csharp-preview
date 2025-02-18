# Lusid.Sdk.Model.MarketDataKeyRule
When performing analytics, instruments and models have dependencies on market data.  A market data key rule essentially tells lusid to \"resolve dependencies matching the pattern 'X' using data of the form 'Y'\".  The parameter 'X' is defined by the key of the key rule, and might specify \"all USD rates curves\" or \"all RIC-based prices\".  The parameter 'Y' is defined by the remaining fields of the key rule, and allows the user to configure things such as  where to look for data, what sort of data should be looked for (e.g. bid/mid/ask), and how old the data is allowed to be.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | A dot-separated string that defines a pattern for matching market data dependencies.  The form of the string depends on the type of the dependency; see below for basic types and the Knowledge Base for further info.  Quote lookup: \&quot;Quote.{CodeType}.{Identifier}\&quot; e.g. \&quot;Quote.RIC.IBM\&quot;  Fx rates: \&quot;Fx.CurrencyPair.{FgnCcy}{DomCcy}\&quot; e.g. \&quot;Fx.CurrencyPair.USDGBP\&quot;  Discounting curves: \&quot;Rates.{Currency}.{Currency}OIS e.g. \&quot;Rates.USD.USDOIS\&quot;                Trailing parameters can be replaced by the wildcard character &#39;*&#39;.  e.g. \&quot;Quote.RIC.*\&quot; matches any dependency on a RIC quote. | 
**Supplier** | **string** | The market data supplier (where the data comes from) | 
**DataScope** | **string** | The scope in which the data should be found when using this rule. | 
**QuoteType** | **string** | The available values are: Price, Spread, Rate, LogNormalVol, NormalVol, ParSpread, IsdaSpread, Upfront | 
**Field** | **string** | The conceptual qualification for the field, such as bid, mid, or ask.  The field must be one of a defined set for the given supplier, in the same way as it  is for the Finbourne.WebApi.Interface.Dto.Quotes.QuoteSeriesId | 
**QuoteInterval** | **string** | Shorthand for the time interval used to select market data. This must be a dot-separated string              nominating a start and end date, for example &#39;5D.0D&#39; to look back 5 days from today (0 days ago). The syntax              is &lt;i&gt;int&lt;/i&gt;&lt;i&gt;char&lt;/i&gt;.&lt;i&gt;int&lt;/i&gt;&lt;i&gt;char&lt;/i&gt;, where &lt;i&gt;char&lt;/i&gt; is one of D(ay), W(eek), M(onth) or Y(ear). | [optional] 
**AsAt** | **DateTimeOffset?** | The AsAt predicate specification. | [optional] 
**PriceSource** | **string** | The source of the quote. For a given provider/supplier of market data there may be an additional qualifier, e.g. the exchange or bank that provided the quote | [optional] 
**Mask** | **string** | Allows for partial or complete override of the market asset resolved for a dependency  Either a named override or a dot separated string (A.B.C.D.*).  e.g. for Rates curve &#39;EUR.*&#39; will replace the resolve MarketAsset &#39;GBP/12M&#39;, &#39;GBP/3M&#39; with the EUR equivalent, if there  are no wildcards in the mask, the mask is taken as the MarketAsset for any dependency matching the rule. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

