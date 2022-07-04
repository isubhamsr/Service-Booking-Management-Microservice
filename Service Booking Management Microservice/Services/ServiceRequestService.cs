using Microsoft.EntityFrameworkCore;
using Service_Booking_Management_Microservice.Model;

namespace Service_Booking_Management_Microservice.Services
{
    public class ServiceRequestService : IServiceRequestService
    {
        private AppicationContext _context;

        public ServiceRequestService(AppicationContext context)
        {
            _context = context;
        }
        public bool DeleteService(int id)
        {
            try
            {
                var service = _context.AppServices.Where(p => p.Id == id).FirstOrDefault();
                if (service != null)
                {
                    _context.Entry(service).State = EntityState.Deleted;
                    _context.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<AppService> GetServiceRequestDetailsByStatus(string status)
        {
            List<AppService> services = new List<AppService>();
            try
            {
                services = _context.AppServices.Where(p => p.Status == status).ToList();
                return services;
            }
            catch (Exception ex)
            {

                throw new Exception();
            }
        }

        public List<AppService> GetServiceRequestDetailsByUserId(int userId)
        {
            List<AppService> services = new List<AppService>();
            try
            {
                services = _context.AppServices.Where(p => p.UserId == userId).ToList();
                return services;
            }
            catch (Exception ex)
            {

                throw new Exception();
            }
        }

        public List<AppService> GetServicesList()
        {
            List<AppService> services = new List<AppService>();
            try
            {
                services = _context.AppServices.ToList();

                return services;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public bool SaveService(AppService serviceReqModel)
        {
            try
            {
                if(serviceReqModel != null)
                {
                    _context.AppServices.Add(serviceReqModel);
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateService(int id, AppService serviceReqModel)
        {
            try
            {
                var service = _context.AppServices.Where(p => p.Id == id).FirstOrDefault();
                if(service != null)
                {
                    service.ReqDate = serviceReqModel.ReqDate;
                    service.Problem = serviceReqModel.Problem;
                    service.Description = serviceReqModel.Description;
                    service.Status = serviceReqModel.Status;

                    _context.Entry(service).State = EntityState.Modified;
                    _context.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
