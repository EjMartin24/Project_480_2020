using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_480_V11.Models;
using System.Linq;
using System.Threading.Tasks;
using static Project_480_V11.Models.BracketDbContext;

namespace Project_480_V11.HomeController
{
    public class HomeController : Controller
    {

        private BracketDbContext _context;
        public HomeController(BracketDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View("Index");
            // _context.Brackets.Add(new BracketInput() {BracketId = "1", FullName="Elijah Martin", Localtion="Washington", Rank="2"});
           // return View(Brackets);
           // return Content("Test");
        }

       
        public IActionResult GetDetails()
        {
            return View("Index");
        }

        [HttpPost]
        public IActionResult Index(BracketInput Brackets)
        {
            _context.Add(Brackets);
            _context.SaveChanges();
            return Content("Save");
            //return View(Brackets);
        }

        //[httpget]
        //public iactionresult details(string bracketid)
        //{
        //    return view(brackets);
        //}

        //[httpget]
        //public iactionresult create()
        //{
        //    return view();
        //}

        //[httppost]
        //public iactionresult create(bracketinput brackets)
        //{
        //    return redirecttoaction("index");
        //}

        //[httpget]
        //public iactionresult edit(int brasketid)
        //{
        //    return view(brackets);
        //}

        //[httpget]
        //public iactionresult edit(int id, bracketinput brackets)
        //{
        //    return redirecttoaction(brackets);
        //}

        //[httpget]
        //public iactionresult delete(int id)
        //{
        //    return view(brackets);
        //}

        //[httppost, actionname("delete")]
        //public iactionresult deleteconfirmed(int id)
        //{
        //    return redirecttoaction("index");
        //}


        //[route("bracketinput/getdetails")]
        //public iactionresult getdetails()
        //{
        //    return view();
        //}

        //[route("bracket/myontails")]
        //public iactionresult myontails(bracketinput bracket)
        //{
        //    return view();
        //}
    }
}