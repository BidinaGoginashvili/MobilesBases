using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobilesBases.Models;
using MobilesBases.ViewModel;
using System.Data.Entity;
using PagedList;
using PagedList.Mvc;
namespace MobilesBases.Controllers
{
    public class MainController : Controller
    {
        private ApplicationDbContext _context;

        public MainController()
        {
            _context = new ApplicationDbContext();
        }

       
        public ActionResult MainPage(string SearchText,int? From,int? To, int? Departments,int? page)
        {
            var info = _context.MI.Include(c => c.MF);
            ViewBag.Departments = new SelectList(_context.MF,"Id","ManufacturerName",null);
            if (SearchText != null)
            {
                info = info.Where(x => x.MF.ManufacturerName.Contains(SearchText));
            }
            if (From != null &&To!=null)
            {
                info = info.Where(x => x.Price>From&&x.Price<To);
              
            }

            if (Departments != null)
            {
                info = info.Where(x => x.MF.Id==Departments);
               
            }
            return View(info.ToList().ToPagedList(page ?? 1,3));
        }

        public ActionResult Details(int id)
        {
            var info = _context.MI.SingleOrDefault(x => x.Id == id);
            var viewModel = new MobileInformationViewModel
            {
                Mii = info,
                Mff = _context.MF.ToList()
            };
            return View(viewModel);
        }

        public ActionResult SearchEngine(string searchText)
        {
            return View(_context.MF.Where(x=>x.ManufacturerName.Contains(searchText)).ToList());
        }
    }
}