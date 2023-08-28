﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL.DTOs
{
    public class ProductReviewDTO : ProductDTO
    {
        public List<ReviewDTO> Reviews { get; set; }

        public ProductReviewDTO()
        {
            Reviews = new List<ReviewDTO>();
        }
    }
}
