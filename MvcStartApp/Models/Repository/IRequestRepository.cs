using MvcStartApp.Models.Db;

namespace MvcStartApp.Models.Repository
{
    public interface IRequestRepository
    {
        Task AddRequest(Request request);
        Task<Request[]> GetRequests();
    }
}
