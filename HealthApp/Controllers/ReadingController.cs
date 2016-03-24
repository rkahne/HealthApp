using HealthApp.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HealthApp.Models
{
    public class ReadingController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ReadingController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Person
        public ActionResult Index()
        {
            var readings = _dbContext.Set<Reading>().ToList();
            IEnumerable<ReadingIndexViewModel> viewModels = readings.Select(r => new ReadingIndexViewModel()
            {
                reading_date = r.reading_date,
                weight = r.weight,
                sbp = r.sbp,
                dbp = r.dbp,
                tc = r.tc,
                hdl = r.hdl,
                ldl = r.ldl,
                triglycerides = r.triglycerides,
                glucose = r.glucose

            });
            return View(viewModels);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new ReadingCreateViewModel());
        }

        // POST: Person
        [HttpPost]
        public ActionResult Create(ReadingIndexViewModel vm)
        {
            Reading newReading = new Reading()
            {
                reading_date = vm.reading_date,
                weight = vm.weight,
                sbp = vm.sbp,
                dbp = vm.dbp,
                tc = vm.tc,
                hdl = vm.hdl,
                ldl = vm.ldl,
                triglycerides = vm.triglycerides,
                glucose = vm.glucose
            };

            _dbContext.Set<Reading>().Add(newReading);
            _dbContext.SaveChanges();

            return RedirectToAction("Create");
        }
    }
}