﻿namespace SabberStonePowerLog.Model
{
	internal class PowerShowEntity : PowerHistoryEntry
	{
		public string Name { get; set; }
		public int Id { get; set; }
		public string Zone { get; set; }
		public string ZonePos { get; set; }
		public string PlayerId { get; set; }
		public string CardId { get; set; }

		public override void Process(PowerGame powerGame)
		{
			powerGame.Entities[Id].Change("CARD_ID", CardId);
		}
	}
}
