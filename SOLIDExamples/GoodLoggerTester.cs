using SOLIDExamples.Loggers;

namespace SOLIDExamples
{
    public class GoodLoggerTester
    {
        /*
         * Notice that the way the message is being logged is completely
         * separate from the actual logging. This follows the Single
         * Responsibility Principle by ensuring that each class is doing
         * exactly 1 thing. This also follows the Open/Closed Principle
         * because if we want to extend the functionality by creating a
         * new logtype such as logging to HTML then we would create a new
         * class which inherits from IGoodLogger and it would just plug
         * into the existing solution.
         */
        public static void Test()
        {
            var fileLogTester = new FileLogger();
            var dbLogTester = new DbLogger();
            var eventViewerLogTester = new EventViewerLogger();
            var consoleLogTester = new ConsoleLogger();

            var goodLogger = new GoodLogger();
            goodLogger.Log(fileLogTester, "Test");
            goodLogger.Log(dbLogTester, "Test");
            goodLogger.Log(eventViewerLogTester, "Test");
            goodLogger.Log(consoleLogTester, "Test");
        }
    }
}
