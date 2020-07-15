// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoundsVector3_Vector3
{
	[CustomLabelInfo("Bounds", nameof(Bounds), 0)]
	[CustomLabelInfo("Point", nameof(Vector3), 1)]
	[CustomLabelInfo("Closest Point", nameof(Vector3), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bounds, Vector3) => (Vector3)/Bounds Closest Point Operator")]
	public sealed class BoundsClosestPointOperator : SingleReturnBinaryOperator<Bounds, Vector3, Vector3>
	{
		protected override Func<Bounds, Vector3, Vector3> operation => DefaultOperators.BoundsClosestPoint;
	}
}
