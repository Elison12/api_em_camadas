using System.Collections.Generic;

namespace Manager.Domain.Entities
{
    public abstract class Base {
        public long Id { get; set; }

        public IReadOnlyCollection<String> Errors => _errors;
        internal List<string> _errors;

        public abstract bool Validate();
    }
    
}