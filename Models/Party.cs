﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EFTools.Models
{
    public partial class Party
    {
        public int PartyKey { get; set; }
        public int? MasterPartyKey { get; set; }
        public string PartyKindCd { get; set; }
        public string PartyTypeCd { get; set; }
        public string SourceSystem { get; set; }
    }
}