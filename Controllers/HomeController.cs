using iSchoolWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using iSchoolWebApp.Services;

namespace iSchoolWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            //load the data...
            var getAbout = new GetAbout();
            //tell the instance to go get the data...
            var loadedAbout = await getAbout.getAb();
            //take the loadedAbout and populate the model
            var aboutModel = new AboutRootModel()
            {
                Title = "About our iSchool",
                About = loadedAbout
            };
            //call the view
            return View(aboutModel);
        }

        public async Task<IActionResult> Course()
        {
            var getCourse = new GetCourses();
            var loadedCourse = await getCourse.getCourses();
            var courseModel = new CourseRootModel()
            {
                Title = "Available Courses",
                course = loadedCourse.ToList()
            };
            return View(courseModel);
        }

        public async Task<IActionResult> Faculty()
        {
            
            var getAllFac = new GetFaculty();
            var loadedFac = await getAllFac.getAllFaculty();
            var facultyModel = new FacultyRootModel()
            {
                Title = "iSchool Faculty",
                faculty = loadedFac.ToList()
            };
            //send to the view
            return View(facultyModel);
        }

        public async Task<IActionResult> Degrees()
        {
            var results = new Undergrad();
            var loadedDeg = await results.getUndergrad();
            var degreesModel = new DegreesRootModel()
            {
                undergraduate = loadedDeg.ToList()
                
            };

            return View(degreesModel);
        }

        public async Task<IActionResult> Minors()
        {
            var getMinors = new GetMinors();
            var loadedMinors = await getMinors.getMinors();

            var minorsModel = new UgMinorsRoot()
            {
                UgMinors = loadedMinors.ToList()
            };

            return View(minorsModel);
        }

        public async Task<IActionResult> Employment()
        {
            //intro 
            var getEmployment = new GetEmployment();
            var intro = await getEmployment.GetIntro();

            //degree stats 
            var degreeStats = await getEmployment.GetDegreeStats();

            //employers
            var emp = await getEmployment.GetEmployers();

            //coop table
            var coop = await getEmployment.GetCoop();
            var empRootModel = new EmploymentRootModel
            {
                introduction = intro,
                degreeStatistics = degreeStats,
                employers = emp,
                coopTable = coop

            };
            return View(empRootModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
