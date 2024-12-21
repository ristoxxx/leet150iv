public class Solution {
    public string IntToRoman(int num) {
        string numbers = num.ToString();
        string result = "";

        static string thousands(string number){
            if(number == "1")
                return "M";
            if(number == "2")
                return "MM";
            if(number == "3")
                return "MMM";
            return "";
        };
      
        static string hundreds(string number){
            if(number == "1")
                return "C";
            if(number == "2")
                return "CC";
            if(number == "3")
                return "CCC";
            if(number == "4")
                return "CD";
            if(number == "5")
                return "D";
            if(number == "6")
                return "DC";
            if(number == "7")
                return "DCC";
            if(number == "8")
                return "DCCC";
            if(number == "9")
                return "CM";
            return"";
        }

        static string tens(string number){
            if(number == "1")
                return "X";
            if(number == "2")
                return "XX";
            if(number == "3")
                return "XXX";
            if(number == "4")
                return "XL";
            if(number == "5")
                return "L";
            if(number == "6")
                return "LX";
            if(number == "7")
                return "LXX";
            if(number == "8")
                return "LXXX";
            if(number == "9")
                return "XC";
            return "";
        }
        static string ones(string number){
            if(number == "1")
                return "I";
            if(number == "2")
                return "II";
            if(number == "3")
                return "III";
            if(number == "4")
                return "IV";
            if(number == "5")
                return "V";
            if(number == "6")
                return "VI";
            if(number == "7")
                return "VII";
            if(number == "8")
                return "VIII";
            if(number == "9")
                return "IX";
            return "";
        }
      
        if(numbers.Length == 4) {
            result = result + thousands(numbers.Substring(0,1));
            result = result + hundreds(numbers.Substring(1,1));
            result = result + tens(numbers.Substring(2,1));
            result = result + ones(numbers.Substring(3,1));
        }

        if(numbers.Length == 3) {
            result = result + hundreds(numbers.Substring(0,1));
            result = result + tens(numbers.Substring(1,1));
            result = result + ones(numbers.Substring(2,1));
        }

        if(numbers.Length == 2) {
            result = result + tens(numbers.Substring(0,1));
            result = result + ones(numbers.Substring(1,1));
        }

        if(numbers.Length == 1) {
            result = result + ones(numbers.Substring(0,1));
        }
        
        return result;
    }
}