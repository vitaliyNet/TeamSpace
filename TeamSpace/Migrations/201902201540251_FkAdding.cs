namespace TeamSpace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FkAdding : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Works", name: "TaskName_Id", newName: "TaskNameId");
            RenameColumn(table: "dbo.Works", name: "TeamLead_Id", newName: "TeamLeadId");
            RenameIndex(table: "dbo.Works", name: "IX_TeamLead_Id", newName: "IX_TeamLeadId");
            RenameIndex(table: "dbo.Works", name: "IX_TaskName_Id", newName: "IX_TaskNameId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Works", name: "IX_TaskNameId", newName: "IX_TaskName_Id");
            RenameIndex(table: "dbo.Works", name: "IX_TeamLeadId", newName: "IX_TeamLead_Id");
            RenameColumn(table: "dbo.Works", name: "TeamLeadId", newName: "TeamLead_Id");
            RenameColumn(table: "dbo.Works", name: "TaskNameId", newName: "TaskName_Id");
        }
    }
}
