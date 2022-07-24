using Microsoft.AspNetCore.Mvc;
using Project_ShoppingCart_PRN211.Models;
using Project_ShoppingCart_PRN211;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using PagedList;
namespace Project_ShoppingCart_PRN211.Controllers
{
    public class ShopController : Controller
    {
        PROJECT_ShoppingCart_PRN291Context context = new PROJECT_ShoppingCart_PRN291Context();
        public const string ACCOUNTKEY = "Account";
        public IActionResult Index(int? page)
        {
            //1. List All Category
            List<Category> categoryList = context.Categories.ToList();
            ViewBag.Category = categoryList;
            
            //List Quantity
            List<int> listquantity = new List<int>();
            for (int i = 1; i <= categoryList.Count; i++)
            {
                int n = context.Categories.Where(s => s.CategoryId == i).ToList().Count();
                listquantity.Add(n);
            }
            ViewBag.listquantity = listquantity;
            //Session Account
            ViewBag.Account = GetAccount();

            //List Product
            if (page == null) page = 1;
            var shoesList = context.Shoes.OrderBy(s => s.ShoesId).ToList();
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            return View(shoesList.ToPagedList(pageNumber, pageSize));
        }
        public IActionResult Search(string txt, int CategoryId, int? page)
        {
            ViewBag.Account = GetAccount();
            //1. List All Category
            List<Category> categoryList = context.Categories.ToList();
            ViewBag.Category = categoryList;
            //2. List All Shoes
            //List Product
            if (page == null) page = 1;
            var shoesList = context.Shoes.OrderBy(s => s.ShoesId).ToList();
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            //Action: Search
            if (txt != null)
            {
                txt = txt.Trim();
                shoesList = context.Shoes.Where(s => s.ShoesName.Contains(txt)).ToList();
            }
            //Action: Filter by Category
            else if(CategoryId != null)
            {
                shoesList = context.Shoes.Where(s => s.CategoryId == CategoryId).ToList();
            }
            else
            {
               shoesList = context.Shoes.ToList();
            }

            return View("Index", shoesList.ToPagedList(pageNumber, pageSize));
        }
        public IActionResult Filter(int filter, int? page)
        {
            //Session Account
            ViewBag.Account = GetAccount();
            //1. List All Category
            List<Category> categoryList = context.Categories.ToList();
            ViewBag.Category = categoryList;


            //2. List All Shoes
            //List Product
            List<Shoe> shoesList = new List<Shoe>();
            if (page == null) page = 1;
            shoesList = context.Shoes.OrderBy(s => s.ShoesId).ToList();
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            //Action: Filter
            if (filter != null)
            {
                //All
                if (filter == 0)
                {
                    shoesList = context.Shoes.ToList();
                }
                //Price (Low -> High)
                else if (filter == 1)
                {
                    shoesList = context.Shoes.OrderBy(s => s.ShoesPrice).ToList();
                }
                //Price (High -> Low)
                else if (filter == 2)
                {
                    shoesList = context.Shoes.OrderByDescending(s => s.ShoesPrice).ToList();
                }
                //Name (A-Z)
                else if (filter == 3)
                {
                    shoesList = context.Shoes.OrderBy(s => s.ShoesName).ToList();
                }
                //Name (Z-A)
                else if (filter == 4)
                {
                    shoesList = context.Shoes.OrderByDescending(s => s.ShoesName).ToList();
                }
            }
            else
            {
                shoesList = context.Shoes.ToList();
            }
            return View("Index", shoesList.ToPagedList(pageNumber, pageSize));

        }
        public IActionResult ShoesDetail(int ShoesId)
        {
            //Session Account
            ViewBag.Account = GetAccount();
            //List All Category
            List<Category> categoryList = context.Categories.ToList();
            ViewBag.Category = categoryList;
            //Get Shoes By ID
            Shoe shoes = context.Shoes.Where(s => s.ShoesId == ShoesId).FirstOrDefault();
            List<Shoe> listFeatured = context.Shoes.Take(5).ToList();
            ViewBag.listFeatured = listFeatured;
            return View(shoes);
            
        }

        public IActionResult Home()
        {
            //Session Account
            ViewBag.Account = GetAccount();
            //List All Category
            List<Category> categoryList = context.Categories.ToList();
            ViewBag.Category = categoryList;

            //1. List Top 5 Cheap Shoes
            List<Shoe> listTop5PriceAsc = context.Shoes.OrderBy(s => s.ShoesPrice).Take(5).ToList();
            ViewBag.listTop5PriceAsc = listTop5PriceAsc;
            //2. List Top 5 Expensive Shoes
            List<Shoe> listTop5PriceDesc = context.Shoes.OrderByDescending(s => s.ShoesPrice).Take(5).ToList();
            ViewBag.listTop5PriceDesc = listTop5PriceDesc;
            return View();
        }

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
