namespace HCH_LAB456.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (1, 'Development')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (2, 'Business')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (3, 'Maketing')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (4, 'Sex Education')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (5, 'Relax')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (6, 'Find Real Love With Tinder')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (7, 'English For Coder')");
        }
        
        public override void Down()
        {
        }
    }
}
