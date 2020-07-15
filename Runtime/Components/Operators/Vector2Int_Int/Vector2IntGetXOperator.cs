// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector2Int_Int
{
	[CustomLabelInfo(null, nameof(Vector2Int), 0)]
	[CustomLabelInfo(null, nameof(Int32), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector2Int) => (Int)/Vector2Int Get X Operator")]
	public sealed class Vector2IntGetXOperator : SingleReturnUnaryOperator<Vector2Int, int>
	{
		protected override Func<Vector2Int, int> operation => DefaultOperators.Vector2IntGetX;
	}
}
