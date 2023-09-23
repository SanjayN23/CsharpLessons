using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace NWind.Models
{
    public class RepositoryOrders
    {
        public NorthwindContext _context;
       
        public RepositoryOrders(NorthwindContext context)
        {
            _context = context;
        }
        public List<Order> GetOrders()
        {
            return _context.Orders.ToList();
        }
        public Order PutOrder(int id)
        {
            Order order = _context.Orders.Find(id);
            return order;
        }

        
            public List<int> GetAllOrderId()
            {
                return (from o in _context.OrderDetails select o.OrderId).ToList();
            }
        
        public List<OrderDetail> FindOrderDetailsByOrderId(int id)
        {
            //Order order=_context.Orders.Find(id);
            //return order.OrderDetails.ToList();

            List<Order> ordersWithOrderDetails = _context.Orders.Include(d => d.OrderDetails).ToList(); //IT ALSO includes child class values also
            Order order = ordersWithOrderDetails.FirstOrDefault(x => x.OrderId == id);
            return order.OrderDetails.ToList();
        }

       public Order FindOrderById(int id)
        {
            var orderById = _context.Orders.Find(id);
            return orderById;
        }
    }
}
 
    

