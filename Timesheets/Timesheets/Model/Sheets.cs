using System;

namespace Timesheets.Core
{
    /// <summary>
    /// Информация о затраченном времени сотрудника на работу
    /// </summary>
    public class Sheets
    {
        private Guid Id { get; set; }           // идентификатор записи
        private DateTime Date { get; set; }     // дата проведения работ
        private Guid EmployeeId { get; set; }   // идентификатор сотрудника, который выполнял работы
        private Guid ContractId { get; set; }   // идентификатор договора
        private Guid WorkTypeId { get; set; }   // идентификатор выполненной работы
        private int Amount { get; set; }        // количество затраченного времени на работу
        
        public Employee Employee { get; set; }      // сотрудник
        public Contracts Contracts { get; set; }    // договор
        public WorkType WorkType { get; set; }      // тип работ
        public Invoice Invoice { get; set; }        // счет
    }
}