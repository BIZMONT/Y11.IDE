using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Antlr.Runtime.Tree;

namespace Y11
{
    class AST
    {
        private string AName;
        private int CycleCounter = 0;//Змінна для підрахунку кількості циклів в програмі (для створення міток)
        private StringBuilder program = new StringBuilder();//Тут зберігатиметься тіло асемблерної програми
        private StringBuilder methodBody = new StringBuilder();//Сюди заноситимуться асемблерні коди операцій
        private SortedSet<string> Variables = new SortedSet<string>();//Таблиця ідентифікаторів
        private StringBuilder err = new StringBuilder();//Лог семантичних помилок

        public AST(string a)
        {
            AName = a;
        }

        //Метод для передачі списку помилок
        public string GetErrors()
        {
            return err.ToString();
        }

        //Даний метод розпочинає обхід AST з кореня
        public string VisitProgram(CommonTree tree)
        {
            //Початок обходу дітей кореневого вузла
            foreach (CommonTree node in tree.Children.OfType<CommonTree>())
            {
                switch (node.Type)
                {
                    case Y11Parser.BECOMES:
                        this.VisitAssign(node);//Якщо операція присвоєння
                        break;

                    case Y11Parser.GET:
                        this.VisitInput(node);//Якщо операція вводу
                        break;

                    case Y11Parser.PUT:
                        this.VisitOutput(node);//Якщо операція виводу
                        break;

                    case Y11Parser.VAR:
                        this.VisitInit(node);//Якщо оголошення змінних
                        break;

                    case Y11Parser.REP:
                        this.VisitCycle(node);//Якщо початок циклу
                        break;

                    default:
                        break;
                }
            }

            program.AppendFormat(".assembly {0} ", AName);
            program.AppendLine("{}");
            program.AppendLine(".assembly extern mscorlib {}");
            program.AppendLine(".method static void main()");
            program.AppendLine("{");
            program.AppendLine(".entrypoint");
            program.AppendLine(".maxstack 100");

            if (this.Variables.Count > 0)
            {
                string variableString = "int32 " + this.Variables.First();
                foreach (string name in this.Variables.Skip(1))
                {
                    variableString += ", int32 " + name;
                }

                program.AppendFormat(".locals init ({0}) \n", variableString);
            }

            program.Append(this.methodBody.ToString());
            program.AppendLine("call string [mscorlib]System.Console::ReadLine()");
            program.AppendLine("ret");
            program.AppendLine("}");
            return program.ToString();
        }

        //Генерація коду операції присвоєння
        void VisitAssign(CommonTree tree)
        {
            if (!this.Variables.Contains(((CommonTree)tree.GetChild(0)).Text))
            {
                err.AppendFormat("line {0}:{1} The variable {2} is being used without being initialized\n",
                    tree.Token.Line.ToString(), tree.Token.CharPositionInLine.ToString(),
                    tree.GetChild(0).Text.ToString());
            }
            else
            {
                var variable = ((CommonTree)tree.GetChild(0)).Text;
                var expression = tree.GetChild(1) as CommonTree;

                this.VisitExpression(expression);
                this.methodBody.AppendFormat("stloc {0} \n", variable);
            }
        }

        //Генерація коду операції виводу
        void VisitOutput(CommonTree tree)
        {
            foreach (CommonTree node in tree.Children.OfType<CommonTree>())
            {
                if (node.Token.Type == 35)
                {
                    this.methodBody.AppendFormat("ldstr {0}\n", node.Token.Text);
                    this.methodBody.AppendLine("call void [mscorlib]System.Console::Write(string)");
                }
                else if (!this.Variables.Contains(node.Token.Text))
                {
                    err.AppendFormat("line {0}:{1} The variable {2} is being used without being initialized\n",
                        tree.Token.Line.ToString(), tree.Token.CharPositionInLine.ToString(),
                        node.Token.Text.ToString());
                }
                else
                {
                    this.methodBody.AppendFormat("ldloc {0}\n", node.Token.Text);
                    this.methodBody.AppendLine("call void [mscorlib]System.Console::Write(int32)");
                }
            }
            this.methodBody.AppendLine("call void [mscorlib]System.Console::WriteLine()");
        }

        //Генерація коду операції вводу
        void VisitInput(CommonTree tree)
        {
            if (this.Variables.Contains(((CommonTree)tree.GetChild(0)).Text))
            {
                this.methodBody.AppendLine("call string [mscorlib]System.Console::ReadLine()");
                this.methodBody.AppendLine("call int32 [mscorlib]System.Int32::Parse(string)");
                this.methodBody.AppendFormat("stloc {0} \n", ((CommonTree)tree.GetChild(0)).Text);
            }
            else
            {
                err.AppendFormat("line {0}:{1} The variable {2} is being used without being initialized\n",
                  tree.Token.Line.ToString(), tree.Token.CharPositionInLine.ToString(),
                  tree.GetChild(0).Text.ToString());
            }
          
        }

        //Генерація коду виразів
        void VisitExpression(CommonTree tree)
        {
            switch (tree.Type)
            {
                case Y11Parser.PLUS:
                case Y11Parser.MINUS:
                case Y11Parser.MUL:
                case Y11Parser.DIV:
                case Y11Parser.MOD:
                case Y11Parser.AND:
                case Y11Parser.OR:
                    this.VisitBinaryOperation(tree);
                    break;

                case Y11Parser.NOT:
                    this.VisitNotOperation(tree);
                    break;

                case Y11Parser.NUMBER:
                    try
                    {
                        Convert.ToInt32(tree.Token.Text);
                    }
                    catch (IndexOutOfRangeException  e)
                    {
                        err.AppendFormat("line {0}:{1} {2}",
                            tree.Token.Line.ToString(), tree.Token.CharPositionInLine.ToString(),
                            e.Message.ToString());
                    }
                    catch (OverflowException e)
                    {
                        err.AppendFormat("line {0}:{1} {2}",
                            tree.Token.Line.ToString(), tree.Token.CharPositionInLine.ToString(),
                            e.Message.ToString());
                    }
                        this.methodBody.AppendFormat("ldc.i4 {0} \n", tree.Token.Text);
                    break;

                case Y11Parser.ID:
                    if (this.Variables.Contains(tree.Token.Text))
                    {
                        this.methodBody.AppendFormat("ldloc {0}\n", tree.Token.Text);
                        break;
                    }
                    else
                    {
                        err.AppendFormat("line {0}:{1} The variable {2} is being used without being initialized\n",
                            tree.Token.Line.ToString(), tree.Token.CharPositionInLine.ToString(),
                            tree.Token.Text.ToString());
                        break;
                    }

                default:
                    break;
            }
        }

        //Генерація коду бінарних операцій
        void VisitBinaryOperation(CommonTree tree)
        {
            this.VisitExpression(tree.GetChild(0) as CommonTree);
            this.VisitExpression(tree.GetChild(1) as CommonTree);

            switch (tree.Type)
            {
                case Y11Parser.PLUS:
                    this.methodBody.AppendLine("add");
                    break;

                case Y11Parser.MINUS:
                    this.methodBody.AppendLine("sub");
                    break;

                case Y11Parser.MUL:
                    this.methodBody.AppendLine("mul");
                    break;

                case Y11Parser.DIV:
                    this.methodBody.AppendLine("div");
                    break;

                case Y11Parser.MOD:
                    this.methodBody.AppendLine("rem");
                    break;

                case Y11Parser.AND:
                    this.methodBody.AppendLine("and");
                    break;

                case Y11Parser.OR:
                    this.methodBody.AppendLine("or");
                    break;
            }
        }

        //Генерація коду операції інверсії
        void VisitNotOperation(CommonTree tree)
        {
            this.VisitExpression(tree.GetChild(0) as CommonTree);

            switch (tree.Type)
            {
                case Y11Parser.NOT:
                    this.methodBody.AppendLine("not");
                    break;
            }
        }

        //Генерація коду оголошення змінних
        void VisitInit(CommonTree tree)
        {
            for (int i = 0; i < tree.ChildCount; i++)
            {
                this.Variables.Add(((CommonTree)tree.GetChild(i)).Text);
            }
        }

        //Генерація коду циклу
        void VisitCycle(CommonTree tree)
        {
            this.methodBody.AppendFormat("loop_{0}:\n", CycleCounter);

            //Обхід дітей для визначення типу операції в циклі
            foreach (CommonTree node in tree.Children.OfType<CommonTree>())
            {
                switch (node.Type)
                {
                    case Y11Parser.BECOMES:
                        this.VisitAssign(node);
                        break;

                    case Y11Parser.GET:
                        this.VisitInput(node);
                        break;

                    case Y11Parser.PUT:
                        this.VisitOutput(node);
                        break;

                    case Y11Parser.REP:
                        CycleCounter++;
                        this.VisitCycle(node);
                        break;

                    case Y11Parser.UNT:
                        this.VisitBool(node.GetChild(0) as CommonTree);
                        CycleCounter++;
                        break;

                    default:
                        Console.WriteLine("Error in cycle node!");
                        break;
                }
            }
        }

        //Генерація коду операцій порівняння
        void VisitBool(CommonTree tree)
        {
            this.VisitExpression(tree.GetChild(0) as CommonTree);
            this.VisitExpression(tree.GetChild(1) as CommonTree);

            switch (tree.Type)
            {
                case Y11Parser.EQL: //Якщо рівне
                    this.methodBody.AppendFormat("beq loop_{0}\n", CycleCounter);
                    break;
                case Y11Parser.LEQ://Якщо менше або рівне
                    this.methodBody.AppendFormat("ble loop_{0}\n", CycleCounter);
                    break;
                case Y11Parser.GEQ://Якщо більше або рівне
                    this.methodBody.AppendFormat("bge loop_{0}\n", CycleCounter);
                    break;
                case Y11Parser.NEQ://Якщо не рівне
                    this.methodBody.AppendFormat("ceq\nbrfalse loop_{0}\n", CycleCounter);
                    break;

                default:
                    Console.Write("Non condition");
                    break;
            }
        }
    }
}