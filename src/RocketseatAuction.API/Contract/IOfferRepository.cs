using RocketseatAuction.API.Entities;

namespace RocketseatAuction.API.Contract;

public interface IOfferRepository
{
    void Add(Offer offer);
}
