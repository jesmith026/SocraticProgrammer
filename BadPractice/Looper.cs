namespace BadPractice
{
    public class Looper
    {
        private readonly Logger _logger;
        public Looper()
        {
            _logger = new Logger(LogType.Console);
        }

        public void Loop()
        {
            for (var i = 0; i < 10; i++)
            {
                _logger.Write(i.ToString());
            }
        }
    }
}
