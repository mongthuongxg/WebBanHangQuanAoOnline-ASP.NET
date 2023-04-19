namespace BanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePosition : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Category", "Position", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Category", "Position", c => c.String());
        }
    }
}
