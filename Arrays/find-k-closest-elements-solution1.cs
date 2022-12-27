// 658. Find K Closest Elements
// https://leetcode.com/problems/find-k-closest-elements/description/
// Using Queues

public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        var queue = new Queue<int>();
        IList<int> res = new List<int>();
        for(int i=0; i < arr.Length; i++){
            if(queue.Count < k)
                queue.Enqueue(arr[i]);
            else if(Math.Abs(x-queue.Peek()) > Math.Abs(x-arr[i])){
                queue.Dequeue();
                queue.Enqueue(arr[i]);
            }
        }
        while(queue.Count != 0)
            res.Add(queue.Dequeue());
        return res.OrderBy(x => x).ToList();
    }
}