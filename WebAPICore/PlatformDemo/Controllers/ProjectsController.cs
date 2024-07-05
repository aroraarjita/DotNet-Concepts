using Microsoft.AspNetCore.Mvc;
using PlatformDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Reading all the projects");

        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Reading project #{id}.");

        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Creating a project");

        }

        /// <summary>
        /// api/projects/{pid}/tickets?tid={tid}
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/projects/{pid}/tickets")]
        public IActionResult GetProjectTicket(int pid, [FromQuery] int tid)
        {
            if (tid == 0)
                return Ok($"Reading all the tickets belong to project #{pid}");

            else
                return Ok($"Reading project #{pid} and ticket #{tid}");

        }


        ///// <summary>
        ///// api/projects/{pid}/tickets?tid={tid}
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet]
        //[Route("/api/projects/{pid}/tickets")]
        //public IActionResult GetProjectTicket([FromQuery]Ticket ticket)
        //{
        //    if (ticket == null)
        //        return BadRequest("Parameters are not provided properly!");


        //    if (ticket.TicketId == 0)
        //        return Ok($"Reading all the tickets belong to project #{ticket.ProjectId}");

        //    else
        //        return Ok($"Reading project #{ticket.ProjectId} and ticket #{ticket.TicketId}, title: {ticket.Title}, description: {ticket.Description}");

        //}



        [HttpPut]
        public IActionResult Put()
        {
            return Ok("Updating a project");

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleting project #{id}.");

        }



    }
}
