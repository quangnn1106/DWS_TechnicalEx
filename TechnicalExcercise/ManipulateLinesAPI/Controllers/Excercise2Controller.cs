using Common;
using Common.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Extensions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManipulateLinesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Excercise2Controller : ControllerBase
    {
        private readonly IRandomService _randomService;
        private readonly IManipulationService _manipulationService;
        private readonly ITextManipulationFactory _textManipulationFactory;
        private readonly string inputFile = "./Input/input.txt";
        private readonly string sortedFile = "./Output/sorted.txt";
        private readonly string reversedFile = "./Output/reversed.txt";
        private readonly string encryptedFile = "./Output/encrypted.txt";
        private readonly string calculateFile = "./Output/calculate.txt";

        public Excercise2Controller(IRandomService randomService, IManipulationService manipulationService, ITextManipulationFactory textManipulationFactory)
        {
            _randomService = randomService;
            _manipulationService = manipulationService;
            _textManipulationFactory = textManipulationFactory;
        }
        [HttpGet("random-number")]
        public IActionResult GetRandomNumber()
        {
            var randomNumber = _randomService.GetRandomNumber(1, 37);
            return Ok(randomNumber);
        }

        [HttpGet("random-word")]
        public IActionResult GetRandomWord()
        {
            var randomWord = _randomService.GetRandomWord(inputFile);
            return Ok(randomWord);
        }


        [HttpGet("random-manipulation")]
        public async Task<IActionResult> GetRandomManipulation()
        {
            Array values = Enum.GetValues(typeof(Utils.Manipulate));
            Random random = new();
            object? randomValue = values.GetValue(random.Next(values.Length));

            if (randomValue is Utils.Manipulate manipulate)
            {
                var result = Array.Empty<string>();
                string filePath;
                ITextManipulation textManipulation;

                switch (manipulate)
                {
                    case Utils.Manipulate.Sort:
                        textManipulation = _textManipulationFactory.CreateSortLines();
                        filePath = sortedFile;
                        break;
                    case Utils.Manipulate.Reversed:
                        textManipulation = _textManipulationFactory.CreateReverseLines();
                        filePath = reversedFile;
                        break;
                    case Utils.Manipulate.Encrypted:
                        textManipulation = _textManipulationFactory.CreateEncryptLines();
                        filePath = encryptedFile;
                        break;
                    case Utils.Manipulate.CalculatorLength:
                        textManipulation = _textManipulationFactory.CreateCalculateLineLengths();
                        filePath = calculateFile;
                        break;
                    default:
                        return BadRequest("Invalid manipulation type.");
                }

                await _manipulationService.ApplyManipulationAsync(inputFile, filePath, textManipulation);
                result = System.IO.File.ReadAllLines(filePath);

                return Ok(new { Service = manipulate.GetDisplayName(), Data = result });
            }
            else
            {
                return StatusCode(500, "An error occurred while selecting a manipulation type.");
            }

        }
    }
}
