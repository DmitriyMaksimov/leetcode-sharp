using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03036Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03036();
        Assert.That(sut.CountMatchingSubarrays([1, 2, 3, 4, 5, 6], [1, 1]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03036();
        Assert.That(sut.CountMatchingSubarrays([1, 4, 4, 1, 3, 5, 5, 3], [1, 0, -1]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03036();
        Assert.That(sut.CountMatchingSubarrays([7,6,5,4,3,3,4,3,2,3,3,2,2,1,1], [0,-1,-1,-1,-1,-1,-1,1,-1,-1,0,-1,-1,-1]), Is.EqualTo(0));
    }
}