namespace MedicalPrescriptionManagementSystem.Server.Models
{
    public class DoctorRegisterModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
    }
}
