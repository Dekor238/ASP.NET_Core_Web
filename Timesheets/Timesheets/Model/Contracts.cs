using System;
using System.Collections.Generic;

namespace Timesheets.Core
{
    /// <summary>
    /// Договор
    /// </summary>
    public class Contracts
    {   
        private Guid Id { get; set; }                   // номер договора
        private string Title { get; set; }              // название договора
        private string Description { get; set; }        // описание договора
        private DateTime DateStart { get; set; }        // дата начала договора
        private DateTime DateEnd { get; set; }          // дата окончания договора
        
        private List<Sheets> Sheets { get; set; }       // список работ по договору
    }
}