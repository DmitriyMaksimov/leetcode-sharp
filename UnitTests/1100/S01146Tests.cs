using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01146Tests
{
    [Test]
    public void T1()
    {
        var snapshotArr = new S01146.SnapshotArray(3);
        snapshotArr.Set(0, 5); // Set array[0] = 5
        Assert.That(snapshotArr.Snap(), Is.EqualTo(0)); // Take a snapshot, return snap_id = 0
        snapshotArr.Set(0, 6);
        Assert.That(snapshotArr.Get(0, 0), Is.EqualTo(5)); // Get the value of array[0] with snap_id = 0, return 5
    }

    [Test]
    public void T2()
    {
        var snapshotArr = new S01146.SnapshotArray(4);
        Assert.That(snapshotArr.Snap(), Is.EqualTo(0));
        Assert.That(snapshotArr.Snap(), Is.EqualTo(1));
        Assert.That(snapshotArr.Get(3, 1), Is.EqualTo(0));
        snapshotArr.Set(2, 4);
        Assert.That(snapshotArr.Snap(), Is.EqualTo(2));
        snapshotArr.Set(1, 4);
    }
}