namespace MastermindTesterCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const bool DEBUG = false;
            Console.WriteLine("Mastermind tester");
            Console.WriteLine("This code tests your Mastermind scoring function.");
            int indexFirstWrong = 0;
            int numTests = 0;
            int numRight = 0;
            bool firstWrong = true;
            //int index = 0;
            StreamReader reader = new StreamReader("../../../mastermind_4x6.txt");
            reader.ReadLine();  // get rid of header

            Console.WriteLine("Secret:Guess-Expected:Score");

            while (!reader.EndOfStream)
            {
                numTests++;
                String line = reader.ReadLine();
                String[] data = line.Split(',');

                byte[] secret = new byte[] { Convert.ToByte(data[0][0] - '0'),
                                             Convert.ToByte(data[0][1] - '0'),
                                             Convert.ToByte(data[0][2] - '0'),
                                             Convert.ToByte(data[0][3] - '0')};
                byte[] guess  = new byte[] { Convert.ToByte(data[1][0] - '0'),
                                             Convert.ToByte(data[1][1] - '0'),
                                             Convert.ToByte(data[1][2] - '0'),
                                             Convert.ToByte(data[1][3] - '0')};
                int black = Convert.ToInt16(data[2]);
                int white = Convert.ToInt16(data[3]);

                int[] score = MMScoring(secret, guess);
                
                if (score[0] == black && score[1] == white)
                {
                    numRight++;
                }
                else
                {
                    if (firstWrong)
                    {
                        firstWrong = false;
                        indexFirstWrong = numTests - 1;
                        Console.Write(secret[0] + "" + secret[1] + "" + secret[2] + "" + secret[3] + ":");
                        Console.Write(secret[0] + "" + secret[1] + "" + secret[2] + "" + secret[3] + "   -      ");
                        Console.Write(black + "" + white + ":");
                        Console.WriteLine(score[0] + "" + score[1]);
                    }
                }
                if(DEBUG)
                {
                    Console.Write(secret[0] + "" + secret[1] + "" + secret[2] + "" + secret[3] + ":");
                    Console.Write(secret[0] + "" + secret[1] + "" + secret[2] + "" + secret[3] + "   -      ");
                    Console.Write(black + "" + white + ":");
                    Console.WriteLine(score[0] + "" + score[1]);
                }
            }
            reader.Close();

            double percentRight = (double)numRight / (double)numTests;
            if (!firstWrong)
            {
                Console.WriteLine("First Wrong answer at index " + indexFirstWrong);
            }
            Console.WriteLine("percentage correct: " + percentRight * 100 + "%.");
        }

        static int[] MMScoring(byte[] secret, byte[] guess)
        {
            int black = 0;  // number of correct color and placement
            int white = 0;  // number of correct color (wrong spot)
            //int[] arr = new int[] { black, white };

            return new int[] { black, white };
        }
    }
}