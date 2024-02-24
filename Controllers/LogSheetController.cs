﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DatabaseContext;
using WebAPI.DTO;
using WebAPI.Service;

namespace WebAPI.Controllers
{
    [Route("logsheet")]
    [ApiController]
    public class LogsheetController : ControllerBase
    {
        CourseService service;
        ProjectDbContext _db;
        public LogsheetController(ProjectDbContext db)
        {
            _db = db;
            service = new CourseService();
        }
        [HttpGet]
        public IEnumerable<LogSheetDTO> LogsheetByStaff(int id)

        {
            var result = _db.logsheets.Where(l => l.LogSheetId == id).ToList();
            return (IEnumerable<LogSheetDTO>)result;
        }
    }
}
