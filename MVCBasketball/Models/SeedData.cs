using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCBasketball.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasketball.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context = new MVCBasketballContext(serviceProvider.GetRequiredService<DbContextOptions<MVCBasketballContext>>()))
            {
                // Look for any player info
                if (context.Raptors.Any())
                {
                    return; //Database has already seeded
                }

                context.Raptors.AddRange(
                    new Raptors() { PlayerNumber = 9, PlayerName = "Serge Ibaka", PlayerPosition = "Foward", PlayerHeight = "7-0", PlayerSalary = 12000000 },
                    new Raptors() { PlayerNumber = 22, PlayerName = "Marcus Saw", PlayerPosition = "Foward", PlayerHeight = "6-5", PlayerSalary = 22000000 },
                    new Raptors() { PlayerNumber = 5, PlayerName = "Pascal Siakim", PlayerPosition = "Guard", PlayerHeight = "6-3", PlayerSalary = 11000000 }
                    );
                context.SaveChanges();            
            } 

        }

    }
}
