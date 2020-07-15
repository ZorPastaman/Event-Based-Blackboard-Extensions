// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolQuaternionQuaternion_Quaternion
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(Quaternion), 1)]
	[CustomLabelInfo("False", nameof(Quaternion), 2)]
	[CustomLabelInfo(null, nameof(Quaternion), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Quaternion, Quaternion) => (Quaternion)/Quaternion Conditional Operator")]
	public sealed class QuaternionConditionalOperator :
		SingleReturnTernaryOperator<bool, Quaternion, Quaternion, Quaternion>
	{
		protected override Func<bool, Quaternion, Quaternion, Quaternion> operation =>
		DefaultOperators.QuaternionConditional;
	}
}
