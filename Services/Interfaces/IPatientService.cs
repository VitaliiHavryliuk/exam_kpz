using DTOs;

namespace Services.Interfaces
{
    public interface IPatientService
    {
        Task<List<T>> GetAllAsync<T>();
        Task DeleteByIdAsync(int id);
        Task<int> CreateAsync(CreatePatientDTO model);
        Task UpdateAsync(UpdatePatientDTO model);
    }
}
