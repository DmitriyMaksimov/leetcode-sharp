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
        snapshotArr.Snap().Should().Be(0); // Take a snapshot, return snap_id = 0
        snapshotArr.Set(0, 6);
        snapshotArr.Get(0, 0).Should().Be(5); // Get the value of array[0] with snap_id = 0, return 5
    }

    [Test]
    public void T2()
    {
        var snapshotArr = new S01146.SnapshotArray(4);
        snapshotArr.Snap().Should().Be(0);
        snapshotArr.Snap().Should().Be(1);
        snapshotArr.Get(3, 1).Should().Be(0);
        snapshotArr.Set(2, 4);
        snapshotArr.Snap().Should().Be(2);
        snapshotArr.Set(1, 4);
    }
}