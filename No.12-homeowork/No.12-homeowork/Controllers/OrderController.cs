using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using No._12_homeowork.Model;

namespace No._12_homeowork.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {

        private readonly OrderContext Orderdatabase;

        public OrderController(OrderContext context)
        {
            this.Orderdatabase = context;
        }

        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(string ordernum)
        {
            var Order = Orderdatabase.orders.FirstOrDefault(t => t.ordernum == ordernum);
            if (Order == null)
            {
                return NotFound();
            }
            return Order;
        }

        [HttpGet]
        public ActionResult<List<Order>> Getorders(string Goodsname, bool? isComplete)
        {
            IQueryable<Order> query = Orderdatabase.orders;
            query = query.Where(t => t.goodsname.Contains(Goodsname));
            return query.ToList();
        }
        [HttpGet("{customername}")]
        public ActionResult<List<Order>> Getorders1(string Customername, bool? isComplete)
        {
            IQueryable<Order> query = Orderdatabase.orders;
            query = query.Where(t => t.goodsname.Contains(Customername));
            return query.ToList();
        }

        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            try
            {
                Orderdatabase.orders.Add(order);
                Orderdatabase.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }
        [HttpPut("{id}")]
        public ActionResult<Order> PutOrder(string ordernum, Order order)
        {
            if (ordernum != order.ordernum)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                Orderdatabase.orders.Add(order);
                Orderdatabase.Entry(order).State = EntityState.Modified;
                Orderdatabase.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(string ordernum)
        {
            try
            {
                var order = Orderdatabase.orders.FirstOrDefault(t => t.ordernum == ordernum);
                if (order != null)
                {
                    Orderdatabase.Remove(order);
                    Orderdatabase.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

    }
}
