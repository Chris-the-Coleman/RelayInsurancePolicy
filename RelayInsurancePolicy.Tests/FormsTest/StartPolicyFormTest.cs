using System.Reflection;
// <copyright file="StartPolicyFormTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RelayInsurancePolicy;

namespace RelayInsurancePolicy.Tests
{
    [TestClass]
    [PexClass(typeof(StartPolicyForm))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class StartPolicyFormTest
    {

        [PexMethod(MaxBranches = 160000)]
        public StartPolicyForm Constructor()
        {
            StartPolicyForm target = new StartPolicyForm();
            return target;
            // TODO: add assertions to method StartPolicyFormTest.Constructor()
        }

        [PexMethod(MaxBranches = 160000)]
        [PexMethodUnderTest("driverNumberUpdate()")]
        internal void driverNumberUpdate([PexAssumeUnderTest]StartPolicyForm target)
        {
            object[] args = new object[0];
            Type[] parameterTypes = new Type[0];
            object result = ((MethodBase)(typeof(StartPolicyForm).GetMethod("driverNumberUpdate",
                                                                            BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                            CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                .Invoke((object)target, args);
            // TODO: add assertions to method StartPolicyFormTest.driverNumberUpdate(StartPolicyForm)
        }
    }
}
