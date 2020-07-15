// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromVector4
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Vector4/From Vector4 To Vector2 Converter")]
	public sealed class FromVector4ToVector2Converter : Converter<Vector4, Vector2>
	{
#pragma warning disable CS0649
		[SerializeField] private Mode m_Mode;
#pragma warning restore CS0649

		private enum Mode
		{
			XY,
			XZ,
			XW,
			YZ,
			YW,
			ZW
		}

		protected override System.Converter<Vector4, Vector2> converter
		{
			get
			{
				switch (m_Mode)
				{
					case Mode.XY:
						return DefaultConverters.FromVector4ToVector2XY;
					case Mode.XZ:
						return DefaultConverters.FromVector4ToVector2XZ;
					case Mode.XW:
						return DefaultConverters.FromVector4ToVector2XW;
					case Mode.YZ:
						return DefaultConverters.FromVector4ToVector2YZ;
					case Mode.YW:
						return DefaultConverters.FromVector4ToVector2YW;
					case Mode.ZW:
						return DefaultConverters.FromVector4ToVector2ZW;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
		}
	}
}
