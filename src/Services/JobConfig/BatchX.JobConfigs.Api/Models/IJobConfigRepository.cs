using System.Threading.Tasks;

namespace BatchX.JobConfig.Api.Models
{
    public interface IJobConfigRepository
    {
        Task<JobConfig> FindById(string id);

        Task Add(JobConfig jobConfig);

        Task Remove(string Id);

        Task Update(JobConfig config);
    }
}
