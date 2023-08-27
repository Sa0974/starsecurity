using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StarSecurityServices.Models;
using System.Linq;
using System.Threading.Tasks;

namespace StarSecurityServices.Controllers
{
    public class DashboardController : Controller
    {
        MyContext myContext;


        public DashboardController(MyContext mycontext)
        {
          
            myContext = mycontext;
        }
        public async Task <IActionResult> Index()
        {
            return View(await myContext.vacancies.ToListAsync()); 
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task< IActionResult> Create([Bind("EmpName,EmpAdd,EmpCon,EmpEdu,Depart,Role,Grade")] Vacancies vacancies)
        {
            if (ModelState.IsValid)
            {
                myContext.Add(vacancies);
                await myContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(vacancies);
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete(int Id)
        {
            Vacancies vacancies = myContext.vacancies.Where(a => a.Id == Id).FirstOrDefault();
            return View(vacancies);
        }
        [HttpPost]
        public IActionResult Delete(Models.Vacancies vacancies)
        {
            var result = myContext.vacancies.Where(a => a.Id == vacancies.Id).FirstOrDefault();
            if (result != null)
            {
               myContext.vacancies.Remove(result);
                myContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }



    }
}
