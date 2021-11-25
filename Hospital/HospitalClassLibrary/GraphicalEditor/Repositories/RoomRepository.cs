﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalClassLibrary.Data;
using HospitalClassLibrary.GraphicalEditor.Models;
using HospitalClassLibrary.GraphicalEditor.Repositories.Interfaces;
using HospitalClassLibrary.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HospitalClassLibrary.GraphicalEditor.Repositories
{
    public class RoomRepository : GenericRepository<Room>, IRoomRepository
    {
        public RoomRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Room>> GetAll(int buildingId)
        {
            return await Context.Room.Where(r => r.BuildingId == buildingId).Select(r => r).ToListAsync();
        }

        public int GetDoctorId(int roomId)
        {
            var rooms = Context.Room.Where(r => r.Id == roomId).Include(r => r.Doctor).ToList();

            return rooms.First().Doctor.Id;
        }

        public async Task<Room> GetRoomWithEquipment(int id)
        {
            var rooms = await Context.Room.Where(r => r.Id == id).Include(r => r.Equipment)
                .ThenInclude(e => e.EquipmentItem).ToListAsync();

            return rooms.First();
        }
    }

}
