using Dolittle.Concepts;
using System;

namespace Concepts.TodoItem
{
    public class ListId : ConceptAs<Guid>
    {
        public static ListId None = default(Guid);

        public static implicit operator ListId(Guid value)
        {
            return new ListId {Value = value};
        }
    }
}
