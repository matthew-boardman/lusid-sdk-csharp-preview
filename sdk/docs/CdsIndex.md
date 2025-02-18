# Lusid.Sdk.Model.CdsIndex
IL CDS Index Instrument; Lusid-ibor internal representation of a Credit Default Swap Index instrument  Calculation information and reference data can be obtained from Markit, e.g. https://www.markit.com/Documentation/Product/ITraxx

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument | 
**StartDate** | **DateTimeOffset** | The start date of the instrument. This is normally synonymous with the trade-date. | 
**MaturityDate** | **DateTimeOffset** | The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates that may well be observed or set prior to the maturity date, but refer to a termination date beyond it. | 
**FlowConventions** | [**CdsFlowConventions**](CdsFlowConventions.md) |  | [optional] 
**CouponRate** | **decimal** | The coupon rate paid on each payment date of the premium leg as a fraction of 100 percent, e.g. \&quot;0.05\&quot; meaning 500 basis points or 5%.  For a standard corporate CDS (North American) this must be either 100bps or 500bps. | 
**Identifiers** | **Dictionary&lt;string, string&gt;** | external market codes and identifiers for the cds index, e.g. a RED code, BBG ID or ICE code. | 
**Basket** | [**Basket**](Basket.md) |  | 
**ConventionName** | [**FlowConventionName**](FlowConventionName.md) |  | [optional] 
**Notional** | **decimal** | The notional quantity that applies to both the premium and protection legs. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

