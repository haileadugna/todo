
namespace Task2
{
    class WordFrequencyCounter
    {
        public void Count(){
            string word = Console.ReadLine()?.Trim() ?? " ";
        
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

            foreach (char c in word){
                int asciivalue = (int)c;

                if (asciivalue < 65 || asciivalue > 90 && asciivalue < 97 || asciivalue > 122){
                    continue;
                }
                else{
                    if (asciivalue >= 65 && asciivalue <= 90){
                        asciivalue += 32;
                    }
                    if (wordFrequency.ContainsKey(asciivalue.ToString())){
                        wordFrequency[asciivalue.ToString()] += 1;
                    }
                    else{
                        wordFrequency.Add(asciivalue.ToString(), 1);
                    }
                }
                
            }

            foreach (var w in wordFrequency){
                Console.WriteLine($"{(char)int.Parse(w.Key)}: {w.Value}");
            }

        }
    }
}

