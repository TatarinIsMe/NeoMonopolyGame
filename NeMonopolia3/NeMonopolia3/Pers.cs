﻿using System;
using System.Collections.Generic;

namespace NeMonopolia3
{
    [Serializable]
	public class Pers
	{
        public int idPers { get; set; }

        public int? idPlayer { get; set; }

        public int? HoldId { get; set; }

        public virtual Player Player { get; set; }

        public int? idGame { get; set; }

        public virtual Game Game { get; set; }

        
        public string NickName { get; set; }

        public virtual List<Hold> Holds { get; set; }

        public string Avatar { get; set; }

        public int? Money { get; set; }

        public int? Intellect { get; set; }

        public int? Honesty { get; set; }

        public int? Communication { get; set; }

        public int? Luck { get; set; }

        public int? Rank { get; set; }

        public int? StopCount { get; set; }

        public bool isPlaying { get; set; }

    }
}

