namespace Task1
{
    class Calculator
    {
        public void Calculate()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine()?.Trim() ?? "0";
            
            Console.WriteLine("Enter number of subjects: ");
            int num_sub = int.Parse(Console.ReadLine()?.Trim() ?? "0");

            Dictionary<string, int> subjects = new Dictionary<string, int>();

            for (int i=0; i< num_sub; i++){
                Console.WriteLine("Enter subject name: ");
                string sub_name = Console.ReadLine()?.Trim() ?? "0";
                Console.WriteLine("Enter subject score: ");
                int sub_score = int.Parse(Console.ReadLine()?.Trim() ?? "0");

                if (sub_score < 0 || sub_score > 100){
                    Console.WriteLine("Invalid score");
                    break;
                }
                subjects.Add(sub_name, sub_score);
            }

            int total = 0;
            foreach (var sub in subjects){
                total += sub.Value;
            }

            double average = total / num_sub;
            
            Console.WriteLine($"Name: {name}");
            foreach (var sub in subjects){
                Console.WriteLine($"{sub.Key}: {sub.Value}");
            }
            Console.WriteLine($"Total score: {total}");
            Console.WriteLine($"The average score is: {average}");
        }
    }
}