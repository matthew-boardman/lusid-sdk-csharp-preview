# Lusid.Sdk.Model.PlacementRequest
A request to create or update a Placement.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**BlockIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | IDs of Blocks associated with this placement. | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this order. | [optional] 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | The instrument ordered. | 
**Quantity** | **decimal** | The quantity of given instrument ordered. | 
**State** | **string** | The state of this placement (typically a FIX state; Open, Filled, etc). | 
**Side** | **string** | The side (Buy, Sell, ...) of this placement. | 
**TimeInForce** | **string** | The time in force applicable to this placement (GTC, FOK, Day, etc) | 
**Type** | **string** | The type of this placement (Market, Limit, etc). | 
**CreatedDate** | **DateTimeOffset** | The active date of this placement. | 
**LimitPrice** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**StopPrice** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**Counterparty** | **string** | The market entity this placement is placed with. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

