namespace SalesWebMvc.Models {
    public class Seller {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SallesRecord> Sales { get; set; } = new List<SallesRecord>();

        public Seller() {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department) {
            Id = id;
            this.Name = name;
            this.Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void addSales(SallesRecord sr) {
            Sales.Add(sr);
        }

        public void RemoveSales(SallesRecord sr) {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final) {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}