# Lusid.Sdk.Model.EquityOption
Lusid-ibor internal representation of a plain vanilla equity option instrument.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument | 
**StartDate** | **DateTimeOffset** | The start date of the instrument. This is normally synonymous with the trade-date. | 
**OptionMaturityDate** | **DateTimeOffset** | The maturity date of the option. | 
**OptionSettlementDate** | **DateTimeOffset** | The settlement date of the option. | 
**DeliveryType** | **string** | is the option cash settled or physical delivery of option  Supported string (enumeration) values are: [Cash, Physical]. | 
**OptionType** | **string** | Type of optionality for the option  Supported string (enumeration) values are: [Call, Put]. | 
**Strike** | **decimal** | The strike of the option. | 
**DomCcy** | **string** | The domestic currency of the instrument. | 
**UnderlyingIdentifier** | **string** | The market identifier type of the underlying code, e.g RIC.  Supported string (enumeration) values are: [LusidInstrumentId, Isin, Sedol, Cusip, ClientInternal, Figi, RIC, QuotePermId, REDCode, BBGId, ICECode]. | 
**Code** | **string** | The identifying code for the equity underlying, e.g. &#39;IBM.N&#39;. | 
**EquityOptionType** | **string** | Equity option types. E.g. Vanilla (default), RightsIssue, Warrant.  Supported string (enumeration) values are: [Vanilla, RightsIssue, Warrant]. | [optional] 
**NumberOfShares** | **decimal?** | The amount of shares to exchange if the option is exercised. | [optional] 
**Premium** | [**Premium**](Premium.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

