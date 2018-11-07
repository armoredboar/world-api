using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation.Results;

namespace Kosmos.Application.Exceptions
{
    public sealed class ValidationException : Exception
    {
        public ValidationException() : base("One or more validation failures have occurred.") => this.Failures = new Dictionary<string, string[]>();

        public ValidationException(List<ValidationFailure> failures) : this()
        {
            IEnumerable<string> propertyNames = failures
                .Select(e => e.PropertyName)
                .Distinct();

            foreach (string propertyName in propertyNames)
            {
                string[] propertyFailures = failures
                    .Where(e => e.PropertyName == propertyName)
                    .Select(e => e.ErrorMessage)
                    .ToArray();

                this.Failures.Add(propertyName, propertyFailures);
            }
        }

        public IDictionary<string, string[]> Failures { get; }
    }
}