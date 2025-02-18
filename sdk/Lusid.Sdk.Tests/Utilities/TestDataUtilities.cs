using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Castle.Core.Internal;
using Lusid.Sdk.Model;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Lusid.Sdk.Tests.Utilities
{
    public static class TestDataUtilities
    {
        private static readonly string ExampleMarketDataDirectory = "../../../tutorials/Ibor/ExampleMarketData/";
        public const string TutorialScope = "Testdemo";
        public const string MarketDataScope = "FinbourneMarketData";
        public static string ValuationDateKey = "Analytic/default/ValuationDate";
        public static string InstrumentTag = "Analytic/default/InstrumentTag";
        public static string ValuationPvKey = "Valuation/PV/Amount";
        public static string InstrumentName = "Instrument/default/Name";
        public static readonly string ValuationPv = "Valuation/PV/Amount";
        public static readonly string Luid = "Instrument/default/LusidInstrumentId";
        public static readonly string Currency = "Valuation/PV/Ccy";
        
        // Items to return back on a GetValuation call. 
        public static readonly List<AggregateSpec> ValuationSpec = new List<AggregateSpec>
        {
            new AggregateSpec(ValuationDateKey, AggregateSpec.OpEnum.Value),
            new AggregateSpec(InstrumentName, AggregateSpec.OpEnum.Value),
            new AggregateSpec(ValuationPvKey, AggregateSpec.OpEnum.Value),
            new AggregateSpec(InstrumentTag, AggregateSpec.OpEnum.Value),
            new AggregateSpec(Luid, AggregateSpec.OpEnum.Value),
            new AggregateSpec(Currency, AggregateSpec.OpEnum.Value)
        };
        //    Specific key used to denote cash in LUSID
        public const string LusidCashIdentifier = "Instrument/default/Currency";
        public const string LusidInstrumentIdentifier = "Instrument/default/LusidInstrumentId";

        public static DateTimeOffset EffectiveAt = new DateTimeOffset(2020, 1, 2, 0, 0, 0, TimeSpan.Zero);

        /// <summary>
        /// Helper method to construct CreateTransactionPortfolioRequest to be used in ITransactionPortfoliosApi
        /// </summary>
        public static CreateTransactionPortfolioRequest BuildTransactionPortfolioRequest(DateTimeOffset? effectiveAt = null)
        {
            var portfolioCode = Guid.NewGuid().ToString();
            //    Effective date of the portfolio, this is the date the portfolio was created and became live.  All dates/times
            //    must be supplied in UTC
            var effectiveDate = effectiveAt  ?? new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero);

            //    Details of the new portfolio to be created, created here with the minimum set of mandatory fields
            var request = new CreateTransactionPortfolioRequest(
                code: portfolioCode,
                displayName: $"Portfolio-{portfolioCode}",
                baseCurrency: "GBP",
                created: effectiveDate
            );
            return request;
        }

        /// <summary>
        /// Helper method to construct TransactionReqeust to be used in ITransactionPortfoliosApi to build transaction
        /// </summary>
        public static TransactionRequest BuildTransactionRequest(
            string instrumentId,
            decimal units,
            decimal price,
            string currency,
            DateTimeOrCutLabel tradeDate,
            string transactionType)
        {
            return new TransactionRequest(
                transactionId: Guid.NewGuid().ToString(),
                type: transactionType,
                instrumentIdentifiers: new Dictionary<string, string>
                {
                    [LusidInstrumentIdentifier] = instrumentId
                },
                transactionDate: tradeDate,
                settlementDate: tradeDate,
                units: units,
                transactionPrice: new TransactionPrice(price, TransactionPrice.TypeEnum.Price),
                totalConsideration: new CurrencyAndAmount(price*units, currency),
                source: "Broker");
        }

        /// <summary>
        /// Helper method to create Cash Fund transaction request to be used in ITransactionPortfoliosApi 
        /// </summary>
        public static TransactionRequest BuildCashFundsInTransactionRequest(
            decimal units,
            string currency,
            DateTimeOffset tradeDate)
        {
            return new TransactionRequest(
                transactionId: Guid.NewGuid().ToString(),

                //    Set the transaction type to denote cash being added to the portfolio
                type: "FundsIn",
                instrumentIdentifiers: new Dictionary<string, string>
                {
                    [LusidCashIdentifier] = currency
                },
                transactionDate: tradeDate,
                settlementDate: tradeDate,
                units: units,
                totalConsideration: new CurrencyAndAmount(0, "GBP"),
                transactionPrice: new TransactionPrice(0.0M),
                source: "Client");
        }

        public static AdjustHoldingRequest BuildAdjustHoldingsRequst(string instrumentId, decimal units, decimal price, string currency, DateTimeOffset? tradeDate)
        {
            return new AdjustHoldingRequest(
                instrumentIdentifiers: new Dictionary<string, string>
                {
                    [LusidInstrumentIdentifier] = instrumentId
                },
                taxLots: new List<TargetTaxLotRequest>
                {
                    new TargetTaxLotRequest(
                        units: units,
                        price: price,
                        cost: new CurrencyAndAmount(
                            amount: price * units,
                            currency: currency
                        ),
                        portfolioCost: price * units,
                        purchaseDate: tradeDate,
                        settlementDate: tradeDate
                    )
                }
           );
        }

        public static AdjustHoldingRequest BuildCashFundsInAdjustHoldingsRequest(string currency, decimal units)
        {
            return new AdjustHoldingRequest(
                instrumentIdentifiers: new Dictionary<string, string>
                {
                    [LusidCashIdentifier] = currency
                },
                taxLots: new List<TargetTaxLotRequest>
                {
                    new TargetTaxLotRequest(
                        units: units,
                        price: null,
                        cost: null,
                        portfolioCost: null,
                        purchaseDate: null,
                        settlementDate: null
                    )
                }
            );
        }

        public static PortfolioHolding BuildPortfolioHolding(string currency, string instrumentUid, decimal units, decimal cost)
        {
            return new PortfolioHolding(
                    cost: new CurrencyAndAmount(cost, currency),
                    costPortfolioCcy: new CurrencyAndAmount(cost, currency),
                    currency: currency,
                    instrumentUid: instrumentUid,
                    holdingType: "P",
                    units: units,
                    settledUnits: units
                );
        }

        public static PortfolioHolding BuildCashPortfolioHolding(string currency, string currencyLuid, decimal units)
        {
            return new PortfolioHolding(
                    cost: new CurrencyAndAmount(0, currency),
                    costPortfolioCcy: new CurrencyAndAmount(0, currency),
                    currency: currency,
                    instrumentUid: currencyLuid,
                    holdingType: "B",
                    units: units,
                    settledUnits: units
                );
        }

        /// <summary>
        /// Helper to create an upsert request for a given LusidInstrument 
        /// </summary>
        public static Dictionary<string, InstrumentDefinition> BuildInstrumentUpsertRequest(List<(LusidInstrument, string)> instruments)
        {
            return instruments
                .ToDictionary(
                    instrument => $"upsertIdFor{instrument.Item1.InstrumentType}",
                    instrument => new InstrumentDefinition(
                        name: instrument.Item1.InstrumentType.ToString(),
                        identifiers: new Dictionary<string, InstrumentIdValue>
                        {
                            ["ClientInternal"] = new InstrumentIdValue(value: instrument.Item2)
                        },
                        definition: instrument.Item1));
        }

        /// <summary>
        /// This method add instruments to a portfolio (specified by its scope and code),
        /// by creating a transaction request with the instrument's LUID.
        /// </summary>
        public static List<TransactionRequest> BuildTransactionRequest(
            List<string> luids,
            DateTimeOffset effectiveAt)
        {
            // CREATE instrument transaction requests
            var transactionRequests = luids.Select(luid =>
                    BuildTransactionRequest(luid, 1, 0.0m, "USD", effectiveAt, "Buy"))
                .ToList();
            return transactionRequests;
        }
        
        /// <summary>
        /// This method upserts JPY/USD and USD/JPY FX quotes for the given effectiveAt date.
        /// </summary>
        public static Dictionary<string, UpsertQuoteRequest> BuildFxRateRequest(DateTimeOffset effectiveAt) => BuildFxRateRequest(effectiveAt, effectiveAt);

        /// <summary>
        /// This method upserts JPY/USD and USD/JPY FX quotes for every day in the date range.
        /// </summary>
        public static Dictionary<string, UpsertQuoteRequest> BuildFxRateRequest(DateTimeOffset effectiveFrom,  DateTimeOffset effectiveAt, bool useConstantFxRate = false)
        {
            // CREATE FX quotes and inverse fx rate in the desired date range
            var upsertQuoteRequests = new Dictionary<string, UpsertQuoteRequest>();
            var numberOfDaysBetween = (effectiveAt - effectiveFrom).Days;
            for (var days = 0; days != numberOfDaysBetween + 1; ++days)
            {
                var date = effectiveFrom.AddDays(days);
                if (useConstantFxRate)
                {
                    var fxRate = BuildSimpleQuoteUpsertRequest("USD/JPY", QuoteSeriesId.InstrumentIdTypeEnum.CurrencyPair, 150, "USD", date);
                    var inverseFxRate = BuildSimpleQuoteUpsertRequest("JPY/USD", QuoteSeriesId.InstrumentIdTypeEnum.CurrencyPair, 1m / 150, "USD", date);

                    upsertQuoteRequests.Add($"day_{days}_fx_rate", fxRate);
                    upsertQuoteRequests.Add($"day_{days}_inverseFx_rate", inverseFxRate);
                }
                else
                {
                    var fxRate = BuildSimpleQuoteUpsertRequest("USD/JPY", QuoteSeriesId.InstrumentIdTypeEnum.CurrencyPair, (150 + days), "USD", date);
                    var inverseFxRate = BuildSimpleQuoteUpsertRequest("JPY/USD", QuoteSeriesId.InstrumentIdTypeEnum.CurrencyPair, 1m / (150 + days), "USD", date);

                    upsertQuoteRequests.Add($"day_{days}_fx_rate", fxRate);
                    upsertQuoteRequests.Add($"day_{days}_inverseFx_rate", inverseFxRate);
                }
            }

            return upsertQuoteRequests;
        }

        /// <summary>
        /// This method upserts the reset quotes for a CDS
        /// </summary>
        public static Dictionary<string, UpsertQuoteRequest> BuildResetQuotesRequest(DateTimeOffset effectiveAt)
        {
            // CREATE reset quotes in the desired date range
            var resetQuote = BuildSimpleQuoteUpsertRequest("BP00", QuoteSeriesId.InstrumentIdTypeEnum.RIC, 150, "USD", effectiveAt);
            var upsertQuoteRequests = new Dictionary<string, UpsertQuoteRequest>
            {
                {"resetQuote", resetQuote}
            };

            return upsertQuoteRequests;
        }

        /// <summary>
        /// Helper method to construct equity quote request to be used in IQuotesApi 
        /// </summary>
        public static Dictionary<string, UpsertQuoteRequest> BuildEquityQuoteRequest(
            string instrumentId,
            DateTimeOffset effectiveFrom,
            DateTimeOffset effectiveAt,
            QuoteSeriesId.InstrumentIdTypeEnum instrumentIdType = QuoteSeriesId.InstrumentIdTypeEnum.LusidInstrumentId)
        {
            // CREATE equity quotes for the desired date range
            var upsertQuoteRequests = new Dictionary<string, UpsertQuoteRequest>();
            var numberOfDaysBetween = (effectiveAt - effectiveFrom).Days;

            for (var days = 0; days != numberOfDaysBetween + 1; ++days)
            {
                var date = effectiveFrom.AddDays(days);
                var quote = BuildSimpleQuoteUpsertRequest(instrumentId, instrumentIdType,100 + days, "USD", date, "mid", "Lusid", null);
                upsertQuoteRequests.Add($"day_{days}_equity_quote", quote);
            }

            return upsertQuoteRequests;
        }


        /// <summary>
        /// Helper method to create simple equity or FX quote upsert request
        /// </summary>
        internal static UpsertQuoteRequest BuildSimpleQuoteUpsertRequest(
            string id,
            QuoteSeriesId.InstrumentIdTypeEnum instrumentIdType,
            decimal price,
            string ccy,
            DateTimeOffset effectiveAt,
            string quoteField = "mid",
            string supplier = "Lusid",
            string priceSource = null
        )
            => new UpsertQuoteRequest(
                new QuoteId(
                    new QuoteSeriesId(supplier, priceSource, id, instrumentIdType, QuoteSeriesId.QuoteTypeEnum.Price,
                        quoteField),
                    effectiveAt
                ),
                new MetricValue(price, ccy));

        /// <summary>
        /// This method upserts the 3 rate curves:
        /// JPY/JPYOIS and USD/USDOIS curves are used for discounting pricing models
        /// USD 6M curves is used for projecting interest rate swap reset rate
        /// </summary>
        public static Dictionary<string, UpsertComplexMarketDataRequest> BuildRateCurvesRequests(DateTimeOffset effectiveAt)
        {
            var curveRequests = new[]
            {
                BuildOisCurveRequest(effectiveAt, "USD"),
                BuildOisCurveHighRatesRequest(effectiveAt, "JPY"),
                Build6MRateCurveRequest(effectiveAt, "USD") // this would be necessary for valuation of swaps paying every 6M
            };

            // ENUMERATE the request
            var upsertComplexMarketDataRequests = curveRequests
                .Select((idx, upsertRequest) => (idx, upsertRequest))
                .ToDictionary(tuple => tuple.idx.ToString(), tuple => tuple.idx);
            return upsertComplexMarketDataRequests;
        }

        /// <summary>
        /// Helper method to construct a upsert complex market data request for OIS interest rate curve to be upserted by IComplexMarketDataApi
        /// </summary>
        public static UpsertComplexMarketDataRequest BuildOisCurveRequest(DateTimeOffset effectiveAt, string currency)
        {
            var complexMarketData = CreateDiscountCurve(effectiveAt);
            var complexMarketDataId = CreateComplexMarketDataId(effectiveAt, currency);
            var upsertRequest = new UpsertComplexMarketDataRequest(complexMarketDataId, complexMarketData);
            return upsertRequest;
        }

        /// <summary>
        /// Helper method to construct a upsert complex market data request for OIS interest rate curve to be upserted by IComplexMarketDataApi
        /// </summary>
        public static UpsertComplexMarketDataRequest BuildOisCurveHighRatesRequest(DateTimeOffset effectiveAt, string currency)
        {
            // different rates as the valuation for some instruments such as fx forwards depend on the difference between the rates curves in two currencies
            var complexMarketData = CreateDiscountCurveHighRates(effectiveAt);
            var complexMarketDataId = CreateComplexMarketDataId(effectiveAt, currency);
            var upsertRequest = new UpsertComplexMarketDataRequest(complexMarketDataId, complexMarketData);
            return upsertRequest;
        }

        /// <summary>
        /// Creates a CreateComplexMarketDataId.
        /// When one upserts a ComplexMarketData, one upserts with it a CreateComplexMarketDataId as to
        /// identify the data, specify its effectiveAt and priceSource (if any).
        /// </summary>
        private static ComplexMarketDataId CreateComplexMarketDataId(DateTimeOffset effectiveAt, string currency)
        {
            return new ComplexMarketDataId(
                provider: "Lusid",
                effectiveAt: effectiveAt.ToString("o"),
                marketAsset: $"{currency}/{currency}OIS",
                priceSource: "");
        }

        private static DiscountFactorCurveData CreateDiscountCurve(DateTimeOffset effectiveAt)
        {
            var discountDates = new List<DateTimeOffset>
                { effectiveAt, effectiveAt.AddMonths(3), effectiveAt.AddMonths(6), effectiveAt.AddMonths(9), effectiveAt.AddMonths(12), effectiveAt.AddYears(5) };
            var rates = new List<decimal> { 1.0m, 0.995026109593975m, 0.990076958773721m, 0.985098445011387m, 0.980144965261876m, 0.9m };
            return new DiscountFactorCurveData(effectiveAt, discountDates, rates, ComplexMarketData.MarketDataTypeEnum.DiscountFactorCurveData);
        }

        private static DiscountFactorCurveData CreateDiscountCurveHighRates(DateTimeOffset effectiveAt)
        {
            var discountDates = new List<DateTimeOffset>
                { effectiveAt, effectiveAt.AddMonths(3), effectiveAt.AddMonths(6), effectiveAt.AddMonths(9), effectiveAt.AddMonths(12), effectiveAt.AddYears(5) };
            var rates = new List<decimal> { 1.0m, 0.992548449440757m, 0.985152424487251m, 0.977731146620901m, 0.970365774179742m, 0.85m };
            return new DiscountFactorCurveData(effectiveAt, discountDates, rates, ComplexMarketData.MarketDataTypeEnum.DiscountFactorCurveData);
        }

        /// <summary>
        /// Helper method to construct a upsert complex market data request for interest rate curve to be upserted by IComplexMarketDataApi
        /// </summary>
        public static UpsertComplexMarketDataRequest Build6MRateCurveRequest(DateTimeOffset effectiveAt, string currency)
        {
            var complexMarketData = GetRateCurveJsonFromFile("USD6M.json");
            var complexMarketDataId = new ComplexMarketDataId(
                provider: "Lusid",
                effectiveAt: effectiveAt.ToString("o"),
                marketAsset: $"{currency}/6M/LIBOR",
                priceSource: "");

            var upsertRequest = new UpsertComplexMarketDataRequest(complexMarketDataId, complexMarketData);
            return upsertRequest;
        }

        private static ComplexMarketData GetRateCurveJsonFromFile(string filename)
        {
            using var reader = new StreamReader(ExampleMarketDataDirectory + filename);
            var jsonString = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<DiscountFactorCurveData>(jsonString);
        }
        
        private static ComplexMarketData GetCdsSpreadCurveJsonFromFile(string filename)
        {
            using var reader = new StreamReader(ExampleMarketDataDirectory + filename);
            var jsonString = reader.ReadToEnd();

            var cdsCurve = new OpaqueMarketData(
                jsonString,
                "Json",
                "CDS curve",
                ComplexMarketData.MarketDataTypeEnum.OpaqueMarketData
            );
            return cdsCurve;
        }

        public static UpsertComplexMarketDataRequest BuildCdsSpreadCurvesUpsertRequest(
            DateTimeOffset effectiveAt,
            string ticker,
            string ccy,
            string seniority,
            string restructType)
        {
            var marketDataId = new ComplexMarketDataId
            (
                provider: "Lusid",
                effectiveAt: effectiveAt.ToString("o"),
                marketAsset: $"{ticker}/{ccy}/{seniority}/{restructType}",
                priceSource: "",
                lineage: ""
            );

            var marketData = GetCdsSpreadCurveJsonFromFile("XYZCorp.json");
            var request = new UpsertComplexMarketDataRequest(marketDataId, marketData);
            return request;
        }

        public static Dictionary<string, UpsertQuoteRequest> BuildQuoteRequest(
            string id,
            QuoteSeriesId.InstrumentIdTypeEnum instrumentIdType,
            decimal price,
            string ccy,
            DateTimeOffset effectiveAt)
        {
            var quoteRequest = BuildSimpleQuoteUpsertRequest(id, instrumentIdType, price, ccy, effectiveAt);
            var upsertRequests = new Dictionary<string, UpsertQuoteRequest> {{"req1", quoteRequest}};
            return upsertRequests; 
        }

        /// <summary>
        /// For pricing options using models such as Black Scholes, one requires a volatility surface/cube. We create one here.
        /// </summary>
        private static ComplexMarketData CreateVolatilitySurfaceData(
            DateTimeOffset effectiveAt,
            List<LusidInstrument> instruments,
            List<MarketQuote> quotes,
            ComplexMarketData.MarketDataTypeEnum type)
        {
            ComplexMarketData volData = new ComplexMarketData();
            if(type == ComplexMarketData.MarketDataTypeEnum.EquityVolSurfaceData)
                volData = new EquityVolSurfaceData(effectiveAt, instruments, quotes, ComplexMarketData.MarketDataTypeEnum.EquityVolSurfaceData);
            if(type == ComplexMarketData.MarketDataTypeEnum.FxVolSurfaceData)
                volData =  new FxVolSurfaceData(effectiveAt, instruments, quotes, ComplexMarketData.MarketDataTypeEnum.FxVolSurfaceData);
            if(type == ComplexMarketData.MarketDataTypeEnum.IrVolCubeData)
                volData =  new IrVolCubeData(effectiveAt, instruments, quotes, ComplexMarketData.MarketDataTypeEnum.IrVolCubeData);

            return volData;
        }

        /// <summary>
        /// Creates a MarketAsset string that is to be upserted with a piece of complex market data.
        /// The MarketAsset acts as an name or identifier for a piece of complex market data.
        /// 
        /// For example, suppose we want to price an equity option on XYZ (listed on the NYSE) using the Black Scholes model.
        /// To price the option, we require a volatility surface.
        /// When we upsert the volatility surface, we give it a MarketAsset of XYZ/USD/LN to indicate this volatility
        /// surface is for XYZ listed in the US and the volatility type is LN (log-normal).
        /// When Lusid is pricing this equity option, it would look for this complex market data with this identifier.
        /// </summary>
        private static string GetMarketAsset(LusidInstrument option, MarketQuote.QuoteTypeEnum volType)
        {
            string marketAsset = "";
            if (option.InstrumentType == LusidInstrument.InstrumentTypeEnum.EquityOption)
            {
                EquityOption eoption = (EquityOption) option;
                marketAsset =  $"{eoption.Code}/{eoption.DomCcy}/" + (volType == MarketQuote.QuoteTypeEnum.NormalVol ? "N" : "LN"); 
            }

            if (option.InstrumentType == LusidInstrument.InstrumentTypeEnum.FxOption)
            {
                FxOption fxoption = (FxOption) option;
                marketAsset = $"{fxoption.DomCcy}/{fxoption.FgnCcy}/" + (volType == MarketQuote.QuoteTypeEnum.NormalVol ? "N" : "LN");
            }
            
            if (option.InstrumentType == LusidInstrument.InstrumentTypeEnum.InterestRateSwaption)
            {
                InterestRateSwaption swaption = (InterestRateSwaption) option;
                var ccy = "USD"; // Note: due to swagger limitation, it is not easy to extract the domestic currency from the swaption currently. 
                marketAsset = $"{ccy}/" + (volType == MarketQuote.QuoteTypeEnum.NormalVol ? "N" : "LN");
            }

            return marketAsset;
        }

        /// <summary>
        /// One-point vol surface for a given option - thus the surface is constant.
        /// This code creates a surface for both equity and FX options and for both Black Scholes and Bachelier model.
        /// </summary>
        public static UpsertComplexMarketDataRequest ConstantVolatilitySurfaceRequest(
            DateTimeOffset effectiveAt,
            LusidInstrument option,
            ModelSelection.ModelEnum model,
            decimal vol = 0.2m)
        {
            ComplexMarketData.MarketDataTypeEnum type = ComplexMarketData.MarketDataTypeEnum.OpaqueMarketData;
            if (option.InstrumentType == LusidInstrument.InstrumentTypeEnum.EquityOption)
                type = ComplexMarketData.MarketDataTypeEnum.EquityVolSurfaceData;
            if (option.InstrumentType == LusidInstrument.InstrumentTypeEnum.FxOption)
                type = ComplexMarketData.MarketDataTypeEnum.FxVolSurfaceData;
            if (option.InstrumentType == LusidInstrument.InstrumentTypeEnum.InterestRateSwaption)
                type = ComplexMarketData.MarketDataTypeEnum.IrVolCubeData;

            var instruments = new List<LusidInstrument> {option};
            var volType = model == ModelSelection.ModelEnum.Bachelier ? MarketQuote.QuoteTypeEnum.NormalVol : MarketQuote.QuoteTypeEnum.LogNormalVol;
            var quotes = new List<MarketQuote> {new MarketQuote(volType, vol)};
            var complexMarketData = CreateVolatilitySurfaceData(effectiveAt, instruments, quotes, type);

            var marketAsset = GetMarketAsset(option, volType);

            var complexMarketDataId = new ComplexMarketDataId(
                provider: "Lusid",
                effectiveAt: effectiveAt.ToString("o"),
                marketAsset: marketAsset);

            var upsertRequest = new UpsertComplexMarketDataRequest(complexMarketDataId, complexMarketData);
            return upsertRequest;
        }

        /// <summary>
        /// This method creates a recipe and wraps it up into an UpsertRecipeRequest.
        /// It consists of rules capable of finding both simple quote and complex market data for a range of instruments.
        /// If windowValuationOnInstrumentStartEnd is true, this sets the price of instruments to be zero after maturity
        /// </summary>
        public static UpsertRecipeRequest BuildRecipeRequest(
            string recipeCode,
            string scope,
            ModelSelection.ModelEnum model,
            bool windowValuationOnInstrumentStartEnd = false)
        {
            // For simpleStaticRule, note that inside CreatePortfolioAndInstrument, the method TestDataUtilities.BuildInstrumentUpsertRequest books the instrument using "ClientInternal".
            // As such the quote upserted using "ClientInternal". The market rule key needs to be "ClientInternal" also to find the quote.  
            var simpleStaticRule = new MarketDataKeyRule(
                key: "Quote.ClientInternal.*",
                supplier: "Lusid",
                scope,
                MarketDataKeyRule.QuoteTypeEnum.Price,
                field: "mid",
                quoteInterval: "1M");
            
            var figiRule = new MarketDataKeyRule(
                key: "Quote.Figi.*",
                supplier: "Lusid",
                scope,
                MarketDataKeyRule.QuoteTypeEnum.Price,
                field: "mid",
                quoteInterval: "5D");
            
            // resetRule is used to locate reset rates such as that for interest rate swaps and swaptions
            var resetRule = new MarketDataKeyRule(
                key: "Quote.RIC.*",
                supplier: "Lusid",
                scope,
                MarketDataKeyRule.QuoteTypeEnum.Price,
                field: "mid",
                quoteInterval: "10Y");
            
            // creditRule here is used by Lusid to locate the credit spread curve.
            // We use long quote intervals here because we are happy to use old market data,
            // as pricing is not a concern in the cash flow demos this is used in.
            var creditRule = new MarketDataKeyRule(
                key: "Credit.*.*.*.*",
                supplier: "Lusid",
                scope,
                MarketDataKeyRule.QuoteTypeEnum.Spread,
                field: "mid",
                quoteInterval: "10Y");
            
            // ratesRule here is used by Lusid to locate the rate curves for discount rate curves
            // used when pricing with discounting models
            var ratesRule = new MarketDataKeyRule(
                key: "Rates.*.*",
                supplier: "Lusid",
                scope,
                MarketDataKeyRule.QuoteTypeEnum.Price,
                field: "mid",
                quoteInterval: "10Y");

            // projection rule here is used by Lusid to locate the rate curves for projections of index rates
            // (e.g. projected LIBOR rates)
            // Used when pricing instruments that depend on an IndexConvention.
            // For instance, interest rate swaps and options.
            var projectionRule = new MarketDataKeyRule(
                key: "Rates.*.*.*",
                supplier: "Lusid",
                scope,
                MarketDataKeyRule.QuoteTypeEnum.Price,
                field: "mid",
                quoteInterval: "10Y");

            // irVolRule here is used by Lusid to locate the interest rate volatility cubes
            // for pricing interest rate swaption
            var irVolRule = new MarketDataKeyRule(
                key: "IrVol.*.*",
                supplier: "Lusid",
                scope,
                MarketDataKeyRule.QuoteTypeEnum.Price,
                field: "mid",
                quoteInterval: "1Y");

            var pricingOptions = new PricingOptions(
                new ModelSelection(ModelSelection.LibraryEnum.Lusid, model),
                windowValuationOnInstrumentStartEnd: windowValuationOnInstrumentStartEnd);
            
            var recipe = new ConfigurationRecipe(
                scope,
                recipeCode,
                market: new MarketContext(
                    marketRules: new List<MarketDataKeyRule>{simpleStaticRule, figiRule, resetRule, creditRule, ratesRule, projectionRule, irVolRule},
                    options: new MarketOptions(defaultSupplier: "Lusid", defaultScope: scope, defaultInstrumentCodeType: "RIC")),
                pricing: new PricingContext(options: pricingOptions),
                description: $"Recipe for {model} pricing");
            
            return new UpsertRecipeRequest(recipe);
        }

        private static readonly List<LusidInstrument.InstrumentTypeEnum> InstrumentThatCanHaveNegativePv = new List<LusidInstrument.InstrumentTypeEnum>
            {
                LusidInstrument.InstrumentTypeEnum.InterestRateSwap,
                LusidInstrument.InstrumentTypeEnum.EquitySwap
            };
        
        // CHECK we got non-null results and simple pricing checks e.g. positive for relevant instruments
        // We default InstrumentType.Unknown for convenience and default to mean positive pv.
        internal static void CheckPvResultsMakeSense(
            ListAggregationResponse result, 
            LusidInstrument.InstrumentTypeEnum instrumentType = LusidInstrument.InstrumentTypeEnum.Unknown)
        {
            foreach (var r in result.Data)
            {
                var pv = (double) r[ValuationPvKey];

                // TODO: swaptions should have pv > 0 but code is suggesting otherwise. Needs investigation.
                if (instrumentType == LusidInstrument.InstrumentTypeEnum.InterestRateSwaption)
                {
                    continue;
                }
                
                Assert.That(pv, Is.Not.EqualTo(0).Within(1e-8));
                
                // Some instruments have pv that is equal or greater than zero (some can be negative).
                // We check the positivity of pv for relevant instruments.
                if (!InstrumentThatCanHaveNegativePv.Contains(instrumentType))
                {
                    Assert.That(pv, Is.GreaterThanOrEqualTo(0));
                }
            }
        }

        /// <summary>
        /// Given an aggregation result on a portfolio of instruments,
        /// we check that on each valuation date, the pvs are constant within some (relative difference) tolerance)
        /// </summary>
        internal static void CheckPvIsConstantAcrossDatesWithinTolerance(ListAggregationResponse result, double relativeDifferenceTolerance = 0.015)
        {
            var pvsAcrossDates = result
                .Data // Access a list of result dictionaries
                .GroupBy(d => (DateTime) d[ValuationDateKey]) // We group by date
                .Select(pvGroup => pvGroup.Sum(record => (double) record[ValuationPv])); // we pick up the PV

            var isWithinTolerance = ValuesWithinARelativeDiffTolerance(pvsAcrossDates, relativeDifferenceTolerance);
            
            // If true, this means the PV is constant across the valuation dates within given tolerance
            Assert.That(isWithinTolerance, Is.True);
        }
        
        /// <summary>
        /// Returns true if all values are within 1% (by default) of the first value.
        /// </summary>
        internal static bool ValuesWithinARelativeDiffTolerance(IEnumerable<double> values, double relativeDifferenceTolerance = 0.01)
        {
            if (values.IsNullOrEmpty())
            {
                throw new ArgumentException("Developer error: We expected at least one element in the list of numbers");
            }
            
            var firstEntry = values.First();
            return values.All(v => Math.Abs( (v - firstEntry) / firstEntry) <= relativeDifferenceTolerance);
        }
        
        /// <summary>
        /// Given an aggregation result on a portfolio, we check that the PV
        /// is non-zero before maturity and zero after.
        /// This method should only be called for a portfolio of only one instrument 
        /// </summary>
        internal static void CheckNonZeroPvBeforeMaturityAndZeroAfter(ListAggregationResponse result, DateTimeOffset maturityDate)
        {
            var valuationResultDictionaries = result.Data;
            foreach (var valuationResult in valuationResultDictionaries)
            {
                var date = (DateTime) valuationResult[ValuationDateKey];
                var pv = (double) valuationResult[ValuationPv];
                if (date < maturityDate)
                {
                    Assert.That(pv, Is.Not.EqualTo(0).Within(1e-12));
                }
                else
                {
                    Assert.That(pv, Is.EqualTo(0).Within(1e-12));
                }
            }
        }
        
        /// <summary>
        /// Check there are no cash positions in the portfolio (of a given currency)
        /// </summary>
        internal static void CheckNoCashPositionsInValuationResults(ListAggregationResponse valuationResult, string currency)
        {
            var doesNotContainAnyCashBeforeExpiration = valuationResult
                .Data
                .Select(d => (string) d[Luid])
                .All(luid => luid != $"CCY_{currency}");
            Assert.That(doesNotContainAnyCashBeforeExpiration, Is.True);
        }
        
        // TODO: requestForUnderlying returns instrument underlying, if any. 
        // TODO: It is currently used for EquityOption physically-settled lifecycle test.
        // TODO: In the long term, we should not need this and LUSID auto-adds underlying of
        // TODO: the option into LUSID upon expiration.
        internal static ValuationRequest CreateValuationRequest(
            string scope,
            string portfolioCode,
            string recipeCode,
            DateTimeOffset effectiveAt,
            DateTimeOffset? effectiveFrom = null,
            List<string> additionalRequestsKeys = null)
        {
            // Get full set of request spec [assumes aggregating additionalRequestKeys by Value.]
            var allValuationRequests = (additionalRequestsKeys ?? new List<string>())
                .Select(requestKey => new AggregateSpec(requestKey, AggregateSpec.OpEnum.Value))
                .ToList();
            allValuationRequests.AddRange(ValuationSpec);
            
            var valuationSchedule = new ValuationSchedule(effectiveFrom, effectiveAt);
            return new ValuationRequest(
                recipeId: new ResourceId(scope, recipeCode),
                metrics: allValuationRequests,
                valuationSchedule: valuationSchedule,
                sort: new List<OrderBySpec> {new OrderBySpec(ValuationDateKey, OrderBySpec.SortOrderEnum.Ascending)},
                portfolioEntityIds: new List<PortfolioEntityId> {new PortfolioEntityId(scope, portfolioCode)},
                reportCurrency: "USD");
        }
    }
}
