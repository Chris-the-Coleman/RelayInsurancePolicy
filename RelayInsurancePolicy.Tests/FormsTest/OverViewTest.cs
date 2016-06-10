using System.Reflection;
using System.Windows.Forms;
// <copyright file="OverViewTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RelayInsurancePolicy;

namespace RelayInsurancePolicy.Tests
{
    [TestClass]
    [PexClass(typeof(OverView))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class OverViewTest
    {

        [PexMethod(MaxBranches = 320000)]
        public OverView Constructor()
        {
            OverView target = new OverView();
            return target;
            // TODO: add assertions to method OverViewTest.Constructor()
        }

        [PexMethod(MaxBranches = 320000)]
        [PexMethodUnderTest("visibility(TextBox, Button, Button)")]
        internal void visibility(
            [PexAssumeUnderTest]OverView target,
            TextBox text,
            Button one,
            Button two
        )
        {
            object[] args = new object[3];
            args[0] = (object)text;
            args[1] = (object)one;
            args[2] = (object)two;
            Type[] parameterTypes = new Type[3];
            parameterTypes[0] = typeof(TextBox);
            parameterTypes[1] = typeof(Button);
            parameterTypes[2] = typeof(Button);
            object result = ((MethodBase)(typeof(OverView).GetMethod("visibility",
                                                                     BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                     CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: add assertions to method OverViewTest.visibility(OverView, TextBox, Button, Button)
        }

        [PexMethod(MaxBranches = 320000)]
        [PexMethodUnderTest("invisibility(TextBox, Button, Button)")]
        internal void invisibility(
            [PexAssumeUnderTest]OverView target,
            TextBox text,
            Button one,
            Button two
        )
        {
            object[] args = new object[3];
            args[0] = (object)text;
            args[1] = (object)one;
            args[2] = (object)two;
            Type[] parameterTypes = new Type[3];
            parameterTypes[0] = typeof(TextBox);
            parameterTypes[1] = typeof(Button);
            parameterTypes[2] = typeof(Button);
            object result = ((MethodBase)(typeof(OverView).GetMethod("invisibility",
                                                                     BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                     CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: add assertions to method OverViewTest.invisibility(OverView, TextBox, Button, Button)
        }

        [PexMethod(MaxBranches = 320000)]
        [PexMethodUnderTest("DriversUpdate(TextBox, Int32, Boolean, Boolean)")]
        internal void DriversUpdate(
            [PexAssumeUnderTest]OverView target,
            TextBox text,
            int driverNumber,
            bool clear,
            bool delete
        )
        {
            object[] args = new object[4];
            args[0] = (object)text;
            args[1] = (object)driverNumber;
            args[2] = (object)clear;
            args[3] = (object)delete;
            Type[] parameterTypes = new Type[4];
            parameterTypes[0] = typeof(TextBox);
            parameterTypes[1] = typeof(int);
            parameterTypes[2] = typeof(bool);
            parameterTypes[3] = typeof(bool);
            object result = ((MethodBase)(typeof(OverView).GetMethod("DriversUpdate",
                                                                     BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                     CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: add assertions to method OverViewTest.DriversUpdate(OverView, TextBox, Int32, Boolean, Boolean)
        }

        [PexMethod(MaxBranches = 80000)]
        [PexMethodUnderTest("AmmendDriver(Int32)")]
        internal void AmmendDriver([PexAssumeUnderTest]OverView target, int driverNumber)
        {
            object[] args = new object[1];
            args[0] = (object)driverNumber;
            Type[] parameterTypes = new Type[1];
            parameterTypes[0] = typeof(int);
            object result = ((MethodBase)(typeof(OverView).GetMethod("AmmendDriver",
                                                                     BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                     CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: add assertions to method OverViewTest.AmmendDriver(OverView, Int32)
        }

        [PexMethod(MaxBranches = 320000)]
        [PexMethodUnderTest("button4_Click(Object, EventArgs)")]
        internal void button4_Click(
            [PexAssumeUnderTest]OverView target,
            object sender,
            EventArgs e
        )
        {
            object[] args = new object[2];
            args[0] = sender;
            args[1] = (object)e;
            Type[] parameterTypes = new Type[2];
            parameterTypes[0] = typeof(object);
            parameterTypes[1] = typeof(EventArgs);
            object result = ((MethodBase)(typeof(OverView).GetMethod("button4_Click",
                                                                     BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                     CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: add assertions to method OverViewTest.button4_Click(OverView, Object, EventArgs)
        }
    }
}
