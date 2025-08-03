namespace leetcode_sharp;

// 841. Keys and Rooms
// https://leetcode.com/problems/keys-and-rooms/
public class S00841
{
    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        var visitedRooms = new HashSet<int>();
        var roomsToVisit = new Queue<int>();
        roomsToVisit.Enqueue(0);

        while (roomsToVisit.Count != 0)
        {
            var currentRoom = roomsToVisit.Dequeue();
            visitedRooms.Add(currentRoom);
            foreach (var key in rooms[currentRoom])
            {
                if (visitedRooms.Contains(key))
                {
                    // Already visited
                    continue;
                }
                roomsToVisit.Enqueue(key);
            }
        }
        
        return visitedRooms.Count == rooms.Count;
    }
}