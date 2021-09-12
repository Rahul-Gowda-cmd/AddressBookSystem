using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddressBook_DataBase;
using System.Collections.Generic;
using System;

namespace AddressBook_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenQuery_WhenRetrieve_ShouldReturnNumberOfRowsRetrieved()
        {
            int expectedResult = 6;
            AddressBookDatabases database = new AddressBookDatabases();
            int result = database.GetPersonDetailsfromDatabase();
            Assert.AreEqual(expectedResult, result);
        }



        [TestMethod]
        public void GivenQuery_whenUpdate_ShouldUpdateContactInDB()
        {
            bool expectedResult = true;
            AddressBookDatabases database = new AddressBookDatabases();
            AddressBookModel model = new AddressBookModel()
            {
                firstname = "Naveen",
                lastname = "K",
                phone = "1234567893",
                email = "Naveen@gmail.com",
                zip = 1,
            };
            bool result = database.UpdateContact(model);
            Assert.AreEqual(expectedResult, result);
        }


        [TestMethod]
        public void GivenDate_ShouldReturnRecordsInAParticularPeriod()
        {
            bool expectedResult = true;
            AddressBookDatabases database = new AddressBookDatabases();
            bool result = database.RetriveContactInParticularPeriod();
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void GivenQuery_WhenRetrieveByCityOrState_ShouldRetrievContactAndReturnNoOfCounts()
        {
            int expectedResult = 3;
            AddressBookDatabases database = new AddressBookDatabases();
            AddressBookModel model = new AddressBookModel()
            {
                state = "Assam"
            };
            int result = database.RetriveContactByCityOrState(model);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void GivenQuery_WhenInsert_ShouldAddNewContactToDB()
        {

            AddressBookDatabases database = new AddressBookDatabases();
            List<AddressBookDetail> model = new List<AddressBookDetail>();

            model.Add(new AddressBookDetail(firstname: "Rahul", lastname: "m", phone: "8624345545", email: "Rahul@gmail.com", city: "Dibrugarh", book_id: 2, person_id: 6, zip: 3, date_added: new DateTime(2019, 04, 09)));
            model.Add(new AddressBookDetail(firstname: "Ravi", lastname: "Vinod", phone: "8890345545", email: "Ravi@gmail.com", city: "Tsk", book_id: 1, person_id: 7, zip: 3, date_added: new DateTime(2020, 02, 09)));
            model.Add(new AddressBookDetail(firstname: "Rakesh", lastname: "sharma", phone: "8452245545", email: "raksesh@gmail.com", city: "Jorhat", book_id: 2, person_id: 8, zip: 3, date_added: new DateTime(2017, 06, 09)));
            model.Add(new AddressBookDetail(firstname: "Raghu", lastname: "Choudri", phone: "899945545", email: "Raghu@gmail.com", city: "Sibsagor", book_id: 1, person_id: 9, zip: 3, date_added: new DateTime(2016, 07, 09)));
            model.Add(new AddressBookDetail(firstname: "Raaj", lastname: "mane", phone: "864533545", email: "Raaj@gmail.com", city: "Ghy", book_id: 2, person_id: 10, zip: 3, date_added: new DateTime(2018, 08, 09)));


            // Assert.AreEqual(result,true);

            DateTime startDateTime = DateTime.Now;
            database.AddNewContactWithoutThread(model);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without thread: " + (stopDateTime - startDateTime));


            DateTime startDateTimeThread = DateTime.Now;
            database.AddNewContactWithThread(model);
            DateTime stopDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration with thread: " + (stopDateTimeThread - startDateTimeThread));
            //Assert.AreEqual(result, 5);
        }
    }
}
