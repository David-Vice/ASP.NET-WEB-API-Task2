﻿using ASP.NET_First_WEB_API.Interfaces;
using ASP.NET_First_WEB_API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.NET_First_WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentsService _students;

        public StudentsController(IStudentsService students)
        {
            this._students = students;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await this._students.GetAllStudents());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await this._students.GetStudent(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Student value)
        {
            return Ok(await this._students.AddStudent(value));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Student value)
        {
            return Ok(await this._students.EditStudent(id, value));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await this._students.DeleteStudent(id));
        }
    }
}
