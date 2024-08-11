using CodePulse.API.Models.Domain;

namespace CodePulse.API.Respository.Interface
{
    public interface ICategoryRespository
    {
        public Task<Category> CreateAsync(Category category);
    }
}
