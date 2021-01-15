﻿using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            this._context = context;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Value>>> Index()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }

        //GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Value>> Get(int id)
        {
            var value = await _context.Values.FindAsync(id);
            return Ok(value);
        }
    }
}
