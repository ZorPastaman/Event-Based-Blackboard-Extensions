// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoundsInt_Vector3
{
	[CustomLabelInfo(null, nameof(BoundsInt), 0)]
	[CustomLabelInfo(null, nameof(Vector3), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(BoundsInt) => (Vector3)/Bounds Int Center Operator")]
	public sealed class BoundsIntCenterOperator : SingleReturnUnaryOperator<BoundsInt, Vector3>
	{
		protected override Func<BoundsInt, Vector3> operation => DefaultOperators.BoundsIntCenter;
	}
}
