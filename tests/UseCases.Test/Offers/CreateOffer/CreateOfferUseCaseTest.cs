using Bogus;
using FluentAssertions;
using Moq;
using RocketseatAuction.API.Communication.Request;
using RocketseatAuction.API.Contract;
using RocketseatAuction.API.Entities;
using RocketseatAuction.API.Services;
using RocketseatAuction.API.UseCases.Offers.CreateOffer;
using Xunit;

namespace UseCases.Test.Offers.CreateOffer;
public class CreateOfferUseCaseTest
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]

    public void Success(int itemId)
    {
        var request = new Faker<RequestCreateOfferJson>()
            .RuleFor(auction => auction.Price, f => f.Random.Decimal(1, 700))
           .Generate();


        var offerRepository = new Mock<IOfferRepository>();
        var loggedUser = new Mock<ILoggedUser>();

        loggedUser.Setup(i => i.User()).Returns(new User());

        var useCase = new CreateOfferUseCase(loggedUser.Object, offerRepository.Object);

        var act = () => useCase.Execute(itemId, request);

        act.Should().NotThrow();

    }

}
