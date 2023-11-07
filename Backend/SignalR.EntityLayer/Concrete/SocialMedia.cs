﻿using SignalR.EntityLayer.Abstract;

namespace SignalR.EntityLayer.Concrete
{
    public class SocialMedia : BaseEntity
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}
