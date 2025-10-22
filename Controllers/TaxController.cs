using Microsoft.AspNetCore.Mvc;
using OnlineCV.Models;

namespace OnlineCV.Controllers
{
    public class TaxController : Controller
    {
        public IActionResult Index()
        {
            return View(new TaxModel());
        }

        [HttpPost]
        public IActionResult Index(TaxModel model)
        {
            if (ModelState.IsValid)
            {
                // Социальный взнос 6%
                model.CAS = model.Income * 0.06m;

                // Медицинский взнос 4.5%
                model.CASS = model.Income * 0.045m;

                // Подоходный налог 12% (для упрощения)
                model.PIT = model.Income * 0.12m;

                // Общая сумма налогов
                model.TotalTax = model.CAS + model.CASS + model.PIT;
            }
            return View(model);
        }
    }
}
