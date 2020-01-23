using System.Threading.Tasks;

namespace DevBlog.Services
{
    public interface ISecurityService
    {
        Task<bool> ValidateUser(string token);
    }
}