using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using String2NumberConverter;

namespace String2NumberConverterTest
{
    [TestClass]
    public class ConvertTest
    {
        [TestMethod]
        public void StressTest10K()
        {
            var errors = new List<dynamic>();
            var randomer = new System.Random();
            
            for (var i = 0; i < 10000; i++)
            {
                
                var n1 = randomer.Next(-10000000, 1000000000);
                var n2 = System.Convert.ToDecimal(randomer.NextDouble());
                var n3 = System.Convert.ToDecimal(randomer.NextDouble() * -1);

                var str1 = new Converter($"{n1}").Calc();
                var str2 = new Converter($"{n2}").Calc();
                var str3 = new Converter($"{n3}").Calc();
                Assert.AreEqual(n1, str1);
                Assert.AreEqual(n2, str2);
                Assert.AreEqual(n3, str3);
            }
            Console.WriteLine($"errors: {errors.Count}");
        }
    }
}