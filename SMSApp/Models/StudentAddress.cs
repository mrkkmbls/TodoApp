using Microsoft.JSInterop;

namespace SMSApp.Models
{
    public class StudentAddress
    {

        public int studentAddressId { get; set; }
        public string compound {set; get; }

        public string door { set; get; }

        public string street { set; get; }

        public string city { set; get; }

        public StudentAddress() { }

        public StudentAddress(string compound, string door, string street, string city)
        {
            this.compound = compound;
            this.door = door;
            this.street = street;
            this.city = city;
        }
    }


}
