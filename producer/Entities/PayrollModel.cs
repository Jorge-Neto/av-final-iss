namespace App.Entities
{
    public class PayrollModel
    {
        public int id { get; set; }
        public int mes { get; set; }
        public int ano { get; set; }
        public int horas { get; set; }
        public int valor { get; set; }
        public EmployeeModel? funcionario { get; set; }
    }

    public class EmployeeModel
    {
        public string? nome { get; set; }
        public string? cpf { get; set; }
    }
}
