using Quartz;
using Quartz.Impl;
using System;

namespace MUCOBADI.ScheduleTask
{
    public class SchedulerTask
    {
        private static readonly string ScheduleCronExpression = "0	0	0	?	*	FRI	*";
        //private static readonly string ScheduleCronExpression = "0 * * * * ?";
        public static async System.Threading.Tasks.Task StartAsync()
        {
            try
            {
                var scheduler = await StdSchedulerFactory.GetDefaultScheduler();
                if (!scheduler.IsStarted)
                {
                    await scheduler.Start();
                }

                // define the job and tie it to our HelloJob class
                IJobDetail job = JobBuilder.Create<Scheduler>()
                    .WithIdentity("job1", "group1")
                    .Build();

                // Trigger the job to run now, and then repeat every 10 seconds
                ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity("trigger1", "group1")
                    .StartNow()
                    .WithSimpleSchedule(x => x
                        .RepeatForever())
                    .WithCronSchedule(ScheduleCronExpression)
                    .Build();

                // Tell Quartz to schedule the job using our trigger
                await scheduler.ScheduleJob(job, trigger);
            }
            catch (Exception ex)
            {
            
            }
        }
    }
}
