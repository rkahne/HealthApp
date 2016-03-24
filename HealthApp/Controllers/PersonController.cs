using HealthApp.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HealthApp.Models
{
    public class PersonController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public PersonController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Person
        public ActionResult Index()
        {
            var people = _dbContext.Set<Person>().ToList();
            IEnumerable<PersonIndexViewModel> viewModels = people.Select(p => new PersonIndexViewModel()
            {
                id = p.person_id,
                first_name = p.first_name,
                last_name = p.last_name,
                dob = p.dob,
                height = p.height
            });
            return View(viewModels);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new PersonCreateViewModel());
        }

        // POST: Person
        [HttpPost]
        public ActionResult Create(PersonIndexViewModel vm)
        {
            Person newPerson = new Person()
            {
                first_name = vm.first_name,
                last_name = vm.last_name,
                dob = vm.dob,
                height = vm.height
            };

            _dbContext.Set<Person>().Add(newPerson);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult AddReading(PersonAddReadingViewModel vm)
        {
            Person associatedPerson = _dbContext.Set<Person>().Find(vm.person_id);

            Reading newReading = new Reading()
            {
                reading_date = vm.reading_date,
                weight = vm.weight,
                ldl = vm.ldl,
                hdl = vm.hdl,
                tc = vm.tc,
                triglycerides = vm.triglycerides,
                sbp = vm.sbp,
                dbp = vm.dbp,
                glucose = vm.glucose,
                Person = associatedPerson
            };

            associatedPerson.Readings.Add(newReading);

            _dbContext.Set<Reading>().Add(newReading);
            _dbContext.SaveChanges();

            return RedirectToAction("AddReading", "Person", new { identifier = vm.person_id });
        }

        [HttpGet]
        public ActionResult AddReading( int identifier )
        {
            return View(new PersonAddReadingViewModel() { person_id=identifier});
        }


        public ActionResult ViewReadings(int identifier)
        {
            var person = _dbContext.Set<Person>().Find(identifier);
            var readings = person.Readings;

            List<ReadingIndexViewModel> toReturn = new List<ReadingIndexViewModel>();
            
            foreach(var r in readings)
            {
                toReturn.Add(new ReadingIndexViewModel
                {
                    reading_date = r.reading_date,
                    weight = r.weight,
                    bmi = (r.weight / (person.height * person.height)) * 703,
                    tc = r.tc,
                    ldl = r.ldl,
                    hdl = r.hdl,
                    triglycerides = r.triglycerides,
                    glucose = r.glucose,
                    sbp = r.sbp,
                    dbp = r.dbp
                });
            }

            return View(toReturn);
        }

    }
}