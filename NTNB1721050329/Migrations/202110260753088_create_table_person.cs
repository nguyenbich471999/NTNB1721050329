namespace NTNB1721050329.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_person : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 20),
                        PersonName = c.String(maxLength: 50),
                        Faculty = c.String(maxLength: 50),
                        Department = c.String(maxLength: 50),
                        University = c.String(maxLength: 50),
                        Address = c.String(maxLength: 50),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
