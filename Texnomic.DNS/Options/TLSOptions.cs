﻿using Texnomic.DNS.Abstractions;

namespace Texnomic.DNS.Options
{
    public class TLSOptions : IOptions
    {
        public int Timeout { get; set; } = 2000;

        public string Host { get; set; } = "dns.google";

        public int Port { get; set; } = 853;

        public string PublicKey { get; set; }
    }
}
