using System.Text;
using LeagueOfLegends.Models.Characters;

namespace LeagueOfLegends.Helpers {
    public static class OutputFormatter {
        public static string WriteLine(BaseCharacter character) {
            var sb = new StringBuilder();

            sb.AppendLine($"Tip: {GetType(character)}");
            sb.AppendLine($"İsim: {character.Name}");
            sb.AppendLine($"Sağlık Değeri: {character.HealthPoint}");
            sb.AppendLine($"Atak Gücü: {character.AttachPoint}");

            return sb.ToString();
        }

        private static string GetType(BaseCharacter character) {
            var type = "Tanımsız";

            switch (character) {
                case Warrior _:
                    type = "Savaşçı";
                    break;

                case Mage _:
                    type = "Sihirbaz";
                    break;

                case Support _:
                    type = "Destek";
                    break;
            }

            return type;
        }
    }
}