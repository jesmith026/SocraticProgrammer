using SOLIDExamples.Loggers;

namespace SOLIDExamples
{
    public class BadLoggerTester
    {
        /*
         * notice that the logger is responsible for figuring out how to log
         * the message based on the enum passed into the method. This breaks
         * the Single Responsibility Principle because it is logging the
         * message AND figuring out how the message should be logged. This
         * also breaks the Open/Closed Principle because if we need to add a
         * new logging type we have to edit the BadLogger class to account for it.
         */
        public static void Test()
        {
            var badLogger = new BadLogger();
            badLogger.Log(LogType.File, "Test");
            badLogger.Log(LogType.Db, "Test");
            badLogger.Log(LogType.EventViewer, "Test");
            badLogger.Log(LogType.Console, "Test");
        }
    }
}
