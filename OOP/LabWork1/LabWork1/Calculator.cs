using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LabWork1
{
     public class Calculator
    {
        public static double Evaluate(string expression)
        {
            var lexer = new CustomGrammarLexer(new AntlrInputStream(expression));
            lexer.RemoveErrorListeners();
            lexer.AddErrorListener(new ThrowExceptionErrorListener());

            var tokens = new CommonTokenStream(lexer);
            var parser = new CustomGrammarParser(tokens);

            var tree = parser.compileUnit();
            var visitor = new LabCalculatorVisitor();

            return visitor.Visit(tree);
        }

    }
}
