using System;
using System.Collections.Generic;

namespace TS.Data.Model
{
    /// <summary>
    /// Предоставляемая услуга по договору
    /// </summary>
    public class WorkType : BaseEntity
    {
        public string Name { get; set; }           // название услуги
        
        public List<Sheets> Sheets { get; set; }   // список работ
    }
}