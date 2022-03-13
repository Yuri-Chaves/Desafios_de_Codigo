int n = int.Parse(Console.ReadLine());

            
            int ii;
            int iii;

            for (int i = 1; i <= n; i++)
            {
                   ii = i * i;
                   iii = ii * i;
                Console.WriteLine($"{i} {ii} {iii}\n");                     
            }
            Console.ReadKey(); 
