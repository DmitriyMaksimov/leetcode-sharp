using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02530Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02530();
        sut.MaxKelements([10, 10, 10, 10, 10], 5).Should().Be(50);
    }

    [Test]
    public void T2()
    {
        var sut = new S02530();
        sut.MaxKelements([1, 10, 3, 3, 3], 3).Should().Be(17);
    }
}
