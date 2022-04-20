using System;
using System.Collections.Generic;

namespace TS.Data.Model
{
    /// <summary>
    /// Сотрудник
    /// </summary>
    public class Employee : BaseEntity
    {
        public string Name { get; set; }           // имя и фамилия сотрудника
        public string Position { get; set; }       // должность сотрудника
        public int Salary { get; set; }            // ставка сотрудника (денег за час работы)

        //public List<Sheets> Sheets { get; set; }   // список работ выполненных сотрудником
    }
}