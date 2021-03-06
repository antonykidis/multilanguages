﻿using NUnit.Framework;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace AKSoftware.Localization.MultiLanguages.Tests
{
    public class LanguagesContainerInAssemblyTests
    {
        ILanguageContainerService _service;

        [SetUp]
        public void Setup()
        {
            _service = new LanguageContainerInAssembly(Assembly.GetExecutingAssembly(), CultureInfo.GetCultureInfo("ca-ES"), "Resources");

        }

        [Test]
        public void Get_Value_By_Composite_Key()
        {
            string value = _service.Keys["HomePage:HelloWorld"];
            Assert.AreEqual(value, "Hola món");
        }

        [Test]
        public void Get_Value_By_Composite_Key_By_Index()
        {
            var value = _service["HomePage:HelloWorld"];
            Assert.AreEqual(value, "Hola món");
        }

        [Test]
        public void Get_Value_By_Key_By_Index()
        {
            var value = _service["MerryChristmas"];
            Assert.AreEqual(value, "Feliz Navidad!");
        }

    }
}
