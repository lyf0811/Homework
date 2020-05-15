namespace source
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class OrderContext : DbContext
    {
        public OrderContext() : base("OrderDataBase")
        {
            Database.SetInitializer(
              new DropCreateDatabaseIfModelChanges<OrderContext>());
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> Orderitems { get; set; }

    

    //为您要在模型中包含的每种实体类型都添加 DbSet。有关配置和使用 Code First  模型
    //的详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=390109。

    // public virtual DbSet<MyEntity> MyEntities { get; set; }
}

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}