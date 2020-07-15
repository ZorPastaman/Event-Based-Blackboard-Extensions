// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromVector2
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Vector2/From Vector2 To Vector4 Converter")]
	public sealed class FromVector2ToVector4Converter : Converter<Vector2, Vector4>
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

		protected override System.Converter<Vector2, Vector4> converter
		{
			get
			{
				switch (m_Mode)
				{
					case Mode.XY:
						return DefaultConverters.FromVector2ToVector4XY;
					case Mode.XZ:
						return DefaultConverters.FromVector2ToVector4XZ;
					case Mode.XW:
						return DefaultConverters.FromVector2ToVector4XW;
					case Mode.YZ:
						return DefaultConverters.FromVector2ToVector4YZ;
					case Mode.YW:
						return DefaultConverters.FromVector2ToVector4YW;
					case Mode.ZW:
						return DefaultConverters.FromVector2ToVector4ZW;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
		}
	}
}
