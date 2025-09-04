using AopAlliance.Intercept;
using Spring.Aop;
using System;

namespace WelcomeToAOP
{
    /// <summary>
    /// Interceptor that adds magical aura effects before and after the MessengerOwl delivers a message.
    /// </summary>
    public class MagicAuraInterceptor : IMethodInterceptor
    {
        /// <summary>
        /// Invokes magical effects around the target method invocation.
        /// </summary>
        /// <param name="invocation">The method invocation being intercepted.</param>
        /// <returns>The result of the original method invocation.</returns>
        public object Invoke(IMethodInvocation invocation)
        {
            // Add pre-invocation magical effect
            Console.WriteLine("✨ A magical aura shimmers before the message is delivered...");

            // Proceed with the original method invocation
            var result = invocation.Proceed();

            // Add post-invocation magical effect
            Console.WriteLine("✨ The aura fades as the message echoes through the realm.");
            
            return result;
        }
    }
}