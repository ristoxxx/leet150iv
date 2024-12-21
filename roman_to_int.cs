public class Solution {
    public int RomanToInt(string s) {
        int result = 0;
        char store = 'A';
        char[] arr = s.ToCharArray();
        foreach (char item in arr)
        {
            if(item == 'I')
                result++;
            if(item == 'V' && store == 'I')
                   result = result + 3;
            if(item == 'V' && store != 'I')
                   result = result + 5;   
            if(item == 'X' && store == 'I')
                result = result + 8;
            if(item == 'X' && store != 'I')
                result = result + 10;    
            if(item == 'L' && store == 'X')
                result = result + 30;
            if(item == 'L' && store != 'X')
                result = result + 50;
            if(item == 'C' && store == 'X')
                result = result + 80;
            if(item == 'C' && store != 'X')
                result = result + 100;
            if(item == 'D' && store == 'C')
                result = result + 300;
            if(item == 'D' && store != 'C')
                result = result + 500;
            if(item == 'M' && store == 'C')
                result = result + 800;
            if(item == 'M' && store != 'C')
                result = result + 1000;
            store = item;       
        }   
        return result;
    }
}