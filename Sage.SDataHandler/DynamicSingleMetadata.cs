using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.Net.Http;
using System.Dynamic;

namespace Sage.SDataHandler
{
    class DynamicSingleMetadata
    {
        public DynamicSingleMetadata(HttpResponseMessage httpResponse, bool isIQueryable)
        {
            dynamic d = new ExpandoObject();
            d.somedynamicproperty = "asd";
        }
    }
}
