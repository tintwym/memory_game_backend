namespace memory_game_backend.Repositories.Interfaces;

using Models.DTOs.Requests;
using Models.Entities;

public interface IUserRepository
{
    Task<User> Create(User user);
    Task<User> GetById(Guid userId);
    Task<User> GetByUsername(string username);
    Task<User> Update(UserRequest.Update request);
    Task<User> Delete(UserRequest.Delete request);
    Task<User> PurchasePremium(UserRequest.PurchasePremium request);
}
