namespace _01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private IStream streams;

        public StreamProgressInfo(IStream streams)
        {
            this.streams = streams;
        }

        public int CalculateCurrentPercent()
        {
            return (this.streams.BytesSent * 100) / this.streams.Length;
        }
    }
}