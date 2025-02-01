using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02559Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02559();
        Assert.That(sut.VowelStrings(["aba", "bcb", "ece", "aa", "e"], [[0, 2], [1, 4], [1, 1]]), Is.EqualTo((int[]) [2, 3, 0]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02559();
        Assert.That(sut.VowelStrings(["a", "e", "i"], [[0, 2], [0, 1], [2, 2]]), Is.EqualTo((int[]) [3, 2, 1]));
    }
}
