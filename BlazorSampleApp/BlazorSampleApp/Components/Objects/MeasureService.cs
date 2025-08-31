namespace BlazorSampleApp.Components.Objects
{
    public static class MeasureService
    {
        private static readonly Random _random = new Random();

        public static MeasureResult Measure()
        {
            return new MeasureResult
            {
                Value = _random.NextDouble(),
                Date = DateTime.Now
            };
        }

    }

    public class MeasureResult
    {
        public double Value { get; set; }
        public DateTime Date { get; set; }
    }
}
