using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UOW.Services;

namespace UOW.Configuration
{
    public interface IUnitOfWork
    {
        IEmployeeRepository Employee { get; }
        Task CompleteAsync();
        void Dispose();
    }
}
