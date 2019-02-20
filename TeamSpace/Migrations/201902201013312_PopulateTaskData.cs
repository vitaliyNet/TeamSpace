namespace TeamSpace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTaskData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TASKNAMES (Name, Description) VALUES ('Action isn’t my problem', 'Action isn’t my problem — it’s making the tasks themselves feel more meaningful.')");
            Sql("INSERT INTO TASKNAMES (Name, Description) VALUES ('Pick important things', 'Pick important things to work on')");
            Sql("INSERT INTO TASKNAMES (Name, Description) VALUES ('One thing', 'Do only one of them at a time')");
            Sql("INSERT INTO TASKNAMES (Name, Description) VALUES ('Set aside everything else, one task only', 'Set aside everything else and do only that one task')");
            Sql("INSERT INTO TASKNAMES (Name, Description) VALUES ('Make it smaller', 'Make it smaller so it’s easier to start')");
            Sql("INSERT INTO TASKNAMES (Name, Description) VALUES ('Feel the joy of getting stuff done', 'Feel the joy of getting stuff done')");
            Sql("INSERT INTO TASKNAMES (Name, Description) VALUES ('Connecting Your Work Tasks to Meaning', 'The Pause. The Why.The Heart.')");
            Sql("INSERT INTO TASKNAMES (Name, Description) VALUES ('It’s that simple', 'Pause. Check in with your Why. And feel the pleasure, the joy, the love, in your heart.')");
        }
        
        public override void Down()
        {
        }
    }
}
