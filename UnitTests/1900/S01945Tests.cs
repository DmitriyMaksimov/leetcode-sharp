using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01945Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01945();
        sut.GetLucky("iiii", 1).Should().Be(36);
    }

    [Test]
    public void T2()
    {
        var sut = new S01945();
        sut.GetLucky("leetcode", 2).Should().Be(6);
    }

    [Test]
    public void T3()
    {
        var sut = new S01945();
        sut.GetLucky("zbax", 2).Should().Be(8);
    }

    [Test]
    public void T4()
    {
        var sut = new S01945();
        sut.GetLucky("iaozzbyqzwbpurzze", 2).Should().Be(5);
    }

    [Test]
    public void T5()
    {
        var sut = new S01945();
        sut.GetLucky("ssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss", 2).Should().Be(1);
    }
}