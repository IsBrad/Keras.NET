namespace Keras
{
    /// <summary>
    ///     Initializer that generates tensors initialized to 0.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class Zeros : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Zeros" /> class.
        /// </summary>
        public Zeros()
        {
            PyInstance = Instance.keras.initializers.Zeros;
            Init();
        }
    }
}