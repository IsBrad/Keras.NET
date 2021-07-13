namespace Keras
{
    /// <summary>
    ///     Initializer that generates tensors initialized to 1.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class Ones : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Ones" /> class.
        /// </summary>
        public Ones()
        {
            PyInstance = Instance.keras.initializers.Zeros;
            Init();
        }
    }
}