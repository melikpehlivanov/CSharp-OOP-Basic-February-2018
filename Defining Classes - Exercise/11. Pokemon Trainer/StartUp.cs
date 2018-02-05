namespace _11.Pokemon_Trainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var trainers = new List<Trainer>();

            while (input != "Tournament")
            {
                var pokemonAndTrainerInfo = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string trainerName = pokemonAndTrainerInfo[0];
                string pokemonName = pokemonAndTrainerInfo[1];
                string pokemonElement = pokemonAndTrainerInfo[2];
                int pokemonHealth = int.Parse(pokemonAndTrainerInfo[3]);

                var trainer = trainers.FirstOrDefault(t => t.Name == trainerName);

                if (trainer == null)
                {
                    trainer = new Trainer(trainerName);
                    trainers.Add(trainer);
                }
                trainer.Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));

                input = Console.ReadLine();
            }

            string commands = Console.ReadLine();

            while (commands != "End")
            {
                trainers.Where(t => t.Pokemons.Any(p => p.Element == commands))
                    .ToList()
                    .ForEach(t => t.Badges++);

                var nonMatchingTrainers = trainers.Where(t => t.Pokemons.All(p => p.Element != commands));

                foreach (var nonMatchingTrainer in nonMatchingTrainers)
                {
                    nonMatchingTrainer.Pokemons.ForEach(p => p.Health -= 10);
                   nonMatchingTrainer.Pokemons = nonMatchingTrainer.Pokemons
                        .Where(p => p.Health > 0)
                        .ToList();
                }


                commands = Console.ReadLine();
            }

            trainers.OrderByDescending(t=> t.Badges)
                .ToList()
                .ForEach(t=> Console.WriteLine(t.ToString()));
        }
    }
}
