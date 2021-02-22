using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (info[0] != "Tournament")
            {
                string trainerName = info[0];
                string pokemonName = info[1];
                string pokemonElement = info[2];
                int pokemonHealth = int.Parse(info[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainers.ContainsKey(trainerName))
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainerName, trainer);
                }
                else
                {
                    trainers[trainerName].Pokemons.Add(pokemon);
                }

                info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            string elementToFind = Console.ReadLine();

            while (elementToFind != "End")
            {
                foreach (var currenttrainer in trainers)
                {
                    bool elementFound = false;

                    for (int i = 0; i < currenttrainer.Value.Pokemons.Count; i++)
                    {
                        if (currenttrainer.Value.Pokemons[i].Element == elementToFind)
                        {
                            currenttrainer.Value.Badges++;
                            elementFound = true;
                            break;
                        }
                    }

                    if (!elementFound)
                    {
                        for (int i = 0; i < currenttrainer.Value.Pokemons.Count; i++)
                        {
                            currenttrainer.Value.Pokemons[i].Health -= 10;

                            if (currenttrainer.Value.Pokemons[i].Health <= 0)
                            {
                                currenttrainer.Value.Pokemons.Remove(currenttrainer.Value.Pokemons[i]);
                            }
                        }
                    }
                }

                elementToFind = Console.ReadLine();
            }

            foreach (var currentTrainer in trainers.OrderByDescending(x => x.Value.Badges))
            {
                Console.WriteLine($"{currentTrainer.Key} {currentTrainer.Value.Badges} {currentTrainer.Value.Pokemons.Count}");
            }
        }
    }
}
