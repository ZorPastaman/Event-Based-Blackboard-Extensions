// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.IntInt_Vector2Int
{
	[CustomLabelInfo("X", nameof(Int32), 0)]
	[CustomLabelInfo("Y", nameof(Int32), 1)]
	[CustomLabelInfo(null, nameof(Vector2Int), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Int, Int) => (Vector2Int)/Vector2Int New Operator")]
	public sealed class Vector2IntNewOperator : SingleReturnBinaryOperator<int, int, Vector2Int>
	{
		protected override Func<int, int, Vector2Int> operation => DefaultOperators.Vector2IntNew;
	}
}
