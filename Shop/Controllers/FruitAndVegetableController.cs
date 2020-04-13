﻿using Shop.Data;
using Shop.Data.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Shop.Controllers
{
    public class FruitAndVegetableController
    {
        private ShopContext context;
        public List<FruitAndVegetable> GetAllFruitsAndVegetables()
        {
            using (context = new ShopContext())
            {
                return context.FruitsAndVegetables.ToList();
            }
        }

        public FruitAndVegetable GetFruitOrVegetableByName(string name)
        {
            using (context = new ShopContext())
            {
                return context.FruitsAndVegetables.Find(name);
            }
        }

        public void Add(FruitAndVegetable fruitORvegetable)
        {
            using (context = new ShopContext())
            {
                context.Add(fruitORvegetable);
                context.SaveChanges();
            }
        }

        public void Update(FruitAndVegetable fruitORvegetable)
        {
            using (context = new ShopContext())
            {
                var item = context.FruitsAndVegetables.Find(fruitORvegetable.Id);
                if (item != null)
                {
                    context.Entry(item).CurrentValues.SetValues(fruitORvegetable);
                    context.SaveChanges();
                }
            }
        }

        public void Delete(FruitAndVegetable fruitORvegetable)
        {
            using (context = new ShopContext())
            {
                var item = context.FruitsAndVegetables.Find(fruitORvegetable.Id);
                if (item != null)
                {
                    context.FruitsAndVegetables.Remove(item);
                    context.SaveChanges();
                }
            }
        }
    }
}
