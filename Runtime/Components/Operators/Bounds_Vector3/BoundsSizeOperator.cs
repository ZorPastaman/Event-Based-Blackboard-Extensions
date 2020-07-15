// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Bounds_Vector3
{
	[CustomLabelInfo(null, nameof(Bounds), 0)]
	[CustomLabelInfo(null, nameof(Vector3), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bounds) => (Vector3)/Bounds Size Operator")]
	public sealed class BoundsSizeOperator : SingleReturnUnaryOperator<Bounds, Vector3>
	{
		protected override Func<Bounds, Vector3> operation => DefaultOperators.BoundsSize;
	}
}
