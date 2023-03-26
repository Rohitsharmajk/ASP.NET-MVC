using Antlr.Runtime.Tree;
using SqlMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SqlMvc.Controllers
{
    public class SqlDataController : Controller
    {
        // GET: SqlData
        public ActionResult MyAnime()
        {
            AnimeChars obj= new AnimeChars();
            return View(obj);
        }

        [HttpPost]
        public ActionResult AddDets(String Id, string Name, string Anime)
        {
            RohitDataEntities1 cntx = new RohitDataEntities1();
            cntx.MvcTables.Add(new MvcTable { Id = Id, Name = Name, Anime = Anime }); 
            cntx.SaveChanges();
            return View("MyAnime");
        }
    }
}