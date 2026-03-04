public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
     var map = new Dictionary<string , IList<string>>();

     foreach(string word in strs){
        char[] chars = word.ToCharArray();
        Array.Sort(chars);
        string sortedWord = new string(chars);

        if(!map.ContainsKey(sortedWord)){
            map[sortedWord] = new List<string>();
        }

        map[sortedWord].Add(word);
     }
     return map.Values.Cast<IList<string>>().ToList();
    }
}
