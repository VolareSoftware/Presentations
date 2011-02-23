using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Lab8.Models;

namespace Lab8.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _repository;

        // Lab #8, Step #4b
        //private IHrService _service;

        public EmployeeController()
            : this(new EmployeeRepository())
        {
        }

        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        //// Lab #8, Step #4b
        //public EmployeeController()
        //    : this(new EmployeeRepository(), new HrService())
        //{
        //}

        //// Lab #8, Step #4b
        //public EmployeeController(IEmployeeRepository repository, IHrService service)
        //{
        //    _repository = repository;
        //    _service = service;
        //}

        //
        // GET: /Employee/

        public ActionResult Index()
        {
            var employees = _repository.GetAll();

            return View(employees);
        }

        //
        // GET: /Employee/Details/5

        public ActionResult Details(int id)
        {
            var employee = _repository.Get(id);

            return View(employee);
        }

        //
        // GET: /Employee/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Employee/Create

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Employee/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Employee/Edit/5

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
