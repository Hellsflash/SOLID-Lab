public interface IStream
{
    int Length { get; }

    int BytesSent { get; }
}