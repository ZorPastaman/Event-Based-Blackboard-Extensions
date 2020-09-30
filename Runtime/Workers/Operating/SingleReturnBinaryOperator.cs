// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Zor.EventBasedBlackboard.Core;

namespace Zor.EventBasedBlackboard.Workers.Operating
{
	/// <summary>
	/// Operates an operation with blackboard properties of types <typeparamref name="TFirstOperand"/> and
	/// <typeparamref name="TSecondOperand"/> that returns a property of type <typeparamref name="TResult"/>.
	/// </summary>
	/// <typeparam name="TFirstOperand">First operand value type.</typeparam>
	/// <typeparam name="TSecondOperand">Second operand value type.</typeparam>
	/// <typeparam name="TResult">Result value type.</typeparam>
	/// <remarks>
	/// <para>This works on subscriptions of <see cref="Blackboard"/>.</para>
	/// <para>Working is controlled by <see cref="enabled"/>. False by default.</para>
	/// </remarks>
	/// <seealso cref="Zor.EventBasedBlackboard.Components.Operators.SingleReturnBinaryOperator{TFirstOperand,TSecondOperand,TResult}"/>
	public sealed class SingleReturnBinaryOperator<TFirstOperand, TSecondOperand, TResult>
	{
		private readonly Blackboard m_firstOperandBlackboard;
		private readonly BlackboardPropertyName m_firstOperandPropertyName;
		private readonly Blackboard m_secondOperandBlackboard;
		private readonly BlackboardPropertyName m_secondOperandPropertyName;
		private readonly Blackboard m_resultBlackboard;
		private readonly BlackboardPropertyName m_resultPropertyName;

		private readonly bool m_operateOnEnable;

		private readonly Func<TFirstOperand, TSecondOperand, TResult> m_operation;

		private readonly Action<BlackboardChangeInfo<TFirstOperand>> m_onFirstOperandChanged;
		private readonly Action<BlackboardChangeInfo<TSecondOperand>> m_onSecondOperandChanged;

		private bool m_enabled;

		public SingleReturnBinaryOperator([NotNull] Blackboard firstOperandBlackboard,
			BlackboardPropertyName firstOperandPropertyName,
			[NotNull] Blackboard secondOperandBlackboard,
			BlackboardPropertyName secondOperandPropertyName,
			[NotNull] Blackboard resultBlackboard,
			BlackboardPropertyName resultPropertyName,
			bool operateOnEnable,
			[NotNull] Func<TFirstOperand, TSecondOperand, TResult> operation)
		{
			m_firstOperandBlackboard = firstOperandBlackboard;
			m_firstOperandPropertyName = firstOperandPropertyName;

			m_secondOperandBlackboard = secondOperandBlackboard;
			m_secondOperandPropertyName = secondOperandPropertyName;

			m_resultBlackboard = resultBlackboard;
			m_resultPropertyName = resultPropertyName;

			m_operateOnEnable = operateOnEnable;

			m_operation = operation;

			m_onFirstOperandChanged = OnFirstOperandChanged;
			m_onSecondOperandChanged = OnSecondOperandChanged;
		}

		/// <summary>
		/// If true, the <see cref="SingleReturnBinaryOperator{TFirstOperand,TSecondOperand,TResult}"/> is subscribed;
		/// if false, the <see cref="SingleReturnBinaryOperator{TFirstOperand,TSecondOperand,TResult}"/>
		/// is not subscribed and does nothing.
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
			m_firstOperandBlackboard.Subscribe(m_firstOperandPropertyName, m_onFirstOperandChanged);
			m_secondOperandBlackboard.Subscribe(m_secondOperandPropertyName, m_onSecondOperandChanged);

			if (!m_operateOnEnable)
			{
				return;
			}

			if (m_firstOperandBlackboard.TryGetValue(m_firstOperandPropertyName, out TFirstOperand firstOperand)
				&& m_secondOperandBlackboard.TryGetValue(m_secondOperandPropertyName, out TSecondOperand secondOperand))
			{
				TResult result = m_operation(firstOperand, secondOperand);
				m_resultBlackboard.SetValue(m_resultPropertyName, result);
			}
		}

		private void Disable()
		{
			m_firstOperandBlackboard.Unsubscribe(m_firstOperandPropertyName, m_onFirstOperandChanged);
			m_secondOperandBlackboard.Unsubscribe(m_secondOperandPropertyName, m_onSecondOperandChanged);
		}

		private void OnFirstOperandChanged(BlackboardChangeInfo<TFirstOperand> firstInfo)
		{
			if (firstInfo.removed
				|| !m_secondOperandBlackboard.TryGetValue(m_secondOperandPropertyName,
					out TSecondOperand secondOperand))
			{
				return;
			}

			TResult result = m_operation(firstInfo.value, secondOperand);
			m_resultBlackboard.SetValue(m_resultPropertyName, result);
		}

		private void OnSecondOperandChanged(BlackboardChangeInfo<TSecondOperand> secondInfo)
		{
			if (secondInfo.removed
				|| !m_firstOperandBlackboard.TryGetValue(m_firstOperandPropertyName, out TFirstOperand firstOperand))
			{
				return;
			}

			TResult result = m_operation(firstOperand, secondInfo.value);
			m_resultBlackboard.SetValue(m_resultPropertyName, result);
		}
	}
}
