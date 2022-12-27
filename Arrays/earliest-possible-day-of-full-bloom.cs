// 2136. Earliest Possible Day of Full Bloom
// https://leetcode.com/problems/earliest-possible-day-of-full-bloom/description/

public class Solution {
    public int EarliestFullBloom(int[] plantTime, int[] growTime) {
        var list = Enumerable.Zip(growTime, plantTime).OrderBy(x => x.Item1);
        int earlyGrow = 0;
        foreach(var (grow, plant) in list){
            earlyGrow = Math.Max(grow, earlyGrow) + plant;
        }
        return earlyGrow;
    }
}