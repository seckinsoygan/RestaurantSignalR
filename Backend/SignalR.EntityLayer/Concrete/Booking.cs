﻿using SignalR.EntityLayer.Abstract;

namespace SignalR.EntityLayer.Concrete
{
    public class Booking : BaseEntity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public int PersonCount { get; set; }
        public DateTime Date { get; set; }
    }
}
