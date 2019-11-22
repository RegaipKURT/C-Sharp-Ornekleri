namespace ADONetExample.Business
{
    public class Shipper
    {
        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }

        public Shipper()
        {

        }

        public Shipper(int ShipperId, string CompanyName, string PhoneNumber) 
        {
            this.CompanyName = CompanyName;
            this.ShipperId = ShipperId;
            this.PhoneNumber = PhoneNumber;
        }
    }
}
