using System;

public class Solution {
    public string solution(string str1, string str2) {
        string answer = "";
        for(int i=0;i<str1.Length;i++)
        {
            answer += string.Format("{0}{1}",str1[i],str2[i]);
        }
        return answer;
    }
}