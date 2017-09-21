﻿namespace LFStats
{
    public class PlayerGameScore
    {
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }
        public int ShotsHit { get; set; }
        public int ShotsFired { get; set; }
        public int TimesZapped { get; set; }
        public int TimesMissiled { get; set; }
        public int MissileHits { get; set; }
        public int NukesActivated { get; set; }
        public int NukesDetonated { get; set; }
        public int NukesCancelled { get; set; }
        public int MedicHits { get; set; }
        public int OwnMedicHits { get; set; }
        public int MedicNukes { get; set; }
        public int ScoutRapidFires { get; set; }
        public int LivesBoosts { get; set; }
        public int AmmoBoosts { get; set; }
        public int LivesLeft { get; set; }
        public int Score { get; set; }
        public int ShotsLeft { get; set; }
        public int Penalties { get; set; }
        public int ShotThreeHit { get; set; }
        public bool ElimOtherTeam { get; set; }
        public bool ElimTeam { get; set; }
        public int OwnNukeCancels { get; set; }
        public int ShotOpponents { get; set; }
        public int ShotTeam { get; set; }
        public int MissiledOpponent { get; set; }
        public int MissiledTeam { get; set; }
        public int Resupplies { get; set; }
        public int Rank { get; set; }
        public int BasesDestroyed { get; set; }
        public decimal Accuracy { get; set; }
        public decimal MvpPoints { get; set; }
        public int SpecialEarned { get; set; }
        public int SpecialSpent { get; set; }
        public int GameId { get; set; }
        public int PlayerId { get; set; }
    }
}
