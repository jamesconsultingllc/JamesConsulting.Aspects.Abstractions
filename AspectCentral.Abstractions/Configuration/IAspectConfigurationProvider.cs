﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAspectConfigurationProvider.cs" company="CBRE">
//   
// </copyright>
// // <summary>
//   The AspectConfigurationEntry interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Reflection;

namespace AspectCentral.Abstractions.Configuration
{
    /// <summary>
    ///     The AspectConfigurationEntry interface.
    /// </summary>
    public interface IAspectConfigurationProvider
    {
        /// <summary>
        ///     Gets the configuration entries.
        /// </summary>
        List<AspectConfiguration> ConfigurationEntries { get; }

        /// <summary>
        /// The add entry.
        /// </summary>
        /// <param name="aspectConfiguration">
        /// The aspect configuration entry.
        /// </param>
        void AddEntry(AspectConfiguration aspectConfiguration);

        /// <summary>
        /// The get type aspect configuration.
        /// </summary>
        /// <param name="contractType">
        /// The contract type.
        /// </param>
        /// <param name="implementationType">
        /// The implementation type.
        /// </param>
        /// <returns>
        /// The <see cref="AspectConfiguration"/>.
        /// </returns>
        AspectConfiguration GetTypeAspectConfiguration(Type contractType, Type implementationType);

        /// <summary>
        ///     The load configuration.
        /// </summary>
        void LoadConfiguration();

        /// <summary>
        /// </summary>
        /// <param name="factoryType">
        /// </param>
        /// <param name="serviceType">
        /// </param>
        /// <param name="implementationType">
        /// </param>
        /// <param name="methodInfo">
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool ShouldIntercept(Type factoryType, Type serviceType, Type implementationType, MethodInfo methodInfo);
    }
}