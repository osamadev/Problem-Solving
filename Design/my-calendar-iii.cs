// 732. My Calendar III
// https://leetcode.com/problems/my-calendar-iii/description/

public class MyCalendarThree {

    SortedDictionary<int, int> dict = null;
    public MyCalendarThree() {
        dict = new SortedDictionary<int, int>(); 
    }
    
    public int Book(int start, int end) {
        if(dict.ContainsKey(start)) dict[start] += 1;
        else dict[start] = 1;
        if(dict.ContainsKey(end)) dict[end] -= 1;
        else dict.Add(end, -1);
        int bookingsCount = 0;
        int currIntersectionsCount = 0;
        foreach(var item in dict.Keys){
            currIntersectionsCount += dict[item];
            bookingsCount = Math.Max(bookingsCount, currIntersectionsCount);
        }
        return bookingsCount;
    }
}

/**
 * Your MyCalendarThree object will be instantiated and called as such:
 * MyCalendarThree obj = new MyCalendarThree();
 * int param_1 = obj.Book(start,end);
 */

