//Write a public method that accepts a number
public static string Fizz(int num)
        {
            var answer = "";
            //when the number is divisible by 3 return the word fizz
            if (num % 3 == 0)
            {
                answer = "fizz";

            }

            //when the number is divisible by 5 return the word buzz
            if (num % 5 == 0)
            {
                answer += "buzz";

            }

            //when the number is divisible by both, return the word fizzbuzz
            return answer;
        }

        