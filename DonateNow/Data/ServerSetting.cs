using System.ComponentModel.DataAnnotations;

namespace DonateNow.Data
{
    public class ServerSetting
    {
        [Key]
        public string Id { get; set; }
        public string Value { get; set; }
    }
}