using Microsoft.AspNetCore.Mvc;
using AwesomeNet.Unit35.ViewModels.Account;
using AwesomeNet.Unit35.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using AutoMapper;
using AwesomeNet.Unit35.Data.UnitOfWork;

namespace AwesomeNet.Unit35.Controllers
{
    public class RegisterController : Controller
    {
        private IMapper _mapper;

        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public RegisterController(UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }

        [Route("Register")]
        [HttpGet]
        public IActionResult Register()
        {
            //return View("Home/Register");
            return View("Register");
        }

        [Route("RegisterPart2")]
        [HttpGet]
        public IActionResult RegisterPart2(ViewModels.Account.RegisterViewModel model)
        {
            return View("RegisterPart2", model);
        }

        [Route("Register")]
        [HttpPost]
        public async Task<IActionResult> Register(ViewModels.Account.RegisterViewModel model)
        //public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<User>(model);

                var result = await _userManager.CreateAsync(user, model.PasswordReg);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View("RegisterPart2", model);
        }

    }
}
