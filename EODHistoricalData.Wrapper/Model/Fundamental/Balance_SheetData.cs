﻿using EOD.Utils;
using Newtonsoft.Json;
using System;

namespace EOD.Model.Fundamental
{
	/// <summary>
	/// 
	/// </summary>
	public class Balance_SheetData
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("Date")]
		private string DateJSON { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("none0")]
		public DateTime? Date { get => GetDate.ParseDate(DateJSON); }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("Filing_date")]
		private string Filing_dateJSON { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("none1")]
		public DateTime? Filing_date { get => GetDate.ParseDate(Filing_dateJSON); }
		/// <summary>
		/// 
		/// </summary>
		public string Currency_symbol { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? TotalAssets { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? IntangibleAssets { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? EarningAssets { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? OtherCurrentAssets { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? TotalLiab { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? TotalStockholderEquity { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? DeferredLongTermLiab { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? OtherCurrentLiab { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? CommonStock { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? CapitalStock { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? RetainedEarnings { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? OtherLiab { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? GoodWill { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? OtherAssets { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Cash { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? CashAndEquivalents { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? TotalCurrentLiabilities { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? CurrentDeferredRevenue { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? NetDebt { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? ShortTermDebt { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? ShortLongTermDebt { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? ShortLongTermDebtTotal { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? OtherStockholderEquity { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? PropertyPlantEquipment { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? TotalCurrentAssets { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? LongTermInvestments { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? NetTangibleAssets { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? ShortTermInvestments { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? NetReceivables { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? LongTermDebt { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Inventory { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? AccountsPayable { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? TotalPermanentEquity { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? NoncontrollingInterestInConsolidatedEntity { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? TemporaryEquityRedeemableNoncontrollingInterests { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? AccumulatedOtherComprehensiveIncome { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? AdditionalPaidInCapital { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? CommonStockTotalEquity { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? PreferredStockTotalEquity { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? RetainedEarningsTotalEquity { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? TreasuryStock { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? AccumulatedAmortization { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? NonCurrrentAssetsOther { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? DeferredLongTermAssetCharges { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? NonCurrentAssetsTotal { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? CapitalLeaseObligations { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? LongTermDebtTotal { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? NonCurrentLiabilitiesOther { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? NonCurrentLiabilitiesTotal { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? NegativeGoodwill { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? Warrants { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? PreferredStockRedeemable { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? CapitalSurpluse { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? LiabilitiesAndStockholdersEquity { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? CashAndShortTermInvestments { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? PropertyPlantAndEquipmentGross { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? PropertyPlantAndEquipmentNet { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? AccumulatedDepreciation { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? NetWorkingCapital { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? NetInvestedCapital { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public double? CommonStockSharesOutstanding { get; set; }
	}
}
