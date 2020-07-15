// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromVector2
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Vector2/From Vector2 To Vector3 Converter")]
	public sealed class FromVector2ToVector3Converter : Converter<Vector2, Vector3>
	{
#pragma warning disable CS0649
		[SerializeField] private Mode m_Mode;
#pragma warning restore CS0649

		private enum Mode
		{
			XY,
			XZ,
			YZ
		}

		protected override System.Converter<Vector2, Vector3> converter
		{
			get
			{
				switch (m_Mode)
				{
					case Mode.XY:
						return DefaultConverters.FromVector2ToVector3XY;
					case Mode.XZ:
						return DefaultConverters.FromVector2ToVector3XZ;
					case Mode.YZ:
						return DefaultConverters.FromVector2ToVector3YZ;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
		}
	}
}
