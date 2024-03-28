using InnoMindsAdminPanel.Models;
using Microsoft.AspNetCore.Mvc;

namespace InnoMindsAdminPanel.Controllers
{
    public class PlansController : Controller
    {
        public IActionResult Index()
        {
            var plans = new List<Plan>
            {
                new Plan { PlanId = 1, Name = "Bronze", Price = 29.99m, Description = "Bronze plan: provides you to access the most basic features!" },
                new Plan { PlanId = 2, Name = "Platinium", Price = 49.99m, Description = "Platinium Plan: By choosing this you are achieving beyond the horizon and accessing to unlimited features!" }
            };

            return View(plans);
        }
    }
}
