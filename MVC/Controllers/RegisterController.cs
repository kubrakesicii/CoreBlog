using Business.Abstract;
using Business.ValidationRules;
using Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IUserService _userService;

        public RegisterController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            UserValidator uv = new UserValidator();
            ValidationResult results = uv.Validate(user);

            if(results.IsValid)
            {
                user.About = "xxx";
                user.IsActive = 1;
                _userService.Register(user);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach(var e in results.Errors)
                {
                    ModelState.AddModelError(e.PropertyName, e.ErrorMessage);
                }
            }
            return View();
        }
    }
}
