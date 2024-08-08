namespace api.Models
{
    public class Transfers
    {
        public string Extrinsic { get; set; }
        public int BlockNumber { get; set; }
        public double Timestamp { get; set; } = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        public int Nonce { get; set; }
        public string Signature { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public double For { get; set; }
    }
}
