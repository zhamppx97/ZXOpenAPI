namespace api.Models
{
    public class Blocks
    {
        public int BlockNumber { get; set; }
        public double Timestamp { get; set; } = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        public string Status { get; set; }
        public string Validator { get; set; }
    }
}
