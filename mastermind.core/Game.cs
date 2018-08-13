using System;
using System.Collections.Generic;
using System.Linq;

namespace Mastermind
{
    public class Game
    {
        private readonly int[] code;

        public Game(ICodeGenerator codeGenerator)
        {
            code = codeGenerator.Generate();
        }

        public AttemptResult Guess(int[] attempt)
        {
            throw new NotImplementedException();
        }
    }
}
