namespace _1235
{
    public class AnnuityPayoutInstruction
    {
        public int Id { get; set; }

        public string AnnuityPurchasedFrom { get; set; }
        public string PaymentFrequency { get; set; }
        public string PaymentStartDate { get; set; }
        public double PaymentAmount { get; set; }
    }
}