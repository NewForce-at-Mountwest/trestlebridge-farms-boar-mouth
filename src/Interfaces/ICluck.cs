namespace Trestlebridge.Interfaces
{
    public interface ICluck
    {
        double FeedPerDay { get; set; }
        void Feed();
    }
}