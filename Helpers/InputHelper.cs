using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Helpers
{
    public static class InputHelper
    {
        public static async Task<string[]> GetInputs(int day, int? part = null, bool? example = false)
        {
            var path = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                INPUTS_FOLDER_NAME, 
                GetInputFilename(day, part, example)
            );
            return await File.ReadAllLinesAsync(path, Encoding.UTF8);
        }

        public static string GetInputFilename(int day, int? part, bool? example)
        {
            var parts = new[]
            {
                $"Day{day}",
                (part.HasValue ? $"Part{part}" : string.Empty),
                (example.HasValue && example.Value ? "_ex" : string.Empty),
                ".txt"
            };

            return string.Concat(parts);
        }

        private static string INPUTS_FOLDER_NAME = "Inputs";
    }
}
