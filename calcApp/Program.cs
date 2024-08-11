
            double a;
            double b;
            
            Console.WriteLine("Enter the first number:");
            bool aIsNumber = double.TryParse(Console.ReadLine().Trim(), out a);

            Console.WriteLine("Enter the second number:");
            bool bIsNumber = double.TryParse(Console.ReadLine().Trim(), out b);
            
            
            if (aIsNumber && bIsNumber)
            {
                double result;
                Console.WriteLine("Choose an operation: +, -, *, /");
                string arithmetic = Console.ReadLine().Trim();

                if(b == 0){
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return;
                }
            
                switch (arithmetic)
                {
                    case "+":
                    result = a + b;
                    break;
                    case "-":
                    result = a - b;
                    break;
                    case "/":
                    result = a / b;
                    break;
                    case "*":
                    result = a * b;
                    break; 
                    default:
                    Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                    return;
                }
            
                Console.WriteLine($"Result: {result}");
            }else{
                Console.WriteLine($"Please enter a number");
            }