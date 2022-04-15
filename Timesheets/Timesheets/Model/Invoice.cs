using System;
using System.Collections.Generic;

namespace Timesheets.Core
{
    /// <summary>
    /// Счет клиенту
    /// </summary>
    public class Invoice
    {
        private Guid Id { get; set; }               // идентификатор счета
        private Guid ContractId { get; set; }       // идентификатор договора
        private DateTime StartDate { get; set; }    // дата начала выставления счета
        private DateTime StopDate { get; set; }     // дата окончания выставления счета
        private int Sum { get; set; }               // сумма для оплаты

        private List<Sheets> Sheets { get; set; }   // список выполненных работ по договору
        public Contracts Contracts { get; set; }    // Договор
    }
}