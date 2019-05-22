namespace DAL.Migrations
{
    using Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.BlogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.BlogContext db)
        {
            if(db.Tags.Count() == 0)
            {
                Tag t1 = new Tag();
                t1.Name = "#TestCat1";

                Tag t2 = new Tag();
                t2.Name = "#TestCat2";

                Tag t3 = new Tag();
                t3.Name = "#TestCat3";

                db.Tags.Add(t1);
                db.Tags.Add(t2);
                db.Tags.Add(t3);
                db.SaveChanges();               
            }
        }
    }
}
