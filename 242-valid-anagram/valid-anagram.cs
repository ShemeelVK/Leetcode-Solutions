public class Solution {
    public bool IsAnagram(string s, string t) {
        string s1=new string(s.OrderBy(s=>s).ToArray());
        string t2=new string(t.OrderBy(t=>t).ToArray());
        if(s1==t2){
        return true;
        }
        else{
            return false;
        }

    }
}