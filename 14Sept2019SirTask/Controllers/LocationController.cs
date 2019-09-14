using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _14Sept2019SirTask.Models;

namespace _14Sept2019SirTask.Controllers
{
    public class LocationController : Controller
    {
        Database1Entities db = new Database1Entities();

        // GET: Location
        public ActionResult Index()
        {
            ViewBag.countryname = new SelectList(db.tbl_Country.ToList(), "countryid", "countryname");
            ViewBag.statename = new List<SelectListItem>(){
                new SelectListItem(){ Text = "", Value="Select State"}
            }; ViewBag.cityname = new List<SelectListItem>() {
                new SelectListItem(){Text="", Value="Select City"}
            };
            return View();
        }


        public JsonResult GetStatesByCountryId(int id)
        {
            return Json(db.tbl_State.Where(a => a.FKcountryid == id).Select(b => new { b.statename, b.stateid }).ToList(),JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCitiesByStateId(int id)
        {
            return Json(db.tbl_City.Where(a => a.FKstateid == id).Select(b => new { b.cityname, b.cityid }).ToList(), JsonRequestBehavior.AllowGet);
        }

    }
}