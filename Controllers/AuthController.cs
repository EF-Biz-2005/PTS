using Microsoft.AspNetCore.Mvc; 

using Microsoft.AspNetCore.Identity; 

using System.Threading.Tasks; 

using StudentManagementSystem.Models; 

  

namespace StudentManagementSystem.Controllers 

{ 

    public class AuthController : Controller 

    { 

        private readonly SignInManager<User> _signInManager; 

        private readonly UserManager<User> _userManager; 

  

        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager) 

        { 

            _userManager = userManager; 

            _signInManager = signInManager; 

        } 

  

        [HttpGet] 

        public IActionResult Login() => View(); 

  

        [HttpPost] 

        public async Task<IActionResult> Login(LoginViewModel model) 
        { 
            if (string.IsNullOrWhiteSpace(model.Email))
            {
             ModelState.AddModelError(string.Empty, "Email is required.");
             return View(model);
            }

         var user = await _userManager.FindByEmailAsync(model.Email);


            if (!ModelState.IsValid)

                return View(model);
            _ = await _userManager.FindByEmailAsync(model.Email);

            if (user == null) 

            { 

                ModelState.AddModelError("", "Invalid login attempt."); 

                return View(model); 

            } 

  

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false); 

  

            if (result.Succeeded) 

                return RedirectToAction("Index", "Students"); 

  

            ModelState.AddModelError("", "Invalid login attempt."); 

            return View(model); 

        } 

  

        [HttpPost] 

        public async Task<IActionResult> Logout() 

        { 

            await _signInManager.SignOutAsync(); 

            return RedirectToAction("Login"); 

        } 

    } 

} 

 