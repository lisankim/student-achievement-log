using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace student_achievement_log.Classes
{
    public class hundredWaysToSayVeryGood
    {
        public List<string> pastList = new List<string>();
        public List<string> list { get; set; } = new List<string>();

        public hundredWaysToSayVeryGood()
        {
            list.Add("You're on the right track now!");
            list.Add("You're doing a good job!");
            list.Add("You're on the right track now!");
            list.Add("GOOD WORK!");
            list.Add("That's coming along!");
            list.Add("GREAT!");
            list.Add("I'm proud of the way you worked today!");
            list.Add("You're really working hard today!");
            list.Add("Exactly right!");
            list.Add("Super!");
            list.Add("You got it made!");
            list.Add("That's Right!!!");
            list.Add("You've just about got it!");
            list.Add("Congratulations!");
            list.Add("You are very good at that!");
            list.Add("That's very much better!");
            list.Add("I'm happy to see you working like that!");
            list.Add("You're doing much better today!");
            list.Add("Now you have it!");
            list.Add("Now you've figured it out!");
            list.Add("That's it!");
            list.Add("Not bad!");
            list.Add("That's the best you have ever done!");
            list.Add("You're learning fast!");
            list.Add("Great!");
            list.Add("Good for you!");
            list.Add("Keep working on it, you're getting better!");
            list.Add("I knew you could do it!");
            list.Add("That's quite an improvement!");
            list.Add("That's good!");
            list.Add("Couldn't have done it better myself!");
            list.Add("You're getting better everyday!");
            list.Add("You did it that time!");
            list.Add("That's not half bad!");
            list.Add("One more time and you'll have it!");
            list.Add("That's the right way to do it!");
            list.Add("You really made my job fun!");
            list.Add("You make it look easy!");
            list.Add("That's the way!");
            list.Add("WOW!");
            list.Add("That's the way to do it!");
            list.Add("Keep up the good work!");
            list.Add("You haven't missed a thing!");
            list.Add("Nice going!");
            list.Add("Now you've figured it out!");
            list.Add("Sensational!");
            list.Add("That's better!");
            list.Add("Nothing can stop you now!");
            list.Add("EXCELLENT!");
            list.Add("PERFECT!");
            list.Add("That's the best ever!");
            list.Add("FINE!");
            list.Add("TERRIFIC!");
            list.Add("You've got your brain in gear today!");
            list.Add("That was first class work!");
            list.Add("WONDERFUL!");
            list.Add("Much better!");
            list.Add("You've just about mastered that!");
            list.Add("That's better than ever!");
            list.Add("Nice going!");
            list.Add("You're really going to town!");
            list.Add("OUTSTANDING!");
            list.Add("Now that's what I call a fine job!");
            list.Add("That's great!");
            list.Add("You did that very well!");
            list.Add("You must have been practicing!");
            list.Add("TREMENDOUS!");
            list.Add("Superb!");
            list.Add("You're really improving!");
            list.Add("You're doing beautifully!");
            list.Add("Way to go!");
            list.Add("FANTASTIC!");
            list.Add("Keep it up!");
            list.Add("You've got that down pat!");
            list.Add("You did a lot of work today!");
            list.Add("Congratulations!");
            list.Add("Right on!");
            list.Add("Good remembering!");
            list.Add("You certainly did well today!");
            list.Add("Keep on trying!");
            list.Add("You outdid yourself today!");
            list.Add("Good for you!");
            list.Add("MARVELOUS!");
            list.Add("I'm very proud of you!");
            list.Add("That's IT!");
            list.Add("I like that!");
            list.Add("I think you've got it now!");
            list.Add("Good job!");
            list.Add("You figured that out fast!");
            list.Add("You have the hang of it!");
            list.Add("Good going!");
            list.Add("Well look at you go!");
            list.Add("Pleasure to teach when you work like that!");
            list.Add("You're very hardworking!");
            list.Add("Amazing job!");
            list.Add("You remembered!");
            list.Add("That's really nice!");
            list.Add("You are really learning a lot!");
            list.Add("Good thinking!");
            list.Add("You're doing fine!");
            list.Add("I've never seen anyone do it better!");
            list.Add("You're doing a wonderful job!");
            list.Add("You're understanding it well!");
        }
        public string GetRandomAffirmation()
        {
            Random rando = new Random();
            int randomIndex = rando.Next(0, list.Count);
            if (pastList.Count == list.Count)
            {
                pastList.Clear();
            }
            while (pastList.Contains(list[randomIndex]))
            {
                randomIndex = rando.Next(0, list.Count);
            }
            pastList.Add(list[randomIndex]);
            return list[randomIndex];
        }

        public void MachineAuditFile(string log)
        {
            string directory = Environment.CurrentDirectory;
            string fileName = "practiceLog.txt";
            string fullPath = Path.Combine(directory, fileName);

            using (StreamWriter sw = new StreamWriter(fullPath, true))
            {
                sw.WriteLine(log);
            }
        }


    }
}
