// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromVector2Int
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Vector2 Int/From Vector2 Int To Vector3 Int Converter")]
	public sealed class FromVector2IntToVector3IntConverter : Converter<Vector2Int, Vector3Int>
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

		protected override System.Converter<Vector2Int, Vector3Int> converter
		{
			get
			{
				switch (m_Mode)
				{
					case Mode.XY:
						return DefaultConverters.FromVector2IntToVector3IntXY;
					case Mode.XZ:
						return DefaultConverters.FromVector2IntToVector3IntXZ;
					case Mode.YZ:
						return DefaultConverters.FromVector2IntToVector3IntYZ;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
		}
	}
}
