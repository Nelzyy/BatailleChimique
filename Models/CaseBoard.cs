﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleChimiqueWinform.Models
{
    class CaseBoard
    {
        private bool _IsEmpty;
        private bool _IsHit;
        private Bateau? _Boat;
        private Coordinate _Coordinate;

        public CaseBoard(Coordinate coord)
        {
            this._IsEmpty = true;
            this._IsHit = false;
            this._Boat = null;
            this._Coordinate = coord;
        }

        public bool IsEmpty
        {
            get => this._IsEmpty;
        }

        public bool IsHit
        {
            get => this._IsHit;
        }

        public void AddBoat(Bateau boat)
        {
            if (this._IsEmpty)
            {
                this._Boat = boat;
                this._IsEmpty = false;
            }
            else
            {
                throw new Exception("Case is already occupied by another boat.");
            }
        }
    }
}
