﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalClassLibrary.Schedule.Models;
using HospitalClassLibrary.Schedule.Services.Interfaces;
using HospitalClassLibrary.Shared.Models;

namespace HospitalAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class ShiftsController : Controller
    {
        private readonly IShiftService _shiftService;

        public ShiftsController(IShiftService shiftService)
        {
            _shiftService = shiftService;
        }

        [HttpGet("shifts")]
        public async Task<IEnumerable<Shift>> GetShifts([FromQuery] DateTimeRange dateTimeRange)
        {
            return await _shiftService.GetAll(dateTimeRange);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetShift(int id)
        {
            var shift = await _shiftService.GetById(id);
            if (shift == null)
                return NotFound();
            return Ok(shift);
        }

        [HttpPost]
        public async Task<IActionResult> PostShift(Shift shift)
        {
            await _shiftService.Create(shift);

            return NoContent();
        }

        [HttpPut("shifts")]
        public async Task<IActionResult> PutShift(Shift shift)
        {
            await _shiftService.Update(shift);

            return NoContent();
        }

        [HttpDelete("shifts")]
        public async Task<IActionResult> DeleteShift(Shift shift)
        {
            await _shiftService.Delete(shift);

            return NoContent();
        }

        [HttpGet("doctor/{id}")]
        public async Task<IEnumerable<object>> GetAllShiftsByDoctorId(int id)
        {
            return await _shiftService.GetAllShiftsByDoctorId(id);
        }

        [HttpGet("onCallShifts/doctor/{id}")]
        public async Task<IEnumerable<OnCallShift>> GetAllOnCallShiftsByDoctorId(int id)
        {
            return await _shiftService.GetAllOnCallShiftsByDoctorId(id);
        }


    }
}
