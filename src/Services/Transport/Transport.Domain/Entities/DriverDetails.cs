namespace Transport.Domain.Entities
{
    public class DriverDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmployeeNo { get; set; }
        public string DriverNID { get; set; }
        public string LicenseNo { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string ContractNumber { get; set; }
        public decimal MonthlySalary { get; set; }
        public decimal PerDaySalary { get; set; }
        public bool IsActive { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
    }
}


