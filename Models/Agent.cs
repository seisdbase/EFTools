﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EFTools.Models
{
    public partial class Agent
    {
        public int PartyKey { get; set; }
        public string AgentId { get; set; }
        public string BrokerId { get; set; }
        public string LicenseNbr { get; set; }
        public DateOnly? LicenseValidFrom { get; set; }
        public DateOnly? LicenseValidTo { get; set; }
        public string EmployeeFlag { get; set; }
        public string TiedAgentFlag { get; set; }
        public string SourceSystem { get; set; }
    }
}