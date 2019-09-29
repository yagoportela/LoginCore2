using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Domain.Entities;
using Project.Domain.Interfaces;
using Project.Domain.Interfaces.Services.User;

namespace Project.Services.Services.User
{
    public class CompanyServices : ICompany
    {
        private readonly IRepository<CompanyEntity> _repository;

        public CompanyServices(IRepository<CompanyEntity> repository){
            _repository = repository;
        }

        public async Task<bool> Delete (Guid id) {
            return await _repository.DeleteAsync (id);
        }

        public async Task<CompanyEntity> Get (Guid id) {
            return await _repository.SelectAsync (id);
        }

        public async Task<IEnumerable<CompanyEntity>> GetAll () {
            return await _repository.SelectAsync ();
        }

        public async Task<CompanyEntity> Post (CompanyEntity company) {
            return await _repository.InsertAsync (company);
        }

        public async Task<CompanyEntity> Put (CompanyEntity company) {
            return await _repository.UpdateAsync (company);
        }
    }
}