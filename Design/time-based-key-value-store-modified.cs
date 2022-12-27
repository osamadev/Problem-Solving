// 981. Time Based Key-Value Store
// https://leetcode.com/problems/time-based-key-value-store/description/

public class TimeMap {

    Dictionary<string, SortedList<int,string>> dict = null;
    public TimeMap() {
        dict = new Dictionary<string, SortedList<int,string>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!dict.ContainsKey(key))
            dict[key] = new SortedList<int,string>(){{timestamp, value}};
            else{
                var internalDict = dict[key];
                internalDict.Add(timestamp, value);
            }
    }
    
    public string Get(string key, int timestamp) {
        if(dict.ContainsKey(key)){
            var result = dict[key];
            var list = result.Keys;
            int item = GetUpperBound(timestamp, list);
            return item > 0 ? result[item] : "";
        }
        return "";
    }

    public int GetUpperBound(int timestamp, IList<int> list){
        int left = 0;
        int right = list.Count-1;
        while(left < right){
            int mid = (right + left+1) / 2;
            if(list[mid] == timestamp){
                return list[mid];
            }
            if(list[mid] < timestamp){
                left = mid;
            }
            else{
                right = mid-1;
            }
        }
        return left == 0 && list[left] > timestamp ? 0 : list[left];
    }
}

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap obj = new TimeMap();
 * obj.Set(key,value,timestamp);
 * string param_2 = obj.Get(key,timestamp);
 */