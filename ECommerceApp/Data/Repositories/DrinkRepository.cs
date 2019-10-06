using ECommerceApp.Data.Interfaces;
using ECommerceApp.Data.Models;
using ECommerceApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApp.Data.Repositories
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public DrinkRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }
        //implementation of the drink interface
        public IEnumerable<Drink> Drinks => _appDbContext.Drinks.Include(c => c.Category);

        public IEnumerable<Drink> PreferredDrinks => _appDbContext.Drinks.Where(p => p.PreferredDrink).Include(c => c.Category);

        public Drink GetDrinkById(int drinkId) => _appDbContext.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
    }
}
