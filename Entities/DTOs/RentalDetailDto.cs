﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto:IDto
    {
        public int RentalId { get; set; }
        
        public int UserId { get; set; }
        public string User { get; set; }
        public string UserEmail { get; set; }
        public string CompanyName { get; set; }
        
        public int CarId { get; set; }
        public string ColorName { get; set; }
        public string BrandName { get; set; }
        public string ModelYear { get; set; }
        public string Description { get; set; }
        public decimal DailyPrice { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
