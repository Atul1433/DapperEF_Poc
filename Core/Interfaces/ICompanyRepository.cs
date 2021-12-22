using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICompanyRepository
    {
        Company Find(int id);
        List<Company> GetAll();

        Company Add(Company company);
        Company Update(Company company);

        void Remove(int id);

    }
}
