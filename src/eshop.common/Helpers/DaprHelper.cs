using Dapr.Client.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace eshop.common
{
    public class DaprHelper
    {
        public static HTTPExtension GetGetHttpExtension()
        {
            HTTPExtension httpExtension = new HTTPExtension()
            {
                Verb = HTTPVerb.Post
            };
            return httpExtension;
        }

        public static HTTPExtension GetPostHttpExtension()
        {
            HTTPExtension httpExtension = new HTTPExtension()
            {
                Verb = HTTPVerb.Post
            };
            return httpExtension;
        }
    }
}
