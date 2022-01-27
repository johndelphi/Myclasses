using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MyClasses
{
  [TestClass]
  public class FileprocessTest
  {
    [TestMethod]
    public void FileNameDoesExist()
    {
      //arrange
      FileProcess ve = new Fileprocess();
      bool fromCall;
      Assert.Inconclusive();
    }
    [TestMethod]
    public void FileNameDoeNOTExist()
    {
      Assert.Inconclusive();
    }
   [TestMethod]
    public void FileNameNullOrEmpty_usingAttribute()
    {
      Assert.Inconclusive();
    }
    [TestMethod]
    public void FileNameNullOrEmpty_UsingTryCatch()
    {
      Assert.Inconclusive();
    }
  }
}
