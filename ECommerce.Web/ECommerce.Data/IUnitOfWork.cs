using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace ECommerce.Data
{
    public interface IUnitOfWork<T> : IDisposable where T : DbContext
    {
        void save();        
    }
}
