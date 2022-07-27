namespace NZWalks.Api.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public Guid RegionId { get; set; }
        public Guid WalkDifficultyId { get; set; }
        
        //Navigation Properties

        //connecting back to region
        public Region region { get; set; }

        //connecting to walkDifficulty
        public WalkDifficulty WalkDifficulty { get; set; } // this got [1:1] cardinality
    }
}
