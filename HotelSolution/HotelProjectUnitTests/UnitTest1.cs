using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelProject;
using System.IO;
using System.Data;
using System;

namespace HotelProjectUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1_CheckIfDataTableIsNull()
        {
            var mainForm = new MainForm();

            DataTable dataTable = mainForm.guestDataTable;
            mainForm.FillDataTable();

            Assert.IsNotNull(dataTable);
        }

        [TestMethod]
        public void Test2_CheckColumnNames()
        {
            var mainForm = new MainForm();

            DataTable dataTable = mainForm.guestDataTable;
            mainForm.FillDataTable();

            Assert.IsTrue(dataTable.Columns.Contains("Id"));
            Assert.IsTrue(dataTable.Columns.Contains("Name"));
            Assert.IsTrue(dataTable.Columns.Contains("BirthDay"));
            Assert.IsTrue(dataTable.Columns.Contains("HasAnimals"));
            Assert.IsTrue(dataTable.Columns.Contains("Status"));
            Assert.IsTrue(dataTable.Columns.Contains("RoomNumber"));
        }

        [TestMethod]
        public void Test3_CheckQuanityOfColumns()
        {
            var mainForm = new MainForm();

            DataTable dataTable = mainForm.guestDataTable;
            mainForm.FillDataTable();

            Assert.AreEqual(6, dataTable.Columns.Count);
        }

        [TestMethod]
        public void Test4_CheckClassConstructor()
        {
            var mainForm = new MainForm();

            var guest = new Guest(1, "Alex", new System.DateTime(2000, 10, 15), true, "выписывается", 102,
                "наличными", new System.DateTime(2020, 10, 15), new System.DateTime(2020, 10, 25));

            Assert.IsNotNull(guest);
        }

        [TestMethod]
        public void Test5_CheckClassConstructor()
        {
            var mainForm = new MainForm();

            var expectedTime = DateTime.Now.ToString("HH:mm:ss");
            mainForm.TickClockTimer(null, EventArgs.Empty);

            Assert.AreEqual(expectedTime, mainForm.clockLabel.Text);
        }
    }
}
