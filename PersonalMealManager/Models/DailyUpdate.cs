using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalMealManager.Models
{
    public class DailyUpdate
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int MealCount { get; set; }
        public int GuestMealCount{get; set;}
        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}