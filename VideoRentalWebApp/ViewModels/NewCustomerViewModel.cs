using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoRentalWebApp.Models;

namespace VideoRentalWebApp.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipTypes> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}