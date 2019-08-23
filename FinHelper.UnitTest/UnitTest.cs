using FinHelper.BL;
using FinHelper.BL.Models;
using FinHelper.DataContracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace FinHelper.UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestGroup()
        {
            FinHelperContext db = null;
            Actions a = new Actions(db);
            a.CreateGroup(new Group() { Name = "Такие расходы" });

            Group toChange = a.GetGroups().FirstOrDefault();
            toChange.Name = "Сякие расходы";
            a.ChangeGroup(toChange);

            a.DeleteGroup(toChange);
        }

        [TestMethod]
        public void TestCategory()
        {
            FinHelperContext db = null;

            Actions a = new Actions(db);
            a.CreateGroup(new Group() { Name = "Такие расходы" });
            Group toChangeGroup = a.GetGroups().FirstOrDefault();

            a.CreateCategory(new Category()
            {
                Name = "Пятерочка",
                Group = toChangeGroup
            });

            Category toChangeCategory = a.GetCategories().FirstOrDefault();
            toChangeCategory.Name = "Магнит";
            a.ChangeCategory(toChangeCategory);

            a.DeleteCategory(toChangeCategory);

            a.DeleteGroup(toChangeGroup);
        }

        [TestMethod]
        public void TestOperation()
        {
            FinHelperContext db = null;

            Actions a = new Actions(db);
            a.CreateGroup(new Group() { Name = "Такие расходы" });
            Group toChangeGroup = a.GetGroups().FirstOrDefault();

            a.CreateCategory(new Category()
            {
                Name = "Пятерочка",
                Group = toChangeGroup
            });

            Category toChangeCategory = a.GetCategories().FirstOrDefault();

            a.CreateOperation(new Operation()
            {
                CategoryTo = toChangeCategory,
                Sum = (decimal)15.13,
                Date = DateTime.Now
            });

            Operation toChangeOperation = a.GetOperations().FirstOrDefault();
            toChangeOperation.Date = DateTime.Now.AddDays(-1);
            a.ChangeOperation(toChangeOperation);

            a.DeleteOperation(toChangeOperation);
            a.DeleteCategory(toChangeCategory);
            a.DeleteGroup(toChangeGroup);
        }
    }
}
