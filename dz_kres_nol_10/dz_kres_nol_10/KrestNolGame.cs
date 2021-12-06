﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_kres_nol_10
{
    public enum Winner
    {
        Crossed,
        Zerros,
        Draw,
        GameIsUnfinised
    }
    public enum State
    {
        Cross,
        Zero,
        Unset
    }
    public class KrestNolGame
    {
        private readonly State[] board = new State[9];
        public int MovesCounter{ get; private set; }
        public KrestNolGame()
        {
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = State.Unset;
            }
        }
        public void MakeMove(int index)
        {
            board[index - 1] = MovesCounter % 2 == 0 ? State.Cross : State.Zero;
            MovesCounter++;

        }
        public State GetState(int index)
        {
            return board[index - 1];
        }
        public Winner GetWinner()
        {
            return GetWinner(1, 4, 7, 2, 5, 8, 3, 6, 9,
                1, 2, 3, 4, 5, 6, 7, 8, 9,
                1, 5, 9, 3, 5, 7);
        }
        private Winner GetWinner(params int[] indexes)
        {
            for (int i = 0; i < indexes.Length; i += 3)
            {
                bool same = AreSame(indexes[i], indexes[i + 1], indexes[i + 2]);
                if (same)
                {
                    State state = GetState(indexes[i]);
                    if (state != State.Unset)
                    {
                        return state == State.Cross ? Winner.Crossed : Winner.Zerros;
                    }
                }
            }
            if (MovesCounter < 9)
                return Winner.GameIsUnfinised;
            return Winner.Draw;
        }
        private bool AreSame(int a, int b, int c)
        {
            return GetState(a) == GetState(b) && GetState(a) == GetState(c);
        }
    }
}
