using WWUD2.Models;

namespace WWUD2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WWUD2.DAV.MainDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WWUD2.DAV.MainDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Questions.AddOrUpdate(q => q.QuestionContent,
                new Question
                { QuestionContent = "you won a million dollars",  AddDate = DateTime.Now },
                new Question
                { QuestionContent = "lost your keys down the street gutter",  AddDate = DateTime.Now },
                new Question
                { QuestionContent = "you broke both your legs",  AddDate = DateTime.Now },
                new Question
                { QuestionContent = "Taylor Swift visited your home", AddDate = DateTime.Now }
            );
        }
    }
}
