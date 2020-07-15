// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Bool_Bool
{
	[CustomLabelInfo(null, nameof(Boolean), 0)]
	[CustomLabelInfo(null, nameof(Boolean), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool) => (Bool)/Bool Not Operator")]
	public sealed class BoolNotOperator : SingleReturnUnaryOperator<bool, bool>
	{
		protected override Func<bool, bool> operation => DefaultOperators.BoolNot;
	}
}
