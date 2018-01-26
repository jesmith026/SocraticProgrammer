using SOLIDExamples.Loggers;

namespace SOLIDExamples
{
    public class GoodLogger
    {
        public void Log(IGoodLogger logger, string msg)
        {
            logger.Log(msg);
        }
    }
}
