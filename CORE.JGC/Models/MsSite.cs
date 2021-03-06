﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CORE.JGC.Models
{
    public class MsSite
    {
        public int Id { get; set; }
        public string SiteCode { get; set; }
        public string SiteName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Telephone { get; set; }
        public bool bActive { get; set; }
        public string Iby { get; set; }
        public DateTime Ion { get; set; }
        public string Uby { get; set; }
        public DateTime Uon { get; set; }
    }
}