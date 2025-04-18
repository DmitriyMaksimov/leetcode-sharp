using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02191Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02191();
        Assert.That(sut.SortJumbled([8, 9, 4, 0, 2, 1, 3, 5, 7, 6], [991, 338, 38]), Is.EqualTo((int[]) [338, 38, 991]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02191();
        Assert.That(sut.SortJumbled([0, 1, 2, 3, 4, 5, 6, 7, 8, 9], [789, 456, 123]), Is.EqualTo((int[]) [123, 456, 789]));
    }
}