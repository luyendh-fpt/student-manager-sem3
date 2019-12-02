namespace StudentManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        RollNumber = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Name = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        Image = c.String(unicode: false),
                        Birthday = c.DateTime(nullable: false, precision: 0),
                        Note = c.String(unicode: false),
                        CreatedAt = c.DateTime(nullable: false, precision: 0),
                        UpdatedAt = c.DateTime(nullable: false, precision: 0),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RollNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
