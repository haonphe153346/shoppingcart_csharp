using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project_ShoppingCart_PRN211.Models;
using System.Linq;

namespace Project_ShoppingCart_PRN211.Controllers
{
    public class LoginController : Controller
    {
        public const string ACCOUNTKEY = "Account";
        PROJECT_ShoppingCart_PRN291Context context = new PROJECT_ShoppingCart_PRN291Context();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string email, string password)
        {
            Account acc = context.Accounts.Where(acc => acc.AccountEmail.Equals(email) && acc.AccountPassword.Equals(password)).FirstOrDefault();
            if(acc != null)
            {
                if (acc.AccountRole == true)
                {
                    SaveAccountSession(acc);
                    ViewBag.Account = GetAccount();
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    return View();
                }
                
            }
            else
            {
                string err = "Your email or password was wrong! Please try again.";
                ViewBag.err = err;
                return View("Index");
            }
            
        }
        public IActionResult Logout()
        {
            ClearAccountSession();
            return RedirectToAction("Index", "Shop");
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
        void SaveAccountSession(Account acc)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(acc);
            session.SetString(ACCOUNTKEY, jsoncart);
        }

        void ClearAccountSession()
        {
            var session = HttpContext.Session;
            session.Remove(ACCOUNTKEY);
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string email, string password)
        {
            return View();
        }

    }
}
