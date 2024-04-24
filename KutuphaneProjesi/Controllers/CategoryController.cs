using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace KutuphaneProjesi.Controllers
{
	public class CategoryController : Controller
	{
		[Authorize]
		public IActionResult Index()
		{
			return View();
		}
	}
}
