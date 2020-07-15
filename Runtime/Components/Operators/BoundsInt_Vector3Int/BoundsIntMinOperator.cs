// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoundsInt_Vector3Int
{
	[CustomLabelInfo(null, nameof(BoundsInt), 0)]
	[CustomLabelInfo(null, nameof(Vector3Int), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(BoundsInt) => (Vector3Int)/Bounds Int Min Operator")]
	public sealed class BoundsIntMinOperator : SingleReturnUnaryOperator<BoundsInt, Vector3Int>
	{
		protected override Func<BoundsInt, Vector3Int> operation => DefaultOperators.BoundsIntMin;
	}
}
