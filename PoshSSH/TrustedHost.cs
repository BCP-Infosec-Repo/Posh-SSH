using System.Collections.Generic;

namespace SSH
{
    public class TrustedHost
    {
        public string Host { get; set; }
        public IList<string> FingerPrints { get; set; }
    }
}
