// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector2IntVector2Int_RectInt
{
	[CustomLabelInfo("Position", nameof(Vector2Int), 0)]
	[CustomLabelInfo("Size", nameof(Vector2Int), 1)]
	[CustomLabelInfo(null, nameof(RectInt), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector2Int, Vector2Int) => (RectInt)/RectInt New With Vectors Operator")]
	public sealed class RectIntNewWithVectorsOperator : SingleReturnBinaryOperator<Vector2Int, Vector2Int, RectInt>
	{
		protected override Func<Vector2Int, Vector2Int, RectInt> operation => DefaultOperators.RectIntNewWithVectors;
	}
}
