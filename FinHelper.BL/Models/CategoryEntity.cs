using FinHelper.DataContracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinHelper.BL.Models
{
    /// <summary>
    /// Модель категория
    /// </summary>
    [Table("Category")]
    public class CategoryEntity 
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
        /// Идентификатор группы
        /// </summary>
        public int GroupId { get; set; }
        /// <summary>
        /// Группа
        /// </summary>
        public virtual GroupEntity Group { get; set; }
        /// <summary>
        /// Операции по категории
        /// </summary>
        public virtual ICollection<OperationEntity> Operations { get; set; }
        /// <summary>
        /// Новая категория
        /// </summary>
        public CategoryEntity()
        {
            Operations = new List<OperationEntity>();
        }
        /// <summary>
        /// Новая модель бд из объекта
        /// </summary>
        public CategoryEntity(Category model)
        {
            Id = model.Id;
            Name = model.Name;
            GroupId = model.Group.Id;
            Group = new GroupEntity(model.Group);
            Operations = new List<OperationEntity>();

            foreach (var i in model.Operations)
                Operations.Add(new OperationEntity(i));
        }

        /// <summary>
        /// Из модели БД в объект
        /// </summary>
        /// <returns>Объект</returns>
        public Category FromEntity()
        {
            Category model =  new Category()
            {
                Id = Id,
                Name = Name,
                Group = Group.FromEntity(),
                Operations = new List<Operation>()
            };

            foreach (var i in Operations)
                model.Operations.Add(i.FromEntity());

            return model;
        }
    }
}
