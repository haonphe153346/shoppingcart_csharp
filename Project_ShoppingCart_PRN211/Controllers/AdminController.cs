using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project_ShoppingCart_PRN211.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PagedList;

namespace Project_ShoppingCart_PRN211.Controllers
{
    public class AdminController : Controller
    {
        public const string ACCOUNTKEY = "Account";

        PROJECT_ShoppingCart_PRN291Context context = new PROJECT_ShoppingCart_PRN291Context();
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
        public IActionResult Index()
        {
            //If Account is Admin then Pass
            if (GetAccount().AccountRole == true)
            {
                //Session Account
                ViewBag.Account = GetAccount();
                //List All Category
                List<Category> categoryList = context.Categories.ToList();
                ViewBag.Category = categoryList;
                //1. COUNT
                //Total Shoes
                int TotalProduct = context.Shoes.ToList().Count();
                ViewBag.TotalProduct = TotalProduct;
                //Total Account
                int TotalAccount = context.Accounts.ToList().Count();
                ViewBag.TotalAccount = TotalAccount;
                //Total Profit
                double TotalProfit = context.Orders.Select(o => o.TotalMoney).ToList().Sum();
                ViewBag.TotalProfit = TotalProfit;
                //Total Order
                int TotalOrder = context.Orders.ToList().Count();
                ViewBag.TotalOrder = TotalOrder;
                //Top 4 Shoes
                List<Shoe> top4Shoes = context.Shoes.OrderByDescending(x => x.ShoesPrice).Take(4).ToList();
                ViewBag.top4Shoes = top4Shoes;
                //List Quantity
                List<int> listquantity = new List<int>();
                for (int i = 1; i <= categoryList.Count; i++)
                {
                    int n = context.Categories.Where(s => s.CategoryId == i).ToList().Count();
                    listquantity.Add(n);
                }
                ViewBag.listquantity = listquantity;
                //2. Top Product


                //3. Chart Category
                List<string> listCateName = context.Categories.Select(x => x.CategoryName).ToList();
                ViewBag.ListCateName = listCateName;

                //4. Chart Profit

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Shop");
            }

        }

        public IActionResult ManagerShoes(int? page)
        {
            //Session Account
            ViewBag.Account = GetAccount();
            //List All Category
            List<Category> categoryList = context.Categories.ToList();
            ViewBag.Category = categoryList;
            //List Product
            if (page == null) page = 1;
            var shoesList = context.Shoes.OrderBy(s => s.ShoesId).ToList();
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View(shoesList.ToPagedList(pageNumber, pageSize));
        }

        public IActionResult AddShoes()
        {
            //Session Account
            ViewBag.Account = GetAccount();
            List<Category> categoryList = context.Categories.ToList();
            ViewBag.Category = categoryList;
            return View();
        }

        [HttpPost]
        public IActionResult AddShoes(string name, string price, string category, int quantity, string image, int? page)
        {
            //Add shoes
            Shoe shoes = new Shoe() { ShoesName = name, ShoesPrice = double.Parse(price), CategoryId = int.Parse(category), ShoesQuantity = quantity, ShoesImage = image };
            context.Shoes.Add(shoes);
            context.SaveChanges();
            //Session Account
            ViewBag.Account = GetAccount();
            List<Category> categoryList = context.Categories.ToList();
            ViewBag.Category = categoryList;
            //List Product
            if (page == null) page = 1;
            var shoesList = context.Shoes.OrderBy(s => s.ShoesId).ToList();
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View("ManagerShoes", shoesList.ToPagedList(pageNumber, pageSize));
        }
        public IActionResult DeleteShoes(int ShoesId, int? page)
        {
            Shoe shoes = context.Shoes.Where(s => s.ShoesId == ShoesId).FirstOrDefault();
            if (shoes != null)
            {
                context.Shoes.Remove(shoes);
                context.SaveChanges();
            }
            //Session Account
            ViewBag.Account = GetAccount();
            List<Category> categoryList = context.Categories.ToList();
            ViewBag.Category = categoryList;
            //List Product
            if (page == null) page = 1;
            var shoesList = context.Shoes.OrderBy(s => s.ShoesId).ToList();
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View("ManagerShoes", shoesList.ToPagedList(pageNumber, pageSize));
        }
        public IActionResult ManagerCategory()
        {
            //Session Account
            ViewBag.Account = GetAccount();
            List<Category> listCategory = context.Categories.ToList();
            return View(listCategory);
        }

        [HttpPost]
        public IActionResult ManagerCategory(string name)
        {

            //Add new Category
            Category category = new Category() { CategoryName = name };
            context.Categories.Add(category);
            context.SaveChanges();

            //Session Account
            ViewBag.Account = GetAccount();
            List<Category> listCategory = context.Categories.ToList();


            return View("ManagerCategory", listCategory);
        }
        public IActionResult DeleteCategory(int CategoryId)
        {
            Category category = context.Categories.Where(x => x.CategoryId == CategoryId).FirstOrDefault();
            if (category != null)
            {
                context.Categories.Remove(category);
                context.SaveChanges();
            }
            //Session Account
            ViewBag.Account = GetAccount();
            List<Category> listCategory = context.Categories.ToList();
            return View("ManagerCategory", listCategory);
        }
        public IActionResult EditShoes(int ShoesId)
        {
            Shoe shoe = context.Shoes.Where(s => s.ShoesId == ShoesId).FirstOrDefault();
            //Session Account
            ViewBag.Account = GetAccount();
            List<Category> categoryList = context.Categories.ToList();
            ViewBag.Category = categoryList;
            return View(shoe);
        }

        [HttpPost]
        public IActionResult EditShoes(int ShoesId, string name, string price, string category, int quantity, string image, int? page)
        {
            //Session Account
            ViewBag.Account = GetAccount();
            List<Category> categoryList = context.Categories.ToList();
            ViewBag.Category = categoryList;
            Shoe shoe = context.Shoes.Where(s => s.ShoesId == ShoesId).FirstOrDefault();
            if(shoe != null)
            {
                shoe.ShoesName = name;
                shoe.ShoesPrice = double.Parse(price);
                shoe.ShoesQuantity = quantity;
                shoe.ShoesImage = image;
                context.SaveChanges();
            }
            
            return View(shoe);
        }

        public IActionResult ManagerOrder(int? page, string status)
        {
            //Session Account
            ViewBag.Account = GetAccount();

            //List Order
            if (page == null) page = 1;
            var orderList = context.Orders.OrderBy(s => s.Id).ToList();
            if (status != null)
            {

                orderList = orderList.Where(x => x.Status == status).OrderBy(s => s.Id).ToList();
                if (status.Equals("3"))
                {
                    orderList = context.Orders.OrderBy(s => s.Id).ToList();
                }
            }
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View(orderList.ToPagedList(pageNumber, pageSize));
        }
        public IActionResult SetSendOrder(int? page, int OrderId)
        {
            //Session Account
            ViewBag.Account = GetAccount();
            //Get Order by ID
            Order order = context.Orders.Where(o => o.Id == OrderId).FirstOrDefault();
            order.Status = "1";
            context.SaveChanges();
            //List Order
            if (page == null) page = 1;
            var orderList = context.Orders.OrderBy(s => s.Id).ToList();
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View("ManagerOrder",orderList.ToPagedList(pageNumber, pageSize));
        }
        public IActionResult SetRejectOrder(int? page, int OrderId)
        {
            //Session Account
            ViewBag.Account = GetAccount();
            //Get Order by ID
            Order order = context.Orders.Where(o => o.Id == OrderId).FirstOrDefault();
            order.Status = "2";
            context.SaveChanges();
            //List Order
            if (page == null) page = 1;
            var orderList = context.Orders.OrderBy(s => s.Id).ToList();
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View("ManagerOrder",orderList.ToPagedList(pageNumber, pageSize));
        }
        public IActionResult ViewOrder(int OrderId)
        {
            //Session Account
            ViewBag.Account = GetAccount();
            List<Shoe> shoes = context.Shoes.ToList();
            //Get Order by ID
            List<OrderDetail> order = context.OrderDetails.Where(o => o.OrderId == OrderId).ToList();
            return View(order);
        }
   }
}
