using System;

namespace TestWebApp.Domain.Model
{
    class IdInformation
    {
        public int IdentityNumber { get; set; }
        public int SerialNumber { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string FatherName { get; set; }
        public string MatherName { get; set; }
        public string BirthPlace { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
