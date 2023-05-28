﻿using Melia.Zone.World;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Tos.Const;

namespace Melia.Zone.Skills
{
	/// <summary>
	/// A character's ability.
	/// </summary>
	public class Ability : IPropertyObject
	{
		/// <summary>
		/// The ability's object id.
		/// </summary>
		public long ObjectId { get; }

		/// <summary>
		/// The ability's properties.
		/// </summary>
		public Properties Properties { get; } = new Properties("Ability");

		/// <summary>
		/// The ability's id.
		/// </summary>
		public AbilityId Id { get; set; }

		/// <summary>
		/// The ability's level.
		/// </summary>
		public int Level { get; set; } = 1;

		/// <summary>
		/// Whether the ability is active.
		/// </summary>
		public bool Active { get; set; } = true;

		/// <summary>
		/// Creates new instance.
		/// </summary>
		public Ability(AbilityId abilityId, int level)
		{
			// It seems like abilities and session objects use the same
			// id pool on officials, so we'll do the same for now.
			this.ObjectId = ZoneServer.Instance.World.CreateSessionObjectId();

			this.Id = abilityId;
			this.Level = level;

			//this.Properties.Add(new RefFloatProperty(PropertyId.Ability.Level, () => this.Level));
			//this.Properties.Add(new RefFloatProperty(PropertyId.Ability.ActiveState, () => this.Active ? 1 : 0));
		}
	}
}
