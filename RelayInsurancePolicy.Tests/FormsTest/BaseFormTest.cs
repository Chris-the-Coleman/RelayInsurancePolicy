﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RelayInsurancePolicy.Tests.FormsTest
{
    [TestClass]
    public class BaseFormTest
    {
        private BaseForm baseForm;
        [TestInitialize]
        public void TestInitialize()
        {
            baseForm = new BaseForm();
           
            Assert.AreNotEqual(baseForm, null);
        }

        
      
    }
}
