using System.Collections.Generic;

namespace Ocelot.Configuration.File
{
    public class FileAggregateReRoute : IReRoute
    {
        public List<string> ReRouteKeys { get;set; }
        public string UpstreamPathTemplate { get;set; }
        public string UpstreamHost { get; set; }
        public bool ReRouteIsCaseSensitive { get; set; }

        // Only supports GET..are you crazy!! POST, PUT WOULD BE CRAZY!! :)
        public List<string> UpstreamHttpMethod 
        { 
            get { return new List<string> {"Get"}; }
        }
    }
}
