namespace Trestlebridge.Interfaces
{
    public interface IGrazing
    {
        double GrassPerDay { get; set; }
        void Graze();
//pulls the animal types to use for the count
        string Type{ get; }
    }
}