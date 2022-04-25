using System;

namespace TS.Data.temp
{
    public class BaseEntity
    {
        public Guid Id { get; set; }                // уникальный идентификатор
        public bool IsDeleted { get; set; }         // идентификатор удаления. по умолчанию - не удалено
    }
}