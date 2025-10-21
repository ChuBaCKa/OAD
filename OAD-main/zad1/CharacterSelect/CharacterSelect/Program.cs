using CharacterSelect.Application.Factory;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect
{
    public static class Program
    {
        public static void Main()
        {
            Console.Title = "Character Select";
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== WYBÓR POSTACI ===");
                Console.WriteLine("1) Chieftain");
                Console.WriteLine("2) Mage");
                Console.WriteLine("3) Rogue");
                Console.WriteLine("4) Succubus");
                Console.WriteLine("5) Neko");
                Console.WriteLine("6) Battle Maid");
                Console.WriteLine("7) Bunny Girl");
                Console.WriteLine("0) Close");
                Console.Write("Select charactor [0-7]: ");
                var input = Console.ReadLine();
                if (input == "0") break;

                if (!int.TryParse(input, out var choice) || choice < 1 || choice > 7)
                {
                    Pause("Niepoprawny wybór. Naciśnij Enter…");
                    continue;
                }

                var cls = (CharacterClass)choice;

                Console.Write("Podaj imię postaci (Enter = domyślne): ");
                var name = Console.ReadLine();

                var character = CharacterFactory.Create(cls, name);

                Console.Clear();
                Console.WriteLine(">>> Utworzono postać!");
                character.Describe();

                Console.WriteLine("\nAkcja: atak");
                character.Attack();
                
                Console.WriteLine("Akcja: umiejętność specjalna");
                character.UseSpecial();

                Console.WriteLine("\nChcesz utworzyć kolejną postać? (t/n): ");
                var again = (Console.ReadLine() ?? "").Trim().ToLowerInvariant();
                if (again != "t" && again != "tak") break;
            }

            Console.WriteLine("\nDzięki za grę! Do zobaczenia 👋");
        }

        private static void Pause(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadLine();
        }
    }
}