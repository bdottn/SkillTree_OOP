using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BMICalculator
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CalculatorTest_男性_一米九_六十公斤_預期回傳太瘦()
        {
            var person =
                new Person()
                {
                    Gender = Gender.Man,
                    Height = 1.9,
                    Weight = 60,
                };

            var calculator = CalculatorFactory.GetCalculator(person);

            var expeted = "太瘦";

            var actual = calculator.Calculator();

            Assert.AreEqual(expeted, actual);
        }

        [TestMethod]
        public void CalculatorTest_男性_一米五_六十公斤_預期回傳太胖()
        {
            var person =
                new Person()
                {
                    Gender = Gender.Man,
                    Height = 1.5,
                    Weight = 60,
                };

            var calculator = CalculatorFactory.GetCalculator(person);

            var expeted = "太胖";

            var actual = calculator.Calculator();

            Assert.AreEqual(expeted, actual);
        }

        [TestMethod]
        public void CalculatorTest_男性_一米七_六十公斤_預期回傳適中()
        {
            var person =
                new Person()
                {
                    Gender = Gender.Man,
                    Height = 1.7,
                    Weight = 60,
                };

            var calculator = CalculatorFactory.GetCalculator(person);

            var expeted = "適中";

            var actual = calculator.Calculator();

            Assert.AreEqual(expeted, actual);
        }

        [TestMethod]
        public void CalculatorTest_女性_一米七_五十公斤_預期回傳太瘦()
        {
            var person =
                new Person()
                {
                    Gender = Gender.Woman,
                    Height = 1.7,
                    Weight = 50,
                };

            var calculator = CalculatorFactory.GetCalculator(person);

            var expeted = "太瘦";

            var actual = calculator.Calculator();

            Assert.AreEqual(expeted, actual);
        }

        [TestMethod]
        public void CalculatorTest_女性_一米五_五十公斤_預期回傳太胖()
        {
            var person =
                new Person()
                {
                    Gender = Gender.Woman,
                    Height = 1.5,
                    Weight = 50,
                };

            var calculator = CalculatorFactory.GetCalculator(person);

            var expeted = "太胖";

            var actual = calculator.Calculator();

            Assert.AreEqual(expeted, actual);
        }

        [TestMethod]
        public void CalculatorTest_女性_一米七_六十公斤_預期回傳適中()
        {
            var person =
                new Person()
                {
                    Gender = Gender.Woman,
                    Height = 1.7,
                    Weight = 60,
                };

            var calculator = CalculatorFactory.GetCalculator(person);

            var expeted = "適中";

            var actual = calculator.Calculator();

            Assert.AreEqual(expeted, actual);
        }
    }
}