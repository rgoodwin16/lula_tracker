
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        public async Task DeleteAsync(int id)
        {
           await DeleteProject(id, "");
        }

        public async Task DeleteAsync(string guid)
        {
         await DeleteProject(null, guid);
        }

        public Task GetAysnc(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string name)
        {
            throw new NotImplementedException();
        }

        private async Task DeleteProject(int? id, string guid)
        {
            var existingProject = !string.IsNullOrWhiteSpace(guid) 
              ? _projects.FirstOrDefault(p => p.Guid == Guid.Parse(guid))
              : _projects.FirstOrDefault(p => p.Id == id);
        
            if(existingProject is  null) return;

             _projects.Remove(existingProject);

            var str = JsonConvert.SerializeObject(_projects);

            await File.WriteAllTextAsync(@"Data/Projects.json", str);
        }
    }
}