﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EFTools.Models
{
    public partial class FinancialOption
    {
        public int AgreementBaseKey { get; set; }
        public string AmountBasisCd { get; set; }
        public string AmountBasisDesc { get; set; }
        public string PaymentFrequencyCd { get; set; }
        public string PaymentFrequencyDesc { get; set; }
        public double? Amount { get; set; }
        public string SourceSystem { get; set; }
    }
}