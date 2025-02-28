using ECommerceApp.Data;
using ECommerceApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ECommerceApp.Controllers
{
    public class OrderController : Controller
    {
        private static List<Order> _orders = new List<Order>
        {
            new Order
            {
                OrderId = 1,
                UserId = 1,
                OrderDate = DateTime.Now,
                OrderDetails = new List<OrderDetails>
                {
                    new OrderDetails { ProductId = 1, Quantity = 2 },
                    new OrderDetails { ProductId = 2, Quantity = 1 }
                }
            }
        };

        [HttpGet("/Orders/{userId}")]
        public IActionResult OrderHistory(int userId)
        {
            var userOrders = _orders
                .Where(o => o.UserId == userId)
                .Select(o => new OrderHistoryViewModel
                {
                    OrderId = o.OrderId,
                    OrderDate = o.OrderDate,
                    Products = o.OrderDetails
                        .Select(od => new ProductViewModel
                        {
                            Name = ProductData.Products.First(p => p.ProductId == od.ProductId).Name,
                            Quantity = od.Quantity,
                            Price = ProductData.Products.First(p => p.ProductId == od.ProductId).Price
                        }).ToList()
                }).ToList();

            return View(userOrders);
        }

        // POST /Order/PlaceOrder
        [HttpPost("/Order/PlaceOrder")]
        public IActionResult PlaceOrder(Order order)
        {
            if (ModelState.IsValid)
            {
                order.OrderId = _orders.Count + 1;
                order.OrderDate = DateTime.Now;
                _orders.Add(order);
                return RedirectToAction("OrderHistory", new { userId = order.UserId });
            }
            return View("OrderForm", order);
        }

        [HttpGet("/Order/OrderForm")]
        public IActionResult OrderForm(int? productId)
        {
            var order = new Order
            {
                OrderDetails = new List<OrderDetails>
                {
                    new OrderDetails { ProductId = productId ?? 0 }
                }
            };
            return View(order);
        }
    }
}