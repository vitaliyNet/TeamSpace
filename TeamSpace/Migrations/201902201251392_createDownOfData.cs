namespace TeamSpace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createDownOfData : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            Sql("DELETE FROM TASKNAMES WHERE Id IN (1, 2, 3, 4, 5, 6, 7, 8)");
        }
    }
}
