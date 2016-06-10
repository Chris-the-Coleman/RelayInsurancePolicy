using System.Windows.Forms;
using System.Reflection;
// <copyright file="DriverDetailsTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RelayInsurancePolicy;

namespace RelayInsurancePolicy.Tests
{
    [TestClass]
    [PexClass(typeof(DriverDetails))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DriverDetailsTest
    {

        [PexMethod(MaxBranches = 600000)]
        public DriverDetails Constructor(int DriverNumber, bool Change)
        {
            DriverDetails target = new DriverDetails(DriverNumber, Change);
            return target;
            // TODO: add assertions to method DriverDetailsTest.Constructor(Int32, Boolean)
        }

        [PexMethod(MaxBranches = 320000)]
        [PexMethodUnderTest("claimVisibilty()")]
        internal void claimVisibilty([PexAssumeUnderTest]DriverDetails target)
        {
            object[] args = new object[0];
            Type[] parameterTypes = new Type[0];
            object result = ((MethodBase)(typeof(DriverDetails).GetMethod("claimVisibilty",
                                                                          BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                          CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: add assertions to method DriverDetailsTest.claimVisibilty(DriverDetails)
        }

        [PexMethod(MaxBranches = 320000)]
        [PexMethodUnderTest("claim(Boolean, Label, DateTimePicker)")]
        internal void claim(
            [PexAssumeUnderTest]DriverDetails target,
            bool visible,
            Label label,
            DateTimePicker picker
        )
        {
            object[] args = new object[3];
            args[0] = (object)visible;
            args[1] = (object)label;
            args[2] = (object)picker;
            Type[] parameterTypes = new Type[3];
            parameterTypes[0] = typeof(bool);
            parameterTypes[1] = typeof(Label);
            parameterTypes[2] = typeof(DateTimePicker);
            object result = ((MethodBase)(typeof(DriverDetails).GetMethod("claim",
                                                                          BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                          CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: add assertions to method DriverDetailsTest.claim(DriverDetails, Boolean, Label, DateTimePicker)
        }

        [PexMethod(MaxBranches = 320000)]
        [PexMethodUnderTest("claimInitializedVisbibilty()")]
        internal void claimInitializedVisbibilty([PexAssumeUnderTest]DriverDetails target)
        {
            object[] args = new object[0];
            Type[] parameterTypes = new Type[0];
            object result = ((MethodBase)(typeof(DriverDetails).GetMethod("claimInitializedVisbibilty",
                                                                          BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                          CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: add assertions to method DriverDetailsTest.claimInitializedVisbibilty(DriverDetails)
        }

        [PexMethod(MaxBranches = 320000)]
        [PexMethodUnderTest("button1_Click_1(Object, EventArgs)")]
        internal void button1_Click_1(
            [PexAssumeUnderTest]DriverDetails target,
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
            object result = ((MethodBase)(typeof(DriverDetails).GetMethod("button1_Click_1",
                                                                          BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                          CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: add assertions to method DriverDetailsTest.button1_Click_1(DriverDetails, Object, EventArgs)
        }

        [PexMethod(MaxBranches = 640000)]
        [PexMethodUnderTest("OverviewForm()")]
        internal void OverviewForm([PexAssumeUnderTest]DriverDetails target)
        {
            object[] args = new object[0];
            Type[] parameterTypes = new Type[0];
            object result = ((MethodBase)(typeof(DriverDetails).GetMethod("OverviewForm",
                                                                          BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                          CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: add assertions to method DriverDetailsTest.OverviewForm(DriverDetails)
        }

        [PexMethod(MaxBranches = 640000)]
        [PexMethodUnderTest("NewDriver()")]
        internal void NewDriver([PexAssumeUnderTest]DriverDetails target)
        {
            object[] args = new object[0];
            Type[] parameterTypes = new Type[0];
            object result = ((MethodBase)(typeof(DriverDetails).GetMethod("NewDriver",
                                                                          BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                          CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: add assertions to method DriverDetailsTest.NewDriver(DriverDetails)
        }

        [PexMethod(MaxBranches = 320000)]
        [PexMethodUnderTest("AddClaims()")]
        internal void AddClaims([PexAssumeUnderTest]DriverDetails target)
        {
            object[] args = new object[0];
            Type[] parameterTypes = new Type[0];
            object result = ((MethodBase)(typeof(DriverDetails).GetMethod("AddClaims",
                                                                          BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                          CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: add assertions to method DriverDetailsTest.AddClaims(DriverDetails)
        }

        [PexMethod(MaxBranches = 320000)]
        [PexMethodUnderTest("CloseForm()")]
        [PexAllowedException(typeof(TargetInvocationException))]
        internal void CloseForm([PexAssumeUnderTest]DriverDetails target)
        {
            object[] args = new object[0];
            Type[] parameterTypes = new Type[0];
            object result = ((MethodBase)(typeof(DriverDetails).GetMethod("CloseForm",
                                                                          BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                          CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: add assertions to method DriverDetailsTest.CloseForm(DriverDetails)
        }
    }
}
