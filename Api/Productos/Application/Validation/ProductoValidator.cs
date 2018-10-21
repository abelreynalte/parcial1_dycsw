using DyCswParcial1.Api.Common.Domain.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DyCswParcial1.Api.Productos.Application.Validation
{
    public class ProductoValidator
    {
        public Notification Validate(bool? all)
        {
            Notification notification = new Notification();
            if (all == null)
            {
                notification.AddError("Missing command parameters");
                return notification;
            }
            return notification;
        }
    }
}
