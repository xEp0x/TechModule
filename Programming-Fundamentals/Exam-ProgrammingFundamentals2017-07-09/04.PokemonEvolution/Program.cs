using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PokemonEvolution
{
    class PokemonEvolutionTypeIndex
    {
        static void Main(string[] args)
        {
            //{pokemonName} -> {evolutionType} -> {evolutionIndex}
            //The pokemonName and evolutionType are strings which may contain any ASCII character (except ‘-’, ‘ ’, ‘>’).
            var inputLine = Console.ReadLine();
            Dictionary<string, List<PokemonEvolution>> allPokemons = new Dictionary<string, List<PokemonEvolution>>();

            while (inputLine != "wubbalubbadubdub")
            {
                var splitedInput = inputLine
                    .Split(new char[] { '-', ' ', '>', }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(e => e.Trim()).ToArray();

                var pokemonName = splitedInput.First();

                if (splitedInput.Length == 1)
                {
                    if (!allPokemons.ContainsKey(pokemonName))
                    {
                        inputLine = Console.ReadLine();
                        continue;
                    }

                    //print currentpokem evolution

                    var searchedPokemonName = pokemonName;
                    var searchedPokemonEvolution = allPokemons[pokemonName];

                    Console.WriteLine($"# {searchedPokemonName}");

                    foreach (var pokemonEvol in searchedPokemonEvolution)
                    {
                        Console.WriteLine($"{pokemonEvol.EvolutionType} <-> {pokemonEvol.EvolutionIndex}");
                    }

                    inputLine = Console.ReadLine();
                    continue;
                }

                var pokemonEvolType = splitedInput[1];
                var pokemonEvolIndex = int.Parse(splitedInput.Last());

                if (!allPokemons.ContainsKey(pokemonName))
                {
                    allPokemons[pokemonName] = new List<PokemonEvolution>();
                }

                var currentPokemonEvolution = new PokemonEvolution
                {
                    EvolutionType = pokemonEvolType,
                    EvolutionIndex = pokemonEvolIndex
                };

                allPokemons[pokemonName].Add(currentPokemonEvolution);

                inputLine = Console.ReadLine();
            }

            foreach (var pokemon in allPokemons)
            {
                var currentPokemonName = pokemon.Key;
                var currentPokemonEvolution = pokemon.Value;

                Console.WriteLine($"# {currentPokemonName}");

                foreach (var pokemonEvol in currentPokemonEvolution.OrderByDescending(p => p.EvolutionIndex))
                {
                    var currentType = pokemonEvol.EvolutionType;
                    var currentIndex = pokemonEvol.EvolutionIndex;
                    Console.WriteLine($"{currentType} <-> {currentIndex}");
                }
            }

            Console.WriteLine();
        }
    }

    public class PokemonEvolution
    {
        public string EvolutionType { get; set; }

        public int EvolutionIndex { get; set; }
    }
}
