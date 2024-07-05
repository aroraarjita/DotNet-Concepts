using PlatformDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformDemo.ModelValidation
{
    public class Ticket_EnsureDueDateInTheFuture : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ticket = (Ticket)validationContext.ObjectInstance as Ticket;

            if (ticket != null && ticket.TicketId == null)
            {
                if (ticket.DueDate.HasValue && ticket.DueDate.Value.Date < DateTime.Now)
                {
                    return new ValidationResult("Due date has to be in future");
                }

            }

            return ValidationResult.Success;

        }

    }
}
