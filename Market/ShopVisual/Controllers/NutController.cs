﻿using System.Collections.Generic;
using System.Linq;

namespace ShopVisual.Controllers
{
    /// <summary>
    /// Provides the link between the database and the UI. 
    /// </summary>
    public class NutController
    {
        /// <summary>
        /// Database link.
        /// </summary>
        private ShopContext context;


        /// <summary>
        /// Gives all Nuts in the database.
        /// </summary>
        /// <returns>all nuts from the database</returns>
        public List<Nut> GetAllNuts()
        {
            using (context = new ShopContext())
            {
                return context.Nuts.ToList();
            }
        }

        /// <summary>
        /// Gives a Nut with the wanted Id.
        /// </summary>
        /// <param name="id">Id of the wanted nut</param>
        /// <returns>a nut with that id</returns>
        public Nut GetNutById(int id) 
        {
            using (context = new ShopContext())
            {
                return context.Nuts.FirstOrDefault(m => m.Id == id);
            }
        }

        /// <summary>
        /// Adds a Nut.
        /// </summary>
        /// <param name="nut">the nut that will be added</param>
        public void Add(Nut nut)
        {
            using (context = new ShopContext())
            {
                context.Nuts.Add(nut);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Updates a Nut.
        /// </summary>
        /// <param name="nut">the nut that will be updated</param>
        public void Update(Nut nut)
        {
            using (context = new ShopContext())
            {
                var item = context.Drinks.Find(nut.Id);
                if (item != null)
                {
                    context.Entry(item).CurrentValues.SetValues(nut);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Deletes a Nut with the wanted Id.
        /// </summary>
        /// <param name="id">Id of the wanted nut</param>
        public void Delete(int id)
        {
            using (context = new ShopContext())
            {
                var item = context.Nuts.FirstOrDefault(m => m.Id == id);
                if (item != null)
                {
                    context.Nuts.Remove(item);
                    context.SaveChanges();
                }

            }
        }

    }
}
