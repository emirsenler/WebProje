using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Person.Models;
using Person.Services.İnterfaces;
using System.Runtime.CompilerServices;

namespace Login.APİ.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPerson _Iperson;
        public PersonController(IPerson _iperson)
        {
            _Iperson = _iperson;
        }

        [HttpPost]
        public IActionResult login(PersonModel.request personobj)
        {
             return Ok(_Iperson.login(personobj));
            
        }
    }
}
