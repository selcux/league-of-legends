using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeagueOfLegends.Models.Characters;

namespace LeagueOfLegends.Helpers {
    public static class OutputFormatter {
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

        public static string CharacterToString(BaseCharacter character) {
            var sb = new StringBuilder();

            sb.AppendLine($"Tip: {GetType(character)}");
            sb.AppendLine($"İsim: {character.Name}");
            sb.AppendLine($"Sağlık Değeri: {character.HealthPoint}");
            sb.AppendLine($"Atak Gücü: {character.AttachPoint}");

            return sb.ToString();
        }

        public static string CharactersToString(IEnumerable<BaseCharacter> characters) {
            const string separator = "-------------------------";
            var sb = new StringBuilder();
            var index = 1;

            foreach (var character in characters) {
                sb.AppendLine($"{index}.");
                sb.Append(CharacterToString(character));
                sb.AppendLine(separator);
                ++index;
            }

            return sb.ToString();
        }
    }
}