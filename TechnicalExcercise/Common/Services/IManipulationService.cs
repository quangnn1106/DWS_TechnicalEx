﻿using Common.Manipulations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Services
{
    public interface IManipulationService
    {
        Task ApplyManipulationAsync(string inputFile, string outputFile, ITextManipulation manipulation);
    }
}
