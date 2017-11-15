﻿using System;
namespace CustomerSystemDAL.Entities
{
    public class OrderItem : IEntity
    {

        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }

        public Double UnitPrice { get; set; }
    }
}
