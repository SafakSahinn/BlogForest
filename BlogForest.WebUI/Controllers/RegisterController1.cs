using BlogForest.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.Controllers
{
	public class RegisterController1 : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public RegisterController1(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public IActionResult CreateUser()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateUser()
		{

		}
	}
}
