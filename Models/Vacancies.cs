using System.ComponentModel.DataAnnotations;

namespace StarSecurityServices.Models
{
    public class Vacancies
    {
        [Key]
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string EmpAdd { get; set; }
        public string EmpCon { get; set; }
        public string EmpEdu { get; set; }
        public string Depart { get; set; }
        public string Role { get; set; }
        public string Grade { get; set; }
    }
}
