using System;
using System.Collections.Generic;

namespace Timesheets.Core
{
    /// <summary>
    /// Предоставляемая услуга по договору
    /// </summary>
    public class WorkType
    {
        private Guid Id { get; set; }               // идентификатор услуга
        private string Name { get; set; }           // название услуги
        
        private List<Sheets> Sheets { get; set; }   // список работ
    }
}