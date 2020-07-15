// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromVector4
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Vector4/From Vector4 To Vector3 Converter")]
	public sealed class FromVector4ToVector3Converter : Converter<Vector4, Vector3>
	{
#pragma warning disable CS0649
		[SerializeField] private Mode m_Mode;
#pragma warning restore CS0649

		private enum Mode
		{
			XYZ,
			YZW
		}

		protected override System.Converter<Vector4, Vector3> converter
		{
			get
			{
				switch (m_Mode)
				{
					case Mode.XYZ:
						return DefaultConverters.FromVector4ToVector3XYZ;
					case Mode.YZW:
						return DefaultConverters.FromVector4ToVector3YZW;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
		}
	}
}
