using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly2_0.Models;

namespace Vidly2_0.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}