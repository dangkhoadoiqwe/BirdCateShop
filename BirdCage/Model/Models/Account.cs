using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class Account
    {
        public Account()
        {
            BookingRequests = new HashSet<BookingRequest>();
            Carts = new HashSet<Cart>();
            Feedbacks = new HashSet<Feedback>();
            TrainingSchedules = new HashSet<TrainingSchedule>();
            UpdateProducts = new HashSet<UpdateProduct>();
        }

        public int AccountId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string ProfilePhoto { get; set; }
        public string Phone { get; set; }
        public int Role { get; set; }
        public int AccountStatus { get; set; }
        public string Email { get; set; }
        public int? Point { get; set; }
        public string Address { get; set; }

        public virtual ICollection<BookingRequest> BookingRequests { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<TrainingSchedule> TrainingSchedules { get; set; }
        public virtual ICollection<UpdateProduct> UpdateProducts { get; set; }
    }
}
