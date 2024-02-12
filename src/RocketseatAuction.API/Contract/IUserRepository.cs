using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Contract;

public interface IUserRepository
{
    bool ExisUserWithEmail(string email);
    User GetUserByEmail(string email);
}
