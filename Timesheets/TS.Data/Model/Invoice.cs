using System;
using System.Collections.Generic;

namespace TS.Data.Model
{
    /// <summary>
    /// Счет клиенту
    /// </summary>
    public class Invoice : BaseEntity
    {
        public Guid ContractId { get; set; }       // идентификатор договора
        public DateTime StartDate { get; set; }    // дата начала выставления счета
        public DateTime StopDate { get; set; }     // дата окончания выставления счета
        public int Sum { get; set; }               // сумма для оплаты

        public List<Sheets> Sheets { get; set; }   // список выполненных работ по договору
        public Contracts Contracts { get; set; }    // Договор
    }
}