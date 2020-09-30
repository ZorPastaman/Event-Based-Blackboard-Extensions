// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Zor.EventBasedBlackboard.Core;

namespace Zor.EventBasedBlackboard.Workers.Operating
{
	/// <summary>
	/// Operates an operation with a blackboard property of type <typeparamref name="TOperand"/>
	/// that returns a property of type <typeparamref name="TResult"/>.
	/// </summary>
	/// <typeparam name="TOperand">Operand value type.</typeparam>
	/// <typeparam name="TResult">Result value type.</typeparam>
	/// <remarks>
	/// <para>This works on subscriptions of <see cref="Blackboard"/>.</para>
	/// <para>Working is controlled by <see cref="enabled"/>. False by default.</para>
	/// </remarks>
	/// <seealso cref="Zor.EventBasedBlackboard.Components.Operators.SingleReturnUnaryOperator{TOperand,TResult}"/>
	public sealed class SingleReturnUnaryOperator<TOperand, TResult>
	{
		private readonly Blackboard m_operandBlackboard;
		private readonly BlackboardPropertyName m_operandPropertyName;
		private readonly Blackboard m_resultBlackboard;
		private readonly BlackboardPropertyName m_resultPropertyName;

		private readonly bool m_operateOnEnable;

		private readonly Func<TOperand, TResult> m_operation;

		private readonly Action<BlackboardChangeInfo<TOperand>> m_onOperandChanged;

		private bool m_enabled;

		public SingleReturnUnaryOperator([NotNull] Blackboard operandBlackboard,
			BlackboardPropertyName operandPropertyName,
			[NotNull] Blackboard resultBlackboard,
			BlackboardPropertyName resultPropertyName,
			bool operateOnEnable,
			[NotNull] Func<TOperand, TResult> operation)
		{
			m_operandBlackboard = operandBlackboard;
			m_operandPropertyName = operandPropertyName;

			m_resultBlackboard = resultBlackboard;
			m_resultPropertyName = resultPropertyName;

			m_operateOnEnable = operateOnEnable;

			m_operation = operation;

			m_onOperandChanged = OnOperandChanged;
		}

		/// <summary>
		/// If true, the <see cref="SingleReturnUnaryOperator{TOperand,TResult}"/> is subscribed; if false, the
		/// <see cref="SingleReturnUnaryOperator{TOperand,TResult}"/> is not subscribed and does nothing.
		/// </summary>
		/// <remarks>False by default.</remarks>
		public bool enabled
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
			get => m_enabled;
			set
			{
				if (m_enabled == value)
				{
					return;
				}

				m_enabled = value;

				if (m_enabled)
				{
					Enable();
				}
				else
				{
					Disable();
				}
			}
		}

		private void Enable()
		{
			m_operandBlackboard.Subscribe(m_operandPropertyName, m_onOperandChanged);

			if (!m_operateOnEnable)
			{
				return;
			}

			if (m_operandBlackboard.TryGetValue(m_operandPropertyName, out TOperand operand))
			{
				TResult result = m_operation(operand);
				m_resultBlackboard.SetValue(m_resultPropertyName, result);
			}
		}

		private void Disable()
		{
			m_operandBlackboard.Unsubscribe(m_operandPropertyName, m_onOperandChanged);
		}

		private void OnOperandChanged(BlackboardChangeInfo<TOperand> info)
		{
			if (info.removed)
			{
				return;
			}

			TResult result = m_operation(info.value);
			m_resultBlackboard.SetValue(m_resultPropertyName, result);
		}
	}
}
