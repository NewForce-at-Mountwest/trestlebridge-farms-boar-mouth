namespace Trestlebridge.Interfaces
{
    public interface IPlowed
    {
        double GrassPerDay { get; set; }
        void Plow();
    }
}