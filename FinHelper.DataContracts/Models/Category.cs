using System.Collections.Generic;

namespace FinHelper.DataContracts
{
    /// <summary>
    /// Модель категория
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Идентификатор объекта в БД
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Название категории
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Группа
        /// </summary>
        public Group Group { get; set; }
        /// <summary>
        /// Операции по категории
        /// </summary>
        public ICollection<Operation> Operations { get; set; }

        public Category()
        {
            Operations = new List<Operation>();
        }
    }
}
