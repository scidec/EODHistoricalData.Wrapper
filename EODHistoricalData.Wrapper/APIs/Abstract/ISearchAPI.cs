﻿using EOD.Model;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace EOD.APIs.Abstract
{
	/// <summary>
	/// Search API for Stocks, ETFs, Mutual Funds and Indices
	/// </summary>
	internal interface ISearchAPI
	{
		Task<List<SearchResult>> GetQuerySearchExtendedAsync(string searchString);

	}
}
