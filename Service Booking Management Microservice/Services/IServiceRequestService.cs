using Service_Booking_Management_Microservice.Model;

namespace Service_Booking_Management_Microservice.Services
{
    public interface IServiceRequestService
    {
        List<AppService> GetServicesList();
        List<AppService> GetServiceRequestDetailsByUserId(int userId);
        bool SaveService(AppService serviceReqModel);
        bool DeleteService(int id);
        bool UpdateService(int id, AppService serviceReqModel);
        List<AppService> GetServiceRequestDetailsByStatus(string status);
    }
}
