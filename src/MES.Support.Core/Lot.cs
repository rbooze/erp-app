using System;
using System.Collections.Generic;
using System.Text;

namespace MES.Support.Core
{
    public class Lot
    {
        public int LotID { get; set; }

        public string LotNumber { get; set; } = "";

        public string Status { get; set; } = "";

        public int QuantityCompleted { get; set; }
    }
}
