using System;

namespace PayrollProcessor.Core.Domain.Features.Employees
{
    public class EmployeePayrollNew
    {
        public DateTimeOffset CheckDate { get; set; }
        public decimal GrossPayroll { get; set; }
        public string PayrollPeriod { get; set; } = "";
    }
}
