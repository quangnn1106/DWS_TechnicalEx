using Common.Manipulations;
using Common.Services;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection.Metadata;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManipulateLinesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Exercise1Controller : ControllerBase
    {
        private readonly ITextManipulationFactory _textManipulationFactory;
        private readonly IManipulationService _manipulationService;
        private readonly string inputFile = "./Input/input.txt"; // Hardcoded file paths
        private readonly string sortedFile = "./Output/sorted.txt";
        private readonly string reversedFile = "./Output/reversed.txt";
        private readonly string encryptedFile = "./Output/encrypted.txt";
        private readonly string calculateFile = "./Output/calculate.txt";
        private readonly string sortedRandomFile = "./Output/sortedRandom.txt";
        private readonly string reversedLetterFile = "./Output/reversedLetter.txt";
        private readonly string decryptedFile = "./Output/decrypted.txt";

        public Exercise1Controller(ITextManipulationFactory textManipulationFactory, IManipulationService manipulationService)
        {
            _textManipulationFactory = textManipulationFactory;
            _manipulationService = manipulationService;
        }

        [HttpGet("getSortedDIP")]
        public async Task<IActionResult> GetSortedFile()
        {
            var sortLines = _textManipulationFactory.CreateSortLines();
            await _manipulationService.ApplyManipulationAsync(inputFile, sortedFile, sortLines);

            if (System.IO.File.Exists(sortedFile))
            {
                var result = System.IO.File.ReadAllLines(sortedFile);
                return Ok(result);
            }
            return NotFound("Sorted file not found.");
        }

        [HttpGet("getReversedDIP")]
        public async Task<IActionResult> GetReveredFile()
        {
            var reversedLines = _textManipulationFactory.CreateReverseLines();
            await _manipulationService.ApplyManipulationAsync(inputFile, reversedFile, reversedLines);

            if (System.IO.File.Exists(reversedFile))
            {
                var result = System.IO.File.ReadAllLines(reversedFile);
                return Ok(result);
            }
            return NotFound("Reversed file not found.");
            
        }

        [HttpGet("getEncryptedDIP")]
        public async Task<IActionResult> GetEncrytedFile()
        {
            var encryptedLines = _textManipulationFactory.CreateEncryptLines();
            await _manipulationService.ApplyManipulationAsync(inputFile, encryptedFile, encryptedLines);

            if (System.IO.File.Exists(encryptedFile))
            {
                var result = System.IO.File.ReadAllLines(encryptedFile);
                return Ok(result);
            }
            return NotFound("Encrypted file not found.");

        }

        [HttpGet("getCalculateDIP")]
        public async Task<IActionResult> GetCalculateFile()
        {
            var calculateLines = _textManipulationFactory.CreateCalculateLineLengths();
            await _manipulationService.ApplyManipulationAsync(inputFile, calculateFile, calculateLines);

            if (System.IO.File.Exists(calculateFile))
            {
                var result = System.IO.File.ReadAllLines(calculateFile);
                return Ok(result);
            }
            return NotFound("Calculate file not found.");

        }

        [HttpGet("getSortedRandomDIP")]
        public async Task<IActionResult> GetSortedRandomFile()
        {
            var sortedRandomly = _textManipulationFactory.CreateSortLinesRandomly();
            await _manipulationService.ApplyManipulationAsync(inputFile, sortedRandomFile, sortedRandomly);

            if (System.IO.File.Exists(sortedRandomFile))
            {
                var result = System.IO.File.ReadAllLines(sortedRandomFile);
                return Ok(result);
            }
            return NotFound("Sorted Random File file not found.");

        }

        [HttpGet("getReversedLetterDIP")]
        public async Task<IActionResult> GetReversedLetterFile()
        {
            var reversedLetter = _textManipulationFactory.CreateReverseLetter();
            await _manipulationService.ApplyManipulationAsync(inputFile, reversedLetterFile, reversedLetter);

            if (System.IO.File.Exists(reversedLetterFile))
            {
                var result = System.IO.File.ReadAllLines(reversedLetterFile);
                return Ok(result);
            }
            return NotFound("Reversed File file not found.");

        }

        [HttpGet("getDecryptedDIP")]
        public async Task<IActionResult> GetDecryptedFile()
        {
            var decryptedLines = _textManipulationFactory.CreateDecryptLines();
            await _manipulationService.ApplyManipulationAsync(encryptedFile, decryptedFile, decryptedLines);

            if (System.IO.File.Exists(decryptedFile))
            {
                var result = System.IO.File.ReadAllLines(decryptedFile);
                var original = System.IO.File.ReadAllLines(inputFile);
                bool areMatching = original.SequenceEqual(result);

                return Ok(new { AreMatching = areMatching, Original = original, DataDecrypt = result });
            }
            return NotFound("Decrypted File file not found.");

        }

    }
}
