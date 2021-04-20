using System;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IProjectRepository
    {
         Task<Project> CreateAsync(string name);
         Task UpdateAsync(string name);
         Task DeleteAsync(int id);
         Task DeleteAsync(Guid guid);
         Task GetAysnc(Guid guid);
    }
}