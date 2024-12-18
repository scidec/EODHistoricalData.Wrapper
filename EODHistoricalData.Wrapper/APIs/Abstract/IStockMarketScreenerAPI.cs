﻿using EOD.Model.Screener;

using System.Threading.Tasks;

namespace EOD.APIs.Abstract
{
	internal interface IStockMarketScreenerAPI
	{
		/// <summary>
		/// 
		/// </summary>
		Task<StockMarkerScreener> GetStockMarketScreenerAsync(string filters = null, string signals = null,
			string sort = null, int? limit = null, int? offset = null);
	}
}
