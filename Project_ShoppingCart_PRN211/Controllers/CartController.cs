using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project_ShoppingCart_PRN211.Models;
using System.Collections.Generic;
using System.Linq;

namespace Project_ShoppingCart_PRN211.Controllers
{
    public class CartController : Controller
    {
        PROJECT_ShoppingCart_PRN291Context context = new PROJECT_ShoppingCart_PRN291Context();

        public const string CARTKEY = "Cart";
        public IActionResult AddToCart(int ShoesId)
        {
            var shoes = context.Shoes.Where(x => x.ShoesId == ShoesId).FirstOrDefault();

            if (shoes == null)
                return NotFound("Không có sản phẩm");

            // Xử lý đưa vào Cart ...
            var cart = GetCartItems();
            var cartitem = cart.Find(p => p.Shoes.ShoesId == ShoesId);
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cartitem.Quantity++;
            }
            else
            {
                //  Thêm mới
                cart.Add(new Cart() { Quantity = 1, Shoes = shoes });
            }

            // Lưu cart vào Session
            SaveCartSession(cart);
            // Chuyển đến trang hiện thị Cart
            return RedirectToAction(nameof(ViewCart));
        }

        public IActionResult ViewCart()
        {
            ViewBag.Account = GetAccount();
            //List All Category
            List<Category> categoryList = context.Categories.ToList();
            ViewBag.Category = categoryList;
            return View(GetCartItems());
        }
        List<Cart> GetCartItems()
        {
            var session = HttpContext.Session;
            string jsoncart = session.GetString(CARTKEY);
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<Cart>>(jsoncart);
            }
            return new List<Cart>();
        }

        // Xóa cart khỏi session
        void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove(CARTKEY);
        }

        // Lưu Cart (Danh sách CartItem) vào session
        void SaveCartSession(List<Cart> ls)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(ls);
            session.SetString(CARTKEY, jsoncart);
        }
        public IActionResult RemoveCart(int ShoesId)
        {
            var cart = GetCartItems();
            var cartitem = cart.Find(p => p.Shoes.ShoesId == ShoesId);
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cart.Remove(cartitem);
            }

            SaveCartSession(cart);
            return RedirectToAction(nameof(ViewCart));
        }
        

        public IActionResult CheckOut()
        {
            //List All Category
            List<Category> categoryList = context.Categories.ToList();
            ViewBag.Category = categoryList;
            ViewBag.Account = GetAccount();

            var cart = GetCartItems();
            float total = 0;
            foreach(Cart cartitem in cart)
            {
                total += cartitem.Quantity * (float)cartitem.Shoes.ShoesQuantity;
            }
            ViewBag.Total = total;
            return View(GetCartItems());
        }

        [HttpPost]
        public IActionResult CheckOut(string name, string phone, string address, string email, string note)
        {
            ViewBag.Account = GetAccount();
            //Total
            var cart = GetCartItems();
            float total = 0;
            foreach (Cart cartitem in cart)
            {
                total += cartitem.Quantity * (float)cartitem.Shoes.ShoesQuantity;
            }
            ViewBag.Total = total;

            //Save to Order
            Order order = new Order() { Fullname = name, PhoneNumber = phone, Address = address, Email = email, Note = note , Date = System.DateTime.Now, Status = "0", TotalMoney = total};
            context.Orders.Add(order);
            context.SaveChanges();
            int orderId = order.Id;

            //Save to OrderDetails
            foreach (var item in cart)
            {
                float totalitem = item.Quantity * (float)item.Shoes.ShoesPrice;
                OrderDetail orderDetail = new OrderDetail() { OrderId = orderId, ProductId = item.Shoes.ShoesId, Num = item.Quantity, Price = item.Shoes.ShoesPrice, TotalNumber = totalitem };
                context.OrderDetails.Add(orderDetail);
                context.SaveChanges();
            }
            return RedirectToAction("Index","Shop");
        }
        public const string ACCOUNTKEY = "Account";

       
        Account GetAccount()
        {
            var session = HttpContext.Session;
            string jsoncart = session.GetString(ACCOUNTKEY);
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<Account>(jsoncart);
            }
            return new Account();
        }
    }
}
