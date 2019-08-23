using FinHelper.BL.Models;
using FinHelper.DataContracts;
using System.Collections.Generic;
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

        /// <summary>
        /// Получение группы
        /// </summary>
        /// <param name="model">группа</param>
        public List<Group> GetGroups()
        {
            var modelsEntity = db.Groups.ToArray();
            List<Group> models = new List<Group>();
            foreach (var g in modelsEntity)
            {
                models.Add(g.FromEntity());
            }

            return models;
        }

        /// <summary>
        /// Удаление группы
        /// </summary>
        /// <param name="model">группа</param>
        public void DeleteGroup(Group model)
        {
            var deleteModel = (from g in db.Groups
                               where g.Id == model.Id
                               select g).FirstOrDefault();


            if (deleteModel != null)
            {
                db.Remove(deleteModel);
                db.SaveChanges();
            }
        }

        #endregion Group

        #region Category

        /// <summary>
        /// Создать новую категорию
        /// </summary>
        /// <param name="model">группа</param>
        public void CreateCategory(Category model)
        {
            db.Categories.Add(new CategoryEntity(model));
        }

        /// <summary>
        /// Изменение категории
        /// </summary>
        /// <param name="model">группа</param>
        public void ChangeCategory(Category model)
        {
            var changeModel = (from g in db.Categories
                               where g.Id == model.Id
                               select g).FirstOrDefault();

            if (changeModel != null)
            {
                changeModel = new CategoryEntity(model);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Получение категории
        /// </summary>
        /// <param name="model">группа</param>
        public List<Category> GetCategories()
        {
            var modelsEntity = db.Categories.ToArray();
            List<Category> models = new List<Category>();
            foreach (var g in modelsEntity)
            {
                models.Add(g.FromEntity());
            }

            return models;
        }

        /// <summary>
        /// Удаление категори
        /// </summary>
        /// <param name="model">группа</param>
        public void DeleteCategory(Category model)
        {
            var deleteModel = (from g in db.Categories
                               where g.Id == model.Id
                               select g).FirstOrDefault();


            if (deleteModel != null)
            {
                db.Remove(deleteModel);
                db.SaveChanges();
            }
        }

        #endregion Category

        #region Oparation

        /// <summary>
        /// Создать новую операцию
        /// </summary>
        /// <param name="model">группа</param>
        public void CreateOperation(Operation model)
        {
            db.Operations.Add(new OperationEntity(model));
        }

        /// <summary>
        /// Изменение операции
        /// </summary>
        /// <param name="model">группа</param>
        public void ChangeOperation(Operation model)
        {
            var changeModel = (from g in db.Operations
                               where g.Id == model.Id
                               select g).FirstOrDefault();

            if (changeModel != null)
            {
                changeModel = new OperationEntity(model);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Получение операции
        /// </summary>
        /// <param name="model">группа</param>
        public List<Operation> GetOperations()
        {
            var modelsEntity = db.Operations.ToArray();
            List<Operation> models = new List<Operation>();
            foreach (var g in modelsEntity)
            {
                models.Add(g.FromEntity());
            }

            return models;
        }

        /// <summary>
        /// Удаление операции
        /// </summary>
        /// <param name="model">группа</param>
        public void DeleteOperation(Operation model)
        {
            var deleteModel = (from g in db.Operations
                               where g.Id == model.Id
                               select g).FirstOrDefault();


            if (deleteModel != null)
            {
                db.Remove(deleteModel);
                db.SaveChanges();
            }
        }

        #endregion Oparation
    }
}
