using CinemaSeats.Domain.Entities;
using CinemaSeats.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaSeats.Infrastructure.Persistence
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedDefaultUserAsync(UserManager<ApplicationUser> userManager)
        {
            var defaultUser = new ApplicationUser { UserName = "administrator@localhost", Email = "administrator@localhost" };

            if (userManager.Users.All(u => u.UserName != defaultUser.UserName))
            {
                await userManager.CreateAsync(defaultUser, "Administrator1!");
            }
        }

        public static async Task SeedSampleDataAsync(ApplicationDbContext context)
        {
            // Seed, if necessary
            if (!context.SeatsMaps.Any())
            {
                context.SeatsMaps.Add(new SeatsMap
                {
                    Rows =
                    {
                        new Row
                        {
                            RowTitle = "A",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "B",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "C",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "D",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "E",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "F",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "G",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "H",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = true },
                                new Seat { SeatTitle = "5", Booked = true },
                                new Seat { SeatTitle = "6", Booked = true },
                                new Seat { SeatTitle = "7", Booked = true },
                                new Seat { SeatTitle = "8", Booked = true },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "I",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = true },
                                new Seat { SeatTitle = "7", Booked = true },
                                new Seat { SeatTitle = "8", Booked = true },
                                new Seat { SeatTitle = "9", Booked = true },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "J",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = true },
                                new Seat { SeatTitle = "6", Booked = true },
                                new Seat { SeatTitle = "7", Booked = true },
                                new Seat { SeatTitle = "8", Booked = true },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "K",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "L",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "M",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "N",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "O",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "P",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "Q",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "R",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "S",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "T",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "U",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "V",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "W",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "X",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "Y",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "Z",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "AA",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "BB",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "CC",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "DD",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "EE",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "FF",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "GG",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "HH",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "II",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "JJ",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "KK",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "LL",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "MM",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        },
                        new Row
                        {
                            RowTitle = "NN",
                            Seats =
                            {
                                new Seat { SeatTitle = "1", Booked = false },
                                new Seat { SeatTitle = "2", Booked = false },
                                new Seat { SeatTitle = "3", Booked = false },
                                new Seat { SeatTitle = "4", Booked = false },
                                new Seat { SeatTitle = "5", Booked = false },
                                new Seat { SeatTitle = "6", Booked = false },
                                new Seat { SeatTitle = "7", Booked = false },
                                new Seat { SeatTitle = "8", Booked = false },
                                new Seat { SeatTitle = "9", Booked = false },
                                new Seat { SeatTitle = "10", Booked = false },
                                new Seat { SeatTitle = "11", Booked = false },
                                new Seat { SeatTitle = "12", Booked = false },
                                new Seat { SeatTitle = "13", Booked = false },
                                new Seat { SeatTitle = "14", Booked = false },
                                new Seat { SeatTitle = "15", Booked = false },
                                new Seat { SeatTitle = "16", Booked = false },
                                new Seat { SeatTitle = "17", Booked = false },
                                new Seat { SeatTitle = "18", Booked = false },
                                new Seat { SeatTitle = "19", Booked = false },
                                new Seat { SeatTitle = "20", Booked = false }
                            }
                        }
                    }
                });

                await context.SaveChangesAsync();
            }
        }
    }
}
