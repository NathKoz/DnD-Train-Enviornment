using System;
using System.Collections.Generic;
#nullable disable

public class UserManager
{
    public Dictionary<string, User> users = new Dictionary<string, User>();

    public UserManager()
    {
        users["Enzo"] = new User("Enzo");
        users["Enzo"].Challenges.Add(new Challenge(
            "In Titanfall 2, I reign supreme,\nA weapon of might, in my owner's dream.\nDual barrels I bear, with a thunderous sound,\nIn close quarters combat, I am renowned.\n\nWith pellets of fury, I strike my foe,\nNo shelter can save them, wherever they go.\nSwift and deadly, my shots never stray,\nGuess my name, in the heat of the fray.\n\nWhat is the first letter of my name?",
            "EVA-8"
        ));
        users["Enzo"].Challenges.Add(new Challenge(
            "Born of ancient magic, with scales that gleam,\nI soar through the skies, a majestic dream.\nWith three heads high, I rule the domain,\nIn the game of shadows, I forever reign.\n\nWhat creature am I?",
            "Blue Eyes White Dragon"
        ));
        users["Enzo"].Challenges.Add(new Challenge(
            "Corn or flour, my base is your choice,\nWith beans, meat, or veggies, I'll make you rejoice.\nServed as an appetizer or a meal that's grand,\n\n",
            "Tostada"
        ));
        users["Enzo"].Challenges.Add(new Challenge(
            "From the shadows I rise, with an undead might,\nIn the realm of duels, I haunt the night.\nWith skeletal hands and eyes glowing red,\nI march from the graveyard, where I once lay dead.\n\nThe first Letter of my name grants you sight:",
            "Zombie"
        ));

        users["Clementine"] = new User("Clementine");
        users["Clementine"].Challenges.Add(new Challenge(
            "In search for the ring of old,\nye tarnished search, young and bold,\nin your quest, your final blockade,\nis the rot in your way\n\n",
            "Melania"
        ));
        users["Clementine"].Challenges.Add(new Challenge(
            "Of my father I am born,\noff to games love and war,\nthe humans worship to my \nnon-existent name, to stay in\nthe fight I shall remain\n\n",
            "Nameless King"
        ));
        users["Clementine"].Challenges.Add(new Challenge(
            "An ancient warrior of steel\nand Ice, not required but\nquite the fight, who am I?\n\n",
            "Hero of Zamor"
        ));
        users["Clementine"].Challenges.Add(new Challenge(
            "In search for the ring, you fight \nthis boss, he proclaims \"I am \nthe last of all KINGS\"\nWho is he? \n\n",
            "Morgott The Omen King"
        ));

        users["Korant"] = new User("Korant");
        users["Korant"].Challenges.Add(new Challenge(
            "In realms where time and circuits blend,\nA race of machines, to no end.\nWith minds of data, they transcend,\nIn Destiny's world, their presence extend.\n\nWhat am I?\n\n",
            "The Vex"
        ));
        users["Korant"].Challenges.Add(new Challenge(
            "A smith, honing his craft,\nignoring the world around him\nhe works to make the purest of Nails\n\n",
            "Nailsmith"
        ));
        users["Korant"].Challenges.Add(new Challenge(
            "A captain on the frontlines\nleading the war to Three Towers\nWho is the commander?\n\n",
            "Captain Droz"
        ));
        users["Korant"].Challenges.Add(new Challenge(
            "In the cosmos vast, where guardians roam,\nAn exotic gear, adding an arrow to the quiver,\nIn all Nightstalker's repertoire, it is well known. \n\nWhat am I?\n\n",
            "Orpheus Rig"
        ));

        users["Radagast"] = new User("Radagast");
        users["Radagast"].Challenges.Add(new Challenge(
            "A space like realm that contains a dragon,\none must conquer to gain flight, Where do I \nspeak of?\n\n",
            "The End"
        ));
        users["Radagast"].Challenges.Add(new Challenge(
            "I make up the air, I am what you breathe,\nyou can light me on fire and watch the blaze,\nWhat element am I?\n\n",
            "Nitrogen"
        ));
        users["Radagast"].Challenges.Add(new Challenge(
            "In the alphabet's embrace, I'm found,\nBut seldom used, my presence renowned.\nAt the end I stand, without a sound,\nA rare sight in words, yet I'm profound.\nWhat am I?\n\n",
            "Z"
        ));
        users["Radagast"].Challenges.Add(new Challenge(
            "A gem of mystery, dark and deep,\nIn obsidian's embrace, secrets keep.\nIn every shard, a story told,\nOf fiery origins, and legends old.\n\n",
            "Obsidian"
        ));

        users["Khana"] = new User("Khana");
        users["Khana"].Challenges.Add(new Challenge(
            "This weapon, electricity harnesses\nUnlocked after death at High Volts\nBlue in color, and pierces through\nanyone in your path\n\n",
            "Electric Railcannon"
        ));
        users["Khana"].Challenges.Add(new Challenge(
            "A Handyman's tool,\nsomething to put things together\nEarned from the beginning \nsunrise in the heart.\nWhat weapon am I?\n\n",
            "Overheat Nailgun"
        ));
        users["Khana"].Challenges.Add(new Challenge(
            "Once alive, but now they're not,\nTheir hunger fierce, their minds forgot.\nA horde of horror, relentless in stride,\nIn the land of the living, they abide.\nWhat are they?\n\n","Zombie"
        ));

    }

}