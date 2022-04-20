using System;
using System.Collections.Generic;

namespace TS.Data.Model
{
    /// <summary>
    /// Договор
    /// </summary>
    public class Contracts : BaseEntity
    {   
        public string Title { get; set; }              // название договора
        public string Description { get; set; }        // описание договора
        public DateTime DateStart { get; set; }        // дата начала договора
        public DateTime DateEnd { get; set; }          // дата окончания договора
        
        public List<Sheets> Sheets { get; set; }       // список работ по договору
    }
}