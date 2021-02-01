using Microsoft.VisualStudio.TestTools.UnitTesting;
using net_stack;
using net_stack.model.exceptions;

namespace net_stack_tests
{
  [TestClass]
  public class StackTest
  {
    private Stack stack;

    [TestInitialize]
    public void SetUp()
    {
      stack = new Stack();
    }

    // implement tests
    [TestMethod]
    public void IsEmptyReturnsTrue()
    {
      var sut = stack.IsEmpty();
      
      Assert.IsTrue(sut);
    }

    [TestMethod]
    public void IsEmptyReturnsFalseAfterPush()
    {
      stack.Push("test1");

      var sut = stack.IsEmpty();
      
      Assert.IsFalse(sut);
    }

    [TestMethod]
    public void PeekReturnsNullWhenStackIsEmpty()
    {
      var sut = stack.Peek();
      
      Assert.IsNull(sut);
    }

    [TestMethod]
    public void PeekReturnsMostRecentlyPushedValue()
    {
      stack.Push("test1");

      var sut = stack.Peek();
      
      Assert.AreEqual("test1", sut);
    }

    [TestMethod]
    [ExpectedException(typeof(EmptyStackException))]
    public void PopThrowsEmptyStackExceptionWhenStackEmpty()
    {
      stack.Pop();
    }

    [TestMethod]
    public void PopReturnsMostRecentPushedValue()
    {
      stack.Push(1);

      var sut = stack.Pop();

      Assert.AreEqual(1, sut);
    }

    [TestMethod]
    public void PeekReturnsNullAfterPopIsCalled()
    {
      stack.Push(1);
      stack.Pop();

      var sut = stack.Peek();

      Assert.IsNull(sut);
    }

    [TestMethod]
    public void IsEmptyReturnsTrueAfterPopIsCalled()
    {
      stack.Push(1);
      stack.Pop();

      var sut = stack.IsEmpty();

      Assert.IsTrue(sut);
    }

    [TestMethod]
    public void AfterTwoPushesPopReturns2ndPushedValue_PeekReturns1stPushedValue()
    {
      stack.Push(1);
      stack.Push(2);

      var sut1 = stack.Pop();
      var sut2 = stack.Peek();

      Assert.AreEqual(2, sut1);
      Assert.AreEqual(1, sut2);
    }

    [TestMethod]
    public void ContainsReturnsTrueIfValuePresent()
    {
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);
      stack.Push(4);

      var sut = stack.Contains(2);

      Assert.IsTrue(sut);
    }

    [TestMethod]
    public void ContainsReturnsFalseIfValueNotPresent()
    {
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);
      stack.Push(4);

      var sut = stack.Contains(5);

      Assert.IsFalse(sut);
    }
  }
}
