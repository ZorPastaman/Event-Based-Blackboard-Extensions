// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromVector3Int
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Vector3 Int/From Vector3 Int To Vector2 Int Converter")]
	public sealed class FromVector3IntToVector2IntConverter : Converter<Vector3Int, Vector2Int>
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

		protected override System.Converter<Vector3Int, Vector2Int> converter
		{
			get
			{
				switch (m_Mode)
				{
					case Mode.XY:
						return DefaultConverters.FromVector3IntToVector2IntXY;
					case Mode.XZ:
						return DefaultConverters.FromVector3IntToVector2IntXZ;
					case Mode.YZ:
						return DefaultConverters.FromVector3IntToVector2IntYZ;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
		}
	}
}
