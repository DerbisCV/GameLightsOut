using System;
using System.Collections.Generic;
using System.Linq;

namespace LightsOut.Services.Models
{
    public class GameBoardModel
    {
        public GameBoardModel(int size = 5)
        {
            Size = size;

            var random = new Random();
            for (int i = 0; i < Size; i++)
            {
                var lstRow = new List<bool>();
                for (int j = 0; j < Size; j++)
                {
                    lstRow.Add(random.Next(2) == 1);
                }
                Rows.Add(lstRow);
            }
        }

        private int Size { get; }
        public List<List<bool>> Rows { get; set; } = new List<List<bool>>();
        public int BoardSize => Rows.Count;
        public int BoardSizeOn => Rows.Sum(x => x.Count(y => y));
        public int BoardSizeOff => BoardSize* BoardSize - BoardSizeOn;
    }
}
