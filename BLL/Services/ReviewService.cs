﻿using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ReviewService
    {
        public static List<ReviewDTO> GetReview()
        {
            var data = DataAccessFactory.ReviewData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Review, ReviewDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ReviewDTO>>(data);
            return mapped;
        }

        public static ReviewDTO GetReview(int id)
        {
            var data = DataAccessFactory.ReviewData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Review, ReviewDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ReviewDTO>(data);
            return mapped;
        }

        public static ReviewDTO Create(ReviewDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Review, ReviewDTO>();
                c.CreateMap<ReviewDTO, Review>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Review>(obj);
            var data = DataAccessFactory.ReviewData().Create(mapped);
            var mapped2 = mapper.Map<ReviewDTO>(data);
            return mapped2;
        }
        public static ReviewDTO Update(Review review)
        {
            var data = DataAccessFactory.ReviewData().Update(review);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Review, ReviewDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ReviewDTO>(data);
            return mapped;
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ReviewData().Delete(id); ;
        }
    }
}
