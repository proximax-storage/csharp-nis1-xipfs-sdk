using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IO.XPX.Standard.Connection
{
    public class QueryParam
    {
        public string Params;
        //
        // Summary:
        //     Serialize Query Parameters
        public QueryParam(object obj)
        {
            this.Params = JsonConvert.SerializeObject(obj);
        }
    }
}
