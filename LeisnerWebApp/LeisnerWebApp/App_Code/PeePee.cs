using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeisnerWebApp.App_Code
{
    public class PeePee
    {
        public string size { get; set; }
        public int peePeeId { get; }

        public PeePee(string size, int peePeeId)
        {
            this.size = size;
            this.peePeeId = peePeeId;
        }
    }
}