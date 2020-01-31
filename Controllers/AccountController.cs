using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using MyApiCall.Models;
using System.Threading.Tasks;
using MyApiCall.ViewModels;
using Newtonsoft.Json;
using RestSharp;

namespace MyApiCall.Controllers
{
    public class AccountController : Controller
    {
        // private readonly MyApiCallContext _db;
        // private readonly UserManager<ApplicationUser> _userManager;
        // private readonly SignInManager<ApplicationUser> _signInManager;

        // public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, MyApiCallContext db)
        // {
        //     _userManager = userManager;
        //     _signInManager = signInManager;
        //     _db = db;
        // }

        public ActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async ActionResult Register (RegisterViewModel model)
        {
            // var user = new ApplicationUser { UserName = model.Email };
            // IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            // if (result.Succeeded)
            // {
            //     return RedirectToAction("Index");
            // }
            // else
            // {
            //     return View();
            // }

            var user = new User();
            user.data[0]["username"] = model.Email;
            user.data[0]["password"] = model.Password;

            var jsonBody = JsonConvert.SerializeObject(user);
            var client = new RestClient();
            var request = new RestRequest();


            return RedirectToAction("Index");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            // Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
            // if (result.Succeeded)
            // {
            //     return RedirectToAction("Index");
            // }
            // else
            // {
            //     return View();
            // }
        }
        [HttpPost]
        public async Task<ActionResult> LogOff()
        {
            // await _signInManager.SignOutAsync();
            // return RedirectToAction("Index");
        }
    }
}