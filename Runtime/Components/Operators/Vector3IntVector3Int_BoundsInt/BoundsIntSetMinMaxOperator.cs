// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector3IntVector3Int_BoundsInt
{
	[CustomLabelInfo("Min Position", nameof(Vector3Int), 0)]
	[CustomLabelInfo("Max Position", nameof(Vector3Int), 1)]
	[CustomLabelInfo(null, nameof(BoundsInt), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector3Int, Vector3Int) => (BoundsInt)/Bounds Int Set Min Max Operator")]
	public sealed class BoundsIntSetMinMaxOperator : SingleReturnBinaryOperator<Vector3Int, Vector3Int, BoundsInt>
	{
		protected override Func<Vector3Int, Vector3Int, BoundsInt> operation => DefaultOperators.BoundsIntSetMinMax;
	}
}
