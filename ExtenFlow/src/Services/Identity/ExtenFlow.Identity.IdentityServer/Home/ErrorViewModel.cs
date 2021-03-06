﻿using IdentityServer4.Models;

namespace ExtenFlow.Identity.IdentityServer
{
    /// <summary>
    /// Class ErrorViewModel.
    /// </summary>
    public class ErrorViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorViewModel"/> class.
        /// </summary>
        public ErrorViewModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorViewModel"/> class.
        /// </summary>
        /// <param name="error">The error.</param>
        public ErrorViewModel(string error)
        {
            Error = new ErrorMessage { Error = error };
        }

        /// <summary>
        /// Gets or sets the error.
        /// </summary>
        /// <value>The error.</value>
        public ErrorMessage? Error { get; set; }
    }
}