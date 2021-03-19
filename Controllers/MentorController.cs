using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exoft_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MentorController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Mentor> Get()
        {
            string name;
            string surname;
            int id;
            (name, surname, id) = Creator.SetDefault();
            IHuman mentor = new Mentor()
            {
                Name = name,
                Surname = surname,
                Id = id,
                subordinate = Creator.SetDefaultMentor()
            };
            return Ok(mentor);
        }
    }
}
