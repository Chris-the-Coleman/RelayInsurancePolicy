using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RelayInsurancePolicy;
using Microsoft.Pex.Framework.Generated;
// <copyright file="StartPolicyFormTest.Constructor.g.cs">Copyright ©  2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace RelayInsurancePolicy.Tests
{
    public partial class StartPolicyFormTest
    {

[TestMethod]
[PexGeneratedBy(typeof(StartPolicyFormTest))]
public void Constructor195()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StartPolicyForm startPolicyForm;
      startPolicyForm = this.Constructor();
      disposables.Add((IDisposable)startPolicyForm);
      disposables.Dispose();
      Assert.IsNotNull((object)startPolicyForm);
      Assert.AreEqual<bool>(true, ((BaseForm)startPolicyForm).Exit);
      Assert.AreEqual<DialogResult>
          (DialogResult.None, ((Form)startPolicyForm).DialogResult);
      Assert.AreEqual<bool>(false, ((Form)startPolicyForm).IsMdiContainer);
      Assert.AreEqual<bool>
          (false, ((ContainerControl)startPolicyForm).AutoScaleDimensions.IsEmpty);
      Assert.AreEqual<float>
          ((float)6, ((ContainerControl)startPolicyForm).AutoScaleDimensions.Width);
      Assert.AreEqual<float>
          ((float)13, ((ContainerControl)startPolicyForm).AutoScaleDimensions.Height);
      Assert.AreEqual<AutoScaleMode>
          (AutoScaleMode.Font, ((ContainerControl)startPolicyForm).AutoScaleMode);
      Assert.IsNull(((ContainerControl)startPolicyForm).ActiveControl);
      Assert.AreEqual<bool>
          (true, ((ScrollableControl)startPolicyForm).AutoScrollMargin.IsEmpty);
      Assert.AreEqual<int>
          (0, ((ScrollableControl)startPolicyForm).AutoScrollMargin.Width);
      Assert.AreEqual<int>
          (0, ((ScrollableControl)startPolicyForm).AutoScrollMargin.Height);
      Assert.AreEqual<bool>
          (true, ((ScrollableControl)startPolicyForm).AutoScrollMinSize.IsEmpty);
      Assert.AreEqual<int>
          (0, ((ScrollableControl)startPolicyForm).AutoScrollMinSize.Width);
      Assert.AreEqual<int>
          (0, ((ScrollableControl)startPolicyForm).AutoScrollMinSize.Height);
      Assert.AreEqual<int>(500, ((Control)startPolicyForm).Bottom);
      Assert.AreEqual<bool>(false, ((Control)startPolicyForm).Created);
      Assert.AreEqual<int>(500, ((Control)startPolicyForm).Height);
      Assert.AreEqual<int>(0, ((Control)startPolicyForm).Left);
      Assert.AreEqual<bool>(false, ((Control)startPolicyForm).RecreatingHandle);
      Assert.AreEqual<int>(650, ((Control)startPolicyForm).Right);
      Assert.AreEqual<int>(0, ((Control)startPolicyForm).TabIndex);
      Assert.AreEqual<int>(0, ((Control)startPolicyForm).Top);
      Assert.AreEqual<int>(650, ((Control)startPolicyForm).Width);
    }
}
    }
}
