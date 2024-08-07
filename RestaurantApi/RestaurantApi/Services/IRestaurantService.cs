﻿using RestaurantApi.Models;

namespace RestaurantApi.Services
{
    public interface IRestaurantService
    {
        int Create(CreateRestaurantDto dto);
        IEnumerable<RestaurantDto> GetAll();
        RestaurantDto GetById(int id);
        bool Delete(int id);
        bool Update(int id, UpdateRestaurantDto dto);
    }
}