using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02196Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02196();
        Assert.That(sut.CreateBinaryTree([[20, 15, 1], [20, 17, 0], [50, 20, 1], [50, 80, 0], [80, 19, 1]]).AsString(), Is.EqualTo("[50,20,80,15,17,19]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02196();
        Assert.That(sut.CreateBinaryTree([[1, 2, 1], [2, 3, 0], [3, 4, 1]]).AsString(), Is.EqualTo("[1,2,null,null,3,4]"));
    }
}