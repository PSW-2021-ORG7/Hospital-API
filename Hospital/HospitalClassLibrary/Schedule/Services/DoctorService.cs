using System.Threading.Tasks;
using HospitalClassLibrary.Schedule.Models;
using HospitalClassLibrary.Schedule.Repositories.Interfaces;
using HospitalClassLibrary.Schedule.Services.Interfaces;

namespace HospitalClassLibrary.Schedule.Services
{

    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;

        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public async Task<Doctor> GetById(int id)
        {
            return await _doctorRepository.GetByIdAsync(id);
        }
        Task<Doctor> IDoctorService.GetDoctorForRoom(int roomId)
        {
            return _doctorRepository.GetDoctorForRoom(roomId);
        }
    }
}
