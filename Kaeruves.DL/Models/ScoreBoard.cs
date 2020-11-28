using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kartuves.DL.Models
{
    [Table("ScoreBoards")]
    public class ScoreBoard
    {
        [Key]
        public int ScoreBoardId { get; set; }
        public int PlayerId { get; set; }
        public DateTime DatePlayed { get; set; }
        public int WordId { get; set; }
        public int GuessCount { get; set; }
        public bool IsCorrect { get; set; }
        public virtual Word Word { get; set; }
        public virtual Player Player { get; set; }

    }
}
