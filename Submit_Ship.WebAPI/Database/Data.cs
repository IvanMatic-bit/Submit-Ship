using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Submit_Ship.WebAPI.Database
{
    public class Data
    {
        public static void Seed(SubmitShipContext context)
        {
            context.Database.Migrate();
        }
    }
}
