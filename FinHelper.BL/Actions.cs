using FinHelper.BL.Models;
using FinHelper.DataContracts;
using System.Linq;

namespace FinHelper.BL
{
    /// <summary>
    /// Действия
    /// </summary>
    public class Actions
    {
        /// <summary>
        /// Контекст базы данных
        /// </summary>
        private FinHelperContext db { get; set; }

        /// <summary>
        /// Новый объект действий
        /// </summary>
        public Actions(FinHelperContext context)
        {
            db = context;
        }

        #region Group

        /// <summary>
        /// Создать новую группу
        /// </summary>
        /// <param name="model">группа</param>
        public void CreateGroup(Group model)
        {
            db.Groups.Add(new GroupEntity(model));
        }

        /// <summary>
        /// Изменение группы
        /// </summary>
        /// <param name="model">группа</param>
        public void ChangeGroup(Group model)
        {
            var changeModel = (from g in db.Groups
                               where g.Id == model.Id
                               select g).FirstOrDefault();

            if (changeModel != null)
            {
                changeModel = new GroupEntity(model);
                db.SaveChanges();
            }
        }

        #endregion Group

        #region Category

        /// <summary>
        /// Создать новую категорию
        /// </summary>
        /// <param name="category">категория</param>
        public void CreateCategory(Category category)
        {
            db.Categories.Add(new CategoryEntity(category));
        }

        //public void ChangeGroup(Group model)
        //{
        //    var changeModel = (from g in db.Groups
        //                       where g.Id == model.Id
        //                       select g).FirstOrDefault();

        //    if (changeModel != null)
        //    {
        //        changeModel = new GroupEntity(model);
        //        db.SaveChanges();
        //    }
        //}

        #endregion Category

        #region Oparation

        /// <summary>
        /// Создать новую операцию
        /// </summary>
        /// <param name="operation">операция</param>
        public void CreateOperation(Operation operation)
        {
            db.Operations.Add(new OperationEntity(operation));

        }

        #endregion Oparation
    }
}
