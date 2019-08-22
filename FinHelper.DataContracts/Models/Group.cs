using System.Collections.Generic;

namespace FinHelper.DataContracts
{
    /// <summary>
    /// Группа категорий
    /// </summary>
    public class Group
    {
        /// <summary>
        /// Идентификатор объекта в БД
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Название группы
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Категории в группе
        /// </summary>
        public virtual ICollection<Category> Categories { get; set; }
    }
}
