// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.FloatFloatFloatFloat_Quaternion
{
	public sealed class QuaternionNewOperator : SingleReturnQuaternaryOperator<float, float, float, float, Quaternion>
	{
		protected override Func<float, float, float, float, Quaternion> operation => DefaultOperators.QuaternionNew;
	}
}
