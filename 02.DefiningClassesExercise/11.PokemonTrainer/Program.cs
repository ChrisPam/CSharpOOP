using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var trainers = new Dictionary<string, Trainer>();
            while (input[0].ToLower() != "tournament")
            {
                var trainerName = input[0];
                var pokemonName = input[1];
                var pokemonElement = input[2];
                var pokemonHealth = int.Parse(input[3]);

                var pokemons = new List<Pokemon>();
                pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                
                if (!trainers.ContainsKey(trainerName))
                {
                    trainers[trainerName] = new Trainer(trainerName, 0, new List<Pokemon>());
                }
                foreach (Pokemon pokemon in pokemons)
                {
                    trainers[trainerName].pokemons.Add(pokemon);
                }


                input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            while (command[0].ToLower() != "end")
            {
                foreach (Trainer trainer in trainers.Values)
                {
                    var hasPokemon = false;
                    foreach (Pokemon pokemon in trainer.pokemons)
                    {
                        if (pokemon.element == command[0])
                        {
                            hasPokemon = true;
                            break;
                        }
                    }
                    if (hasPokemon)
                    {
                        trainer.badges++;
                        break;
                    }
                    else
                    {
                        foreach (Pokemon pokemon in trainer.pokemons)
                        {
                            pokemon.health -= 10;
                        }

                        trainer.pokemons = trainer.pokemons.Where(p => p.health > 0).ToList();
                    }
                }


                command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (Trainer trainer in trainers.Values.OrderByDescending(t => t.badges))
            {
                Console.WriteLine($"{trainer.name} {trainer.badges} {trainer.pokemons.Count}");
            }
        }
    }
}
