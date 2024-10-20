﻿using EOD.APIs.Abstract;
using EOD.Model;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EOD.APIs
{
	internal class EndOfDayHistoriacalDataAPI : BaseAPI, IEndOfDayHistoricalDataAPI
	{
		private const string source = @"https://eodhistoricaldata.com/api/eod/{0}?from={1}&to={2}&period={3}&fmt=json";

		public EndOfDayHistoriacalDataAPI(string apiKey, System.Net.IWebProxy proxy, string source) : base(apiKey, proxy, source) { }

		public async Task<List<HistoricalStockPrice>> GetDataAsync(string ticker, DateTime from, DateTime to, string period)
		{
			object[] args = new object[]
			{
				ticker,
				from.ToString("yyyy-MM-dd"),
				to.ToString("yyyy-MM-dd"),
				period
			};
			string uri = string.Format(source, args);
			return await ExecuteQueryAsync<List<HistoricalStockPrice>>(uri);
		}
	}
}
