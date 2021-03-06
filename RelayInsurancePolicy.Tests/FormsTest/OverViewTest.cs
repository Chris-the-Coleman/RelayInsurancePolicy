﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace RelayInsurancePolicy.Tests.FormsTest
{
    [TestClass]
    public class OverViewTest
    {
        private OverView overView;
        private  TextBox text = new TextBox();

        [TestInitialize]
       public void TestInialize()
        {
            Policy.addDriver("", "", default(DateTime), 0);
            overView = new OverView();
            Assert.AreNotEqual(overView, null);
        }
        [TestMethod]
        public void visibleTest()
        {
            
            Button button1 = new Button();
            Button button2 = new Button();

            text.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            overView.Visibilty(text, button1, button2);
            
             Assert.AreEqual(text.Visible, true);
             Assert.AreEqual(button1.Text, "Amend");
             Assert.AreEqual(button2.Visible, true);

        }
        [TestMethod]
        public void invisibleTest()
        {
            
            Button button1 = new Button();
            Button button2 = new Button();

            text.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            overView.Invisibilty(text, button1, button2);

            Assert.AreEqual(text.Visible, false);
            Assert.AreEqual(button1.Text, "Add Driver");
            Assert.AreEqual(button2.Visible, false);
        }
        [TestMethod]

        public void DriversUpdateClearTest()
        {
          
            Policy.addDriver("", "", default(DateTime), 0);
            text.AppendText("Result");
            String result = "Result";
            overView.DriversUpdate(text,0,true,false);
            Assert.AreEqual(text.Text.Contains(result), false);

        }
        [TestMethod]
        public void DriversUpdateDeleteTest()
        {
            
            Policy.addDriver("", "", default(DateTime), 0);
            //two drivers are needed to test one is added at initialization
            overView.DriversUpdate(text, 0, true, true);
             
            Assert.AreEqual(Policy.drivers.Count, 1);

        }
        [TestMethod]
        public void DriversUpdateUpdateTextTest()
        {
            TextBox text = new TextBox();
            Policy.addDriver("Bob", "", default(DateTime), 0);
            //two drivers are needed to test one is added at initialization
           
            overView.DriversUpdate(text, 0, true, true);
            Assert.AreEqual(text.Text.Contains("Bob"), true);

        }

    }
}
