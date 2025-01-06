using System;

class TextRPG
{
    static void Main()
    {
        Console.WriteLine("🎮 Welcome to the Text-Based RPG Adventure!");
        Console.WriteLine("Choose your hero class:");
        Console.WriteLine("1. 🗡️ Warrior");
        Console.WriteLine("2. 🏹 Archer");
        Console.WriteLine("3. 🧙‍♂️ Mage");
        Console.Write("Your choice (1/2/3): ");

        string choice = Console.ReadLine();
        string heroClass = "";
        int health = 0, attack = 0;

        switch (choice)
        {
            case "1":
                heroClass = "Warrior";
                health = 150;
                attack = 25;
                break;
            case "2":
                heroClass = "Archer";
                health = 100;
                attack = 35;
                break;
            case "3":
                heroClass = "Mage";
                health = 80;
                attack = 50;
                break;
            default:
                Console.WriteLine("Invalid choice. Game over.");
                return;
        }

        Console.WriteLine($"\nWelcome, you have chosen the class: {heroClass}!");
        Console.WriteLine($"Starting stats: Health = {health}, Attack = {attack}");

        Random random = new Random();
        while (health > 0)
        {
            Console.WriteLine("\n👉 What do you want to do?");
            Console.WriteLine("1. 🔍 Explore the world");
            Console.WriteLine("2. ⚔️ Fight a monster");
            Console.WriteLine("3. 🏃 Run away");
            Console.Write("Your choice (1/2/3): ");
            string action = Console.ReadLine();

            if (action == "1")
            {
                Console.WriteLine("🌲 You explore the world and find some gold!");
            }
            else if (action == "2")
            {
                int monsterHealth = random.Next(50, 120);
                int monsterAttack = random.Next(10, 30);
                Console.WriteLine($"👾 A monster attacks you! (Monster's Health: {monsterHealth}, Monster's Attack: {monsterAttack})");

                while (monsterHealth > 0 && health > 0)
                {
                    Console.WriteLine("\n⚔️ Your turn to attack!");
                    monsterHealth -= attack;
                    Console.WriteLine($"The monster takes {attack} damage. Its health is now: {monsterHealth}");

                    if (monsterHealth <= 0)
                    {
                        Console.WriteLine("🎉 You defeated the monster!");
                        break;
                    }

                    Console.WriteLine($"👾 The monster attacks!");
                    health -= monsterAttack;
                    Console.WriteLine($"You take {monsterAttack} damage. Your health is now: {health}");
                }

                if (health <= 0)
                {
                    Console.WriteLine("💀 You died in battle... Game over.");
                    return;
                }
            }
            else if (action == "3")
            {
                Console.WriteLine("🏃 You decided to run away. Sometimes that's the wisest choice!");
            }
            else
            {
                Console.WriteLine("❌ Unknown choice. Try again.");
            }
        }

        Console.WriteLine("💀 Your journey has ended. Thanks for playing!");
    }
}
