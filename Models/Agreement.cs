﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EFTools.Models
{
    public partial class Agreement
    {
        public int AgreementBaseKey { get; set; }
        public long? AgreementNumber { get; set; }
        public DateOnly? SignedDt { get; set; }
        public DateOnly? StartDt { get; set; }
        public string PaymentFrequencyCd { get; set; }
        public string PaymentFrequencyDesc { get; set; }
        public string StatusCd { get; set; }
        public string StatusDesc { get; set; }
        public string SourceSystem { get; set; }
    }
}