// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoundsVector3_Float
{
	[CustomLabelInfo("Bounds", nameof(Bounds), 0)]
	[CustomLabelInfo("Point", nameof(Vector3), 1)]
	[CustomLabelInfo("Squared Distance", nameof(Single), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bounds, Vector3) => (Float)/Bounds Squared Distance Operator")]
	public sealed class BoundsSquaredDistanceOperator : SingleReturnBinaryOperator<Bounds, Vector3, float>
	{
		protected override Func<Bounds, Vector3, float> operation => DefaultOperators.BoundsSquaredDistance;
	}
}
