namespace Trestlebridge.Interfaces
{
    public interface IQuack
    {
        double FeedPerDay { get; set; }
        void Feed();
    }
}