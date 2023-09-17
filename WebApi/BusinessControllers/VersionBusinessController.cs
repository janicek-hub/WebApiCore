namespace WebApi.BusinessControllers
{
    public static class VersionBusinessController
    {
        public static Guid InstanceId { get; set; }

        public static DateTimeOffset StartTime { get; set; }

        static VersionBusinessController()
        {
            InstanceId = Guid.NewGuid();
            StartTime = DateTimeOffset.Now;
        }
    }
}
