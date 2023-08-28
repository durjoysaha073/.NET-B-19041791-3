﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CartItemDTO
    {
        public int Id { get; set; }
       
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
