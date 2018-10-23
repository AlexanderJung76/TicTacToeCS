using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCS
{
    class Program
    {
        static char[] feld = new char[9]  { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        static char[] spielmarke = new char[2]  { 'X', 'O' };
        static ConsoleColor temp = Console.ForegroundColor;
        

        static void Main(string[] args)
        {
            int aktSpieler = 0, spielzug = 0;
            do
            {
                Zeigespielplan(aktSpieler);
                Aktspielzug(aktSpieler);
                if (Pruefegewinn() == 1) break;
                if (aktSpieler == 0) aktSpieler = 1;
                else aktSpieler = 0;
                spielzug++;
            } while (spielzug < 9);
            Zeigespielplan(aktSpieler);
            if (spielzug < 9) Console.WriteLine("Spieler {0} hat gewonnen !\n\nZum beenden Enter Druecken.", aktSpieler + 1);
            else Console.WriteLine("Unentschieden! ;)\n\nZum beenden Enter Druecken.");

            Console.ReadLine();
            
        }

        static void Spielerfarbe(char spielmarke)
        {
            switch(spielmarke)
            {
                case 'X':
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 'O':
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default:
                    Console.ForegroundColor = temp;
                    break;
            }
            return;
        }

        static void Zeigespielplan(int spieler)
        {

            Console.Clear();     // Console.Funktion() zum löschen des Screens
            Console.Write(" ***************\n");
            Console.Write(" * Tic Tac Toe *\n");
            Console.Write(" ***************\n");
            Console.Write("      |   |   \n");
            Console.Write("    ");
            Spielerfarbe(feld[0]);
            Console.Write("{0}",feld[0]);
            Spielerfarbe('|');
            Console.Write(" | ");
            Spielerfarbe(feld[1]);
            Console.Write("{0}",feld[1]);
            Spielerfarbe('|');
            Console.Write(" | ");
            Spielerfarbe(feld[2]);
            Console.Write("{0}",feld[2]);
            Spielerfarbe('|');
            Console.Write(" 			 1 | 2 | 3 \n");
            Console.Write("      |   |   \n");
            Console.Write("   ---|---|---\n");
            Console.Write("      |   |   \n");
            Console.Write("    ");
            Spielerfarbe(feld[3]);
            Console.Write("{0}", feld[3]);
            Spielerfarbe('|');
            Console.Write(" | ");
            Spielerfarbe(feld[4]);
            Console.Write("{0}", feld[4]);
            Spielerfarbe('|');
            Console.Write(" | ");
            Spielerfarbe(feld[5]);
            Console.Write("{0}", feld[5]);
            Spielerfarbe('|');
            Console.Write(" 			 4 | 5 | 6 \n");
            Console.Write("      |   |   \n");
            Console.Write("   ---|---|---\n");
            Console.Write("      |   |   \n");
            Console.Write("    ");
            Spielerfarbe(feld[6]);
            Console.Write("{0}", feld[6]);
            Spielerfarbe('|');
            Console.Write(" | ");
            Spielerfarbe(feld[7]);
            Console.Write("{0}", feld[7]);
            Spielerfarbe('|');
            Console.Write(" | ");
            Spielerfarbe(feld[8]);
            Console.Write("{0}", feld[8]);
            Spielerfarbe('|');
            Console.Write(" 			 7 | 8 | 9 \n");
            Console.Write("      |   |   \n");

            return;
        }

        static int Checkspielzug(int feldnummer, int spieler)
        {
            if (feld[feldnummer - 1] != ' ') return 1;
            feld[feldnummer - 1] = spielmarke[spieler];
            return 0;
        }

        static void Aktspielzug(int spieler)
        {
            int selectfeld = 0, spielzugOK = 0;
            char spielerMark = '0';
            if (spieler == 0) spielerMark = spielmarke[0];
            else spielerMark = spielmarke[1];
            Console.WriteLine("Spieler {0} {1} ist am zug!", spieler + 1, spielerMark);
            do
            {
                Console.WriteLine("Bitte geben sie ihren zug ein (1-9)");
                selectfeld = Int32.Parse(Console.ReadLine());
                spielzugOK = Checkspielzug(selectfeld, spieler);
                if (spielzugOK == 0) break;
                Console.WriteLine("\nDas Feld ist belegt.");
            } while (spielzugOK != 0);
            return;
        }

        static int Pruefegewinn()
        {
            if (feld[0] == feld[1] && feld[1] == feld[2] && feld[0] != ' ' || feld[3] == feld[4] && feld[4] == feld[5] && feld[3] != ' ' || feld[6] == feld[7] && feld[7] == feld[8] && feld[6] != ' ' || feld[0] == feld[3] && feld[3] == feld[6] && feld[0] != ' ' || feld[1] == feld[4] && feld[4] == feld[7] && feld[1] != ' ' || feld[2] == feld[5] && feld[5] == feld[8] && feld[2] != ' ' || feld[0] == feld[4] && feld[4] == feld[8] && feld[0] != ' ' || feld[2] == feld[4] && feld[4] == feld[6] && feld[2] != ' ')
                return 1;
            return 0;
        }


    }
}
