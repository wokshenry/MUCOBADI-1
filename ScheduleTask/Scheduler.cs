using MUCOBADI.Repository.TrackingTools;
using Quartz;
using System.Threading.Tasks;

namespace MUCOBADI.ScheduleTask
{
    public class Scheduler : IJob
    {
        ViralloadTrackerModel viralloadTrackerModel = new ViralloadTrackerModel();
        public Task Execute(IJobExecutionContext context)
        {
            var task = Task.Run(() => viralloadTrackerModel.ForwardValidViralload()); 
            return task;
        }
    }
}
