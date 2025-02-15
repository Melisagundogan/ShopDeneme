﻿using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopapp.business.Abstract
{
     public interface ICategoryService
    {
        Category GetById(int id);

        List<Category> GetAll();

        void Create(Category entity);

        void Update(Category entity);
        void Delete(Category entity);

    }
}
