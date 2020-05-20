using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.common
{
    public class DaprHelper
    {
        public static Dictionary<string, string> GetGetMetadata()
        {
            var metaData = new Dictionary<string, string>();
            metaData.Add("http.verb", "GET");
            return metaData;
        }

        public static Dictionary<string, string> GetPostMetadata()
        {
            var metaData = new Dictionary<string, string>();
            metaData.Add("http.verb", "POST");
            return metaData;
        }

        //public static HttpExtension GetGetHttpExtension()
        //{
        //    var metaData = new HttpExtension;
        //    metaData.Verb = HTTPVerb.Get;
        //    return metaData;
        //}
    }
}
