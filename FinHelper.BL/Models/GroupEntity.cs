using FinHelper.DataContracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinHelper.BL.Models
{
    /// <summary>
    /// Группа категорий
    /// </summary>
    [Table("Group")]
    public class GroupEntity
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
        public virtual ICollection<CategoryEntity> Categories { get; set; }

        /// <summary>
        /// Новая категория
        /// </summary>
        public GroupEntity()
        {
            Categories = new List<CategoryEntity>();
        }

        /// <summary>
        /// Новая модель бд из объекта
        /// </summary>
        public GroupEntity(Group model)
        {
            Id = model.Id;
            Name = model.Name;
            Categories = new List<CategoryEntity>();

            foreach (var i in model.Categories)
                Categories.Add(new CategoryEntity(i));
        }

        /// <summary>
        /// Из модели БД в объект
        /// </summary>
        /// <returns>Объект</returns>
        public Group FromEntity()
        {
            var model = new Group()
            {
                Id = Id,
                Name = Name,
                Categories = new List<Category>()
            };

            foreach (var i in Categories)
                model.Categories.Add(i.FromEntity());

            return model;
        }
    }
}
