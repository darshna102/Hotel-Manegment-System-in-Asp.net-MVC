﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManegment.ViewModel
{
    public class RoomBookingViewModel
    {
        public int BookingId { get; set; }
        public string CustomerName { get; set; }
        public int NoOfMembers { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public DateTime BookingForm { get; set; }
        public decimal RoomPrice { get; set; }
        public DateTime BookingTo { get; set; }
        public string RoomNumber { get; set; }
        public decimal TotalAmount { get; set; }
        public int NumberOfDays { get; set; }
    }
}