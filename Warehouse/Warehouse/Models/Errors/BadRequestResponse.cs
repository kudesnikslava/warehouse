using System.Net;

namespace Warehouse.Models.Errors
{
    public class BadRequestResponse : ErrorResponse
    {
        public BadRequestResponse(string description) : base(HttpStatusCode.BadRequest, description)
        {
        }
    }
}