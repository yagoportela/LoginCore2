using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Domain.Entities;
using Project.Domain.Interfaces;
using Project.Domain.Interfaces.Services.User;

namespace Project.Services.Services.User
{
    public class WorkshopServices : IWorkshop
    {
        private readonly IRepository<WorkshopEntity> _repository;

        public WorkshopServices(IRepository<WorkshopEntity> repository){
            _repository = repository;
        }

        public async Task<bool> Delete (Guid id) {
            return await _repository.DeleteAsync (id);
        }

        public async Task<WorkshopEntity> Get (Guid id) {
            return await _repository.SelectAsync (id);
        }

        public async Task<IEnumerable<WorkshopEntity>> GetAll () {
            return await _repository.SelectAsync ();
        }

        public async Task<WorkshopEntity> Post (WorkshopEntity workshop) {
            return await _repository.InsertAsync (workshop);
        }

        public async Task<WorkshopEntity> Put (WorkshopEntity workshop) {
            return await _repository.UpdateAsync (workshop);
        }
    }
}