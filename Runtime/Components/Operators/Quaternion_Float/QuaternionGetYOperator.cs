// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Quaternion_Float
{
	[CustomLabelInfo(null, nameof(Quaternion), 0)]
	[CustomLabelInfo(null, nameof(Single), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Quaternion) => (Float)/Quaternion Get Y Operator")]
	public sealed class QuaternionGetYOperator : SingleReturnUnaryOperator<Quaternion, float>
	{
		protected override Func<Quaternion, float> operation => DefaultOperators.QuaternionGetY;
	}
}
