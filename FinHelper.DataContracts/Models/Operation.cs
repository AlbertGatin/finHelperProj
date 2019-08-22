using System;

namespace FinHelper.DataContracts
{
    /// <summary>
    /// Операция
    /// </summary>
    public class Operation
    {
        /// <summary>
        /// Идентификатор объекта в БД
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Категория отправителя
        /// </summary>
        public virtual Category CategoryFrom { get; set; }
        /// <summary>
        /// Категория получателя
        /// </summary>
        public virtual Category CategoryTo { get; set; }
        /// <summary>
        /// Сумма
        /// </summary>
        public decimal Sum { get; set; }
        /// <summary>
        /// Дата провередия операции
        /// </summary>
        public DateTime Date { get; set; }
    }
}
