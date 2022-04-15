using System;
using System.Collections.Generic;

namespace Timesheets.Core
{
    /// <summary>
    /// Сотрудник
    /// </summary>
    public class Employee 
    {
        private Guid Id { get; set; }               // идентификатор сотрудника
        private string Name { get; set; }           // имя и фамилия сотрудника
        private string Position { get; set; }       // должность сотрудника
        private int Salary { get; set; }            // ставка сотрудника (денег за час работы)
        private bool IsDeleted { get; set; } = false; // удален сотрудник из базы или нет

        private List<Sheets> Sheets { get; set; }   // список работ выполненных сотрудником
    }
}