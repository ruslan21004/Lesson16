using System;

namespace Homework16
{
    class Program
    {
        static void Main(string[] args)
        {
            Topic topic = new Topic();
            Console.WriteLine(topic.topic("Тема голосования " + " "));

            Voting voting = new Voting();
            voting.voting();
        }
    }

    class Topic
    {
        public string topic(string message)
        {
            Console.WriteLine("Напишите тему голосования");
            string voteTopic = Console.ReadLine();
            return message + voteTopic;
        }
    }

    class Voting
    {
        public void voting()
        {
            Console.WriteLine("\nСделайте выбор, напишите да или нет");
            List<string> votingList = new List<string> { };
            votingList.Add(Console.ReadLine());
            if (votingList.Contains("Да"))
            {
                Console.WriteLine("Голосование окончено, решение сделано");
            }
            else
            {
                Console.WriteLine("Голосование окончено, решение не сделано");
            }
        }
    }
}