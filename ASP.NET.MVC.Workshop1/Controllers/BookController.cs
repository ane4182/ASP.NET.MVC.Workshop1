using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Asp_Net_MVC_Workshop1.Models;

namespace Asp_Net_MVC_Workshop1.Controllers
{
    public class BookController : Controller
    {
        Database1Entities1 db = new Database1Entities1();
        // GET: Book
        public ActionResult Index()
        {
            var book = db.BOOK_DATA.OrderBy(m => m.BOOK_CLASS_ID).ToList();
            return View(book);
        }
       



        

    }
}
