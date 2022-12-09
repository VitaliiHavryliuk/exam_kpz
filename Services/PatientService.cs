using AutoMapper;
using Domain.Entities;
using Domain.RepositoryInterfaces;
using DTOs;
using Services.Interfaces;
using Domain;

namespace Services
{
    public class PatientService : IPatientService
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Patient> _repository;

        public PatientService(IMapper mapper, IGenericRepository<Patient> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<int> CreateAsync(CreatePatientDTO model)
        {
            var newEntity = _mapper.Map<Patient>(model);
            return await _repository.CreateAsync(newEntity);
        }

        public async Task DeleteByIdAsync(int id)
        {
            var entity = (await _repository.GetByCondition(e => e.Id == id)).FirstOrDefault();

            if(entity is null)
            {
                throw new Exception();
            }

            await _repository.DeleteAsync(entity);
        }

        public async Task<List<T>> GetAllAsync<T>()
        {
            var entities = await _repository.GetAll();
            return _mapper.Map<List<T>>(entities.ToList());
        }

        public async Task UpdateAsync(UpdatePatientDTO dto)
        {
            var entity = (await _repository.GetByCondition(e => e.Id == dto.Id)).FirstOrDefault();

            if (entity is null)
            {
                throw new Exception();
            }

            entity.DateOfBirth = dto.DateOfBirth;
            entity.OwnerFullName = dto.OwnerFullName;
            entity.Name = dto.Name;
            entity.Diagnosis = dto.Diagnosis;
            entity.Type = dto.Type;
            await _repository.UpdateAsync(entity);
        }
    }
}
