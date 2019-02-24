using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void castdate()
        {
            string date = "28AUG2016";
            DateTime dateTime;

            if (DateTime.TryParse(date, out dateTime))
            {
                Console.WriteLine(dateTime);
            }
            else
            {
                Console.WriteLine("unable to parse");
            }

        }
    }
}
