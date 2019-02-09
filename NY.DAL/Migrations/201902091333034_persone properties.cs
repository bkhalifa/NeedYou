namespace NY.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class personeproperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persons", "PhoneNumnber", c => c.String());
            AddColumn("dbo.Persons", "InscriptionDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Persons", "Publisher", c => c.String());
            AddColumn("dbo.Persons", "Isuser", c => c.Boolean(nullable: false));
            AddColumn("dbo.Persons", "MyProperty1", c => c.String());
            AddColumn("dbo.Persons", "MyProperty2", c => c.String());
            AddColumn("dbo.Persons", "MyProperty3", c => c.String());
            AddColumn("dbo.Persons", "MyProperty4", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Persons", "MyProperty4");
            DropColumn("dbo.Persons", "MyProperty3");
            DropColumn("dbo.Persons", "MyProperty2");
            DropColumn("dbo.Persons", "MyProperty1");
            DropColumn("dbo.Persons", "Isuser");
            DropColumn("dbo.Persons", "Publisher");
            DropColumn("dbo.Persons", "InscriptionDate");
            DropColumn("dbo.Persons", "PhoneNumnber");
        }
    }
}
