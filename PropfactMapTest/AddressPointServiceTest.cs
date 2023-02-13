using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using PropfactMap.Models;
using PropfactMap.Models.DTOs;
using PropfactMap.Models.Services;

namespace PropfactMapTest
{
    public class AddressPointServiceTest
    {
        [Test]
        public async Task GetResults_should_return_data_with_search()
        {
            var options = new DbContextOptionsBuilder<AddressPointContext>()
                      .UseInMemoryDatabase(databaseName: "Propfact")
                      .Options;

            var dto = new AddressPointEntryDTO()
            {
                Search = "Nou Han",
                Zoom = 2,
                NorthEast = new NorthEastDTO() { Lat = 0.87M, Lng = 0.31M },
                SouthWest = new SouthWestDTO() { Lat = 0.82M, Lng = 0.34M }
            };

            using (var context = new AddressPointContext(options))
            {
                context.AddressPoints.AddRange(
                    new AddressPoint()
                    {
                        Id = 1,
                        X = 0.32M,
                        Y = 0.85M,
                        PointX = 0.32M,
                        PointY = 0.85M,
                        PropAddrL1 = "Nou Han Str 23",
                        PropAddrL2 = "ASW 234"
                    },
                    new AddressPoint()
                    {
                        Id = 2,
                        X = 0.33M,
                        Y = 0.83M,
                        PointX = 0.33M,
                        PointY = 0.83M,
                        PropAddrL1 = "Nou Han Str 54",
                        PropAddrL2 = "ASW 234"
                    },
                    new AddressPoint()
                    {
                        Id = 3,
                        X = 0.332M,
                        Y = 0.831M,
                        PointX = 0.332M,
                        PointY = 0.831M,
                        PropAddrL1 = "Sou Han Str 23",
                        PropAddrL2 = "ASW 234"
                    }
                   );
                await context.SaveChangesAsync();


                var service = new AddressPointService(context);
                var result = await service.GetResults(dto);

                Assert.AreEqual(2, result.Count);
            }
            }

            [Test]
            public async Task GetResults_should_return_empty_data_when_no_data_inside_boundaries()
            {
                var options = new DbContextOptionsBuilder<AddressPointContext>()
                          .UseInMemoryDatabase(databaseName: "Propfact2")
                          .Options;

                var dto = new AddressPointEntryDTO()
                {
                    Search = "Nou Han",
                    Zoom = 2,
                    NorthEast = new NorthEastDTO() { Lat = 0.87M, Lng = 0.30M },
                    SouthWest = new SouthWestDTO() { Lat = 0.86M, Lng = 0.31M }
                };

                using (var context = new AddressPointContext(options))
                {
                    context.AddressPoints.AddRange(
                        new AddressPoint()
                        {
                            Id = 1,
                            X = 0.32M,
                            Y = 0.85M,
                            PointX = 0.32M,
                            PointY = 0.85M,
                            PropAddrL1 = "Nou Han Str 23",
                            PropAddrL2 = "ASW 234"
                        },
                        new AddressPoint()
                        {
                            Id = 2,
                            X = 0.33M,
                            Y = 0.83M,
                            PointX = 0.33M,
                            PointY = 0.83M,
                            PropAddrL1 = "Nou Han Str 54",
                            PropAddrL2 = "ASW 234"
                        },
                        new AddressPoint()
                        {
                            Id = 3,
                            X = 0.332M,
                            Y = 0.831M,
                            PointX = 0.332M,
                            PointY = 0.831M,
                            PropAddrL1 = "Sou Han Str 23",
                            PropAddrL2 = "ASW 234"
                        }
                       );
                    await context.SaveChangesAsync();


                    var service = new AddressPointService(context);
                    var result = await service.GetResults(dto);

                    Assert.AreEqual(0, result.Count);
                }

            }

    }
}