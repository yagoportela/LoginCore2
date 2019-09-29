using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Domain.Entities;
using Project.Domain.Interfaces;
using Project.Domain.Interfaces.Services.User;

namespace Project.Services.Services.User
{
    public class CustomersServices : ICustomers
    {
        private readonly IRepository<CustomersEntity> _repository;

        public CustomersServices(IRepository<CustomersEntity> repository){
            _repository = repository;
        }

        public async Task<bool> Delete (Guid id) {
            return await _repository.DeleteAsync (id);
        }

        public async Task<CustomersEntity> Get (Guid id) {
            return await _repository.SelectAsync (id);
        }

        public async Task<IEnumerable<CustomersEntity>> GetAll () {
            return await _repository.SelectAsync ();
        }

        public async Task<CustomersEntity> Post (CustomersEntity customers) {
            return await _repository.InsertAsync (customers);
        }

        public async Task<CustomersEntity> Put (CustomersEntity customers) {
            return await _repository.UpdateAsync (customers);
        }
    }
}