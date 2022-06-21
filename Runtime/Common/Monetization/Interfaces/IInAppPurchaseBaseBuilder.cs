using System.Collections.Generic;

// ReSharper Disable CheckNamespace
namespace AppodealStack.Monetization.Common
{
    /// <summary>
    /// <para>
    /// Base interface containing common method signatures of the <see langword="InAppPurchaseBuilder"/> classes.
    /// </para>
    /// See <see href=""/> for more details.
    /// </summary>
    public interface IInAppPurchaseBaseBuilder
    {
        void WithPrice(string price);
        void WithCurrency(string currency);
        void WithAdditionalParameters(Dictionary<string, string> additionalParameters);
    }
}
