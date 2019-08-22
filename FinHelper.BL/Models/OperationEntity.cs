using FinHelper.DataContracts;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinHelper.BL.Models
{
    /// <summary>
    /// Операция
    /// </summary>
    [Table("Operation")]
    public class OperationEntity
    {
        /// <summary>
        /// Идентификатор объекта в БД
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Идентификатор категории отправителя
        /// </summary>
        public int? CategoryFromId { get; set; }
        /// <summary>
        /// Категория отправителя
        /// </summary>
        public virtual CategoryEntity CategoryFrom { get; set; }
        /// <summary>
        /// Идентификатор категории получателя
        /// </summary>
        public int? CategoryToId { get; set; }
        /// <summary>
        /// Категория получателя
        /// </summary>
        public virtual CategoryEntity CategoryTo { get; set; }
        /// <summary>
        /// Сумма
        /// </summary>
        [Column(TypeName = "decimal(15, 2)")]
        public decimal Sum { get; set; }
        /// <summary>
        /// Дата провередия операции
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Новая категория
        /// </summary>
        public OperationEntity()
        {
        }

        /// <summary>
        /// Новая модель бд из объекта
        /// </summary>
        public OperationEntity(Operation model)
        {
            Id = model.Id;
            Sum = model.Sum;
            Date = model.Date;
            CategoryFromId = model.CategoryFrom.Id;
            CategoryToId = model.CategoryTo.Id;
            CategoryFrom = new CategoryEntity(model.CategoryFrom);
            CategoryTo = new CategoryEntity(model.CategoryTo);         
        }

        /// <summary>
        /// Из модели БД в объект
        /// </summary>
        /// <returns>Объект</returns>
        public Operation FromEntity()
        {
            Operation model = new Operation()
            {
                Id = Id,
                Date = Date,
                Sum = Sum,
                CategoryFrom = CategoryFrom.FromEntity(),
                CategoryTo = CategoryTo.FromEntity()
            };

            return model;
        }
    }
}
