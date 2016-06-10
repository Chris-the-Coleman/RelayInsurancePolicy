using System.Reflection;
// <copyright file="SubmittedTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RelayInsurancePolicy;

namespace RelayInsurancePolicy.Tests
{
    [TestClass]
    [PexClass(typeof(Submitted))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SubmittedTest
    {

        [PexMethod(MaxBranches = 160000)]
        [PexAllowedException(typeof(InvalidOperationException))]
        public Submitted Constructor()
        {
            Submitted target = new Submitted();
            return target;
            // TODO: add assertions to method SubmittedTest.Constructor()
        }

        [PexMethod(MaxBranches = 160000)]
        [PexMethodUnderTest("CalculatePremium()")]
        internal void CalculatePremium([PexAssumeUnderTest]Submitted target)
        {
            object[] args = new object[0];
            Type[] parameterTypes = new Type[0];
            object result = ((MethodBase)(typeof(Submitted).GetMethod("CalculatePremium",
                                                                      BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                      CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: add assertions to method SubmittedTest.CalculatePremium(Submitted)
        }

        [PexMethod(MaxBranches = 20000)]
        [PexMethodUnderTest("AcceptorDecline()")]
        internal bool AcceptorDecline([PexAssumeUnderTest]Submitted target)
        {
            object[] args = new object[0];
            Type[] parameterTypes = new Type[0];
            bool result0 = (bool)(((MethodBase)(typeof(Submitted).GetMethod("AcceptorDecline",
                                                                            BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic,
                                                                            (Binder)null, CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                      .Invoke((object)target, args));
            bool result = result0;
            return result;
            // TODO: add assertions to method SubmittedTest.AcceptorDecline(Submitted)
        }

        [PexMethod(MaxBranches = 20000)]
        [PexMethodUnderTest("declined()")]
        internal void declined([PexAssumeUnderTest]Submitted target)
        {
            object[] args = new object[0];
            Type[] parameterTypes = new Type[0];
            object result = ((MethodBase)(typeof(Submitted).GetMethod("declined",
                                                                      BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                      CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: add assertions to method SubmittedTest.declined(Submitted)
        }

        [PexMethod(MaxBranches = 20000)]
        [PexMethodUnderTest("button2_Click(Object, EventArgs)")]
        internal void button2_Click(
            [PexAssumeUnderTest]Submitted target,
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
            object result = ((MethodBase)(typeof(Submitted).GetMethod("button2_Click",
                                                                      BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                      CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: add assertions to method SubmittedTest.button2_Click(Submitted, Object, EventArgs)
        }
    }
}
