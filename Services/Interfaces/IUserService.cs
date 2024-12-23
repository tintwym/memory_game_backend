namespace memory_game_backend.Services.Interfaces;

using Models.DTOs.Requests;
using Models.DTOs.Responses;

public interface IUserService
{
    Task<UserResponse.Create> Create(UserRequest.Create request);
    Task<UserResponse.Login> Login(UserRequest.Login request);
    Task<UserResponse.Get> GetById(UserRequest.Get request);
    Task<UserResponse.Get> Update(UserRequest.Update request);
    Task<UserResponse.PurchasePremium> PurchasePremium(UserRequest.PurchasePremium request);
}