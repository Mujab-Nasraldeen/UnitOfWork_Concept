using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using UOW.Models;

namespace UOW.Services
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        
    }
}
