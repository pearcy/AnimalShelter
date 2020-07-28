using Microsoft.AspNetCore.Mvc; 
using AnimalShelter.Models; 
using System.Collections.Generic; 
using System.Linq; 

namespace AnimalShelter.Controllers
{
  public class TypeController : Controller
  {
    private readonly AnimalShelterContext _db; // declare priave readonly AnimalShelterContext

    public TypesController(AnimalShelterContext db) // constructor that sets the value of _db proprty to TypesContext
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Type> model = _db.Types.ToList(); //replaces GetAll() // ToLinst () =LINQ method 
      return View(model);
      //db = isntance of DbContext class - it holds reference to database
      //LINQ turns DbSet into a list using ToList() (came from System.Linq)
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Type type)
    {
      _db.Types.Add(type);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id) //takes id of entry we want to view --> must match property from anonymous object created using ActionLink() in view
    {
      Type thisType = _db.Types.FirstOrDefault(types => types.TypeId == id);
      return View(thisType);
      //FirstOrDefault = Linq method which uses a lambda -- look at db.Types (types table) - find any types where the type id matches the id being provided to this method
    }
  }
}  
