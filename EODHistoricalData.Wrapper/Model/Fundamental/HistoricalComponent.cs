﻿namespace EOD.Model.Fundamental
{
	/// <summary>
	/// 
	/// </summary>
	public class HistoricalComponent
	{
		/// <summary>
		/// 
		/// </summary>
		public string Code { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string StartDate { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public string EndDate { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int? IsActiveNow { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int? IsDelisted { get; set; }
	}
}

