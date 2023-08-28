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
    public class UserService
    {
       /* public static List<UserDTO> GetUsers()
        {
            var data = DAL.DataAccessFactory.UserData().Read();
            var returndata = new List<UserDTO>();
            foreach (var item in data)
            {
                var data1 = new UserDTO()
                {
                    Username = item.Username,
                    Name = item.Name,
                    Gender = item.Gender,
                    Password = item.Password,
                    Dob = item.Dob,

                    Email = item.Email,
                    Phone = item.Phone,
                    Address = item.Address,
                    Type = item.Type

                };
                returndata.Add(data1);



            }
            return returndata; */
              public static List<UserDTO> Get()
               {
                   var data = DataAccessFactory.UserData().Read();
                   var cfg = new MapperConfiguration(c => {
                       c.CreateMap<User, UserDTO>();
                   });
                   var mapper = new Mapper(cfg);
                   var mapped = mapper.Map<List<UserDTO>>(data);
                   return mapped;

               }
               public static UserDTO Get(string username)
               {
                   var data = DataAccessFactory.UserData().Read(username);
                   var cfg = new MapperConfiguration(c =>
                   {
                       c.CreateMap<User, UserDTO>();
                   });
                   var mapper = new Mapper(cfg);
                   var mapped = mapper.Map<UserDTO>(data);
                   return mapped;
               }
           
            public static UserDTO Create(UserDTO obj)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserDTO>();
                c.CreateMap<UserDTO, User>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<User>(obj);
            var data = DataAccessFactory.UserData().Create(mapped);
            var mapped2 = mapper.Map<UserDTO>(data);
            return mapped2;
        }



        public static UserDTO Update(User username)
        {
            var data = DataAccessFactory.UserData().Update(username);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<UserDTO>(data);
            return mapped;
        }



        public static bool Delete(string username)
        {
            return DataAccessFactory.UserData().Delete(username); ;
        }




            











        }
    }

