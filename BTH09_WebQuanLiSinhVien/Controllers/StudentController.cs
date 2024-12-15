using BTH09_WebQuanLiSinhVien.Data;
using BTH09_WebQuanLiSinhVien.Models;
using Microsoft.AspNetCore.Mvc;

namespace BTH09_WebQuanLiSinhVien.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentRepository _repository;

        public StudentController(StudentRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var students = _repository.GetAllStudents();
            return View(students);
        }
    }
}
