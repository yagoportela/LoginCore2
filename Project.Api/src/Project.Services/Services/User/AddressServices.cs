using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Domain.Entities;
using Project.Domain.Interfaces;
using Project.Domain.Interfaces.Services.User;

namespace Project.Services.Services.User
{
    public class AddressServices : IAddress
    {
        private readonly IRepository<AddressEntity> _repository;

        public AddressServices(IRepository<AddressEntity> repository){
            _repository = repository;
        }

        public async Task<bool> Delete (Guid id) {
            return await _repository.DeleteAsync (id);
        }

        public async Task<AddressEntity> Get (Guid id) {
            return await _repository.SelectAsync (id);
        }

        public async Task<IEnumerable<AddressEntity>> GetAll () {
            return await _repository.SelectAsync ();
        }

        public async Task<AddressEntity> Post (AddressEntity address) {
            return await _repository.InsertAsync (address);
        }

        public async Task<AddressEntity> Put (AddressEntity address) {
            return await _repository.UpdateAsync (address);
        }
    }
}