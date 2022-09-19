﻿using System;
using System.Collections.Generic;

namespace EOD.Model.BulkFundamental
{
    /// <summary>
    /// 
    /// </summary>
    public class Income_Statement
    {
        /// <summary>
        /// 
        /// </summary>
        public string Currency_symbol { get; set; }
        /// <summary>
        /// For bulk
        /// </summary>
        public Income_StatementData Quarterly_last_0 { get; set; }
        /// <summary>
        /// For bulk
        /// </summary>
        public Income_StatementData Quarterly_last_1 { get; set; }
        /// <summary>
        /// For bulk
        /// </summary>
        public Income_StatementData Quarterly_last_2 { get; set; }
        /// <summary>
        /// For bulk
        /// </summary>
        public Income_StatementData Quarterly_last_3 { get; set; }
        /// <summary>
        /// For bulk
        /// </summary>
        public Income_StatementData Yearly_last_0 { get; set; }
        /// <summary>
        /// For bulk
        /// </summary>
        public Income_StatementData Yearly_last_1 { get; set; }
        /// <summary>
        /// For bulk
        /// </summary>
        public Income_StatementData Yearly_last_2 { get; set; }
        /// <summary>
        /// For bulk
        /// </summary>
        public Income_StatementData Yearly_last_3 { get; set; }
    }
}