// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.IntIntInt_Vector3Int
{
	[CustomLabelInfo("X", nameof(Int32), 0)]
	[CustomLabelInfo("Y", nameof(Int32), 1)]
	[CustomLabelInfo("Z", nameof(Int32), 2)]
	[CustomLabelInfo(null, nameof(Vector3Int), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Int, Int, Int) => (Vector3Int)/Vector3Int New Operator")]
	public sealed class Vector3IntNewOperator : SingleReturnTernaryOperator<int, int, int, Vector3Int>
	{
		protected override Func<int, int, int, Vector3Int> operation => DefaultOperators.Vector3IntNew;
	}
}
