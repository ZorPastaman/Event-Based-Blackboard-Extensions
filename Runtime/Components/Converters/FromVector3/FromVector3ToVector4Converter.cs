// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromVector3
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Vector3/From Vector3 To Vector4 Converter")]
	public sealed class FromVector3ToVector4Converter : Converter<Vector3, Vector4>
	{
#pragma warning disable CS0649
		[SerializeField] private Mode m_Mode;
#pragma warning restore CS0649

		private enum Mode
		{
			XYZ,
			YZW
		}

		protected override System.Converter<Vector3, Vector4> converter
		{
			get
			{
				switch (m_Mode)
				{
					case Mode.XYZ:
						return DefaultConverters.FromVector3ToVector4XYZ;
					case Mode.YZW:
						return DefaultConverters.FromVector3ToVector4YZW;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
		}
	}
}
