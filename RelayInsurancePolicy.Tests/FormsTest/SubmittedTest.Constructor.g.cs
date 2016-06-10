using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RelayInsurancePolicy;
using Microsoft.Pex.Framework.Generated;
// <copyright file="SubmittedTest.Constructor.g.cs">Copyright ©  2016</copyright>
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
    public partial class SubmittedTest
    {

[TestMethod]
[PexGeneratedBy(typeof(SubmittedTest))]
public void Constructor950()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Submitted submitted;
      submitted = this.Constructor();
      disposables.Add((IDisposable)submitted);
      disposables.Dispose();
      Assert.IsNotNull((object)submitted);
      Assert.AreEqual<bool>(true, ((BaseForm)submitted).Exit);
      Assert.AreEqual<DialogResult>
          (DialogResult.None, ((Form)submitted).DialogResult);
      Assert.AreEqual<bool>(false, ((Form)submitted).IsMdiContainer);
      Assert.AreEqual<bool>
          (false, ((ContainerControl)submitted).AutoScaleDimensions.IsEmpty);
      Assert.AreEqual<float>
          ((float)6, ((ContainerControl)submitted).AutoScaleDimensions.Width);
      Assert.AreEqual<float>
          ((float)13, ((ContainerControl)submitted).AutoScaleDimensions.Height);
      Assert.AreEqual<AutoScaleMode>
          (AutoScaleMode.Font, ((ContainerControl)submitted).AutoScaleMode);
      Assert.IsNull(((ContainerControl)submitted).ActiveControl);
      Assert.AreEqual<bool>
          (true, ((ScrollableControl)submitted).AutoScrollMargin.IsEmpty);
      Assert.AreEqual<int>(0, ((ScrollableControl)submitted).AutoScrollMargin.Width);
      Assert.AreEqual<int>
          (0, ((ScrollableControl)submitted).AutoScrollMargin.Height);
      Assert.AreEqual<bool>
          (true, ((ScrollableControl)submitted).AutoScrollMinSize.IsEmpty);
      Assert.AreEqual<int>
          (0, ((ScrollableControl)submitted).AutoScrollMinSize.Width);
      Assert.AreEqual<int>
          (0, ((ScrollableControl)submitted).AutoScrollMinSize.Height);
      Assert.AreEqual<int>(500, ((Control)submitted).Bottom);
      Assert.AreEqual<bool>(false, ((Control)submitted).Created);
      Assert.AreEqual<int>(500, ((Control)submitted).Height);
      Assert.AreEqual<int>(0, ((Control)submitted).Left);
      Assert.AreEqual<bool>(false, ((Control)submitted).RecreatingHandle);
      Assert.AreEqual<int>(650, ((Control)submitted).Right);
      Assert.AreEqual<int>(0, ((Control)submitted).TabIndex);
      Assert.AreEqual<int>(0, ((Control)submitted).Top);
      Assert.AreEqual<int>(650, ((Control)submitted).Width);
    }
}
    }
}
