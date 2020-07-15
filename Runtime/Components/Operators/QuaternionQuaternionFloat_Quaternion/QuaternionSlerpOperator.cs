// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.QuaternionQuaternionFloat_Quaternion
{
	[CustomLabelInfo("From", nameof(Quaternion), 0)]
	[CustomLabelInfo("To", nameof(Quaternion), 1)]
	[CustomLabelInfo("Time", nameof(Single), 2)]
	[CustomLabelInfo(null, nameof(Quaternion), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Quaternion, Quaternion, Float) => (Quaternion)/Quaternion Slerp Operator")]
	public sealed class QuaternionSlerpOperator : SingleReturnTernaryOperator<Quaternion, Quaternion, float, Quaternion>
	{
		protected override Func<Quaternion, Quaternion, float, Quaternion> operation =>
			DefaultOperators.QuaternionSlerp;
	}
}
