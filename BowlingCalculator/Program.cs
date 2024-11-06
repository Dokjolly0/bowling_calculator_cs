using System.Threading.Channels;
using Microsoft.VisualBasic;
using BowlingCalculator.Function;
using BowlingCalculator.Models;

BowlingScoreboard scoreboard = new BowlingScoreboard();
string frame1_1 = scoreboard.getScoreboardFrame(1, 1, 9);
string frame1_2 = scoreboard.getScoreboardFrame(1, 2, 1, frame1_1);
string resultFrame_1 = scoreboard.getScoreboardResult(1, 100);
scoreboard.printScoreboard(frame1_2, resultFrame_1);

