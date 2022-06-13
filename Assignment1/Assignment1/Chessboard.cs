using System;
using System.IO;


namespace Assignment1
{
    public class Chessboard
    {
        private int _noOfRows;
        private int _noOfCols;

        public Chessboard(int noOfCols, int noOfRows)
        {
            _noOfRows = noOfCols;
            _noOfCols = noOfRows;
        }

        public void DrawChessBoad()
        {
            // Console.WriteLine("Enter Name:");
            string fileName = "Chess";

            //Table start.
            string html = "<!DOCTYPE html>\n";
            html += "<html>\n<head>\n<title></title>\n<meta charset ='UTF-8'>\n";
            html += "<style>\n";
            html += ".chess-board {border-spacing: 0;border-collapse: collapse; width: 270px;}\n";            
            html += ".chess-board td {border: 1px solid;width: 30px;height: 30px;}\n";
            html += ".chess-board .light {background: #eee;}\n";
            html += ".chess-board .dark {background: #000;}\n";
            html += "</style>\n</head>\n<body>\n";
            html += "<table class='chess-board'>\n<tbody>\n";

            for (int i = 1; i <= _noOfRows; i++)
            {
                html += "<tr>\n";

                for (int j = 1; j <= _noOfCols; j++)
                {
                    if (i % 2 == 1)
                    {
                        if (j % 2 == 1)
                            html += "<td class='light'></td>\n";
                        else
                            html += "<td class='dark'></td>\n";
                    }
                    else
                    {
                        if (j % 2 == 0)
                            html += "<td class='light'></td>\n";
                        else
                            html += "<td class='dark'></td>\n";
                    }
                }
                html += "</tr>\n";
            }
            //Table end.
            html += "</tbody>\n</table>\n</body>\n</html>";

            //Create the HTML file.
            string root = @"C:\LogicLoop";
            // If directory does not exist Create Directory
            if (Directory.Exists(root) == false)
            {
                Directory.CreateDirectory(root);
            }

            File.WriteAllText(root + "\\" + fileName + ".htm", html);

            Console.WriteLine("HTML File created.");
            Console.ReadLine();

        }
    }
}
