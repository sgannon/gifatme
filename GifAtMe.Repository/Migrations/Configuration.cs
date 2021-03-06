namespace GifAtMe.Repository.Migrations
{
    using GifAtMe.Domain.Entities.GifEntry;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<GifAtMe.Repository.GifAtMeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GifAtMe.Repository.GifAtMeContext context)
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
            var gifEntries = new List<GifEntry>
            {
                new GifEntry{UserName="mknowles",Url="http://i.imgur.com/STVntis.gif",Keyword="rise"},
                new GifEntry{UserName="mknowles",Url="http://i.imgur.com/rEYJesc.gif",Keyword="thisguy"},
                new GifEntry{UserName="mknowles",Url="http://i.imgur.com/wJUHejF.gif",Keyword="highfive"},
                new GifEntry{UserName="mknowles",Url="http://i.imgur.com/eIZgQL7.gif",Keyword="highfive"}
            };

            gifEntries.ForEach(g => context.GifEntries.AddOrUpdate(g));
            context.SaveChanges();
        }
    }
}