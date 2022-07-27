namespace NZWalks.Api.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public long Population { get; set; }

        //Navigation Property
        public IEnumerable<Walk> Walks { get; set; } //basically telling entity framework that
                                                     // one region can have multiple walks in it
                                                     // Building a [1 : Many] cardinality
    }
}
