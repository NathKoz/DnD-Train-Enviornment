#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;

public class ChallengeManager
{
    public Dictionary<string, Dictionary<string, string>> challenges;

    public ChallengeManager(Dictionary<string, User> users)
    {
        InitializeChallenges(users);
    }

    public void InitializeChallenges(Dictionary<string, User> users)
    {
        challenges = new Dictionary<string, Dictionary<string, string>>();
        foreach (var user in users)
        {
            var userChallenges = new Dictionary<string, string>();
            foreach (var challenge in user.Value.Challenges)
            {
                userChallenges[challenge.Name] = challenge.Answer;
            }
            challenges[user.Key] = userChallenges;
        }
    }


}


