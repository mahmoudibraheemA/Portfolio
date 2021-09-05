using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace Infrastructure
{
    class DataContext:DbContext
    {
        //defuatl constructor
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {

        }
        
    }

}
