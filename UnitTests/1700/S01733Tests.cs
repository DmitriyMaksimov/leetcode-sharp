using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01733))]
public class S01733Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01733();
        Assert.That(sut.MinimumTeachings(2, [[1], [2], [1, 2]], [[1, 2], [1, 3], [2, 3]]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01733();
        Assert.That(sut.MinimumTeachings(3, [[2], [1, 3], [1, 2], [3]], [[1, 4], [1, 2], [3, 4], [2, 3]]), Is.EqualTo(2));
    }
}