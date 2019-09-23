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
        Assert.AreEqual("Wehvaetr wlord", testJumble.Dyslexia("Whatever world"));
    }
    [TestMethod]
    public void Dyslexia_SimpleLogic_Str()
    {
      Jumble testJumble = new Jumble();
      Assert.AreEqual("Sehtepn", testJumble.Dyslexia("Stephen"));
    }
    [TestMethod]
    public void Dyslexia_SimpleLogic2_Str()
    {
      Jumble testJumble = new Jumble();
      Assert.AreEqual("Kneau", testJumble.Dyslexia("Keanu"));
    }
    [TestMethod]
    public void Dyslexia_EvenWordLogic_Str()
    {
      Jumble testJumble = new Jumble();
      Assert.AreEqual("Atduvreens", testJumble.Dyslexia("Adventures"));
    }
    [TestMethod]
    public void Dyslexia_LongPhrase_Str()
    {
      Jumble testJumble = new Jumble();
      Assert.AreEqual("hlelo ncie to meet you", testJumble.Dyslexia("hello nice to meet you"));
    }
    [TestMethod]
    public void Dyslexia_NumbersNotAffected_Str()
    {
      Jumble testJumble = new Jumble();
      Assert.AreEqual("1234 le0sr jbulme me", testJumble.Dyslexia("1234 l0ser jumble me"));
    }
  }
}