
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Newtonsoft.Json;

namespace Infrastructure.Data.Repositories
{
    public class MockProjectRepository : IProjectRepository
    {
        private readonly List<Project> _projects;
        public MockProjectRepository()
        {
            using (var reader = new StreamReader(@"Data/Projects.json"))
            {
                var str = reader.ReadToEnd();
                var projects = JsonConvert.DeserializeObject<List<Project>>(str);
                _projects = projects;
            }
        }
        public async Task<Project> CreateAsync(string name)
        {
            var project = new Project
            {
                Id = _projects.Count + 1,
                Name = name,
                Guid = Guid.NewGuid(),
                Created = DateTime.Now,
                Modified = DateTime.Now
            };

            _projects.Add(project);

            var str = JsonConvert.SerializeObject(_projects);

            await File.WriteAllTextAsync(@"Data/Projects.json", str);

            return project;       

        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Task GetAysnc(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}