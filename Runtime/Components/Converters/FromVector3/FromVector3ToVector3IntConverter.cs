// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromVector3
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Vector3/From Vector3 To Vector3 Int Converter")]
	public sealed class FromVector3ToVector3IntConverter : Converter<Vector3, Vector3Int>
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

		protected override System.Converter<Vector3, Vector3Int> converter
		{
			get
			{
				switch (m_Mode)
				{
					case Mode.Ceil:
						return DefaultConverters.FromVector3ToVector3IntCeil;
					case Mode.Floor:
						return DefaultConverters.FromVector3ToVector3IntFloor;
					case Mode.Round:
						return DefaultConverters.FromVector3ToVector3IntRound;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
		}
	}
}
