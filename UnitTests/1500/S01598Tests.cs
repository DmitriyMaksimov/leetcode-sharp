using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01598Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01598();
        sut.MinOperations(new[] {"d1/", "d2/", "../", "d21/", "./"}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01598();
        sut.MinOperations(new[] {"d1/", "d2/", "./", "d3/", "../", "d31/"}).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S01598();
        sut.MinOperations(new[] {"d1/", "../", "../", "../"}).Should().Be(0);
    }
}