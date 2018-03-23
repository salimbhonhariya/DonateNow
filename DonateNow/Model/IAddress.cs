namespace DonateNow.Model
{
    public interface IAddress
    {
        int AddressId { get; set; }
        int StreetNumber { get; set; }
        string Address1 { get; set; }
        string Address2 { get; set; }
        string City { get; set; }
        int ZipCode { get; set; }
        string Country { get; set; }
    }
}