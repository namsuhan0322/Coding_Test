using System;

public class Solution {
    public int solution(string ineq, string eq, int n, int m) {
        int result=0;
        if(ineq.Equals(">"))
        {
            if(eq.Equals("="))
            {
                result = n >= m ? 1 : 0; 
            }
            else
            {
                 result = n > m ? 1 : 0;
            }
        }
         else if(ineq.Equals("<"))
         {
             if(eq.Equals("="))
             {
                 result = n <= m ? 1 : 0;     
             }
             else
             {
                  result = n < m ? 1 : 0;
             }
         }
        return result;
    }
}