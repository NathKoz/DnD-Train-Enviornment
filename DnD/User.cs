#nullable disable
using System;
using System.Collections.Generic;
using System.Threading;

public class User
{
    public string Username;
    public List<Challenge> Challenges;

    public User(string username)
    {
        Username = username;
        Challenges = new List<Challenge>();
    }

    public void ListChallenges()
    {
        foreach (Challenge challenge in Challenges)
        {
            Console.WriteLine($"{challenge.Name} - {(challenge.Completed ? "Completed" : "Not Completed")}");
        }
    }

    public void EnterChallenge(string challengeName, ChallengeManager challengeManager)
    {
        Challenge challenge = Challenges.Find(c => c.Name == challengeName);
        if (challenge != null)
        {
            if (!challenge.Completed)
            {
                Console.WriteLine(challengeManager.GetRiddle(Username, challengeName));
            }
            else
            {
                Console.WriteLine("Challenge already completed");
            }
        }
        else
        {
            Console.WriteLine("Challenge not found or already completed");
        }
    }

    public void ExitChallenge()
    {
        Console.WriteLine("Exiting challenge");
    }

    public void Logout()
    {
        Console.WriteLine($"Goodbye, {Username}!");
    }
}
