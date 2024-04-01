using RealmCraft.CharacterBuilder;
using System;

namespace RealmCraft
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a hero using HeroBuilder
            HeroBuilder heroBuilder = new HeroBuilder();
            CharacterDirector heroDirector = new CharacterDirector(heroBuilder);
            heroDirector.ConstructCharacter();
            Hero hero = heroBuilder.Build();

            // Creating an enemy using EnemyBuilder
            EnemyBuilder enemyBuilder = new EnemyBuilder();
            CharacterDirector enemyDirector = new CharacterDirector(enemyBuilder);
            enemyDirector.ConstructCharacter();
            Enemy enemy = enemyBuilder.Build();

            // Displaying the hero and enemy
            hero.DisplayCharacter();
            Console.WriteLine();
            enemy.DisplayCharacter();
        }
    }

}
