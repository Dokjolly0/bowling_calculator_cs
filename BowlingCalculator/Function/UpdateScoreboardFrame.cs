using System;

namespace BowlingCalculator.Function
{
    public class BowlingScoreboard
    {
        public string getScoreboardFrame(int numberFrame, int numberAttempt, int score, string frames = "")
        {
            // Declare a frame string
            if (string.IsNullOrEmpty(frames)) frames = $"|   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |\n";
            // Convert the string frames into a character array
            char[] framesArray = frames.ToArray();
            int count = 0;
            string scoreStr = Convert.ToString(score);
            for (int i = 2; i < frames.Length;)
            {
                count++;
                if (numberFrame == count && numberAttempt == 1)
                {
                    if (scoreStr.Length == 1)
                    {
                        framesArray[i] = scoreStr[0];
                    }
                    else if (scoreStr.Length == 2)
                    {
                        framesArray[i] = scoreStr[0];
                        framesArray[i + 1] = scoreStr[1];
                    }
                }
                else
                {
                    i += 4;
                }
                if (numberFrame == count && numberAttempt == 2)
                {
                    if (scoreStr.Length == 1)
                    {
                        framesArray[i] = scoreStr[0];
                    }
                    else if (scoreStr.Length == 2)
                    {
                        framesArray[i] = scoreStr[0];
                        framesArray[i + 1] = scoreStr[1];
                    }
                }
                else
                {
                    i += 4;
                }

                if (numberFrame == 10 && numberAttempt == 3)
                {
                    if (scoreStr.Length == 1)
                    {
                        framesArray[82] = scoreStr[0];
                    }
                    else if (scoreStr.Length == 2)
                    {
                        framesArray[82] = scoreStr[0];
                        framesArray[83] = scoreStr[1];
                    }
                }
            }
            return new string(framesArray);
        }
        
        public string getScoreboardResult(int numberFrame, int score, string frames = "")
        {
            // Declare a frame string
            if (string.IsNullOrEmpty(frames)) frames = $"|       |       |       |       |       |       |       |       |       |           |\n";
            // Convert the string frames into a character array
            char[] framesArray = frames.ToArray();
            int count = 0;
            string scoreStr = Convert.ToString(score);
            for (int i = 4; i < frames.Length; i += 8)
            {
                count++;
                if (numberFrame == count)
                {
                    if (numberFrame > 0 && numberFrame < 10)
                    {
                        if (scoreStr.Length == 1)
                        {
                            framesArray[i] = scoreStr[0];
                        }
                        if (scoreStr.Length == 2)
                        {
                            framesArray[i - 1] = scoreStr[0];
                            framesArray[i] = scoreStr[1];
                        }
                        if (scoreStr.Length == 3)
                        {
                            framesArray[i - 1] = scoreStr[0];
                            framesArray[i] = scoreStr[1];
                            framesArray[i + 1] = scoreStr[2];
                        }
                    }
                    else if (numberFrame == 10)
                    {
                        Console.WriteLine(frames.Length);
                        if (scoreStr.Length == 1)
                        {
                            framesArray[78] = scoreStr[0];
                        }
                        if (scoreStr.Length == 2)
                        {
                            framesArray[78] = scoreStr[0];
                            framesArray[79] = scoreStr[1];
                        }
                        if (scoreStr.Length == 3)
                        {
                            framesArray[77] = scoreStr[0];
                            framesArray[78] = scoreStr[1];
                            framesArray[79] = scoreStr[2];
                        }
                    }
                }
            }
            return new string(framesArray);
        }

        public string printScoreboard(string frames, string totals)
        {
            string scoreboard = 
                $"+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+\n" +
                $"|   1   |   2   |   3   |   4   |   5   |   6   |   7   |   8   |   9   |     10    |\n" +
                $"+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+\n" +
                frames +
                $"+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+\n" +
                totals +
                $"+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+\n";
            Console.WriteLine(scoreboard);
            return scoreboard;
        }
    }
}






























        // public string UpdateScoreboardFrame(int numberFrame, int numberAttempt, int score, string frames = "")
        // {
        //     // Declare a frame string
        //     if (string.IsNullOrEmpty(frames)) frames = $"|   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |\n";
        //     
        //     // Convert the string frames into a character array
        //     char[] framesArray = frames.ToArray();
        //     // Build the score string
        //     string scoreStr = Convert.ToString(score);
        //
        //     // Update the frames based on the frame and attempt numbers
        //     if (numberFrame == 1 && numberAttempt == 1)
        //     {
        //         if (scoreStr.Length == 1)
        //         {
        //             framesArray[2] = scoreStr[0];
        //         }
        //         else if (scoreStr.Length == 2)
        //         {
        //             framesArray[2] = scoreStr[0];
        //             framesArray[3] = scoreStr[1];
        //         }
        //     }
        //     else if (numberFrame == 1 && numberAttempt == 2)
        //     {
        //         if (scoreStr.Length == 1)
        //         {
        //             framesArray[6] = scoreStr[0];
        //         }
        //         else if (scoreStr.Length == 2)
        //         {
        //             framesArray[6] = scoreStr[0];
        //             framesArray[7] = scoreStr[1];
        //         }
        //     }
        //     else if (numberFrame == 2 && numberAttempt == 1)
        //     {
        //         if (scoreStr.Length == 1)
        //         {
        //             framesArray[10] = scoreStr[0];
        //         }
        //         else if (scoreStr.Length == 2)
        //         {
        //             framesArray[10] = scoreStr[0];
        //             framesArray[11] = scoreStr[1];
        //         }
        //     }
        //     else if (numberFrame == 2 && numberAttempt == 2)
        //     {
        //         if (scoreStr.Length == 1)
        //         {
        //             framesArray[14] = scoreStr[0];
        //         }
        //         else if (scoreStr.Length == 2)
        //         {
        //             framesArray[14] = scoreStr[0];
        //             framesArray[15] = scoreStr[1];
        //         }
        //     }
        //     else if (numberFrame == 3 && numberAttempt == 1)
        //     {
        //         if (scoreStr.Length == 1)
        //         {
        //             framesArray[18] = scoreStr[0];
        //         }
        //         else if (scoreStr.Length == 2)
        //         {
        //             framesArray[18] = scoreStr[0];
        //             framesArray[19] = scoreStr[1];
        //         }
        //     }
        //     else if (numberFrame == 3 && numberAttempt == 2)
        //     {
        //         if (scoreStr.Length == 1)
        //         {
        //             framesArray[22] = scoreStr[0];
        //         }
        //         else if (scoreStr.Length == 2)
        //         {
        //             framesArray[22] = scoreStr[0];
        //             framesArray[23] = scoreStr[1];
        //         }
        //     }
        //
        //     // Build a scoreboard
        //     string scoreboard = 
        //         $"+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+\n" +
        //         $"|   1   |   2   |   3   |   4   |   5   |   6   |   7   |   8   |   9   |     10    |\n" +
        //         $"+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+\n" +
        //         new string(framesArray) +
        //         $"+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+\n" +
        //         $"|       |       |       |       |       |       |       |       |       |           |\n" +
        //         $"+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+---+\n";
        //     
        //     // Output the scoreboard to the console
        //     Console.WriteLine(scoreboard);
        //     return new string(framesArray);
        // }