using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace Y11
{
    class Compilator
    {
        private static string WPath;
        private static string WName;
        private string CILCode;//Об'явлення строки асемблерного коду
        public AST Visitor;//Об'явлення AST
        List<Token> Tokens = new List<Token>();//Список токенів вхідної мови
        StringBuilder ErrorLog = new StringBuilder();//Лог помилок

        //Конструктор
        public Compilator(string a, string b)
        {
            WPath = a;
            WName = b;
            Visitor = new AST(WName);
        }

        //Метод передачі згенерованого коду для подальшої обробки.
        public string GetCode()
        {
            return CILCode;
        }

        //Метод передачі списку помилок для подальшої обробки.
        public string GetErrors()
        {
            return ErrorLog.ToString();
        }

        //Метод передачі списку лексем вхідної мови для подальшої обробки.
        public List<Token> GetTokensList()
        {
            return Tokens;
        }

        //Метод який виконує трансляцію
        public void Compile()
        {
            string inputString = File.ReadAllText(WPath + WName + ".y11"); //Символи вхідної мови
            ANTLRStringStream inputStream = new ANTLRStringStream(inputString); //Створення потоку символів для обробки лексером
            var lexer = new Y11Lexer(inputStream);  //Створення об'єкту лексера і передача потоку на обробку

            //Далі йде перевірка усіх токенів на лексичні помилки і формування списку токенів
            try
            {
                TokensDictionary.Load("../../Grammar/Y11.tokens");
                IToken token;
                token = lexer.NextToken();
                while (token.Type != Y11Lexer.EOF)
                {
                    string st = token.Text;
                    if (token.Type == 38)
                    {
                        token = lexer.NextToken();
                        continue;
                    }
                    else if ((token.Type == 13) && (token.Text.ToString().Length > 6))
                    {
                        ErrorLog.AppendFormat("line {0}:{1} Variable to long\n",
                            token.Line.ToString(), token.CharPositionInLine.ToString());
                        token = lexer.NextToken();
                    }
                    else
                    {
                        Tokens.Add(
                            new Token
                            {
                                Name = TokensDictionary.Dictionary[token.Type],
                                Value = token.Text,
                                Line = token.Line,
                                Column = token.CharPositionInLine
                            });
                        Console.WriteLine(token.Text);
                        token = lexer.NextToken();
                    }
                }
                lexer.Reset();
                lexer.Line = 0;
                lexer.CharPositionInLine = 0;
            }
            catch (MismatchedTokenException e)
            {
                ErrorLog.AppendLine(e.Message.ToString());
            }
            catch (EarlyExitException e)
            {
                ErrorLog.AppendLine(e.Message.ToString());
            }
            
            try
            {
                var tokenStream = new CommonTokenStream(lexer); //Створення потоку токенів після обробки в лексері
                var parser = new Y11Parser(tokenStream);//Передача потоку токенів парсеру і їх обробка

                StringWriter ParcerLog = new StringWriter();
                parser.TraceDestination = ParcerLog;//Створення логу синтаксичних помилок
                var tree = parser.prog().Tree as CommonTree;//Створення дерева синтаксичного розбору
                if (parser.NumberOfSyntaxErrors != 0)
                {
                    ErrorLog.AppendLine(ParcerLog.ToString());//Запис синтаксичних помилок до загального логу
                }
                else
                {
                    CILCode = Visitor.VisitProgram(tree);//Генерація коду
                    if (Visitor.GetErrors().Length != 0)
                    {
                        ErrorLog.AppendLine(Visitor.GetErrors());
                    }
                }
            }
            catch (MismatchedTokenException e)
            {
                ErrorLog.AppendLine(e.Message.ToString());
            }
            catch (EarlyExitException e)
            {
                ErrorLog.AppendLine(e.Message.ToString());
            }
            finally 
            {
                File.WriteAllText(WPath + WName + ".err", ErrorLog.ToString());//Створення файлу помилок і запис
            }
        }
    }
}