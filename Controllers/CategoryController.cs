using Microsoft.AspNetCore.Mvc;
using PetShop.Data;
using PetShop.Models;
using System.Collections.Generic;

namespace PetShop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db) {  //dependency injection
            _db = db;
        }
        public IActionResult Index() {
            IEnumerable<Category> objList = _db.Category;
            return View(objList); //передаем представлениие Category
        }

        //GET - Create
        public IActionResult Create() {

            return View();
        }
    }
}
