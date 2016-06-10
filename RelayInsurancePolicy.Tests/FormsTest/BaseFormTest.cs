// <copyright file="BaseFormTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RelayInsurancePolicy;

namespace RelayInsurancePolicy.Tests
{
    [TestClass]
    [PexClass(typeof(BaseForm))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class BaseFormTest
    {

        [PexMethod(MaxBranches = 160000)]
        public BaseForm Constructor()
        {
            BaseForm target = new BaseForm();
            return target;
            // TODO: add assertions to method BaseFormTest.Constructor()
        }
    }
}
