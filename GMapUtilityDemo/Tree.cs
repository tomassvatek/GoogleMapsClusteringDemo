namespace GMapUtilityDemo
{
    public class Tree
    {
        public Tree(string name, double lat, double lon, string description)
        {
            Name = name;
            Lat = lat;
            Lon = lon;
            Description = description;
        }

        public string Name { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Description { get; set; }
    }
}