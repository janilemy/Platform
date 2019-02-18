using System.ComponentModel.DataAnnotations;

namespace Platform.DAL.Entities
{
    /// <summary>
    /// Base abstract entity.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class EntityBase<T>
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [Key]
        public T Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="BaseEntity{T}"/> is active.
        /// </summary>
        /// <value>
        /// <c>true</c> if active; otherwise, <c>false</c>.
        /// </value>
        public bool Active { get; set; }
    }
}
