// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoundsIntVector3Int_Bool
{
	[CustomLabelInfo("Bounds", nameof(BoundsInt), 0)]
	[CustomLabelInfo("Position", nameof(Vector3Int), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(BoundsInt, VectorInt) => (Bool)/Bounds Int Contains Operator")]
	public sealed class BoundsIntContainsOperator : SingleReturnBinaryOperator<BoundsInt, Vector3Int, bool>
	{
		protected override Func<BoundsInt, Vector3Int, bool> operation => DefaultOperators.BoundsIntContains;
	}
}
