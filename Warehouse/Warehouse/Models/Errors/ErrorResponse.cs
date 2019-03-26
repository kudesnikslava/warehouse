using System;
using System.Net;
using Newtonsoft.Json;

namespace Warehouse.Models.Errors
{
    [Serializable]
    public class ErrorResponse
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="code"></param>
        /// <param name="description"></param>
        public ErrorResponse(HttpStatusCode code, string description)
        {
            Code = code;
            Description = description;
        }
        
        /// <summary>
        /// Http Code
        /// </summary>
        [JsonProperty]
        public HttpStatusCode Code { get; private set; }
        
        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty]
        public string Description { get; private set; }
    }
}