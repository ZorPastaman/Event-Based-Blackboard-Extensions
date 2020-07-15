// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromVector3
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Vector3/From Vector3 To Vector2 Converter")]
	public sealed class FromVector3ToVector2Converter : Converter<Vector3, Vector2>
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

		protected override System.Converter<Vector3, Vector2> converter
		{
			get
			{
				switch (m_Mode)
				{
					case Mode.XY:
						return DefaultConverters.FromVector3ToVector2XY;
					case Mode.XZ:
						return DefaultConverters.FromVector3ToVector2XZ;
					case Mode.YZ:
						return DefaultConverters.FromVector3ToVector2YZ;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
		}
	}
}
