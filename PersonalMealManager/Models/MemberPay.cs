using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonalMealManager.Models
{
    public class MemberPay
    {
       
        public int Id { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }

    }
}