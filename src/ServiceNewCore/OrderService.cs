using ModelCo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DalCore;

namespace ServiceNewCore
{
    public interface IOrderService
    {
        IList<Order> ListOrders();
    }

    public class OrderService : IOrderService
    {


        private OmsDbContext dbContext;

        public OrderService(OmsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public IList<Order> ListOrders()
        {
            return dbContext.Orders.Where(c=>c.Id ==1 ).ToList();
        }
    }
}
