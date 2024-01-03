namespace DAL.Migrations
{
    using System;
    using System.Collections.Generic;
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
            List<string> Names = new List<string>

            {
           "Hadiur Rahman Nabil",
           "Khan Nushrat Sultana Netu",
           "Abdullah",
           "Fatima",
           "Ayesha",
           "Nazrul",
           "Shakib",
           "Jahanara",
           "Tajuddin",
           "Khaleda",
           "Sheikh",
           "Nasreen",
           "Hasina",
           "Kabir",
           "Rahima",
           "Aminul",
           "Shirin",
           "Jashim",
           "Moushumi",
           "Monirul"
};

            Random rand = new Random();

            for (int i = 1; i <= 20; i++)
            {
                string randomName = Names[rand.Next(Names.Count)];

                context.Users.AddOrUpdate(new Models.User
                {
                    Name = randomName,
                    Uname = "User-" + i,
                    Password = Guid.NewGuid().ToString().Substring(0, 15),
                    Type = "General"
                });
            }

            Random random = new Random();

            string[] destinations = { "Paris", "Tokyo", "New York", "London", "Sydney", "Rome", "Dubai", "Barcelona" };
            string[] activities = { "Sightseeing", "Adventure Sports", "Cultural Tours", "Cruise", "Hiking", "Shopping", "Food Tours" };

            for (int i = 1; i <= 30; i++)
            {
                string destination = destinations[random.Next(destinations.Length)];
                string activity = activities[random.Next(activities.Length)];

                context.Bookings.AddOrUpdate(new Models.Booking
                {
                    Id = i,
                    Booking_Title = $"Trip to {destination}",
                    Booking_Descripion = $"Enjoy {activity} in {destination}.",
                    Date = DateTime.Now.AddDays(random.Next(1, 90)),
                    BookedBy = "User-" + random.Next(1, 21),

                    
                });

                
            }


            

            string[] suggestionTexts = 
                {

                "Enhance the hotel facilities",
                "Include more adventure activities",
                "Improve customer service",
                "Introduce local cultural experiences",
                "Expand transportation options",
                "Offer special discounts for tourists",
    
                 };

            for (int i = 1; i <= 200; i++)
            {
                context.Suggestions.AddOrUpdate(new Models.Suggestion
                {
                    Id = i,
                    SuggestedText = suggestionTexts[random.Next(suggestionTexts.Length)],
                    BookedId = random.Next(1, 31),
                    Time = DateTime.Now,
                    SuggestedBy = "User-" + random.Next(1, 21),
                });

                
            }

            string[] activityTitles =
               {
               "Sightseeing Tour",
               "Adventure Sports Day",
               "Cultural Workshop",
               "Cruise Exploration",
               "Hiking Expedition",
               "Shopping Experience",
   
                };

            string[] activityDescriptions = 
                {
               "Experience the beauty of local landmarks and attractions.",
               "Engage in thrilling activities like zip-lining and rafting.",
               "Learn about local traditions and customs through workshops.",
               "Explore the city from the comfort of a luxurious cruise ship.",
               "Embark on a challenging hiking adventure amidst nature.",
               "Discover unique local items and souvenirs while shopping.",
    
                };

            for (int i = 1; i <= 30; i++)
            {
                context.Activities.AddOrUpdate(new Models.Activity
                {
                    Id = i,
                    Activity_Title = activityTitles[random.Next(activityTitles.Length)],
                    Activity_Description = activityDescriptions[random.Next(activityDescriptions.Length)],
                    Date = DateTime.Now.AddDays(random.Next(1, 30)), 
                    CreatedBy = "User-" + random.Next(1, 21),

                    
                });

            }

           

            string[] feedbackMessages = 
                {
              "Great experience! Highly recommended.",
              "Good service overall.",
              "Could improve the accommodation facilities.",
              "Enjoyed the activities provided.",
    
                 };

            for (int i = 1; i <= 90; i++)
            {
                context.Feedbacks.AddOrUpdate(new Models.Feedback
                {
                    Id = i,
                    FeedbackText = feedbackMessages[random.Next(feedbackMessages.Length)],
                    ActivityId = random.Next(1, 31),
                    Time = DateTime.Now, 
                    FeedbackBy = "User-" + random.Next(1, 21),
                });

               
            }

            string[] reviewTitles = 
                {
               "Fantastic experience",
               "Average service",
               "Disappointing tour",
               "Highly recommended!",
   
                };

            string[] reviewDescriptions = 
                {
               "The activities were well-organized and enjoyable.",
               "Some aspects need improvement, but overall, a good experience.",
               "Disappointed with the lack of variety in activities.",
                 };

            string[] complaintTexts = 
                {
                "Unsatisfactory service provided.",
                "Activities were canceled without prior notice.",
                "Poor handling of tour arrangements.",
    
                };

            for (int i = 1; i <= 30; i++)
            {
                context.Reviews.AddOrUpdate(new Models.Review
                {
                    Id = i,
                    Review_Title = reviewTitles[random.Next(reviewTitles.Length)],
                    Review_Description = reviewDescriptions[random.Next(reviewDescriptions.Length)],
                    Date = DateTime.Now.AddDays(-random.Next(1, 30)), 
                    ReviewBy = "User-" + random.Next(1, 21),
                });

               
            }

            for (int i = 1; i <= 90; i++)
            {
                context.Complains.AddOrUpdate(new Models.Complain
                {
                    Id = i,
                    ComplainText = complaintTexts[random.Next(complaintTexts.Length)],
                    ReviewId = random.Next(1, 31),
                    Time = DateTime.Now.AddDays(-random.Next(1, 30)), 
                    ComplainBy = "User-" + random.Next(1, 21),
                });

                
            }


        }
    }
 
}
