using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wedding_planner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace wedding_planner.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private MyContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        private int? UserSession
        {
            get { return HttpContext.Session.GetInt32("UserId"); }
            set { HttpContext.Session.SetInt32("UserId", (int)value); }
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if (ModelState.IsValid)
            {
                if (dbContext.Users.Any(i => i.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already exists!");
                    return View("Index");
                }
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                string hashedPw = hasher.HashPassword(newUser, newUser.Password);
                newUser.Password = hashedPw;
                dbContext.Add(newUser);
                dbContext.SaveChanges();
                UserSession = newUser.UserId;
                return RedirectToAction("Dashboard");
            }
            return View("Index");
        }

        [HttpPost("loginuser")]
        public IActionResult LoginUser(LoginUser currentUser)
        {
            if (ModelState.IsValid)
            {
                var UserInDb = dbContext.Users.FirstOrDefault(i => i.Email == currentUser.Email);
                if (UserInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Credentials");
                    return View("Index");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(currentUser, UserInDb.Password, currentUser.Password);
                if (result == 0)
                {
                    ModelState.AddModelError("Password", "Invalid Credentials");
                    return View("Index");
                }
                UserSession = UserInDb.UserId;
                return RedirectToAction("Dashboard");
            }
            return View("Index");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            ViewBag.CurrentUserId = UserSession;
            if (UserSession == null)
                return RedirectToAction("Index");
            var AllWeddings = dbContext.Weddings.Include(i => i.Associations).OrderByDescending(i => i.Date).ToList();
            return View(AllWeddings);
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            if (UserSession == null)
                return RedirectToAction("Index");
            return View();
        }

        [HttpPost("createWedding")]
        public IActionResult CreateWedding(Wedding newWedding)
        {
            if (UserSession == null)
                return RedirectToAction("Index");
            if (ModelState.IsValid)
            {
                newWedding.UserId = (int)UserSession;
                var weddingId = newWedding.WeddingId;
                Console.WriteLine("#######################");
                Console.WriteLine(weddingId);
                Console.WriteLine("#######################");
                dbContext.Weddings.Add(newWedding);
                dbContext.SaveChanges();
                Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@");
                Console.WriteLine(weddingId);
                Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@");
                return RedirectToAction("Detail", new { weddingId = newWedding.WeddingId });
            }
            return View();
        }

        [HttpGet("{weddingId}")]
        public IActionResult Detail(int weddingId)
        {
            if (UserSession == null)
                return RedirectToAction("Index");
            var currentWedding = dbContext.Weddings.Include(i => i.Associations).ThenInclude(i => i.User).FirstOrDefault(i => i.WeddingId == weddingId);
            return View(currentWedding);
        }

        [HttpGet("delete")]
        public IActionResult Delete(int weddingId)
        {
            if (UserSession == null)
                return RedirectToAction("Index");

            var WeddingToDelete = dbContext.Weddings.FirstOrDefault(i => i.WeddingId == weddingId);
            dbContext.Weddings.Remove(WeddingToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("Rsvp/{weddingId}")]
        public IActionResult Rsvp(int weddingId)
        {
            if (UserSession == null)
                return RedirectToAction("Index");

            var newAssociation = new Association()
            {
                WeddingId = weddingId,
                UserId = (int)UserSession
            };
            dbContext.Associations.Add(newAssociation);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }


        [HttpGet("UnRsvp/{weddingId}")]
        public IActionResult UnRsvp(int weddingId)
        {
            if (UserSession == null)
                return RedirectToAction("Index");

            var AssociationToDelete = dbContext.Associations.FirstOrDefault(i => i.WeddingId == weddingId && i.UserId == UserSession);

            dbContext.Associations.Remove(AssociationToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

    }
}
