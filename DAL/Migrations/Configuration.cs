namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Models.TravelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Models.TravelContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            for(int i=1;i<=20;i++)
            {
                context.Users.AddOrUpdate(new Models.User
                {
                    Name = Guid.NewGuid().ToString().Substring(0,20),
                    Uname = "User-"+i,
                    Password = Guid.NewGuid().ToString().Substring(0,15),
                    Type = "General"

                });
            }
            Random random = new Random();
            for(int i=1;i<=30;i++)
            {
                context.Bookings.AddOrUpdate(new Models.Booking
                {
                    Id=i,
                    Booking_Title = Guid.NewGuid().ToString().Substring(0,10),
                    Booking_Descripion = Guid.NewGuid().ToString(),
                    Date = DateTime.Now,
                    BookedBy= "User-"+random.Next(1,21),


                });

            }

            for(int i=1;i<=200;i++)
            {
                context.Suggestions.AddOrUpdate(new Models.Suggestion
                {
                    Id = i,
                    SuggestedText = Guid.NewGuid().ToString().Substring(0, 10),
                    BookedId = random.Next(1, 31),
                    Time = DateTime.Now,
                    SuggestedBy = "User-" + random.Next(1, 21),
                });

            }
        }
    }
}
