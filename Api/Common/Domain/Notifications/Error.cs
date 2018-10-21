using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DyCswParcial1.Api.Common.Domain.Notifications
{
    public class Error
    {
        public string Message { get; set; }

        public Error(string message)
        {
            Message = message;
        }
    }
}
