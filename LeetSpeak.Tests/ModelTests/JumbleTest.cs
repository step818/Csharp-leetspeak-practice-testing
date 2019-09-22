using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class JumbleTest
  {
    [TestMethod]
    public void Dyslexia_MixAllBut0Last_Str()
    {
      Jumble testJumble = new Jumble();
        Assert.AreEqual("hateve orl ", testJumble.Dyslexia("Whatever world"));
    }
    [TestMethod]
    public void Dyslexia_SimpleLogic_Str()
    {
      Jumble testJumble = new Jumble();
      Assert.AreEqual("tephe ", testJumble.Dyslexia("Stephen"));
    }
  }
}