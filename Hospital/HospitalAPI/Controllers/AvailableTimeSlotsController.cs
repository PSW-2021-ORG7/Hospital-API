﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HospitalClassLibrary.RoomEquipment.Models;
using HospitalClassLibrary.Schedule.Services.Interfaces;
using HospitalClassLibrary.Shared.Models;

namespace HospitalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvailableTimeSlotsController : ControllerBase
    {
        private readonly IWorkdayService _workdayService;

        public AvailableTimeSlotsController(IWorkdayService workdayService)
        {
            _workdayService = workdayService;
        }

        [HttpGet]
        public IEnumerable<DateTimeRange> GetRooms([FromQuery] EquipmentTransferRequirements requirements)
        {
            return _workdayService.GetAvailableTimeSlots(requirements);
        }
    }
}
