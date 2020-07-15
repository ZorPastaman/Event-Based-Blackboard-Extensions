// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.QuaternionQuaternion_Bool
{
	[CustomLabelInfo(null, nameof(Quaternion), 0)]
	[CustomLabelInfo(null, nameof(Quaternion), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Quaternion, Quaternion) => (Bool)/Quaternion Not Equal Operator")]
	public sealed class QuaternionNotEqualOperator : SingleReturnBinaryOperator<Quaternion, Quaternion, bool>
	{
		protected override Func<Quaternion, Quaternion, bool> operation => DefaultOperators.QuaternionNotEqual;
	}
}
