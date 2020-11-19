using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GoogleBooksChallenge.Core.Models
{
    public class AccessInfo
    {
        [JsonProperty("webReaderLink")]
        public Uri WebReaderLink { get; set; }
    }
}
