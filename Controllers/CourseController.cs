using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

    public class CourseController : Controller
    {

        public IActionResult Details(int id) //pattern deki id bilgisini göndereceğiz 
        {
            var kurs = Repository.GetById(id);//kurs bilgisi id bekliyor 
              if(kurs == null){
                return RedirectToAction("List","Course"); //id olmadığında route yönlendirmesi farklı olacak.
            }


            return View(kurs);
        }
        
        public IActionResult List() 
        {
            return View("CourseList",Repository.Courses); //sayfa üzerine bir liste gidecek.
        }
    }
