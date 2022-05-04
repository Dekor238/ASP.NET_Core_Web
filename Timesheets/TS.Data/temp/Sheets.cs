using System;
using TS.Data.Model;

namespace TS.Data.temp
{
    /// <summary>
    /// Информация о затраченном времени сотрудника на работу
    /// </summary>
    public class Sheets : BaseEntity
    {
        public DateTime Date { get; set; }     // дата проведения работ
        public Guid EmployeeId { get; set; }   // идентификатор сотрудника, который выполнял работы
        public Guid ContractId { get; set; }   // идентификатор договора
        public Guid WorkTypeId { get; set; }   // идентификатор выполненной работы
        public int Amount { get; set; }        // количество затраченного времени на работу
        
        public Employee Employee { get; set; }      // сотрудник
        public Contracts Contracts { get; set; }    // договор
        public WorkType WorkType { get; set; }      // тип работ
        public Invoice Invoice { get; set; }        // счет
    }
}