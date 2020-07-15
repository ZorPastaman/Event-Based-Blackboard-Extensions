// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromVector2
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Vector2/From Vector2 To Vector2 Int Converter")]
	public sealed class FromVector2ToVector2IntConverter : Converter<Vector2, Vector2Int>
	{
#pragma warning disable CS0649
		[SerializeField] private Mode m_Mode;
#pragma warning restore CS0649

		private enum Mode
		{
			Ceil,
			Floor,
			Round
		}

		protected override System.Converter<Vector2, Vector2Int> converter
		{
			get
			{
				switch (m_Mode)
				{
					case Mode.Ceil:
						return DefaultConverters.FromVector2ToVector2IntCeil;
					case Mode.Floor:
						return DefaultConverters.FromVector2ToVector2IntFloor;
					case Mode.Round:
						return DefaultConverters.FromVector2ToVector2IntRound;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
		}
	}
}
