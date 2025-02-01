using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00900Tests
{
    [Test]
    public void T1()
    {
        var rleIterator = new S00900.RLEIterator([3, 8, 0, 9, 2, 5]);
        Assert.That(rleIterator.Next(2), Is.EqualTo(8)); // exhausts 2 terms of the sequence, returning 8. The remaining sequence is now [8, 5, 5].
        Assert.That(rleIterator.Next(1), Is.EqualTo(8)); // exhausts 1 term of the sequence, returning 8. The remaining sequence is now [5, 5].
        Assert.That(rleIterator.Next(1), Is.EqualTo(5)); // exhausts 1 term of the sequence, returning 5. The remaining sequence is now [5].
        Assert.That(rleIterator.Next(2), Is.EqualTo(-1)); // exhausts 2 terms, returning -1. This is because the first term exhausted was 5,
        // but the second term did not exist. Since the last term exhausted does not exist, we return -1.
    }
}
