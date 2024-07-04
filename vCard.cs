using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Burada propertyleri qeyd edirik ve en esasi ToString metodu vasitesi ile melumatlari VCard formatina saliriq ve ciktisi da boyle olucak:
/*
BEGIN: VCARD
VERSION:3.0
FN: FirstName Surname
EMAIL: Email
TEL:Phone
ADR; TYPE = home:Country; City
END:VCARD
*/

namespace vCard
{
    public class VCard
    {
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"BEGIN:VCARD\nVERSION:3.0\nFN:{Firstname} {Surname}\nEMAIL:{Email}\nTEL:{Phone}\nADR;TYPE=home:{Country};{City}\nEND:VCARD";
        }
    }

}
