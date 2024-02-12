using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Contract;

public interface IAuctionRepository
{
    Auction? GetCurrent();

}
