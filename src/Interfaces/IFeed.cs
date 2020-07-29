namespace Trestlebridge.Interfaces
{
    //DIFFERENT INTERFACE FOR DUCKS TO PREVENT DUCKS FROM GETTING INTO THE CHICKEN HOUSE LATER
    public interface IFeed
    {
        double FeedPerDay { get; set; }
        void Feed();
    }
}